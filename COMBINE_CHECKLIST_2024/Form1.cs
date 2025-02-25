using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using COMBINE_CHECKLIST_2024.Sections.Currugator;
using COMBINE_CHECKLIST_2024.Sections.MachineHistoryViewer;

namespace COMBINE_CHECKLIST_2024
{
    public partial class Main_Dashboard: Form
    {
        private Dashboard dashboard = new Dashboard();
        private Create checklist = new Create();
        private MachineViewer viewMachineHistory = new MachineViewer();

        private static Panel viewer;

        public Main_Dashboard()
        {
            InitializeComponent();
            dashboard.all_dashboard_Panel = new Panel[] {currugator_expanded_panel};
            dashboard.all_SectionTabs = new Form[] { checklist, viewMachineHistory};
            viewer = workpanel_panel;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;  // Remove title bar and borders
            this.WindowState = FormWindowState.Maximized; // Maximize to full screen
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_currugator_Click(object sender, EventArgs e)
        {
            dashboard.expand_currugator_panel(currugator_expanded_panel);
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
            Form_To_Set.Dock = DockStyle.Fill;
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
