using COMBINE_CHECKLIST_2024.DateToText;
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

        public string monitor;
        public string machine;
        public string location;

        public List <Form> group_of_logs = new List<Form>();
        public grouping_of_items(DateTime from_dt, DateTime to_dt, string monitor, string machine, string location)
        {
            InitializeComponent();
            _from_dt = from_dt;
            _to_dt = to_dt;
            changeable_date.Text = date.getMonthAsShortText(from_dt) + " " + from_dt.Day + " - " + date.getMonthAsShortText(to_dt) + " " + to_dt.Day;
            this.monitor = monitor;
            this.machine = machine;
            this.location = location;

            
            monitored_tb.Text = monitor;
            machinename_tb.Text = machine;
            location_tb.Text = location;
        }

        public void add_item(Form item)
        {

            // this.Size
            group_of_logs.Add(item);
            this.Size = new Size(1375,(group_of_logs.Count*200)+75);
            //flowlayoutpanel.Size = new Size(1519, ((group_of_logs.Count + 1)* 166));
            Console.WriteLine(group_of_logs);
            item.TopLevel = false;
            flowlayoutpanel.Controls.Add(item);
            item.Show();
            
        }

        

        private void deletegroup_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
