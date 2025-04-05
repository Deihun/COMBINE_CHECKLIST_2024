namespace COMBINE_CHECKLIST_2024.Sections.Settings
{
    partial class Warning_WithDelayConfirmation
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
            this.cancel_btn = new System.Windows.Forms.Button();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text_label = new System.Windows.Forms.Label();
            this.countdown_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Location = new System.Drawing.Point(0, 158);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(123, 28);
            this.cancel_btn.TabIndex = 0;
            this.cancel_btn.Text = "CANCEL";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // confirm_btn
            // 
            this.confirm_btn.BackColor = System.Drawing.Color.Maroon;
            this.confirm_btn.Enabled = false;
            this.confirm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.confirm_btn.Location = new System.Drawing.Point(232, 156);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(127, 28);
            this.confirm_btn.TabIndex = 1;
            this.confirm_btn.Text = "CONFIRM";
            this.confirm_btn.UseVisualStyleBackColor = false;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.text_label);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 78);
            this.panel1.TabIndex = 2;
            // 
            // text_label
            // 
            this.text_label.AutoSize = true;
            this.text_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.text_label.Location = new System.Drawing.Point(0, 0);
            this.text_label.Name = "text_label";
            this.text_label.Size = new System.Drawing.Size(63, 13);
            this.text_label.TabIndex = 0;
            this.text_label.Text = "<CONTEX>";
            // 
            // countdown_label
            // 
            this.countdown_label.AutoSize = true;
            this.countdown_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdown_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.countdown_label.Location = new System.Drawing.Point(163, 93);
            this.countdown_label.Name = "countdown_label";
            this.countdown_label.Size = new System.Drawing.Size(27, 20);
            this.countdown_label.TabIndex = 3;
            this.countdown_label.Text = "60";
            // 
            // Warning_WithDelayConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 186);
            this.Controls.Add(this.countdown_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.cancel_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Warning_WithDelayConfirmation";
            this.Text = "WARNING";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label text_label;
        private System.Windows.Forms.Label countdown_label;
    }
}