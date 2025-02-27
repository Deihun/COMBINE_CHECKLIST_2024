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

namespace COMBINE_CHECKLIST_2024.Sections.Currugator
{
    public partial class Item_Record: Form
    {
        private Form myParent;
        public DateTime my_targeted_date;
        public bool isDefect = true;
        public Item_Record(Form myParent)
        {
            InitializeComponent();
            this.myParent = myParent;
            _changeColor();
        }

        private void isdefect_toggle_btn_Click(object sender, EventArgs e)
        {
            isDefect = !isDefect;
            isdefect_toggle_btn.BackColor = isDefect ? Color.Khaki : Color.Azure;
            isdefect_toggle_btn.Text = isDefect ? "DEFECTIVE" : "SATISFACTORY";
        }

        public void setDate(DateTime date)
        {
            my_targeted_date = date;
            changeablemonth_label.Text = (convert_monthText(date) + " - " + date.Day);
        }

        public string get_defectiveparts()
        {
            return defective_tb.Text.Equals(string.Empty)? "N/A" : defective_tb.Text;
        }

        public string get_defectiveDescription()
        {
            return defective_description_rtb.Text.Equals(string.Empty)? "N/A" : defective_description_rtb.Text;
        }

        public string get_suggestion()
        {
            return suggestion_rtb.Text.Equals(string.Empty) ? "N/A" : suggestion_rtb.Text;
        }

        public void set_time()
        {
            Datetotext convert = new Datetotext();
            hour_textbox.Text = convert.getHour_12HoursPreset(DateTime.Now);
            min_tb.Text = convert.getMinutes(DateTime.Now);
        }

        public DateTime getTargetDate()
        {
            
            string rawhourstring = hour_textbox.Text; //CAUSING ERROR/ THIS IS CAUSE DUO TO DELETION, solve the deletion of group first.
            //MessageBox.Show("**DEBUGG //" + rawhourstring);
            int hour = Convert.ToInt32(rawhourstring);
            if (!isAM && hour != 12)  // Convert PM hours (except 12 PM)
                hour += 12;
            if (isAM && hour == 12)    // Convert 12 AM to 0
                hour = 0;

            DateTime newDayTime = new DateTime(
                my_targeted_date.Year,
                my_targeted_date.Month,
                my_targeted_date.Day,
                hour,
                Convert.ToInt32(min_tb.Text),
                0);
            return newDayTime;
        }
        public string get_remarks()
        {
            return remarks_rtb.Text.Equals(string.Empty) ? "N/A" : remarks_rtb.Text;
        }

        public int get_overallAnalysis()
        {
            return isDefect ? 1 : 0;
        }

        public string get_checkby()
        {
            return checkby_textfield.Text.Equals(string.Empty) ? "N/A" : checkby_textfield.Text;
        }
        private string convert_monthText(DateTime month)
        {
            string _month = "";

            switch (month.Month)
            {
                case 1:
                    _month = "January";
                break;
                case 2:
                    _month = "February";
                    break;
                case 3:
                    _month = "March";
                    break;
                case 4:
                    _month = "April";
                    break;
                case 5:
                    _month = "May";
                    break;
                case 6:
                    _month = "June";
                    break;
                case 7:
                    _month = "July";
                    break;
                case 8:
                    _month = "August";
                    break;
                case 9:
                    _month = "September";
                    break;
                case 10:
                    _month = "October";
                    break;
                case 11:
                    _month = "November";
                    break;
                case 12:
                    _month = "December";
                    break;
            }

            return _month;
        }

        private void Item_Record_Load(object sender, EventArgs e)
        {

        }

        private void defective_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void defective_description_rtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void defectivedesc_label_Click(object sender, EventArgs e)
        {

        }

        private void defective_tb_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void defectivepart_label_Click(object sender, EventArgs e)
        {

        }

        private void _showHour_Properly()
        {
            setDate(my_targeted_date);
            hour_textbox.Text = my_targeted_date.Hour.ToString();
            min_tb.Text = my_targeted_date.Minute.ToString();
        }

        private void hourUp_btn_Click(object sender, EventArgs e)
        {
            my_targeted_date.AddHours(1);
            _showHour_Properly();
        }

        private void hourDown_btn_Click(object sender, EventArgs e)
        {
            my_targeted_date.AddHours(-1);
            _showHour_Properly();
        }

        private void minUp_btn_Click(object sender, EventArgs e)
        {
            my_targeted_date.AddMinutes(1);
            _showHour_Properly();
        }

        private void minDown_btn_Click(object sender, EventArgs e)
        {
            my_targeted_date.AddMinutes(-1);
            _showHour_Properly();
        }

        private void hour_tb_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(hour_textbox.Text, out int hour))
            {
                hour_textbox.Text = "";
                return;
            }

            // Restrict the value to 12
            if (hour > 12)
            {
                hour_textbox.Text = "12";
                hour_textbox.SelectionStart = hour_textbox.Text.Length; // Move cursor to the end
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkby_textfield_TextChanged(object sender, EventArgs e)
        {

        }

        private void min_tb_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(min_tb.Text, out int minutes))
            {
                min_tb.Text = "";
                return;
            }

            // Restrict the value to 59
            if (minutes > 59)
            {
                min_tb.Text = "59";
                min_tb.SelectionStart = min_tb.Text.Length; // Move cursor to the end
            }
        }



        private bool isAM = false;
        private void _changeColor()
        {
            am_btn.BackColor = isAM ? Color.White : Color.DarkGray;
            am_btn.ForeColor = isAM ? Color.Black : Color.DimGray;
            pm_btn.BackColor = !isAM ? Color.White : Color.DarkGray;
            pm_btn.ForeColor = !isAM ? Color.Black : Color.DimGray;
        }

        private void am_btn_Click(object sender, EventArgs e)
        {
            isAM = true;
            _changeColor();
        }

        private void pm_btn_Click(object sender, EventArgs e)
        {
            isAM = false;
            _changeColor();
        }
    }
}
