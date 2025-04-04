using COMBINE_CHECKLIST_2024.DateToText;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Spreadsheet;
using SQL_Connection_support;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMBINE_CHECKLIST_2024.Sections.MachineHistoryViewer
{
    public partial class QuickSelection: Form
    {
        private SQL_Support sql = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");
        private BulkPrintSelection parent;
        private List<FlowLayoutPanel> list_of_pages;
        public QuickSelection(ComboBox Machine, ComboBox Monitor, ComboBox Location, ComboBox Month, ComboBox Years, List<FlowLayoutPanel> flp, BulkPrintSelection bulkPrintSelection)
        {
            InitializeComponent();
            setComboBoxItem(Machine, this.machine_cb);
            setComboBoxItem(Location, this.location_cb);
            setComboBoxItem(Monitor, this.monitor_cb);
            setComboBoxItem(Month, this.month_cb);
            setComboBoxItem(Years, this.year_cb);
            this.list_of_pages = flp;
            this.parent = bulkPrintSelection;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void setComboBoxItem(ComboBox Sender, ComboBox Receiver)
        {
            List<object> items = new List<object>();

            foreach (object value in Sender.Items)
            {
                items.Add(value);
            }

            foreach (object value in items)
            {
                Receiver.Items.Add(value); // Now safely add them to the receiver
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            foreach (FlowLayoutPanel flp in list_of_pages) flp.Dispose();
            list_of_pages.Clear();
            parent.Add_new_Page();
            parent.number_of_page = 1;
            int number_of_object = 0;
            foreach (DataRow row in get_server_with_filter_on().Rows)
            {
                CheckBox check = parent.create_check_box($"{row["date_commit"]} ({row["ID"]})", Convert.ToInt32(row["ID"]));
                check.Checked = Convert.ToBoolean(row["satisfy"]);
                number_of_object++;
                if (number_of_object >= parent.number_of_object_per_page)
                {
                    number_of_object = 0;
                    parent.number_of_page++;
                    parent.Add_new_Page();
                }
            }
            this.parent.selected_page = 1;
            this.parent.change_page(1, 0);
            Dispose();
        }

        private void month_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private DataTable get_server_with_filter_on()
        {
            List<string> conditions = new List<string>();

            string query = $@"
    SELECT DISTINCT
        record.ID, 
        _group.Machine_Name, 
        _group.Monitored_By, 
        _group.Location, 
        record.date_commit,
        CASE 
            WHEN 
";

            // Adding conditions for the "satisfy" column
            List<string> caseConditions = new List<string>();

            if (!string.IsNullOrEmpty(machine_cb.Text))
                caseConditions.Add($" [_group].Machine_Name = '{machine_cb.Text}'");
            if (!string.IsNullOrEmpty(monitor_cb.Text))
                caseConditions.Add($" [_group].Monitored_By = '{monitor_cb.Text}'");
            if (!string.IsNullOrEmpty(location_cb.Text))
                caseConditions.Add($" [_group].Location = '{location_cb.Text}'");
            if (!string.IsNullOrEmpty(month_cb.Text))
                caseConditions.Add($" MONTH(record.date_commit) = {month_cb.Text}");
            if (!string.IsNullOrEmpty(year_cb.Text))
                caseConditions.Add($" YEAR(record.date_commit) = {year_cb.Text}");

            if (caseConditions.Count > 0)
                query += string.Join(" AND ", caseConditions) + " THEN 1 ELSE 0 END AS satisfy";

            query += $@"
    FROM EXECUTION_HISTORY record
    LEFT JOIN GROUP_TABLE _group ON record.id = _group.historylog_id
    LEFT JOIN LOG_MACHINETABLE item ON item.groupID = _group.GroupID
    ";

            return sql.ExecuteQuery(query);
        }
    }
}
