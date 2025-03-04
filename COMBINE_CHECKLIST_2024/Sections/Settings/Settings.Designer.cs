namespace COMBINE_CHECKLIST_2024.Sections.Settings
{
    partial class Setting
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.historyresetconfirm_btn = new System.Windows.Forms.Button();
            this.resetConfirm_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.resetDatabase = new System.Windows.Forms.Button();
            this.timerResetDatabase = new System.Windows.Forms.Timer(this.components);
            this.resetHistorytimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.historyresetconfirm_btn);
            this.groupBox1.Controls.Add(this.resetConfirm_btn);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.resetDatabase);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(143, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database";
            // 
            // historyresetconfirm_btn
            // 
            this.historyresetconfirm_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.historyresetconfirm_btn.Enabled = false;
            this.historyresetconfirm_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.historyresetconfirm_btn.FlatAppearance.BorderSize = 2;
            this.historyresetconfirm_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.historyresetconfirm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyresetconfirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyresetconfirm_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.historyresetconfirm_btn.Location = new System.Drawing.Point(317, 75);
            this.historyresetconfirm_btn.Name = "historyresetconfirm_btn";
            this.historyresetconfirm_btn.Size = new System.Drawing.Size(174, 31);
            this.historyresetconfirm_btn.TabIndex = 3;
            this.historyresetconfirm_btn.Text = "CONFIRM";
            this.historyresetconfirm_btn.UseVisualStyleBackColor = false;
            this.historyresetconfirm_btn.Click += new System.EventHandler(this.historyresetconfirm_btn_Click);
            // 
            // resetConfirm_btn
            // 
            this.resetConfirm_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resetConfirm_btn.Enabled = false;
            this.resetConfirm_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.resetConfirm_btn.FlatAppearance.BorderSize = 2;
            this.resetConfirm_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.resetConfirm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetConfirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetConfirm_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.resetConfirm_btn.Location = new System.Drawing.Point(317, 19);
            this.resetConfirm_btn.Name = "resetConfirm_btn";
            this.resetConfirm_btn.Size = new System.Drawing.Size(174, 31);
            this.resetConfirm_btn.TabIndex = 2;
            this.resetConfirm_btn.Text = "CONFIRM";
            this.resetConfirm_btn.UseVisualStyleBackColor = false;
            this.resetConfirm_btn.Click += new System.EventHandler(this.resetConfirm_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "RESET HISTORY";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetDatabase
            // 
            this.resetDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.resetDatabase.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.resetDatabase.FlatAppearance.BorderSize = 2;
            this.resetDatabase.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.resetDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetDatabase.Location = new System.Drawing.Point(3, 19);
            this.resetDatabase.Name = "resetDatabase";
            this.resetDatabase.Size = new System.Drawing.Size(174, 31);
            this.resetDatabase.TabIndex = 0;
            this.resetDatabase.Text = "RESET DATABASE";
            this.resetDatabase.UseVisualStyleBackColor = false;
            this.resetDatabase.Click += new System.EventHandler(this.resetDatabase_Click);
            // 
            // timerResetDatabase
            // 
            this.timerResetDatabase.Interval = 3000;
            this.timerResetDatabase.Tick += new System.EventHandler(this.timerResetDatabase_Tick);
            // 
            // resetHistorytimer
            // 
            this.resetHistorytimer.Interval = 3000;
            this.resetHistorytimer.Tick += new System.EventHandler(this.resetHistorytimer_Tick);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1780, 1100);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setting";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button resetDatabase;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button historyresetconfirm_btn;
        private System.Windows.Forms.Button resetConfirm_btn;
        private System.Windows.Forms.Timer timerResetDatabase;
        private System.Windows.Forms.Timer resetHistorytimer;
    }
}