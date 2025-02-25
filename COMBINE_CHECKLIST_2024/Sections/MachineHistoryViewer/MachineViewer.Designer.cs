namespace COMBINE_CHECKLIST_2024.Sections.MachineHistoryViewer
{
    partial class MachineViewer
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
            this.button_container_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.dataPerSection = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_container_flp
            // 
            this.button_container_flp.AutoScroll = true;
            this.button_container_flp.BackColor = System.Drawing.Color.SeaGreen;
            this.button_container_flp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.button_container_flp.Location = new System.Drawing.Point(12, 71);
            this.button_container_flp.Name = "button_container_flp";
            this.button_container_flp.Size = new System.Drawing.Size(220, 953);
            this.button_container_flp.TabIndex = 1;
            // 
            // dataPerSection
            // 
            this.dataPerSection.Location = new System.Drawing.Point(248, 12);
            this.dataPerSection.Name = "dataPerSection";
            this.dataPerSection.Size = new System.Drawing.Size(1350, 964);
            this.dataPerSection.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1496, 984);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "PRINT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MachineViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1610, 1047);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataPerSection);
            this.Controls.Add(this.button_container_flp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MachineViewer";
            this.Text = "MachineViewer";
            this.Load += new System.EventHandler(this.MachineViewer_Load);
            this.VisibleChanged += new System.EventHandler(this.MachineViewer_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel button_container_flp;
        private System.Windows.Forms.FlowLayoutPanel dataPerSection;
        private System.Windows.Forms.Button button1;
    }
}