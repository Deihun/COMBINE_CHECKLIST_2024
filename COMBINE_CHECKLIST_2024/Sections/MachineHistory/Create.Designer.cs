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
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Chartreuse;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 138);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1609, 833);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // additem_btn
            // 
            this.additem_btn.Location = new System.Drawing.Point(0, 88);
            this.additem_btn.Name = "additem_btn";
            this.additem_btn.Size = new System.Drawing.Size(80, 44);
            this.additem_btn.TabIndex = 1;
            this.additem_btn.Text = "ADD";
            this.additem_btn.UseVisualStyleBackColor = true;
            this.additem_btn.Click += new System.EventHandler(this.additem_btn_Click);
            // 
            // create_new_history_btn
            // 
            this.create_new_history_btn.Location = new System.Drawing.Point(1423, 977);
            this.create_new_history_btn.Name = "create_new_history_btn";
            this.create_new_history_btn.Size = new System.Drawing.Size(175, 58);
            this.create_new_history_btn.TabIndex = 3;
            this.create_new_history_btn.Text = "Create new History";
            this.create_new_history_btn.UseVisualStyleBackColor = true;
            this.create_new_history_btn.Click += new System.EventHandler(this.create_new_history_btn_Click);
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1610, 1047);
            this.Controls.Add(this.create_new_history_btn);
            this.Controls.Add(this.additem_btn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Create";
            this.Text = "Checklist";
            this.Load += new System.EventHandler(this.Create_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button additem_btn;
        private System.Windows.Forms.Button create_new_history_btn;
    }
}