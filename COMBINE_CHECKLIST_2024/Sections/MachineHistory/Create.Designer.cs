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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.changeFilePath = new System.Windows.Forms.Button();
            this.changeFileView_tb = new System.Windows.Forms.TextBox();
            this.open_cb = new System.Windows.Forms.CheckBox();
            this.print_cb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightGreen;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 138);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1627, 833);
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
            this.create_new_history_btn.Location = new System.Drawing.Point(1250, 1004);
            this.create_new_history_btn.Name = "create_new_history_btn";
            this.create_new_history_btn.Size = new System.Drawing.Size(348, 41);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Monitored by:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(164, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // changeFilePath
            // 
            this.changeFilePath.Location = new System.Drawing.Point(1129, 977);
            this.changeFilePath.Name = "changeFilePath";
            this.changeFilePath.Size = new System.Drawing.Size(115, 20);
            this.changeFilePath.TabIndex = 10;
            this.changeFilePath.Text = "Change File Path";
            this.changeFilePath.UseVisualStyleBackColor = true;
            this.changeFilePath.Click += new System.EventHandler(this.changeFilePath_Click);
            // 
            // changeFileView_tb
            // 
            this.changeFileView_tb.Enabled = false;
            this.changeFileView_tb.Location = new System.Drawing.Point(1250, 978);
            this.changeFileView_tb.Name = "changeFileView_tb";
            this.changeFileView_tb.Size = new System.Drawing.Size(347, 20);
            this.changeFileView_tb.TabIndex = 11;
            this.changeFileView_tb.Text = "...";
            // 
            // open_cb
            // 
            this.open_cb.AutoSize = true;
            this.open_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_cb.ForeColor = System.Drawing.Color.White;
            this.open_cb.Location = new System.Drawing.Point(1128, 1004);
            this.open_cb.Name = "open_cb";
            this.open_cb.Size = new System.Drawing.Size(126, 17);
            this.open_cb.TabIndex = 12;
            this.open_cb.Text = "Open Immediately";
            this.open_cb.UseVisualStyleBackColor = true;
            // 
            // print_cb
            // 
            this.print_cb.AutoSize = true;
            this.print_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_cb.ForeColor = System.Drawing.Color.White;
            this.print_cb.Location = new System.Drawing.Point(1128, 1025);
            this.print_cb.Name = "print_cb";
            this.print_cb.Size = new System.Drawing.Size(122, 17);
            this.print_cb.TabIndex = 13;
            this.print_cb.Text = "Print Immediately";
            this.print_cb.UseVisualStyleBackColor = true;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1610, 1047);
            this.Controls.Add(this.create_new_history_btn);
            this.Controls.Add(this.print_cb);
            this.Controls.Add(this.open_cb);
            this.Controls.Add(this.changeFileView_tb);
            this.Controls.Add(this.changeFilePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.location_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.machine_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monitor_tb);
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button changeFilePath;
        private System.Windows.Forms.TextBox changeFileView_tb;
        private System.Windows.Forms.CheckBox open_cb;
        private System.Windows.Forms.CheckBox print_cb;
    }
}