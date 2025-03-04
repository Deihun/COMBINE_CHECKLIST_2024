using COMBINE_CHECKLIST_2024.DateToText;
using COMBINE_CHECKLIST_2024.ExcelManagement;
using COMBINE_CHECKLIST_2024.OpenFilePath;
using SQL_Connection_support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ScottPlot;
using ScottPlot.Plottables;
using COMBINE_CHECKLIST_2024.Addons;

namespace COMBINE_CHECKLIST_2024.Sections.MachineHistoryViewer
{
    public partial class MachineViewer: Form
    {
        List<Form> ViewList = new List<Form>();
        private SQL_Support sql = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");
        private gridview_adjustment g_adjust;
        private buttonPerHistory buttonManagement;
        private int selectedID = -1;
        public MachineViewer()
        {
            InitializeComponent();
            
            g_adjust = new gridview_adjustment(sql, dataPerSection);
            buttonManagement = new buttonPerHistory(this, button_container_flp);
            g_adjust.dataPerHistoryLog_flp = dataPerSection;
            buttonManagement.showAllResults();
            button_container_flp.HorizontalScroll.Enabled = false;
            button_container_flp.HorizontalScroll.Visible = false;
            button_container_flp.HorizontalScroll.Maximum = 0;
            button_container_flp.AutoScrollMinSize = new Size(0, 1);

            chart1.Titles.Add("STATUS");
        }

        

        public void addButton(int groupID)
        {
            ButtonItem buttonItem = new ButtonItem(groupID,this);
        }
        public void delButton(Form delbtn)
        {
            ViewList.Remove(delbtn);
            delbtn.Dispose();
        }
        public void resetButton()
        {
            foreach(Form reset in ViewList)
            {
                reset.Dispose();
            }
        }
        public void SetDataGridView(int id)
        {
            g_adjust.show_dataPerSection(id);//
            printOption_panel.Show();
            selectedID = id;
            chart1.Visible = false;

            //
            //dataGridView1.DataSource = MachineView.ExecuteQueryAsync(query);
        }

        private void MachineViewer_Load(object sender, EventArgs e)
        {
        }



        private void MachineViewer_VisibleChanged(object sender, EventArgs e)
        {
            buttonManagement.showAllResults();
            printOption_panel.Hide();
            selectedID = -1;
            chart1.Series["S1"].Points.Clear();
            chart1.Visible = true;
            int defective = 0;
            int satisfactory = 0;
            g_adjust._delete_all();
            DataTable status = sql.ExecuteQuery("SELECT overall_status FROM LOG_MACHINETABLE;");
            foreach (DataRow data in status.Rows)
            {
                bool c = (bool)data["overall_status"];
                if (c) defective += 1;
                else satisfactory += 1;
            }
            if (satisfactory > 0)
            {
                chart1.Series["S1"].Color = System.Drawing.Color.Wheat;
                chart1.Series["S1"].Points.AddXY("SATISFACTORY", satisfactory);
                chart1.Series["S1"].Points.Last().Font = new Font("Arial", 10, System.Drawing.FontStyle.Bold);
            }
            if (defective > 0)
            {
                chart1.Series["S1"].Points.AddXY("DEFECTIVE", defective);
                chart1.Series["S1"].Points.Last().LabelForeColor = System.Drawing.Color.Black;
                chart1.Series["S1"].Points.Last().Font = new Font("Arial", 10, System.Drawing.FontStyle.Bold);
            }

            

        }






        private void dataPerSection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchfilter_tb_TextChanged(object sender, EventArgs e)
        {
            g_adjust.show_dataPerSection(searchfilter_tb.Text, DateFilter_dt);
            buttonManagement.showResultsWithFilter(searchfilter_tb.Text, DateFilter_dt);
            printOption_panel.Hide();
            chart1.Visible = false;
        }

        private void date_cb_CheckedChanged(object sender, EventArgs e)
        {
            DateFilter_dt.Enabled = date_cb.Checked;
            g_adjust.show_dataPerSection(searchfilter_tb.Text, DateFilter_dt);
            buttonManagement.showResultsWithFilter(searchfilter_tb.Text, DateFilter_dt);
            printOption_panel.Hide();
            chart1.Visible = false;
        }

        private void DateFilter_dt_ValueChanged(object sender, EventArgs e)
        {
            g_adjust.show_dataPerSection(searchfilter_tb.Text, DateFilter_dt);
            buttonManagement.showResultsWithFilter(searchfilter_tb.Text, DateFilter_dt);
            printOption_panel.Hide();
            chart1.Visible = false;
        }

