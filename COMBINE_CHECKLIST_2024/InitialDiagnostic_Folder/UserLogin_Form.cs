using COMBINE_CHECKLIST_2024.SQLFolder;
using SQL_Connection_support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMBINE_CHECKLIST_2024.InitialDiagnostic_Folder
{
    public partial class UserLogin_Form: Form
    {
        SQL_Support sql;
        private savecacheHandler savecache = new savecacheHandler();
        public UserLogin_Form()
        {
            InitializeComponent();
            this.Disposed += exit_application;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            savecache.EditUser(user_tb.Text);
            savecache.EditUser(password_tb.Text);
            sql = new SQL_Support(savecache.ConnectionString, "GOODYEAR_MACHINE_HISTORY", savecache.User, savecache.Password);
            if (sql.CanAccessSql())
            {
                password_tb.Text = "";
                this.Disposed -= exit_application;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Wrong user or Password");
            }
            
        }

        private void exit_application(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stuck_ll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            savecache.EditConnection("none");
            Application.Restart();
        }
    }
}
