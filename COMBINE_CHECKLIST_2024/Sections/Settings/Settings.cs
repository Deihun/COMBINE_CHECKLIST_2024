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

namespace COMBINE_CHECKLIST_2024.Sections.Settings
{
    public partial class Setting: Form
    {
        private SQL_Support sql = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");
        public Setting()
        {
            InitializeComponent();
        }

        private void resetConfirm_btn_Click(object sender, EventArgs e)
        {
            sql.ExecuteQuery("TRUNCATE TABLE EXECUTION_HISTORY; " +
                "TRUNCATE TABLE GROUP_TABLE; " +
                "TRUNCATE TABLE LOG_MACHINETABLE;");

            Dictionary<string, object> logHistory = new Dictionary<string, object>
                    {
                        { "Context", $"All Data from MachineHistory data has been deleted" },
                        {"Date_Log", DateTime.Now }
                    };
            sql.InsertData("HISTORY_", logHistory);
        }

        private void resetDatabase_Click(object sender, EventArgs e)
        {
            
            resetConfirm_btn.Enabled = true;
            timerResetDatabase.Start();
        }

        private void timerResetDatabase_Tick(object sender, EventArgs e)
        {
            resetConfirm_btn.Enabled = false;
        }

        private void resetHistorytimer_Tick(object sender, EventArgs e)
        {
            historyresetconfirm_btn.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            historyresetconfirm_btn.Enabled = true;
            resetHistorytimer.Start();
        }

        private void historyresetconfirm_btn_Click(object sender, EventArgs e)
        {
            sql.ExecuteQuery("TRUNCATE TABLE HISTORY_;");
        }
    }
}
