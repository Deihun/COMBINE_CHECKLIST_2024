namespace COMBINE_CHECKLIST_2024.Sections.MachineHistory
{
    partial class Select_An_Item_To_Add_Form
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
            this.data_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.add_new_item_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_flp
            // 
            this.data_flp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.data_flp.Location = new System.Drawing.Point(4, 4);
            this.data_flp.Name = "data_flp";
            this.data_flp.Size = new System.Drawing.Size(347, 555);
            this.data_flp.TabIndex = 0;
            // 
            // confirm_btn
            // 
            this.confirm_btn.Location = new System.Drawing.Point(4, 565);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(101, 27);
            this.confirm_btn.TabIndex = 1;
            this.confirm_btn.Text = "CONFIRM";
            this.confirm_btn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.add_new_item_btn);
            this.panel1.Location = new System.Drawing.Point(357, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 555);
            this.panel1.TabIndex = 2;
            // 
            // add_new_item_btn
            // 
            this.add_new_item_btn.Location = new System.Drawing.Point(3, 3);
            this.add_new_item_btn.Name = "add_new_item_btn";
            this.add_new_item_btn.Size = new System.Drawing.Size(133, 33);
            this.add_new_item_btn.TabIndex = 3;
            this.add_new_item_btn.Text = "ADD NEW ITEM";
            this.add_new_item_btn.UseVisualStyleBackColor = true;
            this.add_new_item_btn.Click += new System.EventHandler(this.add_new_item_btn_Click);
            // 
            // Select_An_Item_To_Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 595);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.data_flp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Select_An_Item_To_Add_Form";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel data_flp;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add_new_item_btn;
    }
}