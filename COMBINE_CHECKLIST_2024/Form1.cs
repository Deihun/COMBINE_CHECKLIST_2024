using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMBINE_CHECKLIST_2024.Addons;
using COMBINE_CHECKLIST_2024.InitialDiagnostics;
using COMBINE_CHECKLIST_2024.Sections.Currugator;
using COMBINE_CHECKLIST_2024.Sections.EditData;
using COMBINE_CHECKLIST_2024.Sections.HistoryLog;
using COMBINE_CHECKLIST_2024.Sections.MachineHistoryViewer;
using COMBINE_CHECKLIST_2024.Sections.Settings;
using SQL_Connection_support;


namespace COMBINE_CHECKLIST_2024
{
    public partial class Main_Dashboard: Form
    {
        private Dashboard dashboard;
        private Create checklist;
        private EditDataForm edit;
        private MachineViewer viewMachineHistory;
        private Setting settings;
        private History history;

        private float scaleX;
        private float scaleY;
        private float originalWidth = 1920f;
        private float originalHeight = 1080f;


        private static Panel viewer;
        SQL_Support sql;
        public Main_Dashboard()
        {
            InitializeComponent();
            InitialDiagnostic ini = new InitialDiagnostic();
            ini.ShowDialog();


            sql = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");
            Dictionary<string, object> logHistory = new Dictionary<string, object>
                    {
                        { "Context", $"System operation started" },
                        {"Date_Log", DateTime.Now }
                    };
            sql.InsertData("HISTORY_", logHistory);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            viewer = work_panel;


            dashboard = new Dashboard();
            checklist = new Create();
            edit = new EditDataForm(this.Width, this.Height);
            viewMachineHistory = new MachineViewer();
            settings = new Setting();
            history = new History();

            dashboard.all_dashboard_Panel = new Panel[] { currugator_expanded_panel, system_panel };
            dashboard.all_SectionTabs = new Form[] { checklist, viewMachineHistory, edit, settings, history };
        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_currugator_Click(object sender, EventArgs e)
        {
            dashboard.expand_currugator_panel(currugator_expanded_panel, 165, 50);
        }

        private void dashboard_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checklist_dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard.change_workpanelsection(checklist, viewer);
        }

        private void btn_currugator_machine_history_Click(object sender, EventArgs e)
        {
            dashboard.change_workpanelsection(viewMachineHistory, viewer);
            Console.WriteLine("MACHINE HISTORY");
        }

        private void edititem_currugator_btn_Click(object sender, EventArgs e)
        {
            dashboard.change_workpanelsection(edit, viewer);
        }

        private void System_btn_Click(object sender, EventArgs e)
        {
            dashboard.expand_currugator_panel(system_panel);
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            dashboard.change_workpanelsection(settings, viewer);
        }

        private void history_btn_Click(object sender, EventArgs e)
        {
            dashboard.change_workpanelsection(history, viewer);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void workpanel_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dictionary<string, object> logHistory = new Dictionary<string, object>
                    {
                        { "Context", $"System operation ended" },
                        {"Date_Log", DateTime.Now }
                    };
            sql.InsertData("HISTORY_", logHistory);
        }
    }


    public class Dashboard 
    {
        public Panel[] all_dashboard_Panel;
        public Form[] all_SectionTabs;
        public void expand_currugator_panel(Panel selected_panel, int max_Height = 200, int min_Height = 50)
        {
            Panel _selected_panel = selected_panel;
            _selected_panel.Height = _selected_panel.Height == max_Height ? min_Height : max_Height;
        }

        public void change_workpanelsection(Form Form_To_Set, Panel viewer)
        {
            _hide_forms_in_workpanelsection();
            Form_To_Set.TopLevel = false;
            //Form_To_Set.Dock = DockStyle.Right;
            viewer.Controls.Clear();
            viewer.Controls.Add(Form_To_Set);
            Form_To_Set.Show();
        }

        public void _hide_forms_in_workpanelsection()
        {
            foreach (Form form in all_SectionTabs)
            {
                form.Hide();
            }
        }
    }
}
