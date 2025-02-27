using ClosedXML.Excel;
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
        private string filepath;
        public Create()
        {
            InitializeComponent();

        }

        private void additem_btn_Click(object sender, EventArgs e)
        {
            Add_Group_confirmation confirm = new Add_Group_confirmation(this.flowLayoutPanel1, this, monitor_tb.Text, machine_tb.Text, location_tb.Text);
            confirm.ShowDialog();
            //this.Controls.
            //Item_Record itemrecord = new Item_Record(flowLayoutPanel1);
            //itemrecord.TopLevel = false;
            //flowLayoutPanel1.Controls.Add(itemrecord);
            
            //itemrecord.Show();
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
         order_a_SelectAsync();
        }

        private void order_a_SelectAsync()
        {
            SQL_Support sql = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");
            Dictionary<string, object> history_log = new Dictionary<string, object> { { "date_commit", DateTime.Now } };

            string query_construct;
            int _last_identity;
            int _last_id_identity;
            sql._isDebugShow = true;

            _last_id_identity = sql.InsertDataAndGetId("EXECUTION_HISTORY", history_log);

            foreach (Form groups in groupOf_groupforms)
                {
                    if (groups is grouping_of_items groupForm) // Correct type
                    {
                    Dictionary<string, object> groupData = new Dictionary<string, object>
                            {
                                {"From_Date", groupForm._from_dt},
                                {"historylog_id", _last_id_identity },
                                {"To_Date", groupForm._to_dt},
                                { "Monitored_By", groupForm.getMonitor()},
                                { "Machine_Name", groupForm.getMachineName()},
                                { "Location", groupForm.getLocation()}
                            };
                    _last_identity = sql.InsertDataAndGetId("GROUP_TABLE", groupData);

                    //INCOMPLETE - NO MONITORED BY AND MACHINENAME YET
                    foreach (Form deepgroup in groupForm.group_of_logs)
                    {
                        Thread.Sleep(1);
                        if  (deepgroup is Item_Record logGroup)
                        {
                            Dictionary<string, object> logData = new Dictionary<string, object>
                            {
                                {"defect_part", logGroup.get_defectiveparts()},
                                {"defec_desc", logGroup.get_defectiveDescription()},
                                {"suggested_replacement_repair", logGroup.get_suggestion()},
                                {"remark_analysis", logGroup.get_remarks()},
                                {"overall_status", logGroup.get_overallAnalysis()},
                                {"checked_by", logGroup.get_checkby()},
                                {"groupID", _last_identity },
                                {"datemark", logGroup.getTargetDate() }
                            };

                            sql.InsertData("LOG_MACHINETABLE", logData);
                        }
                    }
                    }
            }
            HistoryExcelGeneration export = new HistoryExcelGeneration(filepath, open_cb.Checked, print_cb.Checked);
            export.generate_an_excel(_last_id_identity);
        }


        private void Create_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void changeFilePath_Click(object sender, EventArgs e)
        {
            FolderPathManagement select = new FolderPathManagement();
            filepath = select.ShowSaveFileDialog();
            changeFileView_tb.Text = filepath;
        }


    }
}

