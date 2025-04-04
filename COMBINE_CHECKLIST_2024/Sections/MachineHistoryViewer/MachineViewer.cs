using COMBINE_CHECKLIST_2024.DateToText;
using COMBINE_CHECKLIST_2024.ExcelManagement;
using COMBINE_CHECKLIST_2024.OpenFilePath;
using SQL_Connection_support;
using System;
using System.Collections.Generic;

using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

using System.Windows.Forms;


namespace COMBINE_CHECKLIST_2024.Sections.MachineHistoryViewer
{
    public partial class MachineViewer: Form
    {
        List<Form> ViewList = new List<Form>();
        private SQL_Support sql = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");
        private gridview_adjustment g_adjust;
        private int selectedID = -1;


        private const int maximum_object_in_page = 20;
        private int number_of_page;
        private int selected_page = 1;
        private List<FlowLayoutPanel> list_of_pages = new List<FlowLayoutPanel>();
        private List<Button> list_of_item = new List<Button>();

        public MachineViewer()
        {
            InitializeComponent();
            
            g_adjust = new gridview_adjustment(sql, dataPerSection);
            g_adjust.dataPerHistoryLog_flp = dataPerSection;

            button_container_flp.HorizontalScroll.Enabled = false;
            button_container_flp.HorizontalScroll.Visible = false;
            button_container_flp.HorizontalScroll.Maximum = 0;
            button_container_flp.AutoScrollMinSize = new Size(0, 1);
            chart1.Titles.Add("STATUS");
            instantiate_all_object();
        }

        public void Add_new_Page()
        {
            FlowLayoutPanel flp = new FlowLayoutPanel();
            flp.Padding = new Padding(0);
            flp.Margin = new Padding(0);
            flp.FlowDirection = FlowDirection.TopDown;
            flp.WrapContents = false;
            flp.Width = button_container_flp.Width;
            flp.Height = button_container_flp.Height;
            list_of_pages.Add(flp);
            button_container_flp.Controls.Add(flp);
            flp.Show();
        }

        public void instantiate_all_object()
        {

            foreach (FlowLayoutPanel flp in list_of_pages) flp.Dispose();
            list_of_pages.Clear();
            Add_new_Page();
            number_of_page = 1;
            int number_of_objects_total = 0;
            int number_of_object = 0;
            foreach (DataRow row in get_server_with_filter_on().Rows)
            {
                add_new_record_as_button($"{row["date_commit"]} ({row["ID"]})", Convert.ToInt32(row["ID"]));
                number_of_object++;
                number_of_objects_total++;
                if (number_of_object >= maximum_object_in_page)
                {
                    number_of_object = 0;
                    number_of_page++;
                    Add_new_Page();
                }
            }
            selected_page = change_page(1, 0);
            TotalAmount_label.Text = $"TOTAL: {number_of_objects_total}";
        }

        public int change_page(int page, int difference)
        {
            int _page = page + difference;
            foreach (FlowLayoutPanel flp in list_of_pages) flp.Hide();
            try
            {
                list_of_pages[_page - 1].Show();
                page_label.Text = $"PAGE {_page}/{number_of_page}";
                next_btn.Visible = _page < number_of_page;
                back_btn.Visible = _page > 1;
            }
            catch
            {
                list_of_pages[0].Show();
                page_label.Text = $"PAGE {page}/{number_of_page}";
                next_btn.Visible = page < number_of_page;
                back_btn.Visible = page > 1;
                return page;
            }
            return _page;
        }


        private DataTable get_server_with_filter_on()
        {
            List<string> conditions = new List<string>();

            string query = $@"
        SELECT  DISTINCT
            record.ID, 
            _group.Machine_Name, 
            _group.Monitored_By, 
            _group.Location, 
            record.date_commit
        FROM EXECUTION_HISTORY record
        LEFT JOIN GROUP_TABLE _group ON record.id = _group.historylog_id
        LEFT JOIN LOG_MACHINETABLE item ON item.groupID = _group.GroupID
    ";
            if (date_cb.Checked)
            {
                conditions.Add($" DAY(record.date_commit) = {DateFilter_dt.Value.Day} AND MONTH(record.date_commit) = {DateFilter_dt.Value.Month} AND YEAR(record.date_commit) = {DateFilter_dt.Value.Day} ");
            }
             if (!string.IsNullOrEmpty(searchfilter_tb.Text))
                    conditions.Add($" [_group].Machine_Name LIKE '%{searchfilter_tb.Text}%'");

            if (conditions.Count > 0)
                query += " WHERE " + string.Join(" AND ", conditions);

            //MessageBox.Show(query);
            return sql.ExecuteQuery(query);
        }

