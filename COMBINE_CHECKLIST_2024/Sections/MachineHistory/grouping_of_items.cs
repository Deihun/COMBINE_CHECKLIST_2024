using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMBINE_CHECKLIST_2024.Sections.MachineHistory
{
    public partial class grouping_of_items: Form
    {
        List <Form> group_of_logs = new List<Form>();
        public grouping_of_items()
        {
            InitializeComponent();
        }

        public void add_item(Form item)
        {

            // this.Size
            group_of_logs.Add(item);
            this.Size = new Size(1519,(group_of_logs.Count*166)+75);
            flowlayoutpanel.Size = new Size(1519, ((group_of_logs.Count + 1)* 166));
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
