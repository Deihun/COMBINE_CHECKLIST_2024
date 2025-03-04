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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataPerSection = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_singlePrint = new System.Windows.Forms.Button();
            this.button_container_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.searchfilter_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.date_cb = new System.Windows.Forms.CheckBox();
            this.DateFilter_dt = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.printOption_panel = new System.Windows.Forms.Panel();
            this.createAs_btn = new System.Windows.Forms.Button();
            this.bulkPrint_btn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printOption_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPerSection
            // 
            this.dataPerSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPerSection.Location = new System.Drawing.Point(175, 98);
            this.dataPerSection.Name = "dataPerSection";
            this.dataPerSection.Size = new System.Drawing.Size(1199, 711);
            this.dataPerSection.TabIndex = 0;
            this.dataPerSection.Paint += new System.Windows.Forms.PaintEventHandler(this.dataPerSection_Paint);
            // 
            // btn_singlePrint
            // 
            this.btn_singlePrint.Location = new System.Drawing.Point(175, 2);
            this.btn_singlePrint.Name = "btn_singlePrint";
            this.btn_singlePrint.Size = new System.Drawing.Size(166, 53);
            this.btn_singlePrint.TabIndex = 0;
            this.btn_singlePrint.Text = "PRINT";
            this.btn_singlePrint.UseVisualStyleBackColor = true;
            this.btn_singlePrint.Click += new System.EventHandler(this.btn_singlePrint_Click);
            // 
            // button_container_flp
            // 
            this.button_container_flp.AutoScroll = true;
            this.button_container_flp.BackColor = System.Drawing.Color.SeaGreen;
            this.button_container_flp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.button_container_flp.Location = new System.Drawing.Point(3, 98);
            this.button_container_flp.Name = "button_container_flp";
            this.button_container_flp.Size = new System.Drawing.Size(166, 711);
            this.button_container_flp.TabIndex = 1;
            this.button_container_flp.WrapContents = false;
            // 
            // searchfilter_tb
            // 
            this.searchfilter_tb.Location = new System.Drawing.Point(3, 31);
            this.searchfilter_tb.Name = "searchfilter_tb";
            this.searchfilter_tb.Size = new System.Drawing.Size(160, 20);
            this.searchfilter_tb.TabIndex = 2;
            this.searchfilter_tb.TextChanged += new System.EventHandler(this.searchfilter_tb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Filter";
            // 
            // date_cb
            // 
            this.date_cb.AutoSize = true;
            this.date_cb.Location = new System.Drawing.Point(6, 60);
            this.date_cb.Name = "date_cb";
            this.date_cb.Size = new System.Drawing.Size(15, 14);
            this.date_cb.TabIndex = 4;
            this.date_cb.UseVisualStyleBackColor = true;
            this.date_cb.CheckedChanged += new System.EventHandler(this.date_cb_CheckedChanged);
            // 
            // DateFilter_dt
            // 
            this.DateFilter_dt.Enabled = false;
            this.DateFilter_dt.Location = new System.Drawing.Point(27, 57);
            this.DateFilter_dt.Name = "DateFilter_dt";
            this.DateFilter_dt.Size = new System.Drawing.Size(136, 20);
            this.DateFilter_dt.TabIndex = 5;
            this.DateFilter_dt.ValueChanged += new System.EventHandler(this.DateFilter_dt_ValueChanged);
            // 
            // printOption_panel
            // 
            this.printOption_panel.Controls.Add(this.createAs_btn);
            this.printOption_panel.Controls.Add(this.btn_singlePrint);
            this.printOption_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.printOption_panel.Location = new System.Drawing.Point(1024, 815);
            this.printOption_panel.Name = "printOption_panel";
            this.printOption_panel.Size = new System.Drawing.Size(350, 43);
            this.printOption_panel.TabIndex = 6;
            this.printOption_panel.Visible = false;
            // 
            // createAs_btn
            // 
            this.createAs_btn.Location = new System.Drawing.Point(7, 2);
            this.createAs_btn.Name = "createAs_btn";
            this.createAs_btn.Size = new System.Drawing.Size(166, 53);
            this.createAs_btn.TabIndex = 1;
            this.createAs_btn.Text = "SAVE FILE";
            this.createAs_btn.UseVisualStyleBackColor = true;
            this.createAs_btn.Click += new System.EventHandler(this.createAs_btn_Click);
            // 
            // bulkPrint_btn
            // 
            this.bulkPrint_btn.Location = new System.Drawing.Point(3, 815);
            this.bulkPrint_btn.Name = "bulkPrint_btn";
            this.bulkPrint_btn.Size = new System.Drawing.Size(166, 43);
            this.bulkPrint_btn.TabIndex = 1;
            this.bulkPrint_btn.Text = "BULK PRINT";
            this.bulkPrint_btn.UseVisualStyleBackColor = true;
            this.bulkPrint_btn.Click += new System.EventHandler(this.bulkPrint_btn_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(175, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Transparent;
            series1.Name = "S1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(454, 89);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.5F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.printOption_panel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bulkPrint_btn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_container_flp, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataPerSection, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1377, 861);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchfilter_tb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DateFilter_dt);
            this.panel1.Controls.Add(this.date_cb);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 89);
            this.panel1.TabIndex = 0;
            // 
            // MachineViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1377, 861);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MachineViewer";
            this.Text = "MachineViewer";
            this.Load += new System.EventHandler(this.MachineViewer_Load);
            this.VisibleChanged += new System.EventHandler(this.MachineViewer_VisibleChanged);
            this.printOption_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button createAs_btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}