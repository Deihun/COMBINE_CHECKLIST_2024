using SQL_Connection_support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMBINE_CHECKLIST_2024.Sections.MachineHistory
{
    public partial class Select_An_Item_To_Add_Form: Form
    {
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private SQL_Support sql = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");
        private int selected_id_for_preview = -1;
        public Select_An_Item_To_Add_Form()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 50; 
            timer.Tick += (sender, e) =>
            {
                timer.Stop();
                update_labels();
            };
            update_all_objects();
        }

        private void add_new_item_btn_Click(object sender, EventArgs e)
        {
            AddIndependent_Item_Form addIndependent_Item_Form = new AddIndependent_Item_Form();
            addIndependent_Item_Form.ShowDialog();
            update_all_objects();

        }
        private void update_all_objects()
        {
            foreach (Control control in data_flp.Controls) control.Dispose();
            data_flp.Controls.Clear();
            foreach (DataRow row in sql.ExecuteQuery("SELECT * FROM LOG_MACHINETABLE WHERE groupID IS NULL;").Rows)
            {
                CheckBox check = new CheckBox();
                check.Text = row["datemark"].ToString();
                data_flp.Controls.Add(check);
                check.Show();
                check.MouseEnter += (sender, e) => { start_updating(Convert.ToInt32(row["ID"])); };
                //check.Text = row[""]
            };
        }
        private void start_updating(int id)
        {
            selected_id_for_preview = id;
            timer.Stop();
            timer.Start();
        }
        private void update_labels()
        {
            try
            {
                DataRow row = sql.ExecuteQuery($"SELECT * FROM LOG_MACHINETABLE WHERE ID = {selected_id_for_preview}").Rows[0];
                content_label.Text = $"Defective Parts: {row["defect_part"]}";
            }
            catch (Exception e) { MessageBox.Show("catching " + e.Message); }
        }
    }
}
