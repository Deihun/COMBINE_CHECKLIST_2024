using COMBINE_CHECKLIST_2024.DateToText;
using COMBINE_CHECKLIST_2024.Sections.Currugator;
using COMBINE_CHECKLIST_2024.Sections.MachineHistory;
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
using static System.Net.WebRequestMethods;

namespace COMBINE_CHECKLIST_2024.Sections.EditData
{
    public partial class EditDataForm: Form
    {
        private SQL_Support sql = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");
        private List<grouping_of_items> groupList = new List<grouping_of_items>();
        private List<Button> buttonList = new List<Button>();
        private int intData = 1;

        private int originalFormWidth;
        private int originalFormHeight;

        Datetotext _Convert = new Datetotext();
        public EditDataForm(int originalFormWidth, int originalFormHeight)
        {
            InitializeComponent();

            this.AutoScaleMode = AutoScaleMode.Dpi;  // Scale based on screen DPI
            this.AutoScaleDimensions = new SizeF(96F, 96F);  // 96 DPI is default
            //AdjustPanels();
            
            this.originalFormWidth = originalFormWidth;
            this.originalFormHeight = originalFormHeight;
        }
        private void AdjustPanels()
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // Scale based on a 1920x1080 reference resolution
            float scaleX = screenWidth / 1920f;
            float scaleY = screenHeight / 1080f;

            // Adjust Dashboard FlowLayoutPanel
            selectioncontainer_panel.Width = (int)(260 * scaleX);  // Example: Scale width dynamically
            selectioncontainer_panel.Height = this.ClientSize.Height; // Make it full height of form

            // Adjust Work Panel
            flowLayoutPanel1.Width = (this.ClientSize.Width - 10) - selectioncontainer_panel.Width;
            flowLayoutPanel1.Location = new Point(selectioncontainer_panel.Width, 30);
        }

        //adjust sizes
        private Dictionary<Control, Rectangle> originalSizes = new Dictionary<Control, Rectangle>();

        private void StoreOriginalSizes()
        {
            originalFormWidth = this.Width;
            originalFormHeight = this.Height;

            foreach (Control control in this.Controls)
            {
                originalSizes[control] = new Rectangle(control.Location, control.Size);
            }
        }

        private void ScaleControls()
        {
            float scaleX = this.Width / originalFormWidth;
            float scaleY = this.Height / originalFormHeight;

            foreach (var kvp in originalSizes)
            {
                Control control = kvp.Key;
                Rectangle original = kvp.Value;

                if (control.Parent is FlowLayoutPanel)
                {
                    // Keep FlowLayoutPanel's automatic positioning
                    control.Width = (int)(original.Width * scaleX);
                    control.Height = (int)(original.Height * scaleY);
                }
                else
                {
                    // Scale both size & position for standalone elements
                    int newX = (int)(original.X * scaleX);
                    int newY = (int)(original.Y * scaleY);
                    int newWidth = (int)(original.Width * scaleX);
                    int newHeight = (int)(original.Height * scaleY);

                    control.SetBounds(newX, newY, newWidth, newHeight);
                }
            }
        }


        private void setData(int id)
        {
            //INCOMPLETE - LIMIT DATA THROUGH SQL GETTING ALL HISTORY COUNT 
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
            intData++;
            setData(intData);
        }

        private void previous_btn_Click(object sender, EventArgs e)
        {
            intData--;
            setData(intData);
        }
        
        private void reupdateEditArea(int id/* MainID*/)
        {
            removeAllGroups();
            DataTable listOfGroups = sql.ExecuteQuery($"SELECT * FROM GROUP_TABLE WHERE historylog_id = {id};");
            foreach (DataRow row in listOfGroups.Rows)
            { //Generate Group Forms
                int groupID = Convert.ToInt32(row["GroupID"]);
                string monitor = row["Monitored_By"].ToString();
                string machine = row["Machine_Name"].ToString();
                string location = row["Location"].ToString();
                DateTime From = (DateTime)row["From_Date"];
                DateTime To = (DateTime)row["To_Date"];
                grouping_of_items groups = new grouping_of_items(From, To, monitor,machine,location);
                groups.ID_Edit = groupID;
                groups.TopLevel = false;
                groups.Width = flowLayoutPanel1.ClientSize.Width / 2; // Example: half of the panel width
                groups.Height = flowLayoutPanel1.ClientSize.Height / 2; // Example: half of the panel height

                flowLayoutPanel1.Controls.Add(groups);
                groups.hideDelete();
                groups.Show();
                groupList.Add(groups);

                DataTable itemDataTable = sql.ExecuteQuery($"SELECT * FROM LOG_MACHINETABLE WHERE groupID = {groupID};");
                foreach (DataRow _row in itemDataTable.Rows)
                {
                    Item_Record item = new Item_Record();
                    DateTime datemark = (DateTime)_row["datemark"];
                    int _item_id = Convert.ToInt32(_row["ID"]);
                    string defectPart = _row["defect_part"].ToString();
                    string defectDesc = _row["defec_desc"].ToString();
                    string srr = _row["suggested_replacement_repair"].ToString();
                    string ra = _row["remark_analysis"].ToString();
                    bool OS = (bool)_row["overall_status"];
                    string cheBy = _row["checked_by"].ToString();
                    item.ID_Edit = _item_id;
                    item.setDate(datemark);
                    item.setVarCharData(defectPart,defectDesc,srr,ra,cheBy);
                    item.setIsDefect(OS);
                    groups.add_item(item);
                }
            }
            // RENDER WORKBENCH 
        }

