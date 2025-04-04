namespace COMBINE_CHECKLIST_2024.Sections.MachineHistory
{
    partial class AddIndependent_Item_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.add_on_queue = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(5, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 166);
            this.panel1.TabIndex = 0;
            // 
            // add_on_queue
            // 
            this.add_on_queue.Location = new System.Drawing.Point(5, 204);
            this.add_on_queue.Name = "add_on_queue";
            this.add_on_queue.Size = new System.Drawing.Size(128, 31);
            this.add_on_queue.TabIndex = 1;
            this.add_on_queue.Text = "ADD ON QUEUE";
            this.add_on_queue.UseVisualStyleBackColor = true;
            this.add_on_queue.Click += new System.EventHandler(this.add_on_queue_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // AddIndependent_Item_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 236);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.add_on_queue);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddIndependent_Item_Form";
            this.Text = "Add Item in Queue";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add_on_queue;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}