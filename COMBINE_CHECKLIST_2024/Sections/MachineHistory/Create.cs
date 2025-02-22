using COMBINE_CHECKLIST_2024.Sections.MachineHistory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_support;

namespace COMBINE_CHECKLIST_2024.Sections.Currugator
{
    public partial class Create: Form
    {
        public List <Form> groupOf_groupforms = new List<Form>();
        public Create()
        {
            InitializeComponent();
        }

        private void additem_btn_Click(object sender, EventArgs e)
        {
            Add_Group_confirmation confirm = new Add_Group_confirmation(this.flowLayoutPanel1, this);
            confirm.ShowDialog();
            //this.Controls.
            //Item_Record itemrecord = new Item_Record(flowLayoutPanel1);
            //itemrecord.TopLevel = false;
            //flowLayoutPanel1.Controls.Add(itemrecord);
            
            //itemrecord.Show();
        }

        public void addNewGroups(Form groups)
        {
            groupOf_groupforms.Add(groups);
        }

        private void create_new_history_btn_Click(object sender, EventArgs e)
        {
            //CREATION OF DATAs
            SQL_Manager server = new SQL_Manager("DESKTOP-HBKPAB1\\SQLEXPRESS","Microsoft SQL Server (SqlClient)","","");
            
        }
    }
}
