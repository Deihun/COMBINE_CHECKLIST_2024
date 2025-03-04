using COMBINE_CHECKLIST_2024.DateToText;
using COMBINE_CHECKLIST_2024.Sections.Currugator;
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
    public partial class Add_Group_confirmation: Form
    {
        private double selectedPresetDate = 3;
        private FlowLayoutPanel parent;
        private Create creation_parent;

        private string monitor;
        private string machine;
        private string location;

        private DateTime finalConfirmedDateFrom = new DateTime();
        public Add_Group_confirmation(FlowLayoutPanel flowlayout, Create creation_parent, string monitor, string machine, string location)
        {
            InitializeComponent();
            from_dtpicker.Value = from_dtpicker.Value;
            to_dtpicker.Value = to_dtpicker.Value;
            parent = flowlayout;
            this.creation_parent = creation_parent;
            this.monitor = monitor;
            this.machine = machine;
            this.location = location;
            updateEnables();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void confirmation_btn_Click(object sender, EventArgs e)
        {
            updateEnables();
            DateTime datefrom = from_dtpicker.Value.Date;  
            DateTime dateTo = to_dtpicker.Value.Date;     


            if (datefrom > dateTo)
            {
                MessageBox.Show("Start date cannot be later than end date");
                return;
            }

            grouping_of_items group = new grouping_of_items(datefrom,finalConfirmedDateFrom,monitor,machine,location);
            creation_parent.addNewGroups(group);
            group.TopLevel = false;
            parent.Controls.Add(group);
            group.Show();
            group.parent = creation_parent;

            DateTime[] dateRange = getDateRangeArray(datefrom, finalConfirmedDateFrom);

            Console.WriteLine("Generated date range:");
            foreach (var date in dateRange)
            {
                Console.WriteLine(date.ToString("yyyy-MM-dd"));
            }

            foreach (DateTime range in dateRange)
            {
                Item_Record item = new Item_Record(group);
                item.setDate(range);
                item.setAutoComplete();
                group.add_item(item);
            }

            Console.WriteLine("Number of items added: " + dateRange.Length);

            this.Dispose();
        }
        


        private int getDayDifference(DateTime dateStart,DateTime dateEnd)
        {
            return Math.Abs((dateEnd - dateStart).Days);
        }


        private DateTime[] getDateRangeArray(DateTime start, DateTime end)
        {
            int dayDifference = getDayDifference(start, end);
            DateTime[] daterange = new DateTime[dayDifference + 1]; 

            for (int i = 0; i <= dayDifference; i++)
            {
                daterange[i] = start.AddDays(i);
            }

            return daterange;
        }


        private void updateEnables()
        {
            to_dtpicker.Enabled = selectDateTimer_rb.Checked;
            threeDays_btn.Enabled = SelectButtonPreset.Checked;
            fourDays_btn.Enabled = SelectButtonPreset.Checked;
            fiveDays_btn.Enabled = SelectButtonPreset.Checked;
            sixDays_btn.Enabled = SelectButtonPreset.Checked;
            textBox1.Enabled = SelectSpecificDaysToAdd.Checked;
            previewdate.Visible = !selectDateTimer_rb.Checked;
            updateSelectedDates();
        }
        private void updateSelectedDates()
        {
            Datetotext convert = new Datetotext();
            if (selectDateTimer_rb.Checked)
            {
                finalConfirmedDateFrom = to_dtpicker.Value;
            }else if (SelectButtonPreset.Checked)
            {
                finalConfirmedDateFrom = from_dtpicker.Value.AddDays(selectedPresetDate);
            }
            else
            {
                finalConfirmedDateFrom = from_dtpicker.Value.AddDays(Convert.ToDouble(textBox1.Text == ""? "0": textBox1.Text));
            }
            previewdate.Text = convert.getMonthAsShortText(finalConfirmedDateFrom) + $" {finalConfirmedDateFrom.Day}, {finalConfirmedDateFrom.Year}";
        }
        private void SelectButtonPreset_CheckedChanged(object sender, EventArgs e)
        {
            updateEnables();
        }

        private void selectDateTimer_rb_CheckedChanged(object sender, EventArgs e)
        {
            updateEnables();
        }

        private void SelectSpecificDaysToAdd_CheckedChanged(object sender, EventArgs e)
        {
            updateEnables();
        }

        private void threeDays_btn_Click(object sender, EventArgs e)
        {
            selectedPresetDate = 3;
            updateEnables();
        }

        private void fourDays_btn_Click(object sender, EventArgs e)
        {
            selectedPresetDate = 4;
            updateEnables();
        }

        private void fiveDays_btn_Click(object sender, EventArgs e)
        {
            selectedPresetDate = 5;
            updateEnables();
        }

        private void sixDays_btn_Click(object sender, EventArgs e)
        {
            selectedPresetDate = 6;
            updateEnables();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filteredText = new string(textBox1.Text.Where(char.IsDigit).ToArray());

            if (int.TryParse(filteredText, out int number))
            {
                if (number > 100)
                    number = 100; // Limit the number

                textBox1.Text = number.ToString();
            }
            else
            {
                textBox1.Text = ""; // Clear if it's invalid
            }

            textBox1.SelectionStart = textBox1.Text.Length;
            updateEnables();
        }

        private void to_dtpicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                updateEnables();
                to_dtpicker.MinDate = from_dtpicker.Value;
                to_dtpicker.MaxDate = from_dtpicker.Value.AddDays(100);

                if (to_dtpicker.Value < to_dtpicker.MinDate || to_dtpicker.Value > to_dtpicker.MaxDate)
                {
                    to_dtpicker.Value = to_dtpicker.MinDate;
                }
            }
            catch(Exception ex)
            {

            }

        }

        private void from_dtpicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                updateEnables();
                to_dtpicker.MinDate = from_dtpicker.Value;
                to_dtpicker.MaxDate = from_dtpicker.Value.AddDays(100);

                if (to_dtpicker.Value < to_dtpicker.MinDate || to_dtpicker.Value > to_dtpicker.MaxDate)
                {
                    to_dtpicker.Value = to_dtpicker.MinDate;
                }else to_dtpicker.Value = from_dtpicker.Value; 
            }
            catch (Exception ex)
            {
                to_dtpicker.Value = from_dtpicker.Value;
            }
        }
    }
}
