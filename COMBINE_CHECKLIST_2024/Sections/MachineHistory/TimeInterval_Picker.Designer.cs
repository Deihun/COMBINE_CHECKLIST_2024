namespace COMBINE_CHECKLIST_2024.Sections.MachineHistory
{
    partial class TimeInterval_Picker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.confirm_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.singleTime_panel = new System.Windows.Forms.Panel();
            this.pm1_btn = new System.Windows.Forms.Button();
            this.am1_btn = new System.Windows.Forms.Button();
            this.min1_tb = new System.Windows.Forms.TextBox();
            this.hour1_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.interval_panel = new System.Windows.Forms.Panel();
            this.endPM_btn = new System.Windows.Forms.Button();
            this.endAM_btn = new System.Windows.Forms.Button();
            this.startPM_btn = new System.Windows.Forms.Button();
            this.startAM_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.endMin_btn = new System.Windows.Forms.TextBox();
            this.endHour_btn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startMin_btn = new System.Windows.Forms.TextBox();
            this.startHour_btn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toggleUse_twoInterval_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.singleTime_panel.SuspendLayout();
            this.interval_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirm_btn
            // 
            this.confirm_btn.BackColor = System.Drawing.Color.White;
            this.confirm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm_btn.Location = new System.Drawing.Point(6, 216);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(75, 23);
            this.confirm_btn.TabIndex = 0;
            this.confirm_btn.Text = "CONFIRM";
            this.confirm_btn.UseVisualStyleBackColor = false;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.White;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Location = new System.Drawing.Point(86, 216);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 1;
            this.cancel_btn.Text = "CANCEL";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.singleTime_panel);
            this.flowLayoutPanel1.Controls.Add(this.interval_panel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 26);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(640, 174);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // singleTime_panel
            // 
            this.singleTime_panel.Controls.Add(this.pm1_btn);
            this.singleTime_panel.Controls.Add(this.am1_btn);
            this.singleTime_panel.Controls.Add(this.min1_tb);
            this.singleTime_panel.Controls.Add(this.hour1_tb);
            this.singleTime_panel.Controls.Add(this.label1);
            this.singleTime_panel.Location = new System.Drawing.Point(3, 3);
            this.singleTime_panel.Name = "singleTime_panel";
            this.singleTime_panel.Size = new System.Drawing.Size(306, 171);
            this.singleTime_panel.TabIndex = 0;
            // 
            // pm1_btn
            // 
            this.pm1_btn.BackColor = System.Drawing.Color.White;
            this.pm1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pm1_btn.Location = new System.Drawing.Point(234, 81);
            this.pm1_btn.Name = "pm1_btn";
            this.pm1_btn.Size = new System.Drawing.Size(59, 42);
            this.pm1_btn.TabIndex = 4;
            this.pm1_btn.Text = "PM";
            this.pm1_btn.UseVisualStyleBackColor = false;
            this.pm1_btn.Click += new System.EventHandler(this.pm1_btn_Click);
            // 
            // am1_btn
            // 
            this.am1_btn.BackColor = System.Drawing.Color.White;
            this.am1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.am1_btn.Location = new System.Drawing.Point(234, 39);
            this.am1_btn.Name = "am1_btn";
            this.am1_btn.Size = new System.Drawing.Size(59, 42);
            this.am1_btn.TabIndex = 3;
            this.am1_btn.Text = "AM";
            this.am1_btn.UseVisualStyleBackColor = false;
            this.am1_btn.Click += new System.EventHandler(this.am1_btn_Click);
            // 
            // min1_tb
            // 
            this.min1_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min1_tb.Location = new System.Drawing.Point(134, 37);
            this.min1_tb.MaxLength = 2;
            this.min1_tb.Name = "min1_tb";
            this.min1_tb.Size = new System.Drawing.Size(94, 91);
            this.min1_tb.TabIndex = 1;
            this.min1_tb.Tag = "59";
            this.min1_tb.Text = "12";
            this.min1_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // hour1_tb
            // 
            this.hour1_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour1_tb.Location = new System.Drawing.Point(13, 37);
            this.hour1_tb.MaxLength = 2;
            this.hour1_tb.Name = "hour1_tb";
            this.hour1_tb.Size = new System.Drawing.Size(92, 91);
            this.hour1_tb.TabIndex = 0;
            this.hour1_tb.Tag = "12";
            this.hour1_tb.Text = "12";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 91);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // interval_panel
            // 
            this.interval_panel.Controls.Add(this.endPM_btn);
            this.interval_panel.Controls.Add(this.endAM_btn);
            this.interval_panel.Controls.Add(this.startPM_btn);
            this.interval_panel.Controls.Add(this.startAM_btn);
            this.interval_panel.Controls.Add(this.label5);
            this.interval_panel.Controls.Add(this.endMin_btn);
            this.interval_panel.Controls.Add(this.endHour_btn);
            this.interval_panel.Controls.Add(this.label3);
            this.interval_panel.Controls.Add(this.startMin_btn);
            this.interval_panel.Controls.Add(this.startHour_btn);
            this.interval_panel.Controls.Add(this.label2);
            this.interval_panel.Controls.Add(this.label4);
            this.interval_panel.Location = new System.Drawing.Point(315, 3);
            this.interval_panel.Name = "interval_panel";
            this.interval_panel.Size = new System.Drawing.Size(306, 171);
            this.interval_panel.TabIndex = 1;
            // 
            // endPM_btn
            // 
            this.endPM_btn.BackColor = System.Drawing.Color.White;
            this.endPM_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endPM_btn.Location = new System.Drawing.Point(244, 137);
            this.endPM_btn.Name = "endPM_btn";
            this.endPM_btn.Size = new System.Drawing.Size(59, 23);
            this.endPM_btn.TabIndex = 14;
            this.endPM_btn.Text = "PM";
            this.endPM_btn.UseVisualStyleBackColor = false;
            this.endPM_btn.Click += new System.EventHandler(this.endPM_btn_Click);
            // 
            // endAM_btn
            // 
            this.endAM_btn.BackColor = System.Drawing.Color.White;
            this.endAM_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endAM_btn.Location = new System.Drawing.Point(244, 116);
            this.endAM_btn.Name = "endAM_btn";
            this.endAM_btn.Size = new System.Drawing.Size(59, 23);
            this.endAM_btn.TabIndex = 13;
            this.endAM_btn.Text = "AM";
            this.endAM_btn.UseVisualStyleBackColor = false;
            this.endAM_btn.Click += new System.EventHandler(this.endAM_btn_Click);
            // 
            // startPM_btn
            // 
            this.startPM_btn.BackColor = System.Drawing.Color.White;
            this.startPM_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startPM_btn.Location = new System.Drawing.Point(244, 53);
            this.startPM_btn.Name = "startPM_btn";
            this.startPM_btn.Size = new System.Drawing.Size(59, 23);
            this.startPM_btn.TabIndex = 12;
            this.startPM_btn.Text = "PM";
            this.startPM_btn.UseVisualStyleBackColor = false;
            this.startPM_btn.Click += new System.EventHandler(this.startPM_btn_Click);
            // 
            // startAM_btn
            // 
            this.startAM_btn.BackColor = System.Drawing.Color.White;
            this.startAM_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startAM_btn.Location = new System.Drawing.Point(244, 32);
            this.startAM_btn.Name = "startAM_btn";
            this.startAM_btn.Size = new System.Drawing.Size(59, 23);
            this.startAM_btn.TabIndex = 11;
            this.startAM_btn.Text = "AM";
            this.startAM_btn.UseVisualStyleBackColor = false;
            this.startAM_btn.Click += new System.EventHandler(this.startAM_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "END";
            // 
            // endMin_btn
            // 
            this.endMin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endMin_btn.Location = new System.Drawing.Point(170, 106);
            this.endMin_btn.MaxLength = 2;
            this.endMin_btn.Name = "endMin_btn";
            this.endMin_btn.Size = new System.Drawing.Size(71, 62);
            this.endMin_btn.TabIndex = 7;
            this.endMin_btn.Tag = "59";
            this.endMin_btn.Text = "12";
            // 
            // endHour_btn
            // 
            this.endHour_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endHour_btn.Location = new System.Drawing.Point(78, 106);
            this.endHour_btn.MaxLength = 2;
            this.endHour_btn.Name = "endHour_btn";
            this.endHour_btn.Size = new System.Drawing.Size(73, 62);
            this.endHour_btn.TabIndex = 6;
            this.endHour_btn.Tag = "12";
            this.endHour_btn.Text = "12";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 55);
            this.label3.TabIndex = 8;
            this.label3.Text = ":";
            // 
            // startMin_btn
            // 
            this.startMin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startMin_btn.Location = new System.Drawing.Point(170, 20);
            this.startMin_btn.MaxLength = 2;
            this.startMin_btn.Name = "startMin_btn";
            this.startMin_btn.Size = new System.Drawing.Size(71, 62);
            this.startMin_btn.TabIndex = 4;
            this.startMin_btn.Tag = "59";
            this.startMin_btn.Text = "12";
            // 
            // startHour_btn
            // 
            this.startHour_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startHour_btn.Location = new System.Drawing.Point(78, 20);
            this.startHour_btn.MaxLength = 2;
            this.startHour_btn.Name = "startHour_btn";
            this.startHour_btn.Size = new System.Drawing.Size(73, 62);
            this.startHour_btn.TabIndex = 3;
            this.startHour_btn.Tag = "12";
            this.startHour_btn.Text = "12";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 55);
            this.label2.TabIndex = 5;
            this.label2.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "START";
            // 
            // toggleUse_twoInterval_btn
            // 
            this.toggleUse_twoInterval_btn.BackColor = System.Drawing.Color.White;
            this.toggleUse_twoInterval_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleUse_twoInterval_btn.Location = new System.Drawing.Point(8, 2);
            this.toggleUse_twoInterval_btn.Name = "toggleUse_twoInterval_btn";
            this.toggleUse_twoInterval_btn.Size = new System.Drawing.Size(153, 23);
            this.toggleUse_twoInterval_btn.TabIndex = 3;
            this.toggleUse_twoInterval_btn.Text = "USE SINGLE TIME";
            this.toggleUse_twoInterval_btn.UseVisualStyleBackColor = false;
            this.toggleUse_twoInterval_btn.Click += new System.EventHandler(this.toggleUse_twoInterval_btn_Click);
            // 
            // TimeInterval_Picker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 242);
            this.Controls.Add(this.toggleUse_twoInterval_btn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.confirm_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimeInterval_Picker";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.singleTime_panel.ResumeLayout(false);
            this.singleTime_panel.PerformLayout();
            this.interval_panel.ResumeLayout(false);
            this.interval_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel singleTime_panel;
        private System.Windows.Forms.TextBox min1_tb;
        private System.Windows.Forms.TextBox hour1_tb;
        private System.Windows.Forms.Panel interval_panel;
        private System.Windows.Forms.Button pm1_btn;
        private System.Windows.Forms.Button am1_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button toggleUse_twoInterval_btn;
        private System.Windows.Forms.Button endPM_btn;
        private System.Windows.Forms.Button endAM_btn;
        private System.Windows.Forms.Button startPM_btn;
        private System.Windows.Forms.Button startAM_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox endMin_btn;
        private System.Windows.Forms.TextBox endHour_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox startMin_btn;
        private System.Windows.Forms.TextBox startHour_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}