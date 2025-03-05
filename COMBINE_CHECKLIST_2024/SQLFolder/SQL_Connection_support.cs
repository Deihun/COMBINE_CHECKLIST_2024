using Microsoft.SqlServer.Management.Smo;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Connection_support
{
    public class SQL_Support
    {
        private readonly string _connection_server;
        public bool _isDebugShow { get; set; }

        public SQL_Support(string server, string database, string user = null, string password = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(password))
                {
                    _connection_server = $"Server={GetSQLServerInstance()};Database={database};User Id={user};Password={password};";
                }
                else
                {
                    _connection_server = $"Server={GetSQLServerInstance()};Database={database};Integrated Security=True;";
                }
            }
            catch (Exception e)
            {
                if (_isDebugShow) Console.WriteLine($"\n\n//ERROR: " + e.Message);
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



        /// <summary>
        /// Executes a SQL query asynchronously and returns the result as a DataTable.
        /// </summary>
        public async Task<DataTable> ExecuteQueryAsync(string query)
        {
            if (_isDebugShow) Console.WriteLine($"Executing Query: {query}");
            using (SqlConnection conn = new SqlConnection(_connection_server))
            {
                await conn.OpenAsync();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        await Task.Run(() => adapter.Fill(dt));
                        return dt;
                    }
                }
            }
        }


        public DataTable ExecuteQuery(string query)
        {
            if (_isDebugShow) Console.WriteLine($"Executing Query: {query}");

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connection_server))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey; // Ensures schema is fully loaded
                        adapter.Fill(dt);
                    }
                }
            }
            Console.WriteLine($"DEBUG// Rows Retrieved: {dt.Rows.Count}");
            return dt;
        }


        /// <summary>
        /// Executes a stored procedure asynchronously and returns the result as a DataTable.
        /// </summary>
        public async Task<DataTable> ExecuteStoredProcedureAsync(string procedureName, params SqlParameter[] parameters)
        {
            if (_isDebugShow) Console.WriteLine($"Executing Stored Procedure: {procedureName}");
            using (SqlConnection conn = new SqlConnection(_connection_server))
            {
                await conn.OpenAsync();
                using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(parameters);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        await Task.Run(() => adapter.Fill(dt));
                        return dt;
                    }
                }
            }
        }

        /// <summary>
        /// Performs bulk insertion of a DataTable into a specified SQL table asynchronously.
        /// </summary>
        public async Task BulkInsertAsync(DataTable dataTable, string destinationTable)
        {
            if (_isDebugShow) Console.WriteLine($"Performing Bulk Insert into {destinationTable}");
            using (SqlConnection conn = new SqlConnection(_connection_server))
            {
                await conn.OpenAsync();
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
                {
                    bulkCopy.DestinationTableName = destinationTable;
                    await bulkCopy.WriteToServerAsync(dataTable);
                }
            }
        }

        /// <summary>
        /// Executes multiple queries within a single transaction asynchronously.
        /// </summary>
        public async Task<bool> ExecuteTransactionAsync(params string[] queries)
        {
            if (_isDebugShow) Console.WriteLine("Executing Transaction");
            using (SqlConnection conn = new SqlConnection(_connection_server))
            {
                await conn.OpenAsync();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        foreach (string query in queries)
                        {
                            using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
                            {
                                await cmd.ExecuteNonQueryAsync();
                            }
                        }
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        /// <summary>
        /// Tests the database connection with multiple retry attempts.
        /// </summary>
        public async Task<bool> TestConnectionWithRetryAsync(int maxAttempts = 3)
        {
            int attempt = 0;
            while (attempt < maxAttempts)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(_connection_server))
                    {
                        await conn.OpenAsync();
                        if (_isDebugShow) Console.WriteLine("Database Connection Successful");
                        return true;
                    }
                }
                catch
                {
                    attempt++;
                    if (_isDebugShow) Console.WriteLine($"Database Connection Attempt {attempt} Failed");
                    await Task.Delay(1000);
                }
            }
            return false;
        }

        /// <summary>
        /// Executes a SQL query asynchronously and logs the query.
        /// </summary>
        public async Task<int> ExecuteNonQueryWithLoggingAsync(string query)
        {
            if (_isDebugShow) Console.WriteLine($"Executing Non-Query with Logging: {query}");
            using (SqlConnection conn = new SqlConnection(_connection_server))
            {
                await conn.OpenAsync();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    int rowsAffected = await cmd.ExecuteNonQueryAsync();
                    await LogQueryAsync(query);
                    return rowsAffected;
                }
            }
        }

        private async Task LogQueryAsync(string query)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Executes a SQL query safely with parameters asynchronously.
        /// </summary>
        public async Task<int> ExecuteNonQuerySafeAsync(string query, params SqlParameter[] parameters)
        {
            if (_isDebugShow) Console.WriteLine($"Executing Safe Non-Query: {query}");
            using (SqlConnection conn = new SqlConnection(_connection_server))
            {
                await conn.OpenAsync();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    return await cmd.ExecuteNonQueryAsync();
                }
            }
        }


        //private async Task LogQueryAsync(string query)
        //{
        //    string logFile = "query_log.txt";
        //    string logEntry = $"{DateTime.Now}: {query}\n";
        //    await File.AppendAllTextAsync(logFile, logEntry);
        //}

        /// <summary>
        /// Inserts data into a specified SQL table safely using parameters.
        /// </summary>
        public async Task<bool> InsertDataAsync(string tableName, Dictionary<string, object> data)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connection_server))
                {
                    await conn.OpenAsync();

                    string columns = string.Join(", ", data.Keys);
                    string parameters = string.Join(", ", data.Keys.Select(k => "@" + k));
                    string query = $"INSERT INTO {tableName} ({columns}) VALUES ({parameters})";

                    if (_isDebugShow) // Debugging Enabled
                    {
                        Console.WriteLine($"Executing Query: {query}");
                        foreach (var item in data)
                        {
                            Console.WriteLine($"Param {item.Key}: {item.Value}");
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        foreach (var item in data)
                        {
                            cmd.Parameters.AddWithValue("@" + item.Key, item.Value ?? DBNull.Value);
                        }

                        int rowsAffected = await cmd.ExecuteNonQueryAsync();

                        if (_isDebugShow) Console.WriteLine($"Rows Affected: {rowsAffected}");

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                if (_isDebugShow) Console.WriteLine($"SQL Error: {ex.Message}");
                return false;
            }
        }


        public bool InsertData(string tableName, Dictionary<string, object> data)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connection_server))
                {
                    conn.Open();

                    string columns = string.Join(", ", data.Keys);
                    string parameters = string.Join(", ", data.Keys.Select(k => "@" + k));
                    string query = $"INSERT INTO {tableName} ({columns}) VALUES ({parameters})";

                    if (_isDebugShow) // Debugging Enabled
                    {
                        Console.WriteLine($"Executing Query: {query}");
                        foreach (var item in data)
                        {
                            Console.WriteLine($"Param {item.Key}: {item.Value}");
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        foreach (var item in data)
                        {
                            cmd.Parameters.AddWithValue("@" + item.Key, item.Value ?? DBNull.Value);
                        }

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (_isDebugShow) Console.WriteLine($"Rows Affected: {rowsAffected}");

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                if (_isDebugShow) Console.WriteLine($"SQL Error: {ex.Message}");
                return false;
            }
        }

        public int InsertDataAndGetId(string tableName, Dictionary<string, object> data, string idColumn = "id")
        {
            try
            {
                string values = string.Join(", ", data.Values.Select(v =>
                    v is string || v is DateTime ? $"'{v}'" : v.ToString()));

                string query = $"INSERT INTO {tableName} ({string.Join(", ", data.Keys)}) " +
                               $"VALUES ({values}); " +
                               $"SELECT {idColumn} FROM {tableName} WHERE {idColumn} = SCOPE_IDENTITY();";

                DataTable dt = ExecuteQuery(query);
                int id = Convert.ToInt32(dt.Rows[0][0]);
                if (dt.Rows.Count > 0)
                {
                    return id; // Get the first row, first column
                }
                else
                {
                    Console.WriteLine("No data returned.");
                    return -1; // Indicate failure
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                return -1; // Indicate failure
            }
        }

        public string FilterQuery(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            // Escape single quotes by doubling them (' becomes '')
            string filtered = input.Replace("'", "''");

            // Remove dangerous SQL keywords (basic protection)
            string[] blacklist = { "DROP", "DELETE", "INSERT", "UPDATE", "--", ";", "xp_cmdshell", "EXEC", "UNION", "ALTER" };

            foreach (string word in blacklist)
            {
                filtered = Regex.Replace(filtered, @"\b" + word + @"\b", "", RegexOptions.IgnoreCase);
            }

            return filtered.Trim();
        }

    }
}

