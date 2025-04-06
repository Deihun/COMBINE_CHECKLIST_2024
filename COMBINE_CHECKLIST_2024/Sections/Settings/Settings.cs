using COMBINE_CHECKLIST_2024.Addons;
using COMBINE_CHECKLIST_2024.SQLFolder;
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

namespace COMBINE_CHECKLIST_2024.Sections.Settings
{
    public partial class Setting: Form
    {
        private SQL_Support sql;
        private savecacheHandler savecache = new savecacheHandler();
        public Setting(SQL_Support sql)
        {
            InitializeComponent();
            this.sql = sql;
        }

        private void resetConfirm_btn_Click()
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
            Warning_WithDelayConfirmation warning_WithDelayConfirmation = new Warning_WithDelayConfirmation("This action will result of data erasure and dataloss which cannot be undone. Are sure do you want to proceed?", "WARNING", resetConfirm_btn_Click);
            warning_WithDelayConfirmation.ShowDialog();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Warning_WithDelayConfirmation warning_WithDelayConfirmation = new Warning_WithDelayConfirmation("This action will result of data erasure and dataloss which cannot be undone. Are sure do you want to proceed?", "WARNING", historyresetconfirm_btn_Click);
            warning_WithDelayConfirmation.ShowDialog();
        }

        private void historyresetconfirm_btn_Click()
        {
            sql.ExecuteQuery("TRUNCATE TABLE HISTORY_;");
        }

        private void Setting_VisibleChanged(object sender, EventArgs e)
        {
            var theme = new theme_management();
            theme.SetGradientBackground(this);
            foreach (GroupBox groupbox in main_flp.Controls)
            {
                groupbox.ForeColor = theme.get_font_color2();
                foreach (Control control in groupbox.Controls) 
                {
                    if (control is GroupBox groupbox2)
                    {
                    groupbox2.ForeColor = theme.get_font_color2();
                    foreach (Control control2 in groupbox2.Controls) if (control2 is Label label) label.ForeColor = theme.get_font_color2();
                    }
                }
            }
            chosencolor_label.Text = savecache.Theme.ToUpper();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            sql.BackupDatabase();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Warning_WithDelayConfirmation warning_WithDelayConfirmation = new Warning_WithDelayConfirmation("This action will result of data erasure and dataloss which cannot be undone. Are sure do you want to proceed?", "WARNING", load_a_backup);
            warning_WithDelayConfirmation.ShowDialog();
        }

        private void load_a_backup()
        {
            sql.RestoreToExistingDatabase();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            savecache.EditConnection("none");
            Application.Restart();
        }

        private void standard_btn_Click(object sender, EventArgs e)
        {
            chosencolor_label.Text = "STANDARD";
        }

        private void lavender_btn_Click(object sender, EventArgs e)
        {
            chosencolor_label.Text = "LAVENDER";

        }

        private void sky_btn_Click(object sender, EventArgs e)
        {
            chosencolor_label.Text = "SKY";
        }

        private void warm_btn_Click(object sender, EventArgs e)
        {
            chosencolor_label.Text = "SPICY";
        }

        private void gray_btn_Click(object sender, EventArgs e)
        {
            chosencolor_label.Text = "GRAY";
        }

        private void darkmode_btn_Click(object sender, EventArgs e)
        {
            chosencolor_label.Text = "DARKMODE";
        }

        private void applychanges_btn_Click(object sender, EventArgs e)
        {
            savecache.EditCacheTheme(chosencolor_label.Text.ToLower()); 
            Application.Restart();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            savecache.EditUser("");
            savecache.EditPassword("");
            Application.Restart();
        }
    }
}
