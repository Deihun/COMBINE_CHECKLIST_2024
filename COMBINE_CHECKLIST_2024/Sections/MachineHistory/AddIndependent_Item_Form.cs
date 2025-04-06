using COMBINE_CHECKLIST_2024.Sections.Currugator;
using Microsoft.SqlServer.Management.Smo;
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

namespace COMBINE_CHECKLIST_2024.Sections.MachineHistory
{
    public partial class AddIndependent_Item_Form: Form
    {
        private SQL_Support sql;
        Item_Record item_record;
        public AddIndependent_Item_Form(SQL_Support sql)
        {
            InitializeComponent();
            this.sql = sql;
            instantiate_item();
        }

        private void instantiate_item()
        {
            item_record = new Item_Record(sql);
            item_record.TopLevel = false;
            panel1.Controls.Add(item_record);
            item_record.Show();
        }

        private void add_on_queue_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO LOG_MACHINETABLE (defect_part, defec_desc, suggested_replacement_repair, " +
                " remark_analysis, overall_status, checked_by, datemark, target_time) " +
                $" VALUES ('{item_record._defectivepart_textbox.Text}'," +
                $" '{item_record._defectivedescription_richtextbox.Text}', " +
                $" '{item_record._suggested_replacement_repair_richtextbox.Text}', " +
                $" '{item_record._remarks_or_analysis_richtextbox.Text}', " +
                $" {item_record.get_overallAnalysis()}, " +
                $" '{item_record._checkby_textbox.Text}', " +
                $" '{dateTimePicker1.Value}', " +
                $" '{item_record.my_target_time}' " +
                $");";
            sql.ExecuteQuery(query);
            this.Dispose();
        }
    }
}
