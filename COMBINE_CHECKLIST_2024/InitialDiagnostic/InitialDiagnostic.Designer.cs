namespace COMBINE_CHECKLIST_2024.InitialDiagnostics
{
    partial class InitialDiagnostic
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.exit = new System.Windows.Forms.Button();
            this.createDatabase = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "ERROR: UNABLE TO DETECT LOCALDBEXPRESS! PLEASE INSTALL\r\n AND SETUP THE LOCALDB EX" +
    "PRESS FIRST! ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "ERROR: UNABLE TO DETECT MICROSOFT_EXCEL_OFFICE!\r\nPLEASE INSTALL MICROSOFT_EXCEL_O" +
    "FFICE.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "ERROR: UNABLE TO DETECT DATABASE NAME \r\nMATCHING THE SYSTEM USED. \r\n";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(278, 125);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(47, 143);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 3;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // createDatabase
            // 
            this.createDatabase.Location = new System.Drawing.Point(128, 143);
            this.createDatabase.Name = "createDatabase";
            this.createDatabase.Size = new System.Drawing.Size(134, 23);
            this.createDatabase.TabIndex = 4;
            this.createDatabase.Text = "CREATE DATABASE";
            this.createDatabase.UseVisualStyleBackColor = true;
            this.createDatabase.Click += new System.EventHandler(this.createDatabase_Click);
            // 
            // InitialDiagnostic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 176);
            this.Controls.Add(this.createDatabase);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InitialDiagnostic";
            this.Text = "WARNING!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InitialDiagnostic_FormClosed);
            this.Load += new System.EventHandler(this.InitialDiagnostic_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button createDatabase;
    }
}