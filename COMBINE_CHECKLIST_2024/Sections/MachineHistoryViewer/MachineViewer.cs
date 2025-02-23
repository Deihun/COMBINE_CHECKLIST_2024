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
    public partial class MachineViewer: Form
    {
        List<Form> ViewList = new List<Form>();
        public MachineViewer()
        {
            InitializeComponent();
            InitializedButtonAsync();
            //call buttons
   


        }
        public async Task InitializedButtonAsync()
        {
          SQL_Support MachineView = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");
            DataTable initializedtable = await MachineView.ExecuteQueryAsync("SELECT * FROM EXECUTION_HISTORY;");
       
            foreach (DataRow row in initializedtable.Rows)
            {
                // Extract GroupID safely as an integer
                int groupId = row["GroupID"] != DBNull.Value ? Convert.ToInt32(row["GroupID"]) : 0;

                // Execute the query using the extracted groupId
                DataTable groupTable = await MachineView.ExecuteQueryAsync($"SELECT * FROM GROUP_TABLE WHERE GroupID = {groupId};");

                // Call the addButton function
                addButton(groupId);
            }
        }

        public void addButton(int groupID)
        {
            ButtonItem buttonItem = new ButtonItem(groupID,this);
        }
        public void delButton(Form delbtn)
        {
            ViewList.Remove(delbtn);
            delbtn.Dispose();
        }
        public void resetButton()
        {
            foreach(Form reset in ViewList)
            {
                reset.Dispose();
            }
        }
        public void SetDataGridView(int id)
        {
            SQL_Support MachineView = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");
            string query = $"SELECT * FROM LOG_MACHINETABLE WHERE groupID = {id}; ";
            dataGridView1.DataSource = MachineView.ExecuteQueryAsync(query);
        }
    }
}
