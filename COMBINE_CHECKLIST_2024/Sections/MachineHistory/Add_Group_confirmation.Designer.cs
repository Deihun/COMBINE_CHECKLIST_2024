namespace COMBINE_CHECKLIST_2024.Sections.MachineHistory
{
    partial class Add_Group_confirmation
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
            this.from_dtpicker = new System.Windows.Forms.DateTimePicker();
            this.to_dtpicker = new System.Windows.Forms.DateTimePicker();
            this.confirmation_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.selectDateTimer_rb = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SelectButtonPreset = new System.Windows.Forms.RadioButton();
            this.SelectSpecificDaysToAdd = new System.Windows.Forms.RadioButton();
            this.threeDays_btn = new System.Windows.Forms.Button();
            this.fourDays_btn = new System.Windows.Forms.Button();
            this.fiveDays_btn = new System.Windows.Forms.Button();
            this.sixDays_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.previewdate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // from_dtpicker
            // 
            this.from_dtpicker.Location = new System.Drawing.Point(36, 19);
            this.from_dtpicker.Name = "from_dtpicker";
            this.from_dtpicker.Size = new System.Drawing.Size(249, 20);
            this.from_dtpicker.TabIndex = 0;
            this.from_dtpicker.ValueChanged += new System.EventHandler(this.from_dtpicker_ValueChanged);
            // 
            // to_dtpicker
            // 
            this.to_dtpicker.Location = new System.Drawing.Point(36, 14);
            this.to_dtpicker.Name = "to_dtpicker";
            this.to_dtpicker.Size = new System.Drawing.Size(249, 20);
            this.to_dtpicker.TabIndex = 1;
            this.to_dtpicker.ValueChanged += new System.EventHandler(this.to_dtpicker_ValueChanged);
            // 
            // confirmation_btn
            // 
            this.confirmation_btn.Location = new System.Drawing.Point(12, 213);
            this.confirmation_btn.Name = "confirmation_btn";
            this.confirmation_btn.Size = new System.Drawing.Size(96, 34);
            this.confirmation_btn.TabIndex = 2;
            this.confirmation_btn.Text = "Confirm";
            this.confirmation_btn.UseVisualStyleBackColor = true;
            this.confirmation_btn.Click += new System.EventHandler(this.confirmation_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectDateTimer_rb
            // 
            this.selectDateTimer_rb.AutoSize = true;
            this.selectDateTimer_rb.Checked = true;
            this.selectDateTimer_rb.Location = new System.Drawing.Point(16, 17);
            this.selectDateTimer_rb.Name = "selectDateTimer_rb";
            this.selectDateTimer_rb.Size = new System.Drawing.Size(14, 13);
            this.selectDateTimer_rb.TabIndex = 6;
            this.selectDateTimer_rb.TabStop = true;
            this.selectDateTimer_rb.UseVisualStyleBackColor = true;
            this.selectDateTimer_rb.CheckedChanged += new System.EventHandler(this.selectDateTimer_rb_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.previewdate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.sixDays_btn);
            this.groupBox1.Controls.Add(this.fiveDays_btn);
            this.groupBox1.Controls.Add(this.fourDays_btn);
            this.groupBox1.Controls.Add(this.threeDays_btn);
            this.groupBox1.Controls.Add(this.SelectSpecificDaysToAdd);
            this.groupBox1.Controls.Add(this.SelectButtonPreset);
            this.groupBox1.Controls.Add(this.to_dtpicker);
            this.groupBox1.Controls.Add(this.selectDateTimer_rb);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 144);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "END";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.from_dtpicker);
            this.groupBox2.Location = new System.Drawing.Point(12, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 52);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "START";
            // 
            // SelectButtonPreset
            // 
            this.SelectButtonPreset.AutoSize = true;
            this.SelectButtonPreset.Location = new System.Drawing.Point(16, 49);
            this.SelectButtonPreset.Name = "SelectButtonPreset";
            this.SelectButtonPreset.Size = new System.Drawing.Size(14, 13);
            this.SelectButtonPreset.TabIndex = 7;
            this.SelectButtonPreset.UseVisualStyleBackColor = true;
            this.SelectButtonPreset.CheckedChanged += new System.EventHandler(this.SelectButtonPreset_CheckedChanged);
            // 
            // SelectSpecificDaysToAdd
            // 
            this.SelectSpecificDaysToAdd.AutoSize = true;
            this.SelectSpecificDaysToAdd.Location = new System.Drawing.Point(16, 84);
            this.SelectSpecificDaysToAdd.Name = "SelectSpecificDaysToAdd";
            this.SelectSpecificDaysToAdd.Size = new System.Drawing.Size(14, 13);
            this.SelectSpecificDaysToAdd.TabIndex = 8;
            this.SelectSpecificDaysToAdd.UseVisualStyleBackColor = true;
            this.SelectSpecificDaysToAdd.CheckedChanged += new System.EventHandler(this.SelectSpecificDaysToAdd_CheckedChanged);
            // 
            // threeDays_btn
            // 
            this.threeDays_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeDays_btn.Location = new System.Drawing.Point(47, 45);
            this.threeDays_btn.Name = "threeDays_btn";
            this.threeDays_btn.Size = new System.Drawing.Size(58, 23);
            this.threeDays_btn.TabIndex = 9;
            this.threeDays_btn.Text = "3";
            this.threeDays_btn.UseVisualStyleBackColor = true;
            this.threeDays_btn.Click += new System.EventHandler(this.threeDays_btn_Click);
            // 
            // fourDays_btn
            // 
            this.fourDays_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fourDays_btn.Location = new System.Drawing.Point(107, 45);
            this.fourDays_btn.Name = "fourDays_btn";
            this.fourDays_btn.Size = new System.Drawing.Size(58, 23);
            this.fourDays_btn.TabIndex = 10;
            this.fourDays_btn.Text = "4";
            this.fourDays_btn.UseVisualStyleBackColor = true;
            this.fourDays_btn.Click += new System.EventHandler(this.fourDays_btn_Click);
            // 
            // fiveDays_btn
            // 
            this.fiveDays_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fiveDays_btn.Location = new System.Drawing.Point(167, 45);
            this.fiveDays_btn.Name = "fiveDays_btn";
            this.fiveDays_btn.Size = new System.Drawing.Size(58, 23);
            this.fiveDays_btn.TabIndex = 11;
            this.fiveDays_btn.Text = "5";
            this.fiveDays_btn.UseVisualStyleBackColor = true;
            this.fiveDays_btn.Click += new System.EventHandler(this.fiveDays_btn_Click);
            // 
            // sixDays_btn
            // 
            this.sixDays_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sixDays_btn.Location = new System.Drawing.Point(227, 45);
            this.sixDays_btn.Name = "sixDays_btn";
            this.sixDays_btn.Size = new System.Drawing.Size(58, 23);
            this.sixDays_btn.TabIndex = 12;
            this.sixDays_btn.Text = "6";
            this.sixDays_btn.UseVisualStyleBackColor = true;
            this.sixDays_btn.Click += new System.EventHandler(this.sixDays_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(38, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Add Days";
            // 
            // previewdate
            // 
            this.previewdate.AutoSize = true;
            this.previewdate.Location = new System.Drawing.Point(52, 116);
            this.previewdate.Name = "previewdate";
            this.previewdate.Size = new System.Drawing.Size(48, 13);
            this.previewdate.TabIndex = 15;
            this.previewdate.Text = "<DATE>";
            // 
            // Add_Group_confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 259);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.confirmation_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Group_confirmation";
            this.Text = "MONITORING";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker from_dtpicker;
        private System.Windows.Forms.DateTimePicker to_dtpicker;
        private System.Windows.Forms.Button confirmation_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton selectDateTimer_rb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sixDays_btn;
        private System.Windows.Forms.Button fiveDays_btn;
        private System.Windows.Forms.Button fourDays_btn;
        private System.Windows.Forms.Button threeDays_btn;
        private System.Windows.Forms.RadioButton SelectSpecificDaysToAdd;
        private System.Windows.Forms.RadioButton SelectButtonPreset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label previewdate;
    }
}