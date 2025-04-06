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
        private SQL_Support sql;
        private int selected_id_for_preview = -1;
        private Action<List<int>> method;
        private List<int> already_taken_id;
        public Select_An_Item_To_Add_Form(Action<List<int>> method, List<int> already_taken_id, SQL_Support sql)
        {
            InitializeComponent();
            this.sql = sql;
            this.method = method;
            this.already_taken_id = already_taken_id;
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
            AddIndependent_Item_Form addIndependent_Item_Form = new AddIndependent_Item_Form(sql);
            addIndependent_Item_Form.ShowDialog();
            update_all_objects();

        }
        private void update_all_objects()
        {
            foreach (Control control in data_flp.Controls) control.Dispose();
            data_flp.Controls.Clear();
            foreach (DataRow row in sql.ExecuteQuery("SELECT * FROM LOG_MACHINETABLE WHERE groupID IS NULL;").Rows)
            {
                if (already_taken_id.Contains(Convert.ToInt32(row["ID"]))) continue;
                CheckBox check = new CheckBox();
                check.Text = row["datemark"].ToString();
                check.Tag = Convert.ToInt32(row["ID"]);
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
                foreach (Control control in contex_flp.Controls) control.Dispose();
                contex_flp.Controls.Clear();
                DataRow row = sql.ExecuteQuery($"SELECT * FROM LOG_MACHINETABLE WHERE ID = {selected_id_for_preview}").Rows[0];
                string status = Convert.ToBoolean(row["overall_status"]) ? "OK" : "DEFECTIVE";
                create_description($"DATE: {Convert.ToDateTime(row["datemark"]):dd/MM/yyyy}");
                create_description($"Time: {row["target_time"]}");
                create_description($"DEFECTIVE PARTS: {row["defect_part"]}");
                create_description($"DEFECTIVE DESCRIPTION: {row["defec_desc"]}");
                create_description($"SUGGEST/REPLACEMENT/REPAIR: {row["suggested_replacement_repair"]}");
                create_description($"REMARKS/ANALYSIS: {row["remark_analysis"]}");
                //content_label.Text =    $"DATE: {row["datemark"]}\n" +
                //                        $"Defective Parts: {row["defect_part"]}\n" +
                //                        $"Defective Description: {row["defec_desc"]}\n" +
                //                        $"Overall Status: {()}";
            }
            catch (Exception e) { MessageBox.Show("catching " + e.Message); }
        }
        private Label create_description(string text)
        {
            Label label = new Label();
            label.ForeColor = Color.DimGray;
            label.AutoSize = true;
            label.Text = text;
            contex_flp.Controls.Add(label);
            label.Show();
            return label;
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            method.Invoke(get_all_checked_ID());
            this.Dispose();
        }

        private List<int> get_all_checked_ID()
        {
            List<int> ids = new List<int>();
            foreach (Control control in data_flp.Controls) if (control is CheckBox check) if (check.Checked) ids.Add(Convert.ToInt32(check.Tag));
            return ids;
        }


    }
}
