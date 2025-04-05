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
        private SQL_Support sql = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");
        public Setting()
        {
            InitializeComponent();
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
            var savecache = new savecacheHandler();
            savecache.EditConnection("none");
            Application.Restart();
        }

        private void standard_btn_Click(object sender, EventArgs e)
        {
            var savecache = new savecacheHandler();
            savecache.EditCacheTheme("standard");
        }

        private void lavender_btn_Click(object sender, EventArgs e)
        {
            var savecache = new savecacheHandler();
            savecache.EditCacheTheme("lavender");
        }

        private void sky_btn_Click(object sender, EventArgs e)
        {
            var savecache = new savecacheHandler();
            savecache.EditCacheTheme("sky");
        }

        private void warm_btn_Click(object sender, EventArgs e)
        {
            var savecache = new savecacheHandler();
            savecache.EditCacheTheme("warm");
        }

        private void gray_btn_Click(object sender, EventArgs e)
        {
            var savecache = new savecacheHandler();
            savecache.EditCacheTheme("gray");
        }

        private void darkmode_btn_Click(object sender, EventArgs e)
        {
            var savecache = new savecacheHandler();
            savecache.EditCacheTheme("darkmode");
        }
    }
}
