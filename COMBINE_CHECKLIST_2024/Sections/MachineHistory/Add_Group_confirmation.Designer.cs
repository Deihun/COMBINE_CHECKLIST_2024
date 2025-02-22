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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // from_dtpicker
            // 
            this.from_dtpicker.Location = new System.Drawing.Point(12, 68);
            this.from_dtpicker.Name = "from_dtpicker";
            this.from_dtpicker.Size = new System.Drawing.Size(249, 20);
            this.from_dtpicker.TabIndex = 0;
            // 
            // to_dtpicker
            // 
            this.to_dtpicker.Location = new System.Drawing.Point(12, 114);
            this.to_dtpicker.Name = "to_dtpicker";
            this.to_dtpicker.Size = new System.Drawing.Size(249, 20);
            this.to_dtpicker.TabIndex = 1;
            // 
            // confirmation_btn
            // 
            this.confirmation_btn.Location = new System.Drawing.Point(12, 154);
            this.confirmation_btn.Name = "confirmation_btn";
            this.confirmation_btn.Size = new System.Drawing.Size(96, 34);
            this.confirmation_btn.TabIndex = 2;
            this.confirmation_btn.Text = "Confirm";
            this.confirmation_btn.UseVisualStyleBackColor = true;
            this.confirmation_btn.Click += new System.EventHandler(this.confirmation_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "START";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "END";
            // 
            // Add_Group_confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 200);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.confirmation_btn);
            this.Controls.Add(this.to_dtpicker);
            this.Controls.Add(this.from_dtpicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Group_confirmation";
            this.Text = "MONITORING";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker from_dtpicker;
        private System.Windows.Forms.DateTimePicker to_dtpicker;
        private System.Windows.Forms.Button confirmation_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}