        private void removeAllGroups()
        {
            for (int i = groupList.Count - 1; i >= 0; i--) 
            {
                groupList[i].Dispose();
                groupList.RemoveAt(i);
            }
        }

        private void removeAllButtons()
        {
            for (int i = buttonList.Count - 1; i >= 0; i--)
            {
                buttonList[i].Dispose();
                buttonList.RemoveAt(i);
            }
        }

        private void applychange_btn_Click(object sender, EventArgs e)
        {
            string query = "";
            foreach (grouping_of_items groups in groupList)
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
            showButtonSelection();
        }

        private void showButtonSelection()
        {
            DataTable buttonDatas = sql.ExecuteQuery("SELECT * FROM EXECUTION_HISTORY;");
            removeAllButtons();
            foreach (DataRow rows in buttonDatas.Rows)
            {
                Button button = new Button();
                DateTime selectedDate = (DateTime)rows["date_commit"];

                button.Text = _Convert.getMonthAsText(selectedDate) + selectedDate.Day + $", {selectedDate.Year} ({rows["id"]})";
                button.Width = flowLayoutPanel2.Width - 5;
                button.BackColor = Color.White;
                int buttonId = Convert.ToInt32(rows["id"]); // Store ID in a local variable
                buttonList.Add(button);
                button.Click += (s, ev) => ButtonClicked(s, buttonId); // Use local variable

                flowLayoutPanel2.Controls.Add(button); // Add button to the form
            }
        }
        private void showButtonSelection(string Filter, DateTimePicker dtp)
        {
            string query = "SELECT DISTINCT " +
               "eh.id, " +
               "eh.date_commit " +
               "FROM EXECUTION_HISTORY eh " +
               "JOIN GROUP_TABLE gt ON eh.id = gt.historylog_id " +
               "JOIN LOG_MACHINETABLE lm ON gt.GroupID = lm.groupID " +
               "WHERE (gt.Monitored_By LIKE '%" + Filter + "%' " +
               "OR gt.Machine_Name LIKE '%" + Filter + "%' " +
               "OR lm.defect_part LIKE '%" + Filter + "%' " +
               "OR lm.defec_desc LIKE '%" + Filter + "%' " +
               "OR lm.suggested_replacement_repair LIKE '%" + Filter + "%' " +
               "OR lm.checked_by LIKE '%" + Filter + "%')";

            if (dtp.Enabled)
            {
                DateTime selectedDate = dtp.Value;
                query += " AND eh.date_commit >= '" + selectedDate.ToString("yyyy-MM-dd 00:00:00") + "' " +
                         "AND eh.date_commit <= '" + selectedDate.ToString("yyyy-MM-dd 23:59:59") + "'";
            }

            // Execute query
            DataTable buttonDatas = sql.ExecuteQuery(query);



            removeAllButtons();

            foreach (DataRow row in buttonDatas.Rows)
            {
                Button button = new Button
                {
                    Width = flowLayoutPanel2.Width - 5,
                    BackColor = Color.White
                };

                DateTime selectedDate = (DateTime)row["date_commit"];
                int buttonId = Convert.ToInt32(row["ID"]); // Correctly referencing LOG_MACHINETABLE ID

                button.Text = $"{_Convert.getMonthAsText(selectedDate)} {selectedDate.Day}, {selectedDate.Year} ({buttonId})";

                button.Click += (s, ev) => ButtonClicked(s, buttonId); // Ensure correct ID is used

                buttonList.Add(button);
                flowLayoutPanel2.Controls.Add(button);
            }
        }




        private void ButtonClicked(object sender, int e)
        {
            this.intData = e;
            setData(intData);
        }

        private void EditDataForm_Load(object sender, EventArgs e)
        {

        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            showButtonSelection(search_tb.Text, dateTimePicker1);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            showButtonSelection(search_tb.Text, dateTimePicker1);
        }

        private void enableDateTime_cb_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = enableDateTime_cb.Checked;
        }

        private void EditDataForm_Resize(object sender, EventArgs e)
        {
            StoreOriginalSizes();
            ScaleControls();
        }
    }
}
