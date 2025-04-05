using COMBINE_CHECKLIST_2024.DateToText;
using COMBINE_CHECKLIST_2024.ExcelManagement;
using COMBINE_CHECKLIST_2024.OpenFilePath;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using SQL_Connection_support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMBINE_CHECKLIST_2024.Sections.MachineHistoryViewer
{
    public partial class BulkPrintSelection : Form
    {
        private SQL_Support sql = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");
        private Datetotext filter = new Datetotext();
        private Filter_Datas filter_data = new Filter_Datas();

        public int number_of_object_per_page = 12;
        public int number_of_page;
        public int selected_page = 1;

        private List<FlowLayoutPanel> list_of_pages = new List<FlowLayoutPanel>();
        public BulkPrintSelection()
        {
            InitializeComponent();
            dateTimePicker1.Enabled = false;

            monitoredby_cb.Items.Add("");
            location_cb.Items.Add("");
            machineName_cb.Items.Add("");
            DataTable results = sql.ExecuteQuery("SELECT DISTINCT [Machine_Name] FROM GROUP_TABLE;");
            foreach (DataRow r in results.Rows)
            {
                machineName_cb.Items.Add(r["Machine_Name"]);
            }
            results.Clear();
            results = sql.ExecuteQuery("SELECT DISTINCT [Monitored_By] FROM GROUP_TABLE;");
            foreach (DataRow r in results.Rows)
            {
                monitoredby_cb.Items.Add(r["Monitored_By"]);
            }
            results.Clear();
            results = sql.ExecuteQuery("SELECT DISTINCT [Location] FROM GROUP_TABLE;");
            foreach (DataRow r in results.Rows)
            {
                location_cb.Items.Add(r["Location"]);
            }
            results.Clear();
            results = sql.ExecuteQuery("SELECT DISTINCT YEAR([date_commit]) AS year_commit FROM EXECUTION_HISTORY;");
            foreach (DataRow r in results.Rows)
            {

                YearCB.Items.Add(r["year_commit"]);
            }
            instantiate_all_object();
        }
        public void Add_new_Page()
        {
            FlowLayoutPanel flp = new FlowLayoutPanel();
            flp.Padding = new Padding(0);
            flp.Margin = new Padding(0);
            flp.FlowDirection = FlowDirection.TopDown;
            flp.WrapContents = false;
            flp.Width = selection_container_fl.Width - 20;
            flp.Height = selection_container_fl.Height - 20;
            list_of_pages.Add(flp);
            selection_container_fl.Controls.Add(flp);
        }
        public void instantiate_all_object()
        {
            filter_data.month = string.IsNullOrEmpty(year_cb.Text) ? "" : year_cb.Text;
            filter_data.year = string.IsNullOrEmpty(YearCB.Text) ? "" : YearCB.Text;
            filter_data.machine_name = string.IsNullOrEmpty(machineName_cb.Text) ? "" : machineName_cb.Text;
            filter_data.monitored_by = string.IsNullOrEmpty(monitoredby_cb.Text) ? "" : monitoredby_cb.Text;
            filter_data.location = string.IsNullOrEmpty(location_cb.Text) ? "" : location_cb.Text;
            foreach (FlowLayoutPanel flp in list_of_pages) flp.Dispose();
            list_of_pages.Clear();
            Add_new_Page();
            number_of_page = 1;
            int number_of_object = 0;
            foreach (DataRow row in get_server_with_filter_on().Rows)
            {
                create_check_box($"{row["date_commit"]} ({row["ID"]})", Convert.ToInt32(row["ID"]));
                number_of_object++;
                if (number_of_object >= number_of_object_per_page)
                {
                    number_of_object = 0;
                    number_of_page++;
                    Add_new_Page();
                }
            }
            selected_page = change_page(1, 0);
        }

        public CheckBox create_check_box(string text, int tag)
        {
            CheckBox selection = new CheckBox();
            selection.Text = text;
            selection.Tag = tag;
            selection.CheckStateChanged += (sender, e) => { checkTrigger(); };
            list_of_pages[number_of_page - 1].Controls.Add(selection);
            selection.Show();
            return selection;
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
            if (specificDate_rd.Checked)
            {
                conditions.Add($" DAY(record.date_commit) = {dateTimePicker1.Value.Day} AND MONTH(record.date_commit) = {dateTimePicker1.Value.Month} AND YEAR(record.date_commit) = {dateTimePicker1.Value.Day} ");
            }
            else
            {
                if (!string.IsNullOrEmpty(filter_data.machine_name))
                    conditions.Add($" [_group].Machine_Name = '{filter_data.machine_name}'");
                if (!string.IsNullOrEmpty(filter_data.monitored_by))
                    conditions.Add($" [_group].Monitored_By = '{filter_data.monitored_by}'");
                if (!string.IsNullOrEmpty(filter_data.location))
                    conditions.Add($" [_group].Location = '{filter_data.location}'");
                if (!string.IsNullOrEmpty(filter_data.month))
                    conditions.Add($" MONTH(record.date_commit) = {filter.getMonth(filter_data.month)}");
                if (!string.IsNullOrEmpty(filter_data.year))
                    conditions.Add($" YEAR(record.date_commit) = {filter_data.year}");
            }

            if (conditions.Count > 0)
                query += " WHERE " + string.Join(" AND ", conditions);

            return sql.ExecuteQuery(query);
        }

        public void checkTrigger()
        {
            List<int> group_id = new List<int>();
            foreach (FlowLayoutPanel flp in list_of_pages)
            {
                foreach (CheckBox checkbox in flp.Controls)
                {
                    if (checkbox.Checked) group_id.Add(Convert.ToInt32(checkbox.Tag));
                }
            }
            HistoryExcelGeneration excel = new HistoryExcelGeneration();
            web.DocumentText = excel.ConvertExcelToHtml(excel.GenerateBulkExcelWorkbook(group_id));
        }
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void specificDate_rd_CheckedChanged(object sender, EventArgs e)
        {
            applyDisables();
        }

        private void applyDisables()
        {
            dateTimePicker1.Enabled = specificDate_rd.Checked;
            machineName_cb.Enabled = !specificDate_rd.Checked;
            monitoredby_cb.Enabled = !specificDate_rd.Checked;
            location_cb.Enabled = !specificDate_rd.Checked;
            YearCB.Enabled = !specificDate_rd.Checked;
            year_cb.Enabled = !specificDate_rd.Checked;
            year_cb.Text = !specificDate_rd.Checked ? year_cb.Text : string.Empty;
            machineName_cb.Text = !specificDate_rd.Checked ? machineName_cb.Text : string.Empty;

        }

        private void Dropdownbox_rd_CheckedChanged(object sender, EventArgs e)
        {
            applyDisables();
        }

        private void machineName_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void year_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearfilter_btn_Click(object sender, EventArgs e)
        {
            machineName_cb.Text = "";
            year_cb.Text = "";
            monitoredby_cb.Text = "";
            location_cb.Text = "";
            year_cb.Text = "";
            instantiate_all_object();
        }

        private void monitoredby_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            HistoryExcelGeneration excel = new HistoryExcelGeneration();
            WorkbookPrinter a = new WorkbookPrinter(excel.GenerateBulkExcelWorkbook(get_selected_list_id()));
            a.Print();
            Dictionary<string, object> logHistory = new Dictionary<string, object>
                    {
                        { "Context", $"A 'BulkPrint' has been performed in View-Data" },
                        {"Date_Log", DateTime.Now }
                    };
            sql.InsertData("HISTORY_", logHistory);
        }


        private void createFile_btn_Click(object sender, EventArgs e)
        {
            FolderPathManagement select = new FolderPathManagement();
            string filepath = select.ShowSaveFileDialog();
            if (!(filepath == null || filepath == string.Empty))
            {
                HistoryExcelGeneration excel = new HistoryExcelGeneration(filepath);
                excel.ExportToExcel(excel.GenerateBulkExcelWorkbook(get_selected_list_id()));
            }
            Dictionary<string, object> logHistory = new Dictionary<string, object>
                    {
                        { "Context", $"A 'Bulk-Create-File' has been performed in View-Data with path '{filepath}'" },
                        {"Date_Log", DateTime.Now }
                    };
            sql.InsertData("HISTORY_", logHistory);
        }
        private List<int> get_selected_list_id()
        {
            List<int> ids = new List<int>();
            foreach (FlowLayoutPanel flp in list_of_pages)
            {
                foreach (CheckBox checkbox in flp.Controls) if (checkbox.Checked) ids.Add(Convert.ToInt32(checkbox.Tag));
            }
            return ids;
        }


        private void removeAllSelected_btn_Click(object sender, EventArgs e)
        {
            foreach (FlowLayoutPanel flp in list_of_pages)
            {
                foreach (CheckBox check in flp.Controls) check.Checked = false;
            }
        }

        private void location_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void YearCB_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void v_Click(object sender, EventArgs e)
        {
            QuickSelection q = new QuickSelection(machineName_cb, monitoredby_cb, location_cb, year_cb, YearCB,list_of_pages, this);
            q.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            instantiate_all_object();
        }

        public int change_page(int page, int difference)
        {
            int _page = page + difference;
            foreach (FlowLayoutPanel flp in list_of_pages) flp.Hide();
            try
            {
                list_of_pages[_page - 1].Show();
                Page_Label.Text = $"PAGE {_page}/{number_of_page}";
                next_btn.Visible = _page < number_of_page;
                back_btn.Visible = _page > 1;
            }
            catch
            {
                list_of_pages[0].Show();
                Page_Label.Text = $"PAGE {page}/{number_of_page}";
                next_btn.Visible = page < number_of_page;
                back_btn.Visible = page > 1;
                return page;
            }
            return _page;
        }
        private void back_btn_Click(object sender, EventArgs e)
        {
            selected_page = change_page(selected_page, -1);
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            selected_page = change_page(selected_page, 1);
        }
    }
}

    public class Filter_Datas
{
    public string machine_name = "";
    public string monitored_by = "";
    public string location = "";
    public string month = "";
    public string year = "";
}
