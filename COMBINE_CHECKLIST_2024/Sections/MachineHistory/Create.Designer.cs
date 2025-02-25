namespace COMBINE_CHECKLIST_2024.Sections.Currugator
{
    partial class Create
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.additem_btn = new System.Windows.Forms.Button();
            this.create_new_history_btn = new System.Windows.Forms.Button();
            this.monitor_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.machine_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.location_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightGreen;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 138);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1609, 833);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // additem_btn
            // 
            this.additem_btn.Location = new System.Drawing.Point(13, 104);
            this.additem_btn.Name = "additem_btn";
            this.additem_btn.Size = new System.Drawing.Size(70, 29);
            this.additem_btn.TabIndex = 1;
            this.additem_btn.Text = "ADD";
            this.additem_btn.UseVisualStyleBackColor = true;
            this.additem_btn.Click += new System.EventHandler(this.additem_btn_Click);
            // 
            // create_new_history_btn
            // 
            this.create_new_history_btn.Location = new System.Drawing.Point(1423, 977);
            this.create_new_history_btn.Name = "create_new_history_btn";
            this.create_new_history_btn.Size = new System.Drawing.Size(175, 58);
            this.create_new_history_btn.TabIndex = 3;
            this.create_new_history_btn.Text = "Create new History";
            this.create_new_history_btn.UseVisualStyleBackColor = true;
            this.create_new_history_btn.Click += new System.EventHandler(this.create_new_history_btn_Click);
            // 
            // monitor_tb
            // 
            this.monitor_tb.Location = new System.Drawing.Point(12, 29);
            this.monitor_tb.Name = "monitor_tb";
            this.monitor_tb.Size = new System.Drawing.Size(137, 20);
            this.monitor_tb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Monitored by:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Machine Name:";
            // 
            // machine_tb
            // 
            this.machine_tb.Location = new System.Drawing.Point(164, 29);
            this.machine_tb.Name = "machine_tb";
            this.machine_tb.Size = new System.Drawing.Size(137, 20);
            this.machine_tb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Location:";
            // 
            // location_tb
            // 
            this.location_tb.Location = new System.Drawing.Point(13, 69);
            this.location_tb.Name = "location_tb";
            this.location_tb.Size = new System.Drawing.Size(137, 20);
            this.location_tb.TabIndex = 8;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1610, 1047);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.location_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.machine_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monitor_tb);
            this.Controls.Add(this.create_new_history_btn);
            this.Controls.Add(this.additem_btn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Create";
            this.Text = "Checklist";
            this.Load += new System.EventHandler(this.Create_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button additem_btn;
        private System.Windows.Forms.Button create_new_history_btn;
        private System.Windows.Forms.TextBox monitor_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox machine_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox location_tb;
    }
}