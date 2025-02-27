using COMBINE_CHECKLIST_2024.DateToText;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMBINE_CHECKLIST_2024.Sections.MachineHistoryViewer
{
    public partial class SelectionItem: Form
    {
        public int storedID;
        public DateTime target_date;
        public string machinename;
        private BulkPrintSelection parent;
        private Datetotext date = new Datetotext();
        public SelectionItem(int storedID, DateTime target_date, BulkPrintSelection parent)
        {
            InitializeComponent();
            this.storedID = storedID;
            this.target_date = target_date;
            this.parent = parent;
            this.checkBox1.Text = date.getMonthAsShortText(target_date) + " " + target_date.Day + ", " + target_date.Year + $" ({storedID})";
        }

        public void hitCheckbox()
        {
            parent.checkTrigger();
            checkBox1.Checked = !checkBox1.Checked;
        }

        public void hitCheckbox(bool set_checkbox)
        {
            parent.checkTrigger();
            checkBox1.Checked = set_checkbox;
        }

        public bool getStoredBool()
        {
            return checkBox1.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            parent.checkTrigger();
        }
    }
}