        private void bulkPrint_btn_Click(object sender, EventArgs e)
        {
            BulkPrintSelection bulkprint = new BulkPrintSelection();
            bulkprint.ShowDialog();
        }

        private void createAs_btn_Click(object sender, EventArgs e)
        {
            FolderPathManagement select = new FolderPathManagement();
            string filepath = select.ShowSaveFileDialog();
            if (!(filepath == null || filepath == string.Empty))
            {
                HistoryExcelGeneration excel = new HistoryExcelGeneration(filepath);
                excel.ExportToExcel(excel.GenerateExcelWorkbook(selectedID));
            }
            Dictionary<string, object> logHistory = new Dictionary<string, object>
                    {
                        { "Context", $"A 'SaveFile' has been performed via View-Data in path '{filepath}', referencing data ID {selectedID.ToString()}" },
                        {"Date_Log", DateTime.Now }
                    };
            sql.InsertData("HISTORY_", logHistory);
        
        }

        private void btn_singlePrint_Click(object sender, EventArgs e)
        {
            HistoryExcelGeneration excel = new HistoryExcelGeneration();
            WorkbookPrinter a = new WorkbookPrinter(excel.GenerateExcelWorkbook(selectedID));
            a.Print();
            Dictionary<string, object> logHistory = new Dictionary<string, object>
                    {
                        { "Context", $"A print has been performed via View-Data, referencing data ID {selectedID.ToString()}" },
                        {"Date_Log", DateTime.Now }
                    };
            sql.InsertData("HISTORY_", logHistory);

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }



    //FOR dataPerSection 
    public class gridview_adjustment
    {
        public FlowLayoutPanel dataPerHistoryLog_flp;
        private FlowLayoutPanel flowparent;
        private List<Object> pergroups = new List<Object>();
        private SQL_Support sql;

        public gridview_adjustment(SQL_Support sql, FlowLayoutPanel parent)
        {
            this.sql = sql;
            this.flowparent = parent;
        }
        public void show_dataPerSection(int _id)
        {
            HistoryExcelGeneration generate = new HistoryExcelGeneration();
            WebBrowser web = new WebBrowser();
            _delete_all();
            pergroups.Add(web);
            web.DocumentText =  generate.ConvertExcelToHtml(generate.GenerateExcelWorkbook(_id));
            web.Size = flowparent.Size;
            flowparent.Controls.Add(web);


            //List<int> group_id_of_item = new List<int>();
            //string query = $"SELECT * FROM GROUP_TABLE WHERE historylog_id = {_id}; ";
            //DataTable data = sql.ExecuteQuery(query);
            //foreach (DataRow id in data.Rows)
            //{
            //    group_id_of_item.Add(Convert.ToInt32(id["GroupID"]));
            //}

            //foreach (int id in group_id_of_item)
            //{
            //    query = $"SELECT defect_part, defec_desc, suggested_replacement_repair, remark_analysis, overall_status, checked_by, datemark  FROM LOG_MACHINETABLE WHERE groupID = {id};";
            //    DataTable _data = sql.ExecuteQuery(query);
            //    _new_data_section(_data);
            //}
            
            //

        }

        public void show_dataPerSection(string filter, DateTimePicker date)
        {
            _delete_all();

            string filterCondition = $"(L.defect_part LIKE '%{filter}%' OR " +
                                     $"L.defec_desc LIKE '%{filter}%' OR " +
                                     $"L.suggested_replacement_repair LIKE '%{filter}%' OR " +
                                     $"L.remark_analysis LIKE '%{filter}%' OR " +
                                     $"L.overall_status LIKE '%{filter}%' OR " +
                                     $"L.checked_by LIKE '%{filter}%' OR " +
                                     $"G.Machine_Name LIKE '%{filter}%' OR " +
                                     $"G.Monitored_By LIKE '%{filter}%' OR " +
                                     $"G.Location LIKE '%{filter}%')";
            if (date.Enabled)
            {
                int selectedYear = date.Value.Year;
                int selectedMonth = date.Value.Month;
                int selectedDay = date.Value.Day;

                // Append additional filter for datemark
                filterCondition += $" AND YEAR(L.datemark) = {selectedYear} " +
                                   $"AND MONTH(L.datemark) = {selectedMonth} " +
                                   $"AND DAY(L.datemark) = {selectedDay}";
            }

            // Build the final query
            string query = $"SELECT L.defect_part, L.defec_desc, L.suggested_replacement_repair, L.remark_analysis, " +
                           $"L.overall_status, L.checked_by, L.datemark, " +
                           $"G.Machine_Name, G.Monitored_By, G.Location " +
                           $"FROM LOG_MACHINETABLE L " +
                           $"INNER JOIN GROUP_TABLE G ON L.groupID = G.GroupID " +
                           $"WHERE {filterCondition};";

            // Execute query and get combined data
            DataTable _data = sql.ExecuteQuery(query);

            // Call _new_data_section() once with the full data
            _new_data_section(_data);
        }






