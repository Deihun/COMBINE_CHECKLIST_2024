using ClosedXML.Excel;
using COMBINE_CHECKLIST_2024.Addons;
using COMBINE_CHECKLIST_2024.DateToText;
using COMBINE_CHECKLIST_2024.ExcelManagement;
using COMBINE_CHECKLIST_2024.OpenFilePath;
using COMBINE_CHECKLIST_2024.Sections.MachineHistory;
using SQL_Connection_support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace COMBINE_CHECKLIST_2024.Sections.Currugator
{
    public partial class Create: Form
    {
        public List <Form> groupOf_groupforms = new List<Form>();
        SQL_Support sql = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");
        int _last_identity;
        public Create()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;

        }

        private void additem_btn_Click(object sender, EventArgs e)
        {
            Add_Group_confirmation confirm = new Add_Group_confirmation(this.flowLayoutPanel1, this, sql.FilterQuery(monitor_tb.Text), sql.FilterQuery(machine_tb.Text), sql.FilterQuery(location_tb.Text));
            confirm.ShowDialog();
        }

        public void addNewGroups(Form groups)
        {
            groupOf_groupforms.Add(groups);
            //groups.Parent = this;
        }

        public void deleteGroup(Form groups)
        {
            groupOf_groupforms.Remove(groups);
        }

        private void create_new_history_btn_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count < 1)
            {
                MessageBox.Show("Cannot add empty data. Please click 'ADD' button to add items in a work panel.", "Warning");
            }
            else
            {
                after_panel.Show();
                create_new_history_btn.Hide();
                addAsDateInterval_btn.Hide();
                order_a_SelectAsync();
                foreach (Control control in flowLayoutPanel1.Controls) if (control is grouping_of_items g) g.hideDelete();
                flowLayoutPanel1.Controls.Clear();

                MessageBox.Show($"Data {_last_identity} successfully added in the database!");
            }
        }

        private void order_a_SelectAsync()
        {

            string query = $"INSERT INTO EXECUTION_HISTORY (date_commit) VALUES('{DateTime.Now:yyyy-MM-dd HH:mm:ss}'); SELECT SCOPE_IDENTITY()";
            sql._isDebugShow = true;
            _last_identity = Convert.ToInt32(sql.ExecuteQuery(query).Rows[0][0]);

            foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control is grouping_of_items groupForm) // Correct type
                    {
                    query = $"INSERT INTO GROUP_TABLE (From_Date, historylog_id, To_Date, Monitored_By, Machine_Name, Location) " +
                                   $"VALUES ('{groupForm._from_dt:yyyy-MM-dd HH:mm:ss}', {_last_identity}, '{groupForm._to_dt.Date:yyyy-MM-dd HH:mm:ss}', '{groupForm.getMonitor()}', '{groupForm.getMachineName()}', '{groupForm.getLocation()}'); " +
                                   "SELECT SCOPE_IDENTITY();";
                    MessageBox.Show($"{query}");
                    int groupID = Convert.ToInt32(sql.ExecuteQuery(query).Rows[0][0]);

                    sql._isDebugShow = true;

                    foreach (Control _control in groupForm.items_in_flp.Controls)
                    {
                        if (_control is Item_Record logGroup)
                        {
                            string _query = $"INSERT INTO LOG_MACHINETABLE (defect_part, defec_desc, suggested_replacement_repair, remark_analysis, overall_status, checked_by, groupID, datemark, target_time) " +
                                           $" VALUES ('{logGroup.get_defectiveparts()}', '{logGroup.get_defectiveDescription()}', '{logGroup.get_suggestion()}', '{logGroup.get_remarks()}', " +
                                           $" {logGroup.get_overallAnalysis()}, '{logGroup.get_checkby()}', {groupID}, '{logGroup.my_targeted_date.Date:yyyy - MM - dd HH: mm: ss}', '{logGroup.my_target_time}');";

                            sql.ExecuteQuery(_query);
                        }
                    }
                    after_panel.Show();
                    Dictionary<string, object> logHistory = new Dictionary<string, object>
                    {
                        { "Context", $"{sql.FilterQuery( monitor_tb.Text) } has added a new data in the database with ID {_last_identity.ToString()}" },
                        {"Date_Log", DateTime.Now }
                    };
                    
                    sql.InsertData("HISTORY_",logHistory);
                    create_new_history_btn.SendToBack();
                }
            }
            //HistoryExcelGeneration export = new HistoryExcelGeneration(filepath);
            //export.generate_an_excel(_last_id_identity);
        }

        private void Create_Load(object sender, EventArgs e)
        {}

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {}

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

        private void Create_VisibleChanged(object sender, EventArgs e)
        {
            after_panel.Hide();
            create_new_history_btn.Show();
            addAsDateInterval_btn.Show();
            create_new_history_btn.BringToFront();
            AutoCompleteStringCollection location = new AutoCompleteStringCollection();
            AutoCompleteStringCollection monitoredBy = new AutoCompleteStringCollection();
            AutoCompleteStringCollection machinename = new AutoCompleteStringCollection();


            DataTable _location = sql.ExecuteQuery("SELECT * FROM GROUP_TABLE;");

            foreach (DataRow row in _location.Rows)
            {
                location.Add(row["Location"].ToString());
                monitoredBy.Add(row["Monitored_By"].ToString());
                machinename.Add(row["Machine_Name"].ToString());
            }
            setAutoComplete(location_tb, location);
            setAutoComplete(monitor_tb, monitoredBy);
            setAutoComplete(machine_tb, machinename);

            foreach (Control control in flowLayoutPanel1.Controls) control.Dispose();
            flowLayoutPanel1.Controls.Clear();
            after_panel.Hide();
            SetGradientBackground("#D1FFC3", "#79AE86");
        }

        private void setAutoComplete(TextBox textbox, AutoCompleteStringCollection acsc)
        {
            textbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textbox.AutoCompleteCustomSource = acsc;
        }

        private void saveFile_btn_Click(object sender, EventArgs e)
        {
                FolderPathManagement select = new FolderPathManagement();
                string filepath = select.ShowSaveFileDialog();
                if (!(filepath == null || filepath == string.Empty))
                {
                    HistoryExcelGeneration excel = new HistoryExcelGeneration(filepath);
                    excel.ExportToExcel(excel.GenerateExcelWorkbook(_last_identity));
                }
                Dictionary<string, object> logHistory = new Dictionary<string, object>
                    {
                        { "Context", $"{sql.FilterQuery(monitor_tb.Text)} has save a new file into a path '{filepath}', referencing data ID {_last_identity.ToString()}" },
                        {"Date_Log", DateTime.Now }
                    };
                sql.InsertData("HISTORY_", logHistory);

        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (_last_identity > -1)
            {
                HistoryExcelGeneration excel = new HistoryExcelGeneration();
                WorkbookPrinter a = new WorkbookPrinter(excel.GenerateExcelWorkbook(_last_identity));
                a.Print();
            }
            Dictionary<string, object> logHistory = new Dictionary<string, object>
                    {
                        { "Context", $"{sql.FilterQuery(monitor_tb.Text)} Perform a print, referencing data ID {_last_identity.ToString()}" },
                        {"Date_Log", DateTime.Now }
                    };
            sql.InsertData("HISTORY_", logHistory);

        }

        private void add_another_btn_Click(object sender, EventArgs e)
        {
            after_panel.Hide();
            create_new_history_btn.Show();
            addAsDateInterval_btn.Show();

            foreach (Control control in flowLayoutPanel1.Controls) control.Dispose();
            flowLayoutPanel1.Controls.Clear();
        }

        private void set_suggestion(Dictionary<Tuple<Action<TextBox, string>,TextBox, string>, string> list)
        {
            foreach (Control controls in suggestion_flp.Controls) controls.Dispose();
            suggestion_flp.Controls.Clear();
            foreach (var suggest in list)
            {
                LinkLabel linklabel = new LinkLabel();
                linklabel.Text = suggest.Value;
                linklabel.ForeColor = System.Drawing.Color.White;
                linklabel.LinkColor = System.Drawing.Color.White;
                linklabel.Padding = new Padding(0);
                linklabel.Margin = new Padding(0);
                linklabel.LinkClicked += (sender, e) => { suggest.Key.Item1.Invoke(suggest.Key.Item2,suggest.Key.Item3); };
                suggestion_flp.Controls.Add(linklabel);
                linklabel.Show();
            } 
        }

        private void monitor_tb_MouseEnter(object sender, EventArgs e)
        {
            string query = @"SELECT DISTINCT Monitored_By, frequency
                            FROM (
                                SELECT TOP 3 Monitored_By, COUNT(*) AS frequency
                                FROM GROUP_TABLE
                                WHERE Monitored_By IS NOT NULL AND Monitored_By <> ''
                                GROUP BY Monitored_By
                                ORDER BY frequency DESC
                            ) AS freq_data

                            UNION

                            SELECT Monitored_By, NULL AS frequency
                            FROM (
                                SELECT _group.Monitored_By
                                FROM GROUP_TABLE _group
                                JOIN EXECUTION_HISTORY record ON record.id = _group.historylog_id
                                WHERE _group.Monitored_By IS NOT NULL AND _group.Monitored_By <> ''
                                ORDER BY record.date_commit DESC
                                OFFSET 0 ROWS FETCH FIRST 1 ROWS ONLY
                            ) AS recent_data;
                            ";
            Dictionary<Tuple<Action<TextBox, string>, TextBox, String>, string> list = new Dictionary<Tuple<Action<TextBox, string>, TextBox, string>, string>();
            foreach (DataRow row in sql.ExecuteQuery(query).Rows)
            {
                var tupleKey = new Tuple<Action<TextBox, string>, TextBox, string>(
                    set_text_from_suggestion,              
                    sender as TextBox,                     
                    row["Monitored_By"].ToString()         
                );
                try { list.Add(tupleKey, row["Monitored_By"].ToString()); } catch { }
            }
            set_suggestion(list);
        }

        private void set_text_from_suggestion(TextBox textbox, string text)
        {
            textbox.Text = text;
        }

        private void machine_tb_MouseEnter(object sender, EventArgs e)
        {

            string query = @"SELECT DISTINCT Machine_Name, frequency
                            FROM (
                                SELECT TOP 3 Machine_Name, COUNT(*) AS frequency
                                FROM GROUP_TABLE
                                WHERE Machine_Name IS NOT NULL AND Machine_Name <> ''
                                GROUP BY Machine_Name
                                ORDER BY frequency DESC
                            ) AS freq_data

                            UNION

                            SELECT Machine_Name, NULL AS frequency
                            FROM (
                                SELECT _group.Machine_Name
                                FROM GROUP_TABLE _group
                                JOIN EXECUTION_HISTORY record ON record.id = _group.historylog_id
                                WHERE _group.Machine_Name IS NOT NULL AND _group.Machine_Name <> ''
                                ORDER BY record.date_commit DESC
                                OFFSET 0 ROWS FETCH FIRST 1 ROWS ONLY
                            ) AS recent_data;
                            ";
            Dictionary<Tuple<Action<TextBox, string>, TextBox, String>, string> list = new Dictionary<Tuple<Action<TextBox, string>, TextBox, string>, string>();
            foreach (DataRow row in sql.ExecuteQuery(query).Rows)
            {
                var tupleKey = new Tuple<Action<TextBox, string>, TextBox, string>(
                    set_text_from_suggestion,
                    sender as TextBox,
                    row["Machine_Name"].ToString()
                );
                try { list.Add(tupleKey, row["Machine_Name"].ToString()); } catch { }
            }
            set_suggestion(list);
        }

        private void top_panel_MouseEnter(object sender, EventArgs e)
        {

        }

        private void top_panel_MouseLeave(object sender, EventArgs e)
        {

        }

        private void location_tb_MouseEnter(object sender, EventArgs e)
        {


            string query = @"SELECT DISTINCT Location, frequency
                            FROM (
                                SELECT TOP 3 Location, COUNT(*) AS frequency
                                FROM GROUP_TABLE
                                WHERE Location IS NOT NULL AND Location <> ''
                                GROUP BY Location
                                ORDER BY frequency DESC
                            ) AS freq_data

                            UNION

                            SELECT Location, NULL AS frequency
                            FROM (
                                SELECT _group.Location
                                FROM GROUP_TABLE _group
                                JOIN EXECUTION_HISTORY record ON record.id = _group.historylog_id
                                WHERE _group.Location IS NOT NULL AND _group.Location <> ''
                                ORDER BY record.date_commit DESC
                                OFFSET 0 ROWS FETCH FIRST 1 ROWS ONLY
                            ) AS recent_data;
                            ";
            Dictionary<Tuple<Action<TextBox, string>, TextBox, String>, string> list = new Dictionary<Tuple<Action<TextBox, string>, TextBox, string>, string>();
            foreach (DataRow row in sql.ExecuteQuery(query).Rows)
            {
                var tupleKey = new Tuple<Action<TextBox, string>, TextBox, string>(
                    set_text_from_suggestion,
                    sender as TextBox,
                    row["Location"].ToString()
                );
                try { list.Add(tupleKey, row["Location"].ToString()); } catch { }
            }
            set_suggestion(list);
        }

        public void set_guide(List<string> list_of_tutorials)
        {
            foreach (Control control in guide_flp.Controls) control.Dispose();
            guide_flp.Controls.Clear();
            foreach(string a in list_of_tutorials)
            {
                Label label = new Label();
                label.Text = a;
                label.AutoSize = false;
                label.ForeColor = Color.White;
                label.Height = 75;
                guide_flp.Controls.Add(label);
                label.Margin = new Padding(25, 15, 25, 0);
                label.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grouping_of_items grouping_Of_Items = new grouping_of_items(DateTime.Now, DateTime.Now, monitor_tb.Text, machine_tb.Text, location_tb.Text);
            grouping_Of_Items.TopLevel = false;
            flowLayoutPanel1.Controls.Add(grouping_Of_Items);
            grouping_Of_Items.Show();
        }

        private void add_with_presets_btn_Click(object sender, EventArgs e)
        {
            Select_An_Item_To_Add_Form select_An_Item_To_Add_Form = new Select_An_Item_To_Add_Form();
            select_An_Item_To_Add_Form.ShowDialog();
        }
    }
}

