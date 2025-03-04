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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.applychange_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.enableDateTime_cb = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.selectioncontainer_panel = new System.Windows.Forms.Panel();
            this.selectioncontainer_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID: 1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.PaleGreen;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(218, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1147, 769);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // applychange_btn
            // 
            this.applychange_btn.Location = new System.Drawing.Point(1217, 801);
            this.applychange_btn.Name = "applychange_btn";
            this.applychange_btn.Size = new System.Drawing.Size(148, 61);
            this.applychange_btn.TabIndex = 0;
            this.applychange_btn.Text = "Apply Changes";
            this.applychange_btn.UseVisualStyleBackColor = true;
            this.applychange_btn.Click += new System.EventHandler(this.applychange_btn_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.SeaGreen;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 70);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(212, 779);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search Filter";
            // 
            // search_tb
            // 
            this.search_tb.Location = new System.Drawing.Point(1, 20);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(203, 20);
            this.search_tb.TabIndex = 5;
            this.search_tb.TextChanged += new System.EventHandler(this.search_tb_TextChanged);
            // 
            // enableDateTime_cb
            // 
            this.enableDateTime_cb.AutoSize = true;
            this.enableDateTime_cb.Location = new System.Drawing.Point(1, 46);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // selectioncontainer_panel
            // 
            this.selectioncontainer_panel.Controls.Add(this.label2);
            this.selectioncontainer_panel.Controls.Add(this.flowLayoutPanel2);
            this.selectioncontainer_panel.Controls.Add(this.dateTimePicker1);
            this.selectioncontainer_panel.Controls.Add(this.search_tb);
            this.selectioncontainer_panel.Controls.Add(this.enableDateTime_cb);
            this.selectioncontainer_panel.Location = new System.Drawing.Point(0, 11);
            this.selectioncontainer_panel.Name = "selectioncontainer_panel";
            this.selectioncontainer_panel.Size = new System.Drawing.Size(212, 849);
            this.selectioncontainer_panel.TabIndex = 8;
            // 
            // EditDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1377, 861);
            this.Controls.Add(this.selectioncontainer_panel);
            this.Controls.Add(this.applychange_btn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditDataForm";
            this.Text = "Edit Data";
            this.Load += new System.EventHandler(this.EditDataForm_Load);
            this.VisibleChanged += new System.EventHandler(this.EditDataForm_VisibleChanged);
            this.Resize += new System.EventHandler(this.EditDataForm_Resize);
            this.selectioncontainer_panel.ResumeLayout(false);
            this.selectioncontainer_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button applychange_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.CheckBox enableDateTime_cb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel selectioncontainer_panel;
    }
}