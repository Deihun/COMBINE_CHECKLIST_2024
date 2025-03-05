using COMBINE_CHECKLIST_2024.DateToText;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Spreadsheet;
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
        List<SelectionItem> selection;
        public QuickSelection(ComboBox Machine, ComboBox Monitor, ComboBox Location, ComboBox Month, ComboBox Years, List<SelectionItem> selection)
        {
            InitializeComponent();
            setComboBoxItem(Machine, this.machine_cb);
            setComboBoxItem(Location, this.location_cb);
            setComboBoxItem(Monitor, this.monitor_cb);
            setComboBoxItem(Month, this.month_cb);
            setComboBoxItem(Years, this.year_cb);
            this.selection = selection;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void setComboBoxItem(ComboBox Sender, ComboBox Receiver)
        {
            List<object> items = new List<object>();

            foreach (object value in Sender.Items)
            {
                items.Add(value); // Copy items to a separate list first
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
            foreach (SelectionItem s in selection)
            {
                s.hitCheckbox(false);
            }
                Datetotext convertdate = new Datetotext();
            foreach (SelectionItem s in selection)
            {
                DateTime target_date = s.target_date;
                int selectedMonth = convertdate.getMonth(month_cb.Text);

                

                bool isMonthValid = (month_cb.Text == "" || selectedMonth == target_date.Month);
                bool isYearValid = (year_cb.Text == "" || target_date.Year == Convert.ToInt32(year_cb.Text));
                bool isMonitorValid = (monitor_cb.Text == "" || month_cb.Text.Equals(s.monitor));
                bool isLocationValid = (location_cb.Text == "" || location_cb.Text.Equals(s.location));
                bool isMachineValid = (machine_cb.Text == "" || machine_cb.Text.Equals(s.machinename));
                Console.WriteLine($"DEBUGG:// {isYearValid} {isMachineValid} {isLocationValid} {isMonitorValid}");
                if (isMonthValid && isYearValid && isMachineValid && isLocationValid && isMonitorValid)
                {
                    s.hitCheckbox(true);
                }
            }
            Dispose();
        }

        private void month_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
