namespace COMBINE_CHECKLIST_2024.Sections.MachineHistoryViewer
{
    partial class QuickSelection
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
            this.machine_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monitor_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.location_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.month_cb = new System.Windows.Forms.ComboBox();
            this.year_cb = new System.Windows.Forms.ComboBox();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // machine_cb
            // 
            this.machine_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.machine_cb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.machine_cb.FormattingEnabled = true;
            this.machine_cb.Location = new System.Drawing.Point(99, 12);
            this.machine_cb.Name = "machine_cb";
            this.machine_cb.Size = new System.Drawing.Size(122, 21);
            this.machine_cb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Machine Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monitored By";
            // 
            // monitor_cb
            // 
            this.monitor_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monitor_cb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.monitor_cb.FormattingEnabled = true;
            this.monitor_cb.Location = new System.Drawing.Point(99, 39);
            this.monitor_cb.Name = "monitor_cb";
            this.monitor_cb.Size = new System.Drawing.Size(122, 21);
            this.monitor_cb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Location";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // location_cb
            // 
            this.location_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.location_cb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.location_cb.FormattingEnabled = true;
            this.location_cb.Location = new System.Drawing.Point(99, 66);
            this.location_cb.Name = "location_cb";
            this.location_cb.Size = new System.Drawing.Size(122, 21);
            this.location_cb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date";
            // 
            // month_cb
            // 
            this.month_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.month_cb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.month_cb.FormattingEnabled = true;
            this.month_cb.Location = new System.Drawing.Point(99, 94);
            this.month_cb.Name = "month_cb";
            this.month_cb.Size = new System.Drawing.Size(61, 21);
            this.month_cb.TabIndex = 6;
            // 
            // year_cb
            // 
            this.year_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.year_cb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.year_cb.FormattingEnabled = true;
            this.year_cb.Location = new System.Drawing.Point(166, 94);
            this.year_cb.Name = "year_cb";
            this.year_cb.Size = new System.Drawing.Size(55, 21);
            this.year_cb.TabIndex = 8;
            // 
            // confirm_btn
            // 
            this.confirm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm_btn.Location = new System.Drawing.Point(155, 130);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(75, 30);
            this.confirm_btn.TabIndex = 9;
            this.confirm_btn.Text = "CONFIRM";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Location = new System.Drawing.Point(74, 130);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 30);
            this.cancel_btn.TabIndex = 10;
            this.cancel_btn.Text = "CANCEL";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // QuickSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 165);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.year_cb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.month_cb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.location_cb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monitor_cb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.machine_cb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QuickSelection";
            this.Text = "Quick Select";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox machine_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox monitor_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox location_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox month_cb;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.ComboBox year_cb;
    }
}