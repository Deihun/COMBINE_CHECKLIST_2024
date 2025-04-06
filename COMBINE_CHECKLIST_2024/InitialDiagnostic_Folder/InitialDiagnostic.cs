using COMBINE_CHECKLIST_2024.InitialDiagnostic;
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
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace COMBINE_CHECKLIST_2024.InitialDiagnostics
{
    public partial class initialDiagnostic: Form
    {
        bool CanRestart = false;
        public initialDiagnostic()
        {
            InitializeComponent();
            createDatabase.Hide();
        }

        bool IsLocalDBInstalled()
        {
            string keyPath = @"SOFTWARE\Microsoft\Microsoft SQL Server Local DB\Installed Versions";
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(keyPath))
            {
                return key != null; 
            }
        }

        bool IsExcelInstalled()
        {
            string[] registryKeys = new string[]
            {
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\excel.exe", // Most common
            @"SOFTWARE\Microsoft\Office\16.0\Excel\InstallRoot", // Office 2016, 2019, 365
            @"SOFTWARE\Microsoft\Office\15.0\Excel\InstallRoot", // Office 2013
            @"SOFTWARE\Microsoft\Office\14.0\Excel\InstallRoot", // Office 2010
            @"SOFTWARE\Microsoft\Office\12.0\Excel\InstallRoot"  // Office 2007
            };

            foreach (string key in registryKeys)
            {
                using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(key))
                {
                    if (registryKey != null)
                    {
                        return true; // Excel is installed
                    }
                }
            }
            return false; // Excel not found
        }


        private void InitialDiagnostic_Load(object sender, EventArgs e)
        {
            var stored_string = new savecacheHandler();
            string _server = stored_string.ConnectionString;
            if (!IsExcelInstalled())
            {
                MicrosoftExcel_Warning microsoftExcel_Warning = new MicrosoftExcel_Warning();
                stored_flp.Controls.Add(microsoftExcel_Warning);
                microsoftExcel_Warning.Show();
            }
            if (_server == "none")
            {
                server_instance_management sim = new server_instance_management();
                sim.TopLevel = false;
                stored_flp.Controls.Add(sim);
                sim.Show();
            }
            if (stored_flp.Controls.Count < 1) this.Dispose();
        }

        private void InitialDiagnostic_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (!CanRestart) Application.Exit();
            //else Application.Restart();
        }

        void CreateDatabase(string server, string dbName)
        {
            string connectionString = $"Server={server};Database=master;Integrated Security=True;";

            string query = $"CREATE DATABASE {dbName};" +
                           $"ALTER DATABASE GOODYEAR_MACHINE_HISTORY SET ONLINE;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                Console.WriteLine($"✅ Database '{dbName}' created successfully!");
                MessageBox.Show("test");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error: {ex.Message}");
            }
        }

        string GetSQLServerInstance()
        {
            string instanceName = "SQLEXPRESS"; // Default instance name
            string registryPath = @"SOFTWARE\Microsoft\Microsoft SQL Server";

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(registryPath))
            {
                if (key != null)
                {
                    object installedInstances = key.GetValue("InstalledInstances");
                    if (installedInstances is string[] instances && instances.Length > 0)
                    {
                        instanceName = instances[0]; // Get first installed instance
                    }
                }
            }

            return $"{Environment.MachineName}\\{instanceName}";
        }

        private void createDatabase_Click(object sender, EventArgs e)
        {
            SQL_Support sql = new SQL_Support(GetSQLServerInstance(), "GOODYEAR_MACHINE_HISTORY");
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
        }
    }
}