        public void _new_data_section(DataTable data)
        {
            DataGridView _data = new DataGridView();
            List<bool> statusList = new List<bool>();

            foreach (DataRow row in data.Rows)
            {
                statusList.Add((bool)row["overall_status"]);
            }

            data.Columns.Remove("overall_status");
            data.Columns.Add("Overall-Status", typeof(string));
            for (int i = 0; i < data.Rows.Count; i++)
            {
                data.Rows[i]["Overall-Status"] = statusList[i] ? "Defective" : "Satisfactory";
            }

            _data.DataSource = data;
            _data.Width = flowparent.Width - 10; // Fit into the FlowLayoutPanel
            _data.Height = flowparent.Height;

            // Set DataGridView to ensure columns fill available space
            _data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Ensure no extra spacing
            _data.Margin = new Padding(0);
            _data.Padding = new Padding(0);

            // Disable unnecessary horizontal scrolling
            _data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical; // Only vertical scrolling
            _data.ReadOnly = true;
            flowparent.Controls.Add(_data);
            pergroups.Add(_data);
        }

        public void _delete_all()
        {
           foreach(object obj in pergroups)
            {
                if (obj is IDisposable dispose)
                {
                    dispose.Dispose();
                }
                
            }
            pergroups.Clear();
        }
    }


    public class buttonPerHistory
    {
        public List<ButtonItem> buttons = new List<ButtonItem>();
        private SQL_Support sql = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");
        private FlowLayoutPanel button_container;
        private MachineViewer parent;

        public buttonPerHistory(MachineViewer parent, FlowLayoutPanel button_container)
        {
            this.parent = parent;
            this.button_container = button_container;
        }

        public void _remove_all_buttons()
        {
            foreach (ButtonItem button in buttons){button.Dispose();}
            buttons.Clear();
        }

        public void _add_button(int id_of_history_log, DateTime history)
        {
            ButtonItem historylog_btn = new ButtonItem(id_of_history_log, parent);
            Datetotext convertDate = new Datetotext();
            string set_rename = "(" + id_of_history_log.ToString() + ") " + convertDate.getMonthAsText(history) + history.Day + ", " + history.Year;
            buttons.Add(historylog_btn);
            historylog_btn.TopLevel = false;
            historylog_btn.RenameBtn(set_rename);
            button_container.Controls.Add(historylog_btn);
            historylog_btn.Show();
        }

        public void showAllResults()
        {
            _remove_all_buttons();
            sql._isDebugShow = true;
            DataTable data = sql.ExecuteQuery("SELECT * FROM EXECUTION_HISTORY");
            foreach (DataRow row in data.Rows)
            {
                int id = Convert.ToInt32(row["ID"]);
                DateTime history = Convert.ToDateTime(row["date_commit"]);
                _add_button(id, history);
            }
        }

        public void showResultsWithFilter(string Filter, DateTimePicker dtp)
        {
                _remove_all_buttons();
                string query = "SELECT DISTINCT " +
                               "eh.id, eh.date_commit " +
                               "FROM EXECUTION_HISTORY eh " +
                               "JOIN GROUP_TABLE gt ON eh.id = gt.historylog_id " +
                               "JOIN LOG_MACHINETABLE lm ON gt.GroupID = lm.groupID " +
                               "WHERE gt.Monitored_By LIKE '%" + Filter + "%' " +
                               "OR gt.Machine_Name LIKE '%" + Filter + "%' " +
                               "OR lm.defect_part LIKE '%" + Filter + "%' " +
                               "OR lm.defec_desc LIKE '%" + Filter + "%' " +
                               "OR lm.suggested_replacement_repair LIKE '%" + Filter + "%' " +
                               "OR lm.checked_by LIKE '%" + Filter + "%'";


            if (dtp.Enabled)
            {
                DateTime selectedDate = dtp.Value;
                query += " AND eh.date_commit >= '" + selectedDate.ToString("yyyy-MM-dd 00:00:00") + "' " +
                         "AND eh.date_commit <= '" + selectedDate.ToString("yyyy-MM-dd 23:59:59") + "'";
            }

            DataTable data = sql.ExecuteQuery(query);
                foreach (DataRow row in data.Rows)
                {
                    int id = Convert.ToInt32(row["id"]);
                    DateTime history = Convert.ToDateTime(row["date_commit"]);
                    _add_button(id, history);
                }
            
        }


    }



}
