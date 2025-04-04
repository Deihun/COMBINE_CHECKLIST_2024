using DocumentFormat.OpenXml.Drawing;
using GrapeCity.DataVisualization.TypeScript;
using Microsoft.SqlServer.Management.XEvent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMBINE_CHECKLIST_2024.Sections.MachineHistory
{
    public partial class TimeInterval_Picker: Form
    {
        private bool isSingle_use = true;
        private bool isSingle_use_AM = true;
        private bool isInterval_start_AM = true;
        private bool isInterval_end_AM = true;

        private Action<string> returning_string;  
        public TimeInterval_Picker(Action<string> method)
        {
            InitializeComponent();
            this.returning_string = method;
            _setup();
        }
        public TimeInterval_Picker(Action<string> method, string set_in_time)
        {
            InitializeComponent();
            this.returning_string = method;
            _setup(set_in_time);
        }

        private void _setup()
        {
            update_time_pick_mode();
            update_med_single_time();
            update_med_interval_start();
            update_med_interval_end();

            hour1_tb.KeyPress += key_press;
            min1_tb.KeyPress += key_press;
            startHour_btn.KeyPress += key_press;
            startMin_btn.KeyPress += key_press;
            endHour_btn.KeyPress += key_press;
            endMin_btn.KeyPress += key_press;

            hour1_tb.LostFocus += outFocus_Inputs;
            min1_tb.LostFocus += outFocus_Inputs;
            startHour_btn.LostFocus += outFocus_Inputs;
            startMin_btn.LostFocus += outFocus_Inputs;
            endHour_btn.LostFocus += outFocus_Inputs;
            endMin_btn.LostFocus += outFocus_Inputs;
        }
        private void _setup(string to_setIn)
        {
            _setup(); 

            if (to_setIn.Contains(" - ")) 
            {
                isSingle_use = false;
                update_time_pick_mode();

                string[] times = to_setIn.Split(new string[] { " - " }, StringSplitOptions.None);

                var startTime = ParseTime(times[0]);
                var endTime = ParseTime(times[1]);

                hour1_tb.Text = startTime.Hour.ToString("D2");
                min1_tb.Text = startTime.Minute.ToString("D2");
                isSingle_use_AM = startTime.IsAM;

                startHour_btn.Text = startTime.Hour.ToString("D2");
                startMin_btn.Text = startTime.Minute.ToString("D2");
                isInterval_start_AM = startTime.IsAM;

                endHour_btn.Text = endTime.Hour.ToString("D2");
                endMin_btn.Text = endTime.Minute.ToString("D2");
                isInterval_end_AM = endTime.IsAM;
            }
            else
            {
                var time = ParseTime(to_setIn);
                hour1_tb.Text = time.Hour.ToString("D2");
                min1_tb.Text = time.Minute.ToString("D2");
                isSingle_use_AM = time.IsAM;
            }
        }

        private (int Hour, int Minute, bool IsAM) ParseTime(string time)
        {
            Match match = Regex.Match(time, @"(\d{1,2}):(\d{2})(AM|PM)");

            if (match.Success)
            {
                int hour = int.Parse(match.Groups[1].Value);
                int minute = int.Parse(match.Groups[2].Value);
                bool isAM = match.Groups[3].Value == "AM";

                return (hour, minute, isAM);
            }

            throw new FormatException("Invalid time format");
        }


        private string getSelectedTime_AsText()
        {
            string text = "";
            if (isSingle_use)
            {
                string a = isSingle_use_AM ? "AM" : "PM";
                text = $"{hour1_tb.Text}:{min1_tb.Text}{a}";
            }
            else
            {
                string a = isInterval_start_AM ? "AM" : "PM";
                string b = isInterval_end_AM ? "AM" : "PM";
                text = $"{startHour_btn.Text}:{startMin_btn.Text}{a} - {endHour_btn.Text}:{endMin_btn.Text}{b}";
            }
                return text;
        }

        private void update_time_pick_mode()
        {
            toggleUse_twoInterval_btn.Text = isSingle_use ? "USE TIME INTERVAL" : "USE SPECIFIC TIME";
            interval_panel.Visible = !isSingle_use;
            singleTime_panel.Visible = isSingle_use;
        }

        private void update_med_single_time()
        {
            am1_btn.BackColor = isSingle_use_AM ? Color.Gray : Color.White;
            pm1_btn.BackColor = !isSingle_use_AM ? Color.Gray : Color.White;
        }
        private void update_med_interval_start()
        {
            startAM_btn.BackColor = isInterval_start_AM ? Color.Gray : Color.White;
            startPM_btn.BackColor = !isInterval_start_AM ? Color.Gray : Color.White;
        }
        private void update_med_interval_end()
        {
            endAM_btn.BackColor = isInterval_end_AM ? Color.Gray : Color.White;
            endPM_btn.BackColor = !isInterval_end_AM ? Color.Gray : Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void am1_btn_Click(object sender, EventArgs e)
        {
            isSingle_use_AM = true;
            update_med_single_time();
        }

        private void pm1_btn_Click(object sender, EventArgs e)
        {
            isSingle_use_AM = false;
            update_med_single_time();
        }

        private void startAM_btn_Click(object sender, EventArgs e)
        {
            isInterval_start_AM = true;
            update_med_interval_start();
        }

        private void startPM_btn_Click(object sender, EventArgs e)
        {
            isInterval_start_AM = false;
            update_med_interval_start();
        }

        private void endAM_btn_Click(object sender, EventArgs e)
        {
            isInterval_end_AM = true;
            update_med_interval_end();
        }

        private void endPM_btn_Click(object sender, EventArgs e)
        {
            isInterval_end_AM = false;
            update_med_interval_end();
        }

        private void toggleUse_twoInterval_btn_Click(object sender, EventArgs e)
        {
            isSingle_use = !isSingle_use;
            update_time_pick_mode();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            returning_string?.Invoke(getSelectedTime_AsText());
            Dispose();
        }

        private void key_press(object sender,KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null) return;

            int maxLimit = textBox.Tag != null ? Convert.ToInt32(textBox.Tag) : int.MaxValue;
            int minLimit = 1; 

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            string newText = e.KeyChar == '\b' 
                ? textBox.Text.Length > 0 ? textBox.Text.Substring(0, textBox.Text.Length - 1) : ""
                : textBox.Text + e.KeyChar;

            if (int.TryParse(newText, out int newValue))
            {
                if (newValue > maxLimit)
                {
                    textBox.Text = maxLimit.ToString(); 
                    textBox.SelectionStart = textBox.Text.Length; 
                    e.Handled = true;
                }
                else if (newValue < minLimit && newText.Length > 0) 
                {
                    textBox.Text = minLimit.ToString();
                    textBox.SelectionStart = textBox.Text.Length;
                    e.Handled = true;
                }
            }
        }

        private void outFocus_Inputs(object sender, EventArgs e)
        {
            if (sender is TextBox textBox1)
            {
                if (int.TryParse(textBox1.Text, out int number))
                {
                    textBox1.Text = number.ToString("D2");
                }
                else
                {
                    textBox1.Text = "00"; 
                }
            }
        }
    }
}
