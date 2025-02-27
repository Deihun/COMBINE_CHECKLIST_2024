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
            this.dataPerSection = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_singlePrint = new System.Windows.Forms.Button();
            this.button_container_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.searchfilter_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.date_cb = new System.Windows.Forms.CheckBox();
            this.DateFilter_dt = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.printOption_panel = new System.Windows.Forms.Panel();
            this.bulkPrint_btn = new System.Windows.Forms.Button();
            this.printOption_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPerSection
            // 
            this.dataPerSection.Location = new System.Drawing.Point(248, 12);
            this.dataPerSection.Name = "dataPerSection";
            this.dataPerSection.Size = new System.Drawing.Size(1194, 964);
            this.dataPerSection.TabIndex = 0;
            this.dataPerSection.Paint += new System.Windows.Forms.PaintEventHandler(this.dataPerSection_Paint);
            // 
            // btn_singlePrint
            // 
            this.btn_singlePrint.Location = new System.Drawing.Point(279, 9);
            this.btn_singlePrint.Name = "btn_singlePrint";
            this.btn_singlePrint.Size = new System.Drawing.Size(134, 53);
            this.btn_singlePrint.TabIndex = 0;
            this.btn_singlePrint.Text = "PRINT";
            this.btn_singlePrint.UseVisualStyleBackColor = true;
            // 
            // button_container_flp
            // 
            this.button_container_flp.AutoScroll = true;
            this.button_container_flp.BackColor = System.Drawing.Color.SeaGreen;
            this.button_container_flp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.button_container_flp.Location = new System.Drawing.Point(12, 96);
            this.button_container_flp.Name = "button_container_flp";
            this.button_container_flp.Size = new System.Drawing.Size(230, 928);
            this.button_container_flp.TabIndex = 1;
            this.button_container_flp.WrapContents = false;
            // 
            // searchfilter_tb
            // 
            this.searchfilter_tb.Location = new System.Drawing.Point(12, 31);
            this.searchfilter_tb.Name = "searchfilter_tb";
            this.searchfilter_tb.Size = new System.Drawing.Size(230, 20);
            this.searchfilter_tb.TabIndex = 2;
            this.searchfilter_tb.TextChanged += new System.EventHandler(this.searchfilter_tb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Filter";
            // 
            // date_cb
            // 
            this.date_cb.AutoSize = true;
            this.date_cb.Location = new System.Drawing.Point(12, 60);
            this.date_cb.Name = "date_cb";
            this.date_cb.Size = new System.Drawing.Size(15, 14);
            this.date_cb.TabIndex = 4;
            this.date_cb.UseVisualStyleBackColor = true;
            this.date_cb.CheckedChanged += new System.EventHandler(this.date_cb_CheckedChanged);
            // 
            // DateFilter_dt
            // 
            this.DateFilter_dt.Enabled = false;
            this.DateFilter_dt.Location = new System.Drawing.Point(34, 57);
            this.DateFilter_dt.Name = "DateFilter_dt";
            this.DateFilter_dt.Size = new System.Drawing.Size(200, 20);
            this.DateFilter_dt.TabIndex = 5;
            this.DateFilter_dt.ValueChanged += new System.EventHandler(this.DateFilter_dt_ValueChanged);
            // 
            // printOption_panel
            // 
            this.printOption_panel.Controls.Add(this.bulkPrint_btn);
            this.printOption_panel.Controls.Add(this.btn_singlePrint);
            this.printOption_panel.Location = new System.Drawing.Point(1191, 982);
            this.printOption_panel.Name = "printOption_panel";
            this.printOption_panel.Size = new System.Drawing.Size(423, 69);
            this.printOption_panel.TabIndex = 6;
            this.printOption_panel.Visible = false;
            // 
            // bulkPrint_btn
            // 
            this.bulkPrint_btn.Location = new System.Drawing.Point(3, 9);
            this.bulkPrint_btn.Name = "bulkPrint_btn";
            this.bulkPrint_btn.Size = new System.Drawing.Size(270, 53);
            this.bulkPrint_btn.TabIndex = 1;
            this.bulkPrint_btn.Text = "BULK PRINT";
            this.bulkPrint_btn.UseVisualStyleBackColor = true;
            this.bulkPrint_btn.Click += new System.EventHandler(this.bulkPrint_btn_Click);
            // 
            // MachineViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1610, 1047);
            this.Controls.Add(this.printOption_panel);
            this.Controls.Add(this.DateFilter_dt);
            this.Controls.Add(this.date_cb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchfilter_tb);
            this.Controls.Add(this.dataPerSection);
            this.Controls.Add(this.button_container_flp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MachineViewer";
            this.Text = "MachineViewer";
            this.Load += new System.EventHandler(this.MachineViewer_Load);
            this.VisibleChanged += new System.EventHandler(this.MachineViewer_VisibleChanged);
            this.printOption_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel dataPerSection;
        private System.Windows.Forms.Button btn_singlePrint;
        private System.Windows.Forms.FlowLayoutPanel button_container_flp;
        private System.Windows.Forms.TextBox searchfilter_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox date_cb;
        private System.Windows.Forms.DateTimePicker DateFilter_dt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel printOption_panel;
        private System.Windows.Forms.Button bulkPrint_btn;
    }
}