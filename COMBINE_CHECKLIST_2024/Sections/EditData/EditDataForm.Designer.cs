namespace COMBINE_CHECKLIST_2024.Sections.EditData
{
    partial class EditDataForm
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
            this.applychange_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.enableDateTime_cb = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.selectioncontainer_panel = new System.Windows.Forms.Panel();
            this.clear_btn = new System.Windows.Forms.Button();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Page_panel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.back_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.page_label = new System.Windows.Forms.Label();
            this.TotalAmount_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectioncontainer_panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Page_panel.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1177, 321);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // applychange_btn
            // 
            this.applychange_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.applychange_btn.Location = new System.Drawing.Point(1024, 0);
            this.applychange_btn.Name = "applychange_btn";
            this.applychange_btn.Size = new System.Drawing.Size(153, 50);
            this.applychange_btn.TabIndex = 0;
            this.applychange_btn.Text = "Apply Changes";
            this.applychange_btn.UseVisualStyleBackColor = true;
            this.applychange_btn.Click += new System.EventHandler(this.applychange_btn_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.YellowGreen;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 221);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search Filter";
            // 
            // search_tb
            // 
            this.search_tb.Location = new System.Drawing.Point(4, 20);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(141, 20);
            this.search_tb.TabIndex = 5;
            this.search_tb.TextChanged += new System.EventHandler(this.search_tb_TextChanged);
            // 
            // enableDateTime_cb
            // 
            this.enableDateTime_cb.AutoSize = true;
            this.enableDateTime_cb.Location = new System.Drawing.Point(5, 47);
            this.enableDateTime_cb.Name = "enableDateTime_cb";
            this.enableDateTime_cb.Size = new System.Drawing.Size(15, 14);
            this.enableDateTime_cb.TabIndex = 6;
            this.enableDateTime_cb.UseVisualStyleBackColor = true;
            this.enableDateTime_cb.CheckedChanged += new System.EventHandler(this.enableDateTime_cb_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // selectioncontainer_panel
            // 
            this.selectioncontainer_panel.BackColor = System.Drawing.Color.OliveDrab;
            this.selectioncontainer_panel.Controls.Add(this.clear_btn);
            this.selectioncontainer_panel.Controls.Add(this.confirm_btn);
            this.selectioncontainer_panel.Controls.Add(this.label2);
            this.selectioncontainer_panel.Controls.Add(this.dateTimePicker1);
            this.selectioncontainer_panel.Controls.Add(this.search_tb);
            this.selectioncontainer_panel.Controls.Add(this.enableDateTime_cb);
            this.selectioncontainer_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectioncontainer_panel.Location = new System.Drawing.Point(0, 0);
            this.selectioncontainer_panel.Margin = new System.Windows.Forms.Padding(0);
            this.selectioncontainer_panel.Name = "selectioncontainer_panel";
            this.selectioncontainer_panel.Size = new System.Drawing.Size(200, 100);
            this.selectioncontainer_panel.TabIndex = 8;
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(146, 44);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(52, 23);
            this.clear_btn.TabIndex = 9;
            this.clear_btn.Text = "CLEAR";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // confirm_btn
            // 
            this.confirm_btn.Location = new System.Drawing.Point(146, 19);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(52, 23);
            this.confirm_btn.TabIndex = 8;
            this.confirm_btn.Text = "FIND";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1377, 371);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Page_panel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.selectioncontainer_panel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 371);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Page_panel
            // 
            this.Page_panel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Page_panel.Controls.Add(this.flowLayoutPanel3);
            this.Page_panel.Controls.Add(this.page_label);
            this.Page_panel.Controls.Add(this.TotalAmount_label);
            this.Page_panel.Controls.Add(this.label1);
            this.Page_panel.Location = new System.Drawing.Point(0, 321);
            this.Page_panel.Margin = new System.Windows.Forms.Padding(0);
            this.Page_panel.Name = "Page_panel";
            this.Page_panel.Size = new System.Drawing.Size(200, 50);
            this.Page_panel.TabIndex = 9;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.back_btn);
            this.flowLayoutPanel3.Controls.Add(this.next_btn);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(2, 9);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(110, 35);
            this.flowLayoutPanel3.TabIndex = 0;
            this.flowLayoutPanel3.WrapContents = false;
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
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click_1);
            // 
            // page_label
            // 
            this.page_label.AutoSize = true;
            this.page_label.ForeColor = System.Drawing.Color.White;
            this.page_label.Location = new System.Drawing.Point(113, 19);
            this.page_label.Name = "page_label";
            this.page_label.Size = new System.Drawing.Size(61, 13);
            this.page_label.TabIndex = 1;
            this.page_label.Text = "PAGE: #/#";
            // 
            // TotalAmount_label
            // 
            this.TotalAmount_label.AutoSize = true;
            this.TotalAmount_label.ForeColor = System.Drawing.Color.White;
            this.TotalAmount_label.Location = new System.Drawing.Point(108, 33);
            this.TotalAmount_label.Name = "TotalAmount_label";
            this.TotalAmount_label.Size = new System.Drawing.Size(69, 13);
            this.TotalAmount_label.TabIndex = 2;
            this.TotalAmount_label.Text = "TOTAL: ###";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(129, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID: 1";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(200, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1177, 371);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.applychange_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 321);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 50);
            this.panel1.TabIndex = 4;
            // 
            // EditDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(1377, 371);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditDataForm";
            this.Text = "Edit Data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EditDataForm_Load);
            this.VisibleChanged += new System.EventHandler(this.EditDataForm_VisibleChanged);
            this.Resize += new System.EventHandler(this.EditDataForm_Resize);
            this.selectioncontainer_panel.ResumeLayout(false);
            this.selectioncontainer_panel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.Page_panel.ResumeLayout(false);
            this.Page_panel.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button applychange_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.CheckBox enableDateTime_cb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel selectioncontainer_panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel Page_panel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Label page_label;
        private System.Windows.Forms.Label TotalAmount_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button confirm_btn;
    }
}