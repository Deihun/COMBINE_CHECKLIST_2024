using COMBINE_CHECKLIST_2024.Sections.MachineHistory;
using COMBINE_CHECKLIST_2024;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_Connection_support;
using System.Data.SqlClient;


namespace COMBINE_CHECKLIST_2024.Sections.Currugator
{
    public partial class Create: Form
    {
        public List <Form> groupOf_groupforms = new List<Form>();
        public Create()
        {
            InitializeComponent();
        }

        private void additem_btn_Click(object sender, EventArgs e)
        {
            Add_Group_confirmation confirm = new Add_Group_confirmation(this.flowLayoutPanel1, this);
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
        }

        private void create_new_history_btn_Click(object sender, EventArgs e)
        {
         order_a_SelectAsync();

            

        }

        private async Task order_a_SelectAsync()
        {
            SQL_Support sql = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");
            Dictionary<string, object> history_log = new Dictionary<string, object> { { "date_commit", DateTime.Now } };

            string query_construct;
            int _last_identity;
            sql._isDebugShow = true;

            _last_identity = sql.InsertDataAndGetId("EXECUTION_HISTORY", history_log);

            foreach (Form groups in groupOf_groupforms)
                {
                    if (groups is grouping_of_items groupForm) // Correct type
                    {
                        Dictionary<string, object> groupData = new Dictionary<string, object>
                            {
                                {"From_Date", groupForm._from_dt},
                                {"historylog_id", _last_identity },
                                {"To_Date", groupForm._to_dt}
                            };
                    _last_identity = sql.InsertDataAndGetId("GROUP_TABLE", groupData);

                    //INCOMPLETE - NO MONITORED BY AND MACHINENAME YET
                    foreach (Form deepgroup in groupForm.group_of_logs)
                    {
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
                                {"datemark", logGroup.my_targeted_date }
                            };
                            sql.InsertDataAsync("LOG_MACHINETABLE", logData);
                        }
                    }
                    }
                    

                    

                }
        }


        private void Create_Load(object sender, EventArgs e)
        {

        }
    }
}
