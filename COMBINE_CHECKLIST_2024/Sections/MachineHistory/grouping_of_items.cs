using COMBINE_CHECKLIST_2024.DateToText;
using COMBINE_CHECKLIST_2024.Sections.Currugator;
using Microsoft.SqlServer.Management.Smo;
using SQL_Connection_support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMBINE_CHECKLIST_2024.Sections.MachineHistory
{
    public partial class grouping_of_items: Form
    {
        private Datetotext date = new Datetotext();
        public DateTime _from_dt { get; set; }
        public DateTime _to_dt { get; set; }
        public Create main_parentcreate;

        public TextBox _location_textbox;
        public TextBox _monitoredby_textbox;
        public TextBox _machinename_textbox;

        public int ID_Edit;



        public Create parent;
        public string monitor;
        public string machine;
        public string location;
        private const int min_expand_state = 65;
        private int max_expand_state = 0;
        private bool is_expanded = true;

        public List <Form> group_of_logs = new List<Form>();
        public FlowLayoutPanel items_in_flp;
        private SQL_Support sql = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");
        public grouping_of_items(DateTime from_dt, DateTime to_dt, string monitor, string machine, string location)
        {
            InitializeComponent();
            _from_dt = from_dt;
            _to_dt = to_dt;
            changeable_date.Text = date.getMonthAsShortText(from_dt) + " " + from_dt.Day + " - " + date.getMonthAsShortText(to_dt) + " " + to_dt.Day;
            this.monitor = monitor;
            this.machine = machine;
            this.location = location;
            this.items_in_flp = flowlayoutpanel;

            
            monitored_tb.Text = monitor;
            machinename_tb.Text = machine;
            location_tb.Text = location;
            DataTable group_table = sql.ExecuteQuery("SELECT * FROM GROUP_TABLE;");
            AutoCompleteStringCollection _location = new AutoCompleteStringCollection();
            AutoCompleteStringCollection _monitoredBy = new AutoCompleteStringCollection();
            AutoCompleteStringCollection _machinename = new AutoCompleteStringCollection();
            foreach (DataRow row in group_table.Rows)
            {
                _location.Add(row["Location"].ToString());
                _monitoredBy.Add(row["Monitored_By"].ToString());
                _machinename.Add(row["Machine_Name"].ToString());
            }
            setAutoComplete(location_tb, _location);
            setAutoComplete(monitored_tb, _monitoredBy);
            setAutoComplete(machinename_tb, _machinename);
            _location_textbox = this.location_tb;
            _monitoredby_textbox = this.monitored_tb;
            _machinename_textbox = this.machinename_tb;
        }

        private void setAutoComplete(TextBox textbox, AutoCompleteStringCollection acsc)
        {
            textbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textbox.AutoCompleteCustomSource = acsc;
        }

        public string getMonitor()
        {
            return sql.FilterQuery(monitored_tb.Text);
        }
        public string getMachineName()
        {
            return sql.FilterQuery(machinename_tb.Text);
        }
        public string getLocation()
        {
            return sql.FilterQuery(location_tb.Text);
        }

        public void hideDelete()
        {
            deletegroup_btn.Hide();
        }

        public void add_item(Form item)
        {

            // this.Size
            item.Padding = new Padding(0);
            group_of_logs.Add(item);
            max_expand_state = ((group_of_logs.Count - 1) * 176) + 240;
            change_expand_state();
            item.TopLevel = false;
            flowlayoutpanel.Controls.Add(item);
            item.Show();
            compare_dates();
        }

        public void compare_dates()
        {
            List<DateTime> ranges = new List< DateTime>();
            foreach (Item_Record item in items_in_flp.Controls)
            {
                ranges.Add(item.my_targeted_date);
            }
            _from_dt = ranges.Min();
            _to_dt = ranges.Max();
            changeable_date.Text = date.getMonthAsShortText(_from_dt) + " " + _from_dt.Day + " - " + date.getMonthAsShortText(_to_dt) + " " + _to_dt.Day;
        }

        private void change_expand_state()
        {
            if (is_expanded)
            {
                this.Size = new Size(1070, max_expand_state);
                this.collapse_btn.Text = "COLLAPSE";
            }
            else
            {
                this.Size = new Size(1070, min_expand_state);
                this.collapse_btn.Text = "EXPAND";
            }
        }

        

        private void deletegroup_btn_Click(object sender, EventArgs e)
        {
            this.group_of_logs.Clear();
            this.parent.deleteGroup(this);
            this.Dispose();
        }

        private void collapse_btn_Click(object sender, EventArgs e)
        {
            is_expanded = !is_expanded;
            change_expand_state();
        }

        private void deletegroup_btn_MouseEnter(object sender, EventArgs e)
        {
            List<string> guide = new List<string>()
            {
                "- Delete this targeted Group"
            };

            if (main_parentcreate is null) return;
            main_parentcreate.set_guide(guide);
        }

        private void collapse_btn_MouseEnter(object sender, EventArgs e)
        {
            List<string> guide = new List<string>()
            {
                "- Expand or Collapse all Items within this Group"
            };

            if (main_parentcreate is null) return;
            main_parentcreate.set_guide(guide);
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            List<string> guide = new List<string>()
            {
                "- It is where the Machine Located at. ex. PLANT 1", "CTR+Q\nApply the 'Location' changes to all Groups"
            };

            if (main_parentcreate is null) return;
            main_parentcreate.set_guide(guide);
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            List<string> guide = new List<string>()
            {
                "- It is the name of targeted Machine that is being under maintenance", "CTR+Q\nApply the 'Machine Name' changes to all Groups"
            };
            if (main_parentcreate is null) return;
            main_parentcreate.set_guide(guide);
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            List<string> guide = new List<string>()
            {
                "- It is you"
            };
            if (main_parentcreate is null) return;
            main_parentcreate.set_guide(guide);
        }

        private void machinename_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Q)
            {
                FlowLayoutPanel parent = this.Parent as FlowLayoutPanel;
                foreach (Control control in parent.Controls)
                {
                    if (control is grouping_of_items group)
                    {
                        group._machinename_textbox.Text = machinename_tb.Text;
                    }
                }
            }
        }

        private void location_tb_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.Q)
            {
                FlowLayoutPanel parent = this.Parent as FlowLayoutPanel;
                foreach (Control control in parent.Controls)
                {
                    if (control is grouping_of_items group)
                    {
                        group._location_textbox.Text = _location_textbox.Text;
                    }
                }
            }
        }

        private void monitored_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Q)
            {
                FlowLayoutPanel parent = this.Parent as FlowLayoutPanel;
                foreach (Control control in parent.Controls)
                {
                    if (control is grouping_of_items group)
                    {
                        group._monitoredby_textbox.Text = _monitoredby_textbox.Text;
                    }
                }
            }
        }
    }
}
