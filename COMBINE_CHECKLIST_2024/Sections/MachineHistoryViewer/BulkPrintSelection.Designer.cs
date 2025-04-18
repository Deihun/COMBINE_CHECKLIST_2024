﻿namespace COMBINE_CHECKLIST_2024.Sections.MachineHistoryViewer
{
    partial class BulkPrintSelection
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
            this.selection_container_fl = new System.Windows.Forms.FlowLayoutPanel();
            this.web = new System.Windows.Forms.WebBrowser();
            this.print_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.createFile_btn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.specificDate_rd = new System.Windows.Forms.RadioButton();
            this.Dropdownbox_rd = new System.Windows.Forms.RadioButton();
            this.year_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.machineName_cb = new System.Windows.Forms.ComboBox();
            this.v = new System.Windows.Forms.Button();
            this.clearfilter_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monitoredby_cb = new System.Windows.Forms.ComboBox();
            this.location_cb = new System.Windows.Forms.ComboBox();
            this.removeAllSelected_btn = new System.Windows.Forms.Button();
            this.YearCB = new System.Windows.Forms.ComboBox();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.back_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.Page_Label = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selection_container_fl
            // 
            this.selection_container_fl.AutoScroll = true;
            this.selection_container_fl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.selection_container_fl.Location = new System.Drawing.Point(12, 203);
            this.selection_container_fl.Name = "selection_container_fl";
            this.selection_container_fl.Size = new System.Drawing.Size(217, 443);
            this.selection_container_fl.TabIndex = 0;
            this.selection_container_fl.WrapContents = false;
            // 
            // web
            // 
            this.web.Location = new System.Drawing.Point(235, 7);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(1031, 639);
            this.web.TabIndex = 1;
            // 
            // print_btn
            // 
            this.print_btn.Location = new System.Drawing.Point(1123, 648);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(143, 28);
            this.print_btn.TabIndex = 2;
            this.print_btn.Text = "PRINT";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(235, 652);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(143, 24);
            this.cancel_btn.TabIndex = 3;
            this.cancel_btn.Text = "CLOSE";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // createFile_btn
            // 
            this.createFile_btn.Location = new System.Drawing.Point(1012, 648);
            this.createFile_btn.Name = "createFile_btn";
            this.createFile_btn.Size = new System.Drawing.Size(106, 29);
            this.createFile_btn.TabIndex = 5;
            this.createFile_btn.Text = "CREATE FILE";
            this.createFile_btn.UseVisualStyleBackColor = true;
            this.createFile_btn.Click += new System.EventHandler(this.createFile_btn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // specificDate_rd
            // 
            this.specificDate_rd.AutoSize = true;
            this.specificDate_rd.Location = new System.Drawing.Point(8, 45);
            this.specificDate_rd.Name = "specificDate_rd";
            this.specificDate_rd.Size = new System.Drawing.Size(14, 13);
            this.specificDate_rd.TabIndex = 8;
            this.specificDate_rd.UseVisualStyleBackColor = true;
            this.specificDate_rd.CheckedChanged += new System.EventHandler(this.specificDate_rd_CheckedChanged);
            // 
            // Dropdownbox_rd
            // 
            this.Dropdownbox_rd.AutoSize = true;
            this.Dropdownbox_rd.Checked = true;
            this.Dropdownbox_rd.Location = new System.Drawing.Point(8, 68);
            this.Dropdownbox_rd.Name = "Dropdownbox_rd";
            this.Dropdownbox_rd.Size = new System.Drawing.Size(14, 13);
            this.Dropdownbox_rd.TabIndex = 9;
            this.Dropdownbox_rd.TabStop = true;
            this.Dropdownbox_rd.UseVisualStyleBackColor = true;
            this.Dropdownbox_rd.CheckedChanged += new System.EventHandler(this.Dropdownbox_rd_CheckedChanged);
            // 
            // year_cb
            // 
            this.year_cb.AutoCompleteCustomSource.AddRange(new string[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sept",
            "Oct",
            "Nov",
            "Dec"});
            this.year_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.year_cb.FormattingEnabled = true;
            this.year_cb.Items.AddRange(new object[] {
            "",
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sept",
            "Oct",
            "Nov",
            "Dec"});
            this.year_cb.Location = new System.Drawing.Point(120, 144);
            this.year_cb.Name = "year_cb";
            this.year_cb.Size = new System.Drawing.Size(53, 21);
            this.year_cb.TabIndex = 10;
            this.year_cb.SelectedIndexChanged += new System.EventHandler(this.year_cb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Machine Name";
            // 
            // machineName_cb
            // 
            this.machineName_cb.AutoCompleteCustomSource.AddRange(new string[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sept",
            "Oct",
            "Nov",
            "Dec"});
            this.machineName_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.machineName_cb.FormattingEnabled = true;
            this.machineName_cb.Location = new System.Drawing.Point(120, 64);
            this.machineName_cb.Name = "machineName_cb";
            this.machineName_cb.Size = new System.Drawing.Size(109, 21);
            this.machineName_cb.TabIndex = 13;
            this.machineName_cb.SelectedIndexChanged += new System.EventHandler(this.machineName_cb_SelectedIndexChanged);
            // 
            // v
            // 
            this.v.Location = new System.Drawing.Point(8, 7);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(109, 28);
            this.v.TabIndex = 0;
            this.v.Text = "Auto-Select";
            this.v.UseVisualStyleBackColor = true;
            this.v.Click += new System.EventHandler(this.v_Click);
            // 
            // clearfilter_btn
            // 
            this.clearfilter_btn.Location = new System.Drawing.Point(122, 169);
            this.clearfilter_btn.Name = "clearfilter_btn";
            this.clearfilter_btn.Size = new System.Drawing.Size(107, 28);
            this.clearfilter_btn.TabIndex = 14;
            this.clearfilter_btn.Text = "Clear Filter";
            this.clearfilter_btn.UseVisualStyleBackColor = true;
            this.clearfilter_btn.Click += new System.EventHandler(this.clearfilter_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Monitored By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Location";
            // 
            // monitoredby_cb
            // 
            this.monitoredby_cb.AutoCompleteCustomSource.AddRange(new string[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sept",
            "Oct",
            "Nov",
            "Dec"});
            this.monitoredby_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monitoredby_cb.FormattingEnabled = true;
            this.monitoredby_cb.Location = new System.Drawing.Point(120, 91);
            this.monitoredby_cb.Name = "monitoredby_cb";
            this.monitoredby_cb.Size = new System.Drawing.Size(109, 21);
            this.monitoredby_cb.TabIndex = 17;
            this.monitoredby_cb.SelectedIndexChanged += new System.EventHandler(this.monitoredby_cb_SelectedIndexChanged);
            // 
            // location_cb
            // 
            this.location_cb.AutoCompleteCustomSource.AddRange(new string[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sept",
            "Oct",
            "Nov",
            "Dec"});
            this.location_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.location_cb.FormattingEnabled = true;
            this.location_cb.Location = new System.Drawing.Point(120, 117);
            this.location_cb.Name = "location_cb";
            this.location_cb.Size = new System.Drawing.Size(109, 21);
            this.location_cb.TabIndex = 18;
            this.location_cb.SelectedIndexChanged += new System.EventHandler(this.location_cb_SelectedIndexChanged);
            // 
            // removeAllSelected_btn
            // 
            this.removeAllSelected_btn.Location = new System.Drawing.Point(120, 7);
            this.removeAllSelected_btn.Name = "removeAllSelected_btn";
            this.removeAllSelected_btn.Size = new System.Drawing.Size(109, 28);
            this.removeAllSelected_btn.TabIndex = 19;
            this.removeAllSelected_btn.Text = "Deselect All";
            this.removeAllSelected_btn.UseVisualStyleBackColor = true;
            this.removeAllSelected_btn.Click += new System.EventHandler(this.removeAllSelected_btn_Click);
            // 
            // YearCB
            // 
            this.YearCB.AutoCompleteCustomSource.AddRange(new string[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sept",
            "Oct",
            "Nov",
            "Dec"});
            this.YearCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearCB.FormattingEnabled = true;
            this.YearCB.Items.AddRange(new object[] {
            ""});
            this.YearCB.Location = new System.Drawing.Point(179, 145);
            this.YearCB.Name = "YearCB";
            this.YearCB.Size = new System.Drawing.Size(50, 21);
            this.YearCB.TabIndex = 20;
            this.YearCB.SelectedIndexChanged += new System.EventHandler(this.YearCB_SelectedIndexChanged);
            // 
            // confirm_btn
            // 
            this.confirm_btn.Location = new System.Drawing.Point(12, 169);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(107, 28);
            this.confirm_btn.TabIndex = 21;
            this.confirm_btn.Text = "CONFIRM";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.back_btn);
            this.flowLayoutPanel1.Controls.Add(this.next_btn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 648);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(132, 28);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(0, 0);
            this.back_btn.Margin = new System.Windows.Forms.Padding(0);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(65, 24);
            this.back_btn.TabIndex = 5;
            this.back_btn.Text = "BACK";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(65, 0);
            this.next_btn.Margin = new System.Windows.Forms.Padding(0);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(65, 24);
            this.next_btn.TabIndex = 4;
            this.next_btn.Text = "NEXT";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // Page_Label
            // 
            this.Page_Label.AutoSize = true;
            this.Page_Label.Location = new System.Drawing.Point(151, 656);
            this.Page_Label.Name = "Page_Label";
            this.Page_Label.Size = new System.Drawing.Size(40, 13);
            this.Page_Label.TabIndex = 23;
            this.Page_Label.Text = "##/##";
            // 
            // BulkPrintSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 678);
            this.Controls.Add(this.Page_Label);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.YearCB);
            this.Controls.Add(this.removeAllSelected_btn);
            this.Controls.Add(this.clearfilter_btn);
            this.Controls.Add(this.location_cb);
            this.Controls.Add(this.monitoredby_cb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.v);
            this.Controls.Add(this.machineName_cb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.year_cb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dropdownbox_rd);
            this.Controls.Add(this.specificDate_rd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.createFile_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.web);
            this.Controls.Add(this.selection_container_fl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BulkPrintSelection";
            this.Text = "BulkPrintSelection";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel selection_container_fl;
        private System.Windows.Forms.WebBrowser web;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button createFile_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton specificDate_rd;
        private System.Windows.Forms.RadioButton Dropdownbox_rd;
        private System.Windows.Forms.ComboBox year_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox machineName_cb;
        private System.Windows.Forms.Button v;
        private System.Windows.Forms.Button clearfilter_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox monitoredby_cb;
        private System.Windows.Forms.ComboBox location_cb;
        private System.Windows.Forms.Button removeAllSelected_btn;
        private System.Windows.Forms.ComboBox YearCB;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Label Page_Label;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}