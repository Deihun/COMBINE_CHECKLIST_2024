namespace COMBINE_CHECKLIST_2024.Sections.MachineHistory
{
    partial class grouping_of_items
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
            this.flowlayoutpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.deletegroup_btn = new System.Windows.Forms.Button();
            this.location_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.machinename_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.monitored_tb = new System.Windows.Forms.TextBox();
            this.changeable_date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowlayoutpanel
            // 
            this.flowlayoutpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowlayoutpanel.AutoScroll = true;
            this.flowlayoutpanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowlayoutpanel.Location = new System.Drawing.Point(-2, 46);
            this.flowlayoutpanel.Name = "flowlayoutpanel";
            this.flowlayoutpanel.Size = new System.Drawing.Size(1278, 162);
            this.flowlayoutpanel.TabIndex = 0;
            this.flowlayoutpanel.WrapContents = false;
            // 
            // deletegroup_btn
            // 
            this.deletegroup_btn.Location = new System.Drawing.Point(1282, 12);
            this.deletegroup_btn.Name = "deletegroup_btn";
            this.deletegroup_btn.Size = new System.Drawing.Size(75, 36);
            this.deletegroup_btn.TabIndex = 1;
            this.deletegroup_btn.Text = "DELETE";
            this.deletegroup_btn.UseVisualStyleBackColor = true;
            this.deletegroup_btn.Click += new System.EventHandler(this.deletegroup_btn_Click);
            // 
            // location_tb
            // 
            this.location_tb.Location = new System.Drawing.Point(10, 20);
            this.location_tb.Name = "location_tb";
            this.location_tb.Size = new System.Drawing.Size(149, 20);
            this.location_tb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Machine-Name:";
            // 
            // machinename_tb
            // 
            this.machinename_tb.Location = new System.Drawing.Point(183, 20);
            this.machinename_tb.Name = "machinename_tb";
            this.machinename_tb.Size = new System.Drawing.Size(149, 20);
            this.machinename_tb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Monitored by:";
            // 
            // monitored_tb
            // 
            this.monitored_tb.Location = new System.Drawing.Point(366, 20);
            this.monitored_tb.Name = "monitored_tb";
            this.monitored_tb.Size = new System.Drawing.Size(149, 20);
            this.monitored_tb.TabIndex = 6;
            // 
            // changeable_date
            // 
            this.changeable_date.AutoSize = true;
            this.changeable_date.Location = new System.Drawing.Point(1183, 24);
            this.changeable_date.Name = "changeable_date";
            this.changeable_date.Size = new System.Drawing.Size(48, 13);
            this.changeable_date.TabIndex = 0;
            this.changeable_date.Text = "<DATE>";
            // 
            // grouping_of_items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 220);
            this.Controls.Add(this.changeable_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monitored_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.machinename_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.location_tb);
            this.Controls.Add(this.deletegroup_btn);
            this.Controls.Add(this.flowlayoutpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "grouping_of_items";
            this.Text = "grouping_of_items";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowlayoutpanel;
        private System.Windows.Forms.Button deletegroup_btn;
        private System.Windows.Forms.TextBox location_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox machinename_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox monitored_tb;
        private System.Windows.Forms.Label changeable_date;
    }
}