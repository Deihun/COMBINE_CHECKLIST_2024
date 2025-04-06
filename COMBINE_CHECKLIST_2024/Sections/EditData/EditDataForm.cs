using COMBINE_CHECKLIST_2024.Addons;
using COMBINE_CHECKLIST_2024.DateToText;
using COMBINE_CHECKLIST_2024.Sections.Currugator;
using COMBINE_CHECKLIST_2024.Sections.MachineHistory;
using SQL_Connection_support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace COMBINE_CHECKLIST_2024.Sections.EditData
{
    public partial class EditDataForm: Form
    {
        private SQL_Support sql;
        private List<FlowLayoutPanel> list_of_pages = new List<FlowLayoutPanel>();
        private int intData = 1;


        private const int maximum_object_in_page = 20;
        private int number_of_page;
        private int selected_page = 1;
        private List<Button> list_of_item = new List<Button>();

        public EditDataForm(SQL_Support sql)
        {
            InitializeComponent();
            this.sql = sql;
        }

        private void setData(int id)
        {
            label1.Text = $"ID: {id}";
            reupdateEditArea(id);
        }
        private void setData(int id, int combinedID)
        {
            id += combinedID;
            setData(id);
        }

        private void next_btn_Click(object sender, EventArgs e)
        {

        }

        private void previous_btn_Click(object sender, EventArgs e)
        {
            intData--;
            setData(intData);
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
                if (number_of_object > maximum_object_in_page)
                {
                    number_of_object = 0;
                    number_of_page++;
                    Add_new_Page();
                }
            }
            selected_page = change_page(1, 0);
            TotalAmount_label.Text = $"TOTAL: {number_of_objects_total}";
        }

        public void Add_new_Page()
        {
            FlowLayoutPanel flp = new FlowLayoutPanel();
            flp.Padding = new Padding(0);
            flp.Margin = new Padding(0);
            flp.FlowDirection = FlowDirection.TopDown;
            flp.WrapContents = false;
            flp.Width = flowLayoutPanel2.Width;
            flp.Height = flowLayoutPanel2.Height;
            list_of_pages.Add(flp);
            flowLayoutPanel2.Controls.Add(flp);
            flp.Show();
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
        private Button add_new_record_as_button(string name, int groupID)
        {
            Button button = new Button();
            button.Width = flowLayoutPanel2.Width - 20;
            button.Text = name;
            button.Tag = groupID;
            button.BackColor = Color.White;
            list_of_item.Add(button);
            list_of_pages[number_of_page - 1].Controls.Add(button);
            button.Click += (sender, e) => { reupdateEditArea(groupID); };
            button.Show();
            return button;
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
            if (enableDateTime_cb.Checked)
            {
                conditions.Add($" DAY(record.date_commit) = {dateTimePicker1.Value.Day} AND MONTH(record.date_commit) = {dateTimePicker1.Value.Month} AND YEAR(record.date_commit) = {dateTimePicker1.Value.Day} ");
            }
            if (!string.IsNullOrEmpty(search_tb.Text))
                conditions.Add($" [_group].Machine_Name LIKE '%{search_tb.Text}%'");

            if (conditions.Count > 0)
                query += " WHERE " + string.Join(" AND ", conditions);

            return sql.ExecuteQuery(query);
        }


        private void reupdateEditArea(int id)
        {
            foreach (Control control in flowLayoutPanel1.Controls) control.Dispose();
            flowLayoutPanel1.Controls.Clear();
            label1.Text = $"ID: {id}";
            DataTable listOfGroups = sql.ExecuteQuery($"SELECT * FROM GROUP_TABLE WHERE historylog_id = {id};");
            foreach (DataRow row in listOfGroups.Rows)
            { //Generate Group Forms
                int groupID = Convert.ToInt32(row["GroupID"]);
                string monitor = row["Monitored_By"].ToString();
                string machine = row["Machine_Name"].ToString();
                string location = row["Location"].ToString();
                DateTime From = (DateTime)row["From_Date"];
                DateTime To = (DateTime)row["To_Date"];
                grouping_of_items groups = new grouping_of_items(From, To, monitor,machine,location, sql);
                groups.ID_Edit = groupID;
                groups.TopLevel = false;
                groups.Width = flowLayoutPanel1.ClientSize.Width / 2; 
                groups.Height = flowLayoutPanel1.ClientSize.Height / 2; 
                flowLayoutPanel1.Controls.Add(groups);
                groups.hideDelete();
                groups.Show();

                DataTable itemDataTable = sql.ExecuteQuery($"SELECT * FROM LOG_MACHINETABLE WHERE groupID = {groupID};");
                foreach (DataRow _row in itemDataTable.Rows)
                {
                    Item_Record item = new Item_Record(sql);
                    int _item_id = Convert.ToInt32(_row["ID"]);
                    string defectPart = _row["defect_part"].ToString();
                    string defectDesc = _row["defec_desc"].ToString();
                    string srr = _row["suggested_replacement_repair"].ToString();
                    string ra = _row["remark_analysis"].ToString();
                    bool OS = (bool)_row["overall_status"];
                    string cheBy = _row["checked_by"].ToString();
                    item.ID_Edit = _item_id;
                    item.my_targeted_date = Convert.ToDateTime(_row["datemark"]);
                    item.my_target_time = _row["target_time"].ToString();
                    item.setVarCharData(defectPart,defectDesc,srr,ra,cheBy);
                    item.setIsDefect(OS);
                    groups.add_item(item);
                }
            }
            // RENDER WORKBENCH 
        }

        private void applychange_btn_Click(object sender, EventArgs e)
        {
            string query = "";
            foreach (grouping_of_items groups in flowLayoutPanel1.Controls)
            {
               query = $"UPDATE GROUP_TABLE SET Monitored_By = '{groups.getMonitor()}'," +
                    $"Machine_Name = '{groups.getMachineName()}', Location = '{groups.getLocation()}'" +
                    $"WHERE GroupID = {groups.ID_Edit};";
                sql.ExecuteQuery(query);


                foreach (Form form in groups.group_of_logs)
                {
                    if (form is Item_Record itemRecord)
                    {
                        int itemID = itemRecord.ID_Edit;
                        query = $"UPDATE LOG_MACHINETABLE SET " +
                                $"defect_part = '{itemRecord.get_defectiveparts().Replace("'", "''")}', " +
                                $"defec_desc = '{itemRecord.get_defectiveDescription().Replace("'", "''")}', " +
                                $"suggested_replacement_repair = '{itemRecord.get_suggestion().Replace("'", "''")}', " +
                                $"remark_analysis = '{itemRecord.get_remarks().Replace("'", "''")}', " +
                                $"overall_status = '{itemRecord.get_overallAnalysis().ToString().Replace("'", "''")}', " +
                                $"checked_by = '{itemRecord.get_checkby().Replace("'", "''")}' " +
                                $"WHERE ID = {itemRecord.ID_Edit};";
                        sql.ExecuteQuery(query);
                    }
                }
            }
            Dictionary<string, object> logHistory = new Dictionary<string, object>
                    {
                        { "Context", $"ID{intData} has been change via 'Edit-Data'"},
                        {"Date_Log", DateTime.Now }
                    };
            sql.InsertData("HISTORY_", logHistory);
        }
        

        private void EditDataForm_VisibleChanged(object sender, EventArgs e)
        {
            instantiate_all_object();
            var theme = new theme_management();
            theme.SetGradientBackground(this);
            panel1.BackColor = theme.get_color_bottom_bar();
            selectioncontainer_panel.BackColor = theme.get_color_bottom_bar();
            flowLayoutPanel2.BackColor = theme.get_color_buttonPerItem();
            Page_panel.BackColor = theme.get_color_top_board();
            label1.ForeColor = theme.get_font_color();
            label2.ForeColor = theme.get_font_color();
            page_label.ForeColor = theme.get_font_color();
            TotalAmount_label.ForeColor = theme.get_font_color();
        }



        private void EditDataForm_Load(object sender, EventArgs e)
        {

        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void enableDateTime_cb_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = enableDateTime_cb.Checked;
        }

        private void EditDataForm_Resize(object sender, EventArgs e)
        {
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            instantiate_all_object();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            search_tb.Text = "";
            enableDateTime_cb.Checked = false;
            instantiate_all_object();
        }

        private void next_btn_Click_1(object sender, EventArgs e)
        {
            selected_page = change_page(selected_page, 1);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            selected_page = change_page(selected_page, -1);
        }
    }
}
