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
using COMBINE_CHECKLIST_2024.InitialDiagnostic_Folder;
using COMBINE_CHECKLIST_2024.InitialDiagnostics;
using COMBINE_CHECKLIST_2024.Sections.Currugator;
using COMBINE_CHECKLIST_2024.Sections.EditData;
using COMBINE_CHECKLIST_2024.Sections.HistoryLog;
using COMBINE_CHECKLIST_2024.Sections.MachineHistoryViewer;
using COMBINE_CHECKLIST_2024.Sections.Settings;
using COMBINE_CHECKLIST_2024.SQLFolder;
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
        private savecacheHandler savecache = new savecacheHandler();

        private static Panel viewer;
        SQL_Support sql;
        public Main_Dashboard()
        {
            InitializeComponent();
            initialDiagnostic ini = new initialDiagnostic();
            ini.ShowDialog();
            sql = new SQL_Support(savecache.ConnectionString, "GOODYEAR_MACHINE_HISTORY", savecache.User, savecache.Password);
            if (!sql.CanAccessSql())
            {
                UserLogin_Form userLogin_Form = new UserLogin_Form();
                userLogin_Form.Disposed += (sender, e) => { Application.Exit(); };
                userLogin_Form.ShowDialog();
                sql = new SQL_Support(savecache.ConnectionString, "GOODYEAR_MACHINE_HISTORY", savecache.User, savecache.Password);
            }




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
            checklist = new Create(sql);
            edit = new EditDataForm(sql);
            viewMachineHistory = new MachineViewer(sql);
            settings = new Setting(sql);
            history = new History(sql);

            dashboard.all_dashboard_Panel = new Panel[] { currugator_expanded_panel, system_panel };
            dashboard.all_SectionTabs = new Form[] { checklist, viewMachineHistory, edit, settings, history };

            dashboard.change_workpanelsection(edit, viewer);
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

        private void Main_Dashboard_VisibleChanged(object sender, EventArgs e)
        {
            var theme = new theme_management();
            dashboard_flowlayout.BackColor = theme.get_color_from_theme_dashboard();
            btn_currugator.ForeColor = theme.get_font_color();
            btn_currugator_machine_history.ForeColor = theme.get_font_color();
            checklist_dashboard_btn.ForeColor = theme.get_font_color();
            edititem_currugator_btn.ForeColor = theme.get_font_color();
            exit_btn.ForeColor = theme.get_font_color();
            history_btn.ForeColor = theme.get_font_color();
            settings_btn.ForeColor = theme.get_font_color();
            System_btn.ForeColor = theme.get_font_color();
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
