using COMBINE_CHECKLIST_2024.InitialDiagnostics;
using COMBINE_CHECKLIST_2024.SQLFolder;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.Win32;
using SQL_Connection_support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMBINE_CHECKLIST_2024.InitialDiagnostic
{
    public partial class server_instance_management: Form
    {
        private savecacheHandler savecachehandler = new savecacheHandler();
        public server_instance_management()
        {
            InitializeComponent();
            warning_sql_not_installed.Visible = !IsLocalDBInstalled();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if (connecttoOther_radiobutton.Checked)
            {
                if (!IsServerReachable(textBox1.Text) || CanConnectToDatabase(textBox1.Text, "GOODYEAR_MACHINE_HISTORY"))
                {
                    MessageBox.Show("UNABLE TO CONNECT TO THE GIVEN SERVER NAME: EITHER THE CONNECTION SERVER OR THE DATABASE DOESN'T EXIST");
                    return;
                }
                else
                {

                    savecachehandler.EditConnection(textBox1.Text);
                    this.Parent.Parent.Dispose(); 
                }
            }
            else
            {
                if (CanConnectToDatabase(GetSQLServerInstance(), "GOODYEAR_MACHINE_HISTORY"))
                {
                    MessageBox.Show("IT CAN CONNECT");
                    savecachehandler.EditConnection(GetSQLServerInstance());
                    initialDiagnostic parent =  this.Parent.Parent as initialDiagnostic;
                    parent.Dispose();
                }
                else
                {
                    MessageBox.Show("IT CANT CONNECT");
                    savecachehandler.EditConnection(GetSQLServerInstance());
                    panelpassword_panel.Show();
                    panel_setup.Hide();
                    panel_TableCreation.Hide();
                }
            }
        }
        void CreateDatabase(string server, string dbName)
        {
            if (withuserpassword_rb.Checked)
            {
                savecachehandler.EditUser(user_tb.Text);
                savecachehandler.EditPassword(password_tb.Text);
            }
            else
            {
                savecachehandler.EditUser("");
                savecachehandler.EditPassword("");
            }
            string user = savecachehandler.User;
            string password = savecachehandler.Password;
            bool useSqlAuth = withuserpassword_rb.Checked;

            if (useSqlAuth)
            {
                user = user_tb.Text;
                password = password_tb.Text;
                savecachehandler.EditUser(user);
                savecachehandler.EditPassword(password);
            }
            else
            {
                savecachehandler.EditUser("");
                savecachehandler.EditPassword("");
            }

            string connectionString =  $"Server={server};Database=master;Integrated Security=True;";

            // SQL statements
            string createDbQuery = $"CREATE DATABASE [{dbName}]; ALTER DATABASE [{dbName}] SET ONLINE;";

            // Optional: Only create login and user if SQL Authentication is used
            string createLoginAndUserQuery = useSqlAuth
                ? $@"
        IF NOT EXISTS (SELECT name FROM sys.sql_logins WHERE name = N'{user}')
        BEGIN
            CREATE LOGIN [{user}] WITH PASSWORD = N'{password}', CHECK_POLICY = OFF;
        END;

        USE [{dbName}];

        IF NOT EXISTS (SELECT name FROM sys.database_principals WHERE name = N'{user}')
        BEGIN
            CREATE USER [{user}] FOR LOGIN [{user}];
            EXEC sp_addrolemember N'db_owner', N'{user}';
        END;
        "
                : "";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(createDbQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    if (useSqlAuth && !string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(password))
                    {
                        using (SqlCommand cmd = new SqlCommand(createLoginAndUserQuery, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            panelpassword_panel.Hide();
            panel_TableCreation.Show();
        }

        string GetSQLServerInstance()
        {
            string instanceName = "SQLEXPRESS";
            string registryPath = @"SOFTWARE\Microsoft\Microsoft SQL Server";

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(registryPath))
            {
                if (key != null)
                {
                    object installedInstances = key.GetValue("InstalledInstances");
                    if (installedInstances is string[] instances && instances.Length > 0)
                    {
                        instanceName = instances[0];
                    }
                }
            }

            return $"{Environment.MachineName}\\{instanceName}";
        }

        public bool CanConnectToDatabase(string connectionString, string databaseName)
        {
            string connectionStringWithDatabase = "Server=" +connectionString + $";Initial Catalog={databaseName}; Integrated Security=True;";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStringWithDatabase))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to the database '{databaseName}': {ex.Message}");
                return false;
            }
        }

        public bool IsServerValid(string serverName)
        {
            if (!IsServerReachable(serverName))
            {
                return false;
            }
            return IsSqlServerReachable(serverName);
        }

        private bool IsServerReachable(string serverName)
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send(serverName);

                return reply.Status == IPStatus.Success;
            }
            catch
            {
                return false;
            }
        }

        private bool IsSqlServerReachable(string serverName, int port = 1433)
        {
            try
            {
                using (TcpClient tcpClient = new TcpClient())
                {
                    tcpClient.Connect(serverName, port);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        private bool IsLocalDBInstalled()
        {
            string keyPath = @"SOFTWARE\Microsoft\Microsoft SQL Server Local DB\Installed Versions";
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(keyPath))
            {
                return key != null;
            }
        }

        private void createtable_btn_Click(object sender, EventArgs e)
        {
            SQL_Support sql = new SQL_Support(GetSQLServerInstance(), "GOODYEAR_MACHINE_HISTORY", savecachehandler.User, savecachehandler.Password);
            string query = @" " +
            " CREATE TABLE EXECUTION_HISTORY (" +
                    " id int IDENTITY(1,1)," +
                    " date_commit DATETIME " +
                    "); " +
                "CREATE TABLE HISTORY_(" +
                "HISTORY_ID int IDENTITY(1,1), " +
                "ExecHist_ID int, " +
                "Context VARCHAR(MAX), " +
                "Date_Log DATETIME " +
            "); " +
             "" +
            "CREATE TABLE GROUP_TABLE ( " +
               " GroupID int IDENTITY(1,1), " +
               " From_Date DATETIME, " +
               " To_Date DATETIME, " +
               " Monitored_By VARCHAR(MAX), " +
               " Machine_Name VARCHAR(MAX), " +
               " Location VARCHAR(MAX), " +
              "  historylog_id int " +
           " ); " +
           "  " +
           " CREATE TABLE LOG_MACHINETABLE ( " +
           "     ID int IDENTITY(1,1), " +
           "     groupID int, " +
           "     defect_part VARCHAR(MAX), " +
           "     defec_desc VARCHAR(MAX), " +
           "     suggested_replacement_repair VARCHAR(MAX), " +
           "     remark_analysis VARCHAR(MAX), " +
           "     overall_status BIT, " +
           "     checked_by VARCHAR(MAX), " +
           "     datemark date, " +
           "     target_time VARCHAR(MAX) " +
           " );";

            sql.ExecuteQuery(query);
            Thread.Sleep(1000);
            Application.Restart();
        }

        private void exit_2btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            CreateDatabase(savecachehandler.ConnectionString, "GOODYEAR_MACHINE_HISTORY");
        }

        private void withuserpassword_rb_CheckedChanged(object sender, EventArgs e)
        {
            password_tb.Enabled = withuserpassword_rb.Checked;
            user_tb.Enabled = withuserpassword_rb.Enabled;
        }
    }
}
