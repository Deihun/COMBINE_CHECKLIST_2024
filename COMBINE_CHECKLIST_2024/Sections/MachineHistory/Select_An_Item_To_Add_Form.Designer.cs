﻿namespace COMBINE_CHECKLIST_2024.Sections.MachineHistory
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
            this.contex_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.contex_flp.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_flp
            // 
            this.data_flp.AutoScroll = true;
            this.data_flp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.data_flp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.data_flp.Location = new System.Drawing.Point(4, 4);
            this.data_flp.Margin = new System.Windows.Forms.Padding(0);
            this.data_flp.Name = "data_flp";
            this.data_flp.Padding = new System.Windows.Forms.Padding(10);
            this.data_flp.Size = new System.Drawing.Size(350, 555);
            this.data_flp.TabIndex = 0;
            this.data_flp.WrapContents = false;
            // 
            // confirm_btn
            // 
            this.confirm_btn.Location = new System.Drawing.Point(4, 565);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(101, 27);
            this.confirm_btn.TabIndex = 1;
            this.confirm_btn.Text = "CONFIRM";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.contex_flp);
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
            // contex_flp
            // 
            this.contex_flp.AutoScroll = true;
            this.contex_flp.Controls.Add(this.label1);
            this.contex_flp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.contex_flp.Location = new System.Drawing.Point(20, 42);
            this.contex_flp.Name = "contex_flp";
            this.contex_flp.Size = new System.Drawing.Size(309, 495);
            this.contex_flp.TabIndex = 4;
            this.contex_flp.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT AN ITEM";
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
            this.contex_flp.ResumeLayout(false);
            this.contex_flp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel data_flp;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add_new_item_btn;
        private System.Windows.Forms.FlowLayoutPanel contex_flp;
        private System.Windows.Forms.Label label1;
    }
}