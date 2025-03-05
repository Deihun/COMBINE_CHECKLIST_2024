using COMBINE_CHECKLIST_2024.DateToText;
using SQL_Connection_support;
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
    public partial class ButtonItem: Form
    {
        public MachineViewer parent;
        public DataTable ButtonData;
        public int groupID;

        private Datetotext converttoText = new Datetotext();

        public ButtonItem(int groupid, MachineViewer parent)
        {
            InitializeComponent();
            this.groupID = groupid;
            this.parent = parent;
        }
        public void RenameBtn(string rename)
        {
            button1.Text = rename;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.SetDataGridView(groupID);
        }
    }
}
