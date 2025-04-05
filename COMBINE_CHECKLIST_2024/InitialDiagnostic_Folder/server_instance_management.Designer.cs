namespace COMBINE_CHECKLIST_2024.InitialDiagnostic
{
    partial class server_instance_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(server_instance_management));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_setup = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.warning_sql_not_installed = new System.Windows.Forms.Label();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connecttoOther_radiobutton = new System.Windows.Forms.RadioButton();
            this.selfhost_radiobutton = new System.Windows.Forms.RadioButton();
            this.panel_TableCreation = new System.Windows.Forms.Panel();
            this.createtable_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel_setup.SuspendLayout();
            this.panel_TableCreation.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel_setup);
            this.flowLayoutPanel1.Controls.Add(this.panel_TableCreation);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 303);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panel_setup
            // 
            this.panel_setup.Controls.Add(this.exit_btn);
            this.panel_setup.Controls.Add(this.warning_sql_not_installed);
            this.panel_setup.Controls.Add(this.confirm_btn);
            this.panel_setup.Controls.Add(this.label2);
            this.panel_setup.Controls.Add(this.textBox1);
            this.panel_setup.Controls.Add(this.label1);
            this.panel_setup.Controls.Add(this.connecttoOther_radiobutton);
            this.panel_setup.Controls.Add(this.selfhost_radiobutton);
            this.panel_setup.Location = new System.Drawing.Point(3, 3);
            this.panel_setup.Name = "panel_setup";
            this.panel_setup.Size = new System.Drawing.Size(797, 300);
            this.panel_setup.TabIndex = 0;
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(529, 265);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(129, 30);
            this.exit_btn.TabIndex = 7;
            this.exit_btn.Text = "EXIT";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // warning_sql_not_installed
            // 
            this.warning_sql_not_installed.AutoSize = true;
            this.warning_sql_not_installed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.warning_sql_not_installed.Location = new System.Drawing.Point(420, 157);
            this.warning_sql_not_installed.Name = "warning_sql_not_installed";
            this.warning_sql_not_installed.Size = new System.Drawing.Size(230, 13);
            this.warning_sql_not_installed.TabIndex = 6;
            this.warning_sql_not_installed.Text = "SQL-EXPRESS- is missing or not in your device";
            this.warning_sql_not_installed.Visible = false;
            // 
            // confirm_btn
            // 
            this.confirm_btn.Location = new System.Drawing.Point(664, 265);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(129, 30);
            this.confirm_btn.TabIndex = 5;
            this.confirm_btn.Text = "CONFIRM";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SERVER NAME";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // connecttoOther_radiobutton
            // 
            this.connecttoOther_radiobutton.AutoSize = true;
            this.connecttoOther_radiobutton.Checked = true;
            this.connecttoOther_radiobutton.Location = new System.Drawing.Point(31, 24);
            this.connecttoOther_radiobutton.Name = "connecttoOther_radiobutton";
            this.connecttoOther_radiobutton.Size = new System.Drawing.Size(178, 17);
            this.connecttoOther_radiobutton.TabIndex = 1;
            this.connecttoOther_radiobutton.TabStop = true;
            this.connecttoOther_radiobutton.Text = "CONNECT_TO_OTHER_HOST";
            this.connecttoOther_radiobutton.UseVisualStyleBackColor = true;
            // 
            // selfhost_radiobutton
            // 
            this.selfhost_radiobutton.AutoSize = true;
            this.selfhost_radiobutton.Location = new System.Drawing.Point(394, 24);
            this.selfhost_radiobutton.Name = "selfhost_radiobutton";
            this.selfhost_radiobutton.Size = new System.Drawing.Size(107, 17);
            this.selfhost_radiobutton.TabIndex = 0;
            this.selfhost_radiobutton.Text = "USE AS A HOST";
            this.selfhost_radiobutton.UseVisualStyleBackColor = true;
            // 
            // panel_TableCreation
            // 
            this.panel_TableCreation.Controls.Add(this.label5);
            this.panel_TableCreation.Controls.Add(this.label4);
            this.panel_TableCreation.Controls.Add(this.createtable_btn);
            this.panel_TableCreation.Location = new System.Drawing.Point(806, 3);
            this.panel_TableCreation.Name = "panel_TableCreation";
            this.panel_TableCreation.Size = new System.Drawing.Size(778, 300);
            this.panel_TableCreation.TabIndex = 1;
            this.panel_TableCreation.Visible = false;
            // 
            // createtable_btn
            // 
            this.createtable_btn.Location = new System.Drawing.Point(600, 259);
            this.createtable_btn.Name = "createtable_btn";
            this.createtable_btn.Size = new System.Drawing.Size(155, 36);
            this.createtable_btn.TabIndex = 0;
            this.createtable_btn.Text = "CREATE DATABASE";
            this.createtable_btn.UseVisualStyleBackColor = true;
            this.createtable_btn.Click += new System.EventHandler(this.createtable_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "DATABASE CREATION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(618, 85);
            this.label5.TabIndex = 2;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // server_instance_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 303);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "server_instance_management";
            this.Text = "server_instance_management";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel_setup.ResumeLayout(false);
            this.panel_setup.PerformLayout();
            this.panel_TableCreation.ResumeLayout(false);
            this.panel_TableCreation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel_setup;
        private System.Windows.Forms.RadioButton connecttoOther_radiobutton;
        private System.Windows.Forms.RadioButton selfhost_radiobutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label warning_sql_not_installed;
        private System.Windows.Forms.Panel panel_TableCreation;
        private System.Windows.Forms.Button createtable_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}