        private Button add_new_record_as_button(string name, int groupID)
        {
            Button button = new Button();
            button.Width = button_container_flp.Width - 20;
            button.Text = name;
            button.Tag = groupID;
            button.BackColor = Color.White;
            list_of_item.Add(button);
            list_of_pages[number_of_page - 1].Controls.Add(button);
            button.Click += (sender, e) => { SetDataGridView(groupID); };
            button.Show();
            return button;
        }


        public void SetDataGridView(int id)
        {
            g_adjust.show_dataPerSection(id);//
            printOption_panel.Show();
            selectedID = id;
        }


        private void MachineViewer_Load(object sender, EventArgs e)
        {
        }

        private void MachineViewer_VisibleChanged(object sender, EventArgs e)
        {
            instantiate_all_object();
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
            SetGradientBackground("#D1FFC3", "#79AE86");
        }


        private void SetGradientBackground(string hexColor1, string hexColor2)
        {
            Color color1 = ColorTranslator.FromHtml(hexColor1);
            Color color2 = ColorTranslator.FromHtml(hexColor2);

            Bitmap bmp = new Bitmap(this.Width, this.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Rectangle(0, 0, this.Width, this.Height),
                color1,
                color2,
                LinearGradientMode.Vertical)) // Change direction if needed
            {
                g.FillRectangle(brush, 0, 0, this.Width, this.Height);
            }
            this.BackgroundImage = bmp;
        }



        private void dataPerSection_Paint(object sender, PaintEventArgs e)
        {
        }

        private void searchfilter_tb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void date_cb_CheckedChanged(object sender, EventArgs e)
        {
            DateFilter_dt.Enabled = date_cb.Checked;
            g_adjust.show_dataPerSection(searchfilter_tb.Text, DateFilter_dt);

        }

        private void DateFilter_dt_ValueChanged(object sender, EventArgs e)
        {

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
                        { "Context", $"A 'SaveFile' has been performed via View-Data in path '{filepath}', referencing data ID {selectedID}" },
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
                        { "Context", $"A print has been performed via View-Data, referencing data ID {selectedID}" },
                        {"Date_Log", DateTime.Now }
                    };
            sql.InsertData("HISTORY_", logHistory);

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            selected_page = change_page(selected_page, -1);
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            selected_page = change_page(selected_page, 1);
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            printOption_panel.Hide();
            instantiate_all_object();
            g_adjust.show_dataPerSection(searchfilter_tb.Text, DateFilter_dt);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            searchfilter_tb.Text = "";
            date_cb.Checked = false;
            instantiate_all_object();
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

                filterCondition += $" AND YEAR(L.datemark) = {selectedYear} " +
                                   $"AND MONTH(L.datemark) = {selectedMonth} " +
                                   $"AND DAY(L.datemark) = {selectedDay}";
            }
            string query = $"SELECT L.defect_part, L.defec_desc, L.suggested_replacement_repair, L.remark_analysis, " +
                           $"L.overall_status, L.checked_by, L.datemark, " +
                           $"G.Machine_Name, G.Monitored_By, G.Location " +
                           $"FROM LOG_MACHINETABLE L " +
                           $"INNER JOIN GROUP_TABLE G ON L.groupID = G.GroupID " +
                           $"WHERE {filterCondition};";
            DataTable _data = sql.ExecuteQuery(query);
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
            _data.Width = flowparent.Width - 10; 
            _data.Height = flowparent.Height;
            _data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            _data.Margin = new Padding(0);
            _data.Padding = new Padding(0);
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
}
