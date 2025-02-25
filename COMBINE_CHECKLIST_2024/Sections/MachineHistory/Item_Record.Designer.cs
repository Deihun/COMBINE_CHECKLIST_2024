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
            this.hourUp_btn = new System.Windows.Forms.Button();
            this.minUp_btn = new System.Windows.Forms.Button();
            this.hourDown_btn = new System.Windows.Forms.Button();
            this.hour_tb = new System.Windows.Forms.TextBox();
            this.min_tb = new System.Windows.Forms.TextBox();
            this.minDown_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkby_textfield
            // 
            this.checkby_textfield.Location = new System.Drawing.Point(8, 60);
            this.checkby_textfield.Name = "checkby_textfield";
            this.checkby_textfield.Size = new System.Drawing.Size(152, 20);
            this.checkby_textfield.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Checked by:";
            // 
            // isdefect_toggle_btn
            // 
            this.isdefect_toggle_btn.BackColor = System.Drawing.Color.Khaki;
            this.isdefect_toggle_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.isdefect_toggle_btn.FlatAppearance.BorderSize = 3;
            this.isdefect_toggle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isdefect_toggle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isdefect_toggle_btn.Location = new System.Drawing.Point(180, 31);
            this.isdefect_toggle_btn.Name = "isdefect_toggle_btn";
            this.isdefect_toggle_btn.Size = new System.Drawing.Size(123, 126);
            this.isdefect_toggle_btn.TabIndex = 4;
            this.isdefect_toggle_btn.Text = "DEFECTIVE";
            this.isdefect_toggle_btn.UseVisualStyleBackColor = false;
            this.isdefect_toggle_btn.Click += new System.EventHandler(this.isdefect_toggle_btn_Click);
            // 
            // defective_description_rtb
            // 
            this.defective_description_rtb.Location = new System.Drawing.Point(581, 71);
            this.defective_description_rtb.Name = "defective_description_rtb";
            this.defective_description_rtb.Size = new System.Drawing.Size(210, 83);
            this.defective_description_rtb.TabIndex = 5;
            this.defective_description_rtb.Text = "";
            this.defective_description_rtb.TextChanged += new System.EventHandler(this.defective_description_rtb_TextChanged);
            // 
            // defective_tb
            // 
            this.defective_tb.Location = new System.Drawing.Point(581, 28);
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
            this.defectivepart_label.Location = new System.Drawing.Point(578, 8);
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
            this.defectivedesc_label.Location = new System.Drawing.Point(578, 50);
            this.defectivedesc_label.Name = "defectivedesc_label";
            this.defectivedesc_label.Size = new System.Drawing.Size(142, 17);
            this.defectivedesc_label.TabIndex = 8;
            this.defectivedesc_label.Text = "Defective Description";
            this.defectivedesc_label.Click += new System.EventHandler(this.defectivedesc_label_Click);
            // 
            // suggestion_rtb
            // 
            this.suggestion_rtb.Location = new System.Drawing.Point(825, 29);
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
            this.suggest_label.Location = new System.Drawing.Point(822, 8);
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
            this.label2.Location = new System.Drawing.Point(180, 11);
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
            this.label4.Location = new System.Drawing.Point(1041, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Remarks / Analysis";
            // 
            // remarks_rtb
            // 
            this.remarks_rtb.Location = new System.Drawing.Point(1044, 30);
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
            // hourUp_btn
            // 
            this.hourUp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.hourUp_btn.Location = new System.Drawing.Point(357, 73);
            this.hourUp_btn.Name = "hourUp_btn";
            this.hourUp_btn.Size = new System.Drawing.Size(34, 29);
            this.hourUp_btn.TabIndex = 17;
            this.hourUp_btn.Text = "^";
            this.hourUp_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hourUp_btn.UseVisualStyleBackColor = true;
            this.hourUp_btn.Click += new System.EventHandler(this.hourUp_btn_Click);
            // 
            // minUp_btn
            // 
            this.minUp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.minUp_btn.Location = new System.Drawing.Point(427, 74);
            this.minUp_btn.Name = "minUp_btn";
            this.minUp_btn.Size = new System.Drawing.Size(34, 29);
            this.minUp_btn.TabIndex = 18;
            this.minUp_btn.Text = "^";
            this.minUp_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.minUp_btn.UseVisualStyleBackColor = true;
            this.minUp_btn.Click += new System.EventHandler(this.minUp_btn_Click);
            // 
            // hourDown_btn
            // 
            this.hourDown_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.hourDown_btn.Location = new System.Drawing.Point(357, 108);
            this.hourDown_btn.Name = "hourDown_btn";
            this.hourDown_btn.Size = new System.Drawing.Size(34, 29);
            this.hourDown_btn.TabIndex = 19;
            this.hourDown_btn.Text = "v";
            this.hourDown_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hourDown_btn.UseVisualStyleBackColor = true;
            this.hourDown_btn.Click += new System.EventHandler(this.hourDown_btn_Click);
            // 
            // hour_tb
            // 
            this.hour_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour_tb.Location = new System.Drawing.Point(353, 22);
            this.hour_tb.MaxLength = 2;
            this.hour_tb.Name = "hour_tb";
            this.hour_tb.Size = new System.Drawing.Size(42, 45);
            this.hour_tb.TabIndex = 20;
            this.hour_tb.Text = "22";
            // 
            // min_tb
            // 
            this.min_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_tb.Location = new System.Drawing.Point(422, 22);
            this.min_tb.MaxLength = 2;
            this.min_tb.Name = "min_tb";
            this.min_tb.Size = new System.Drawing.Size(42, 45);
            this.min_tb.TabIndex = 21;
            this.min_tb.Text = "22";
            // 
            // minDown_btn
            // 
            this.minDown_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.minDown_btn.Location = new System.Drawing.Point(427, 108);
            this.minDown_btn.Name = "minDown_btn";
            this.minDown_btn.Size = new System.Drawing.Size(34, 29);
            this.minDown_btn.TabIndex = 22;
            this.minDown_btn.Text = "v";
            this.minDown_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.minDown_btn.UseVisualStyleBackColor = true;
            this.minDown_btn.Click += new System.EventHandler(this.minDown_btn_Click);
            // 
            // Item_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1271, 166);
            this.Controls.Add(this.minDown_btn);
            this.Controls.Add(this.min_tb);
            this.Controls.Add(this.hour_tb);
            this.Controls.Add(this.hourDown_btn);
            this.Controls.Add(this.minUp_btn);
            this.Controls.Add(this.hourUp_btn);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Item_Record";
            this.Text = "Item_Record";
            this.Load += new System.EventHandler(this.Item_Record_Load);
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
        private System.Windows.Forms.Button hourUp_btn;
        private System.Windows.Forms.Button minUp_btn;
        private System.Windows.Forms.Button hourDown_btn;
        private System.Windows.Forms.TextBox hour_tb;
        private System.Windows.Forms.TextBox min_tb;
        private System.Windows.Forms.Button minDown_btn;
    }
}