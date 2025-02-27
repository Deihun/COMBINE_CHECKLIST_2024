namespace COMBINE_CHECKLIST_2024.Sections.Currugator
{
    partial class Item_Record
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
            this.checkby_textfield = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.isdefect_toggle_btn = new System.Windows.Forms.Button();
            this.defective_description_rtb = new System.Windows.Forms.RichTextBox();
            this.defective_tb = new System.Windows.Forms.TextBox();
            this.defectivepart_label = new System.Windows.Forms.Label();
            this.defectivedesc_label = new System.Windows.Forms.Label();
            this.suggestion_rtb = new System.Windows.Forms.RichTextBox();
            this.suggest_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.remarks_rtb = new System.Windows.Forms.RichTextBox();
            this.changeablemonth_label = new System.Windows.Forms.Label();
            this.hour_textbox = new System.Windows.Forms.TextBox();
            this.min_tb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pm_btn = new System.Windows.Forms.Button();
            this.am_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkby_textfield
            // 
            this.checkby_textfield.Location = new System.Drawing.Point(254, 28);
            this.checkby_textfield.Name = "checkby_textfield";
            this.checkby_textfield.Size = new System.Drawing.Size(224, 20);
            this.checkby_textfield.TabIndex = 2;
            this.checkby_textfield.TextChanged += new System.EventHandler(this.checkby_textfield_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Checked by:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // isdefect_toggle_btn
            // 
            this.isdefect_toggle_btn.BackColor = System.Drawing.Color.Khaki;
            this.isdefect_toggle_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.isdefect_toggle_btn.FlatAppearance.BorderSize = 3;
            this.isdefect_toggle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isdefect_toggle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isdefect_toggle_btn.Location = new System.Drawing.Point(96, 31);
            this.isdefect_toggle_btn.Name = "isdefect_toggle_btn";
            this.isdefect_toggle_btn.Size = new System.Drawing.Size(123, 126);
            this.isdefect_toggle_btn.TabIndex = 4;
            this.isdefect_toggle_btn.Text = "DEFECTIVE";
            this.isdefect_toggle_btn.UseVisualStyleBackColor = false;
            this.isdefect_toggle_btn.Click += new System.EventHandler(this.isdefect_toggle_btn_Click);
            // 
            // defective_description_rtb
            // 
            this.defective_description_rtb.Location = new System.Drawing.Point(520, 71);
            this.defective_description_rtb.Name = "defective_description_rtb";
            this.defective_description_rtb.Size = new System.Drawing.Size(210, 83);
            this.defective_description_rtb.TabIndex = 5;
            this.defective_description_rtb.Text = "";
            this.defective_description_rtb.TextChanged += new System.EventHandler(this.defective_description_rtb_TextChanged);
            // 
            // defective_tb
            // 
            this.defective_tb.Location = new System.Drawing.Point(520, 28);
            this.defective_tb.Name = "defective_tb";
            this.defective_tb.Size = new System.Drawing.Size(210, 20);
            this.defective_tb.TabIndex = 6;
            this.defective_tb.TextChanged += new System.EventHandler(this.defective_tb_TextChanged_1);
            // 
            // defectivepart_label
            // 
            this.defectivepart_label.AutoSize = true;
            this.defectivepart_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defectivepart_label.ForeColor = System.Drawing.Color.White;
            this.defectivepart_label.Location = new System.Drawing.Point(517, 8);
            this.defectivepart_label.Name = "defectivepart_label";
            this.defectivepart_label.Size = new System.Drawing.Size(108, 17);
            this.defectivepart_label.TabIndex = 7;
            this.defectivepart_label.Text = "Defective Parts:";
            this.defectivepart_label.Click += new System.EventHandler(this.defectivepart_label_Click);
            // 
            // defectivedesc_label
            // 
            this.defectivedesc_label.AutoSize = true;
            this.defectivedesc_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defectivedesc_label.ForeColor = System.Drawing.Color.White;
            this.defectivedesc_label.Location = new System.Drawing.Point(517, 50);
            this.defectivedesc_label.Name = "defectivedesc_label";
            this.defectivedesc_label.Size = new System.Drawing.Size(142, 17);
            this.defectivedesc_label.TabIndex = 8;
            this.defectivedesc_label.Text = "Defective Description";
            this.defectivedesc_label.Click += new System.EventHandler(this.defectivedesc_label_Click);
            // 
            // suggestion_rtb
            // 
            this.suggestion_rtb.Location = new System.Drawing.Point(763, 29);
            this.suggestion_rtb.Name = "suggestion_rtb";
            this.suggestion_rtb.Size = new System.Drawing.Size(210, 124);
            this.suggestion_rtb.TabIndex = 9;
            this.suggestion_rtb.Text = "";
            this.suggestion_rtb.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // suggest_label
            // 
            this.suggest_label.AutoSize = true;
            this.suggest_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggest_label.ForeColor = System.Drawing.Color.White;
            this.suggest_label.Location = new System.Drawing.Point(760, 8);
            this.suggest_label.Name = "suggest_label";
            this.suggest_label.Size = new System.Drawing.Size(209, 17);
            this.suggest_label.TabIndex = 10;
            this.suggest_label.Text = "Suggested Replacement/Repair";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Overall Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1002, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Remarks / Analysis";
            // 
            // remarks_rtb
            // 
            this.remarks_rtb.Location = new System.Drawing.Point(1005, 29);
            this.remarks_rtb.Name = "remarks_rtb";
            this.remarks_rtb.Size = new System.Drawing.Size(210, 124);
            this.remarks_rtb.TabIndex = 14;
            this.remarks_rtb.Text = "";
            // 
            // changeablemonth_label
            // 
            this.changeablemonth_label.AutoSize = true;
            this.changeablemonth_label.ForeColor = System.Drawing.Color.White;
            this.changeablemonth_label.Location = new System.Drawing.Point(12, 9);
            this.changeablemonth_label.Name = "changeablemonth_label";
            this.changeablemonth_label.Size = new System.Drawing.Size(47, 13);
            this.changeablemonth_label.TabIndex = 16;
            this.changeablemonth_label.Text = "MONTH";
            // 
            // hour_textbox
            // 
            this.hour_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour_textbox.Location = new System.Drawing.Point(18, 19);
            this.hour_textbox.MaxLength = 2;
            this.hour_textbox.Name = "hour_textbox";
            this.hour_textbox.Size = new System.Drawing.Size(63, 45);
            this.hour_textbox.TabIndex = 20;
            this.hour_textbox.Text = "12";
            this.hour_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hour_textbox.TextChanged += new System.EventHandler(this.hour_tb_TextChanged);
            // 
            // min_tb
            // 
            this.min_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_tb.Location = new System.Drawing.Point(99, 19);
            this.min_tb.MaxLength = 2;
            this.min_tb.Name = "min_tb";
            this.min_tb.Size = new System.Drawing.Size(63, 45);
            this.min_tb.TabIndex = 21;
            this.min_tb.Text = "59";
            this.min_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.min_tb.TextChanged += new System.EventHandler(this.min_tb_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.pm_btn);
            this.panel1.Controls.Add(this.am_btn);
            this.panel1.Controls.Add(this.min_tb);
            this.panel1.Controls.Add(this.hour_textbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(254, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 88);
            this.panel1.TabIndex = 22;
            // 
            // pm_btn
            // 
            this.pm_btn.Location = new System.Drawing.Point(168, 43);
            this.pm_btn.Name = "pm_btn";
            this.pm_btn.Size = new System.Drawing.Size(43, 23);
            this.pm_btn.TabIndex = 26;
            this.pm_btn.Text = "PM";
            this.pm_btn.UseVisualStyleBackColor = true;
            this.pm_btn.Click += new System.EventHandler(this.pm_btn_Click);
            // 
            // am_btn
            // 
            this.am_btn.Location = new System.Drawing.Point(168, 18);
            this.am_btn.Name = "am_btn";
            this.am_btn.Size = new System.Drawing.Size(43, 23);
            this.am_btn.TabIndex = 25;
            this.am_btn.Text = "AM";
            this.am_btn.UseVisualStyleBackColor = true;
            this.am_btn.Click += new System.EventHandler(this.am_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(73, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 54);
            this.label5.TabIndex = 24;
            this.label5.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(251, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Time";
            // 
            // Item_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1271, 166);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.changeablemonth_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.remarks_rtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.suggest_label);
            this.Controls.Add(this.suggestion_rtb);
            this.Controls.Add(this.defective_tb);
            this.Controls.Add(this.defective_description_rtb);
            this.Controls.Add(this.defectivepart_label);
            this.Controls.Add(this.defectivedesc_label);
            this.Controls.Add(this.isdefect_toggle_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkby_textfield);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Item_Record";
            this.Text = "Item_Record";
            this.Load += new System.EventHandler(this.Item_Record_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox checkby_textfield;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button isdefect_toggle_btn;
        private System.Windows.Forms.RichTextBox defective_description_rtb;
        private System.Windows.Forms.TextBox defective_tb;
        private System.Windows.Forms.Label defectivepart_label;
        private System.Windows.Forms.Label defectivedesc_label;
        private System.Windows.Forms.RichTextBox suggestion_rtb;
        private System.Windows.Forms.Label suggest_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox remarks_rtb;
        private System.Windows.Forms.Label changeablemonth_label;
        private System.Windows.Forms.TextBox hour_textbox;
        private System.Windows.Forms.TextBox min_tb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button am_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pm_btn;
    }
}