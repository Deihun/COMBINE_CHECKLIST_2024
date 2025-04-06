namespace COMBINE_CHECKLIST_2024.InitialDiagnostics
{
    partial class initialDiagnostic
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
            this.exit = new System.Windows.Forms.Button();
            this.createDatabase = new System.Windows.Forms.Button();
            this.stored_panel = new System.Windows.Forms.Panel();
            this.stored_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(12, 316);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 3;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // createDatabase
            // 
            this.createDatabase.Location = new System.Drawing.Point(93, 316);
            this.createDatabase.Name = "createDatabase";
            this.createDatabase.Size = new System.Drawing.Size(134, 23);
            this.createDatabase.TabIndex = 4;
            this.createDatabase.Text = "CREATE DATABASE";
            this.createDatabase.UseVisualStyleBackColor = true;
            this.createDatabase.Click += new System.EventHandler(this.createDatabase_Click);
            // 
            // stored_panel
            // 
            this.stored_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.stored_panel.Location = new System.Drawing.Point(12, 185);
            this.stored_panel.Name = "stored_panel";
            this.stored_panel.Size = new System.Drawing.Size(561, 298);
            this.stored_panel.TabIndex = 5;
            // 
            // stored_flp
            // 
            this.stored_flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stored_flp.Location = new System.Drawing.Point(0, 0);
            this.stored_flp.Name = "stored_flp";
            this.stored_flp.Size = new System.Drawing.Size(800, 303);
            this.stored_flp.TabIndex = 6;
            this.stored_flp.WrapContents = false;
            // 
            // InitialDiagnostic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 303);
            this.Controls.Add(this.stored_flp);
            this.Controls.Add(this.stored_panel);
            this.Controls.Add(this.createDatabase);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InitialDiagnostic";
            this.Text = "WARNING!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InitialDiagnostic_FormClosed);
            this.Load += new System.EventHandler(this.InitialDiagnostic_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button createDatabase;
        private System.Windows.Forms.Panel stored_panel;
        private System.Windows.Forms.FlowLayoutPanel stored_flp;
    }
}