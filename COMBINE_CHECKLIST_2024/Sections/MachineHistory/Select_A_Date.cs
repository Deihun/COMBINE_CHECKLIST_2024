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
    public partial class Select_A_Date: Form
    {
        private Action<DateTime> method;
        public Select_A_Date(Action<DateTime> e)
        {
            InitializeComponent();
            this.method = e;
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            method.Invoke(dateTimePicker1.Value);
            this.Dispose();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
