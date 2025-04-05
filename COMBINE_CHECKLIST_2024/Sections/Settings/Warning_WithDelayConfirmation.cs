using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMBINE_CHECKLIST_2024.Sections.Settings
{
    public partial class Warning_WithDelayConfirmation: Form
    {
        private Action method;
        private Timer timer = new Timer();
        private int countdown = 0;
        public Warning_WithDelayConfirmation(string text, string header_text, Action method_when_confirm, int countdown = 5)
        {
            InitializeComponent();
            countdown_label.Text = this.countdown.ToString();
            this.timer.Interval = 1000;
            this.countdown = countdown;
            this.method = method_when_confirm;
            this.Text = header_text;
            this.text_label.Text = text;
            timer.Tick += (sender, e) =>
            {
                this.countdown--;
                countdown_label.Text = this.countdown.ToString();
                if (this.countdown < 0)
                {
                    timer.Stop();
                    confirm_btn.Enabled = true;
                }
            };
            timer.Start();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            method.Invoke();
            this.Dispose();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
