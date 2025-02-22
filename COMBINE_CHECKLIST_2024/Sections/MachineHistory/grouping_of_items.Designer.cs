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
            this.SuspendLayout();
            // 
            // flowlayoutpanel
            // 
            this.flowlayoutpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowlayoutpanel.AutoScroll = true;
            this.flowlayoutpanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowlayoutpanel.Location = new System.Drawing.Point(-2, 41);
            this.flowlayoutpanel.Name = "flowlayoutpanel";
            this.flowlayoutpanel.Size = new System.Drawing.Size(1278, 162);
            this.flowlayoutpanel.TabIndex = 0;
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
            // grouping_of_items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 201);
            this.Controls.Add(this.deletegroup_btn);
            this.Controls.Add(this.flowlayoutpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "grouping_of_items";
            this.Text = "grouping_of_items";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowlayoutpanel;
        private System.Windows.Forms.Button deletegroup_btn;
    }
}