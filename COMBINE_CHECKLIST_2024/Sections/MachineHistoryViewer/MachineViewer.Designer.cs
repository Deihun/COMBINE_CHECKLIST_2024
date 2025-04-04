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
            this.panel1 = new System.Windows.Forms.Panel();
            this.clear_btn = new System.Windows.Forms.Button();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.main_flp = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Page_panel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.back_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.page_label = new System.Windows.Forms.Label();
            this.TotalAmount_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.printOption_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.main_flp.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Page_panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPerSection
            // 
            this.dataPerSection.BackColor = System.Drawing.Color.Transparent;
            this.dataPerSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPerSection.Location = new System.Drawing.Point(0, 100);
            this.dataPerSection.Margin = new System.Windows.Forms.Padding(0);
            this.dataPerSection.Name = "dataPerSection";
            this.dataPerSection.Size = new System.Drawing.Size(1177, 711);
            this.dataPerSection.TabIndex = 0;
            this.dataPerSection.Paint += new System.Windows.Forms.PaintEventHandler(this.dataPerSection_Paint);
            // 
            // btn_singlePrint
            // 
            this.btn_singlePrint.Location = new System.Drawing.Point(175, 2);
            this.btn_singlePrint.Name = "btn_singlePrint";
            this.btn_singlePrint.Size = new System.Drawing.Size(166, 45);
            this.btn_singlePrint.TabIndex = 0;
            this.btn_singlePrint.Text = "PRINT";
            this.btn_singlePrint.UseVisualStyleBackColor = true;
            this.btn_singlePrint.Click += new System.EventHandler(this.btn_singlePrint_Click);
            // 
            // button_container_flp
            // 
            this.button_container_flp.AutoScroll = true;
            this.button_container_flp.BackColor = System.Drawing.Color.YellowGreen;
            this.button_container_flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_container_flp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.button_container_flp.Location = new System.Drawing.Point(0, 100);
            this.button_container_flp.Margin = new System.Windows.Forms.Padding(0);
            this.button_container_flp.Name = "button_container_flp";
            this.button_container_flp.Size = new System.Drawing.Size(200, 711);
            this.button_container_flp.TabIndex = 1;
            this.button_container_flp.WrapContents = false;
            // 
            // searchfilter_tb
            // 
            this.searchfilter_tb.Location = new System.Drawing.Point(4, 22);
            this.searchfilter_tb.Name = "searchfilter_tb";
            this.searchfilter_tb.Size = new System.Drawing.Size(130, 20);
            this.searchfilter_tb.TabIndex = 2;
            this.searchfilter_tb.TextChanged += new System.EventHandler(this.searchfilter_tb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Filter";
            // 
            // date_cb
            // 
            this.date_cb.AutoSize = true;
            this.date_cb.Location = new System.Drawing.Point(5, 51);
            this.date_cb.Name = "date_cb";
            this.date_cb.Size = new System.Drawing.Size(15, 14);
            this.date_cb.TabIndex = 4;
            this.date_cb.UseVisualStyleBackColor = true;
            this.date_cb.CheckedChanged += new System.EventHandler(this.date_cb_CheckedChanged);
            // 
            // DateFilter_dt
            // 
            this.DateFilter_dt.Enabled = false;
            this.DateFilter_dt.Location = new System.Drawing.Point(22, 48);
            this.DateFilter_dt.Name = "DateFilter_dt";
            this.DateFilter_dt.Size = new System.Drawing.Size(112, 20);
            this.DateFilter_dt.TabIndex = 5;
            this.DateFilter_dt.ValueChanged += new System.EventHandler(this.DateFilter_dt_ValueChanged);
            // 
            // printOption_panel
            // 
            this.printOption_panel.Controls.Add(this.createAs_btn);
            this.printOption_panel.Controls.Add(this.btn_singlePrint);
            this.printOption_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printOption_panel.Location = new System.Drawing.Point(827, 0);
            this.printOption_panel.Margin = new System.Windows.Forms.Padding(0);
            this.printOption_panel.Name = "printOption_panel";
            this.printOption_panel.Size = new System.Drawing.Size(350, 50);
            this.printOption_panel.TabIndex = 6;
            this.printOption_panel.Visible = false;
            // 
            // createAs_btn
            // 
            this.createAs_btn.Location = new System.Drawing.Point(7, 2);
            this.createAs_btn.Name = "createAs_btn";
            this.createAs_btn.Size = new System.Drawing.Size(166, 45);
            this.createAs_btn.TabIndex = 1;
            this.createAs_btn.Text = "SAVE FILE";
            this.createAs_btn.UseVisualStyleBackColor = true;
            this.createAs_btn.Click += new System.EventHandler(this.createAs_btn_Click);
            // 
            // bulkPrint_btn
            // 
            this.bulkPrint_btn.Location = new System.Drawing.Point(3, 3);
            this.bulkPrint_btn.Name = "bulkPrint_btn";
            this.bulkPrint_btn.Size = new System.Drawing.Size(94, 43);
            this.bulkPrint_btn.TabIndex = 1;
            this.bulkPrint_btn.Text = "BULK PRINT";
            this.bulkPrint_btn.UseVisualStyleBackColor = true;
            this.bulkPrint_btn.Click += new System.EventHandler(this.bulkPrint_btn_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Transparent;
            series1.Name = "S1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1177, 100);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.clear_btn);
            this.panel1.Controls.Add(this.confirm_btn);
            this.panel1.Controls.Add(this.searchfilter_tb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DateFilter_dt);
            this.panel1.Controls.Add(this.date_cb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(140, 47);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(52, 23);
            this.clear_btn.TabIndex = 7;
            this.clear_btn.Text = "CLEAR";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // confirm_btn
            // 
            this.confirm_btn.Location = new System.Drawing.Point(140, 22);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(52, 23);
            this.confirm_btn.TabIndex = 6;
            this.confirm_btn.Text = "FIND";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // main_flp
            // 
            this.main_flp.BackColor = System.Drawing.Color.Transparent;
            this.main_flp.ColumnCount = 2;
            this.main_flp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.main_flp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.main_flp.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.main_flp.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.main_flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_flp.Location = new System.Drawing.Point(0, 0);
            this.main_flp.Name = "main_flp";
            this.main_flp.RowCount = 1;
            this.main_flp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.main_flp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.main_flp.Size = new System.Drawing.Size(1377, 861);
            this.main_flp.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_container_flp, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Page_panel, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 861);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Page_panel
            // 
            this.Page_panel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Page_panel.Controls.Add(this.flowLayoutPanel1);
            this.Page_panel.Controls.Add(this.page_label);
            this.Page_panel.Controls.Add(this.TotalAmount_label);
            this.Page_panel.Location = new System.Drawing.Point(0, 811);
            this.Page_panel.Margin = new System.Windows.Forms.Padding(0);
            this.Page_panel.Name = "Page_panel";
            this.Page_panel.Size = new System.Drawing.Size(200, 50);
            this.Page_panel.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.back_btn);
            this.flowLayoutPanel1.Controls.Add(this.next_btn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 9);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(110, 35);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(0, 0);
            this.back_btn.Margin = new System.Windows.Forms.Padding(0);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(55, 32);
            this.back_btn.TabIndex = 1;
            this.back_btn.Text = "BACK";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(55, 0);
            this.next_btn.Margin = new System.Windows.Forms.Padding(0);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(55, 32);
            this.next_btn.TabIndex = 0;
            this.next_btn.Text = "NEXT";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // page_label
            // 
            this.page_label.AutoSize = true;
            this.page_label.ForeColor = System.Drawing.Color.White;
            this.page_label.Location = new System.Drawing.Point(110, 10);
            this.page_label.Name = "page_label";
            this.page_label.Size = new System.Drawing.Size(61, 13);
            this.page_label.TabIndex = 1;
            this.page_label.Text = "PAGE: #/#";
            // 
            // TotalAmount_label
            // 
            this.TotalAmount_label.AutoSize = true;
            this.TotalAmount_label.ForeColor = System.Drawing.Color.White;
            this.TotalAmount_label.Location = new System.Drawing.Point(108, 25);
            this.TotalAmount_label.Name = "TotalAmount_label";
            this.TotalAmount_label.Size = new System.Drawing.Size(69, 13);
            this.TotalAmount_label.TabIndex = 2;
            this.TotalAmount_label.Text = "TOTAL: ###";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.chart1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataPerSection, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(200, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1177, 861);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.OliveDrab;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel4.Controls.Add(this.printOption_panel, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.bulkPrint_btn, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 811);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1177, 50);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // MachineViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1377, 861);
            this.Controls.Add(this.main_flp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MachineViewer";
            this.Text = "MachineViewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MachineViewer_Load);
            this.VisibleChanged += new System.EventHandler(this.MachineViewer_VisibleChanged);
            this.printOption_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.main_flp.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.Page_panel.ResumeLayout(false);
            this.Page_panel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel main_flp;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel Page_panel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Label page_label;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label TotalAmount_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button clear_btn;
    }
}