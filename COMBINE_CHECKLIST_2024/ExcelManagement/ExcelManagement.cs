using ClosedXML.Excel;
using COMBINE_CHECKLIST_2024.DateToText;
using SQL_Connection_support;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrapeCity.Documents.Excel;
using System.Drawing.Printing;
using System.Drawing;
using DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text.pdf;
using iTextSharp.text;
using _pfont = System.Drawing.Font;
using System.util;

namespace COMBINE_CHECKLIST_2024.ExcelManagement
{
    class HistoryExcelGeneration
    {
        /// <summary>
        /// File-Path is where address of generated Excel will be deliver along with its name.
        /// </summary>
        private string file_path { get; set; }
        /// <summary>
        /// When true, Allows Excel file to open immediately once generated
        /// </summary>
        public bool auto_open { get; set; }
        /// <summary>
        /// When true, Allows Excel file to print immediately once generated
        /// </summary>
        public bool auto_print { get; set; }
        /// <summary>
        /// ExcelManagement Class is used for creating preset Excel layout base on GOODYEAR Machine History. This Class is strictly only follows a data from it's LocalDatabase
        /// </summary>
        /// <param name="file_path"> Instantiate a file path location for where Excel will be save. </param>
        /// <param name="auto_open"> Allows Excel file to open immediately once generated </param>
        /// <param name="auto_print"> Allows Excel file to print immediately once generated. </param>
        public HistoryExcelGeneration(string file_path = null, bool auto_open = false, bool auto_print = false)
        {
            this.file_path = file_path;
            this.auto_open = auto_open;
            this.auto_print = auto_print;
        }




        /// <summary>
        /// Generate an Excelspread sheet following the preset layout. 
        /// </summary>
        /// <param name="historylog_id"> History-ID is base on historyID in database. Each completion of encode-history of user has an ID which is used to reference a data.</param>

        public void generate_an_excel(int historylog_id)
        {
            string debugString = "\n\t//EXECUTING GENERATE_AN_EXCEL - METHOD\n";
            SQL_Support sql = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");


            List<DataTable> _grouptable_list = new List<DataTable>();
            List<int> _storedGroupID = new List<int>();
            DataTable historyLog_referencer = sql.ExecuteQuery($"SELECT * FROM GROUP_TABLE WHERE historylog_id = {historylog_id};");
            DataTable historyLog_filteredContent = sql.ExecuteQuery($"SELECT From_Date, To_Date, Monitored_By, Machine_Name, Location FROM GROUP_TABLE WHERE historylog_id = {historylog_id};");
            try
            {
                debugString += "DEBUG// foreach ID in _storedGroupID \t[ ";
                foreach (DataRow fullData in historyLog_referencer.Rows)
                {
                    _storedGroupID.Add(Convert.ToInt32(fullData["GroupID"]));
                    debugString += Convert.ToInt32(fullData["GroupID"]) + " ";
                }
                foreach (int selectedID in _storedGroupID)
                {
                    SQL_Support con = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");
                    DataTable historyitemLog = new DataTable();
                    historyitemLog = con.ExecuteQuery($"SELECT defect_part, defec_desc, suggested_replacement_repair, remark_analysis, overall_status, checked_by, datemark  FROM LOG_MACHINETABLE WHERE groupID = {selectedID};").Copy();
                    debugString += $"\nDEBUG// foreach ID=[{selectedID}] ROW-COUNT[{historyitemLog.Rows.Count}]- [\n";
                    _grouptable_list.Add(historyitemLog);
                    foreach (DataRow ItemArray in historyitemLog.Rows)
                    {
                        debugString += $"\t - {ItemArray["defect_part"]} - {ItemArray["overall_status"]} \n";
                    }
                    debugString += "]";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"ERROR: {e}");
            }
            Console.WriteLine("\n\n" + debugString + "\n\n");
            ExportToExcel(_grouptable_list, historyLog_filteredContent);
        }

        public void generate_Bulk_dataExcel(List<int> group_id)
        {
            Dictionary<List<DataTable>, DataTable> bulk_set = new Dictionary<List<DataTable>, DataTable>();
            foreach (int id in group_id)
            {
                string debugString = "\n\t//EXECUTING GENERATE_AN_EXCEL - METHOD\n";
                SQL_Support sql = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");


                List<DataTable> _grouptable_list = new List<DataTable>();
                List<int> _storedGroupID = new List<int>();
                DataTable historyLog_referencer = sql.ExecuteQuery($"SELECT * FROM GROUP_TABLE WHERE historylog_id = {id};");
                DataTable historyLog_filteredContent = sql.ExecuteQuery($"SELECT From_Date, To_Date, Monitored_By, Machine_Name, Location FROM GROUP_TABLE WHERE historylog_id = {id};");
                try
                {
                    debugString += "DEBUG// foreach ID in _storedGroupID \t[ ";
                    foreach (DataRow fullData in historyLog_referencer.Rows)
                    {
                        _storedGroupID.Add(Convert.ToInt32(fullData["GroupID"]));
                        debugString += Convert.ToInt32(fullData["GroupID"]) + " ";
                    }
                    foreach (int selectedID in _storedGroupID)
                    {
                        SQL_Support con = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");
                        DataTable historyitemLog = new DataTable();
                        historyitemLog = con.ExecuteQuery($"SELECT defect_part, defec_desc, suggested_replacement_repair, remark_analysis, overall_status, checked_by, datemark  FROM LOG_MACHINETABLE WHERE groupID = {selectedID};").Copy();
                        debugString += $"\nDEBUG// foreach ID=[{selectedID}] ROW-COUNT[{historyitemLog.Rows.Count}]- [\n";
                        _grouptable_list.Add(historyitemLog);
                        foreach (DataRow ItemArray in historyitemLog.Rows)
                        {
                            debugString += $"\t - {ItemArray["defect_part"]} - {ItemArray["overall_status"]} \n";
                        }
                        debugString += "]";
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"ERROR: {e}");
                }
                Console.WriteLine("\n\n" + debugString + "\n\n");
                bulk_set.Add(_grouptable_list, historyLog_filteredContent);
                ExportToExcel(bulk_set);
            }
        }

        public XLWorkbook GenerateExcelWorkbook(int history_log)
        {
            string debugString = "\n\t//EXECUTING GENERATE_AN_EXCEL - METHOD\n";
            SQL_Support sql = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");


            List<DataTable> _grouptable_list = new List<DataTable>();
            List<int> _storedGroupID = new List<int>();
            DataTable historyLog_referencer = sql.ExecuteQuery($"SELECT * FROM GROUP_TABLE WHERE historylog_id = {history_log};");
            DataTable historyLog_filteredContent = sql.ExecuteQuery($"SELECT From_Date, To_Date, Monitored_By, Machine_Name, Location FROM GROUP_TABLE WHERE historylog_id = {history_log};");
            try
            {
                debugString += "DEBUG// foreach ID in _storedGroupID \t[ ";
                foreach (DataRow fullData in historyLog_referencer.Rows)
                {
                    _storedGroupID.Add(Convert.ToInt32(fullData["GroupID"]));
                    debugString += Convert.ToInt32(fullData["GroupID"]) + " ";
                }
                foreach (int selectedID in _storedGroupID)
                {
                    SQL_Support con = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");
                    DataTable historyitemLog = new DataTable();
                    historyitemLog = con.ExecuteQuery($"SELECT defect_part, defec_desc, suggested_replacement_repair, remark_analysis, overall_status, checked_by, datemark  FROM LOG_MACHINETABLE WHERE groupID = {selectedID};").Copy();
                    debugString += $"\nDEBUG// foreach ID=[{selectedID}] ROW-COUNT[{historyitemLog.Rows.Count}]- [\n";
                    _grouptable_list.Add(historyitemLog);
                    foreach (DataRow ItemArray in historyitemLog.Rows)
                    {
                        debugString += $"\t - {ItemArray["defect_part"]} - {ItemArray["overall_status"]} \n";
                    }
                    debugString += "]";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"ERROR: {e}");
            }
            Console.WriteLine("\n\n" + debugString + "\n\n");
            return GenerateExcelWorkbook(_grouptable_list, historyLog_filteredContent);
        }

        public XLWorkbook GenerateBulkExcelWorkbook(List<int> group_id)
        {
            Dictionary<List<DataTable>, DataTable> bulk_set = new Dictionary<List<DataTable>, DataTable>();
            foreach (int id in group_id)
            {
                string debugString = "\n\t//EXECUTING GENERATE_AN_EXCEL - METHOD\n";
                SQL_Support sql = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");


                List<DataTable> _grouptable_list = new List<DataTable>();
                List<int> _storedGroupID = new List<int>();
                DataTable historyLog_referencer = sql.ExecuteQuery($"SELECT * FROM GROUP_TABLE WHERE historylog_id = {id};");
                DataTable historyLog_filteredContent = sql.ExecuteQuery($"SELECT From_Date, To_Date, Monitored_By, Machine_Name, Location FROM GROUP_TABLE WHERE historylog_id = {id};");
                try
                {
                    debugString += "DEBUG// foreach ID in _storedGroupID \t[ ";
                    foreach (DataRow fullData in historyLog_referencer.Rows)
                    {
                        _storedGroupID.Add(Convert.ToInt32(fullData["GroupID"]));
                        debugString += Convert.ToInt32(fullData["GroupID"]) + " ";
                    }
                    foreach (int selectedID in _storedGroupID)
                    {
                        SQL_Support con = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");
                        DataTable historyitemLog = new DataTable();
                        historyitemLog = con.ExecuteQuery($"SELECT defect_part, defec_desc, suggested_replacement_repair, remark_analysis, overall_status, checked_by, datemark  FROM LOG_MACHINETABLE WHERE groupID = {selectedID};").Copy();
                        debugString += $"\nDEBUG// foreach ID=[{selectedID}] ROW-COUNT[{historyitemLog.Rows.Count}]- [\n";
                        _grouptable_list.Add(historyitemLog);
                        foreach (DataRow ItemArray in historyitemLog.Rows)
                        {
                            debugString += $"\t - {ItemArray["defect_part"]} - {ItemArray["overall_status"]} \n";
                        }
                        debugString += "]";
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"ERROR: {e}");
                }
                Console.WriteLine("\n\n" + debugString + "\n\n");
                bulk_set.Add(_grouptable_list, historyLog_filteredContent);
            }
            return GenerateBulkExcelWorkbook(bulk_set);
        }

        static DataTable _MergeDataTables(int spacing, params DataTable[] tables)
        {
            if (tables.Length == 0) throw new ArgumentException("At least one DataTable is required.");

            DataTable mergedTable = tables[0].Clone(); // Clone structure from the first DataTable

            for (int i = 0; i < tables.Length; i++)
            {
                // Add rows from current DataTable
                foreach (DataRow row in tables[i].Rows)
                {
                    mergedTable.ImportRow(row);
                }

                // Add spacing rows (except after the last table)
                if (i < tables.Length - 1)
                {
                    for (int j = 0; j < spacing; j++)
                    {
                        mergedTable.Rows.Add(DBNull.Value, DBNull.Value);
                    }
                }
            }

            return mergedTable;
        }


        static DataTable MergeDataTables(List<DataTable> tables, int spacing)
        {
            if (tables == null || tables.Count == 0)
                throw new ArgumentException("The list of DataTables cannot be null or empty.");

            DataTable mergedTable = tables[0].Clone(); // Clone structure from the first DataTable

            for (int i = 0; i < tables.Count; i++)
            {
                foreach (DataRow row in tables[i].Rows)
                {
                    mergedTable.ImportRow(row);
                }
                if (i < tables.Count - 1)
                {
                    for (int j = 0; j < spacing; j++)
                    {
                        mergedTable.Rows.Add(DBNull.Value, DBNull.Value);
                    }
                }
            }
            return mergedTable;
        }

        public XLWorkbook GenerateExcelWorkbook(List<DataTable> dt, DataTable groupHighlight)
        {
            var workbook = new XLWorkbook();
            Datetotext date = new Datetotext();
            var worksheet = workbook.Worksheets.Add("Users Data");
            string projectRoot = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            var imageStream = new MemoryStream();
            Properties.Resources.LOGO.Save(imageStream, System.Drawing.Imaging.ImageFormat.Png);
            imageStream.Position = 0;

            var picture = worksheet.AddPicture(imageStream, "LOGO")
            .MoveTo(worksheet.Cell("A1"))
            .Scale(0.8);

            worksheet.PageSetup.PageOrientation = XLPageOrientation.Portrait;
            worksheet.PageSetup.Margins.Top = 0;
            worksheet.PageSetup.Margins.Bottom = 0;
            worksheet.PageSetup.Margins.Left = 0;
            worksheet.PageSetup.Margins.Right = 0;
            worksheet.PageSetup.Margins.Header = 0;
            worksheet.PageSetup.Margins.Footer = 0;
            worksheet.Column(1).Width = 6;
            worksheet.Column(2).Width = 12;
            worksheet.Column(3).Width = 10;
            worksheet.Column(4).Width = 12;
            worksheet.Column(5).Width = 13;
            worksheet.Column(6).Width = 13;
            worksheet.Column(7).Width = 16;
            worksheet.Column(8).Width = 12;

            string range_address = "D2:H3";
            worksheet.Range(range_address).Merge();
            var header_cell = worksheet.Cell("D2");
            header_cell.Value = "GOODYEAR CONTAINER CORP - MACHINE HISTORY";
            header_cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            header_cell.Style.Font.Bold = true;
            header_cell.Style.Font.FontSize = 16;



            int currentRow = 5;

            if (groupHighlight.Rows.Count > 0)
            {
                foreach (DataRow row in groupHighlight.Rows)
                {
                    DateTime from = (DateTime)row["From_Date"];
                    DateTime to = (DateTime)row["to_Date"];
                    int rowStart_boarder = currentRow;

                    range_address = $"A{currentRow}:H{currentRow}";
                    worksheet.Range(range_address).Merge();
                    SetCellData(worksheet, currentRow, 1, row["Machine_Name"].ToString().ToUpper() + " MAINTENANCE MACHINE HISTORY", 14, true, XLColor.Black, XLColor.LightBlue, XLAlignmentHorizontalValues.Center);
                    currentRow++;
                    range_address = $"A{currentRow}:B{currentRow}";
                    worksheet.Range(range_address);
                    range_address = $"D{currentRow}:E{currentRow}";
                    worksheet.Range(range_address).Merge();
                    range_address = $"G{currentRow}:H{currentRow}";
                    worksheet.Range(range_address).Merge();
                    SetCellData(worksheet, currentRow, 1, "Location: " + row["Location"], 8);
                    SetCellData(worksheet, currentRow, 3, date.getMonthAsShortText(from) + " " + from.Day + " - " + date.getMonthAsShortText(to) + " " + to.Day, 8);
                    SetCellData(worksheet, currentRow, 4, "Machine Name: " + row["Machine_Name"], 10);
                    SetCellData(worksheet, currentRow, 7, "Monitored By: " + row["Monitored_By"].ToString(), 8, false, null, null, XLAlignmentHorizontalValues.Right);
                    currentRow++;
                    range_address = $"A{currentRow}:H{currentRow}";
                    worksheet.Range(range_address).Merge();
                    SetCellData(worksheet, currentRow, 1, from.Year.ToString(), 10, false, XLColor.Black, XLColor.LightBlue, XLAlignmentHorizontalValues.Center);
                    currentRow++;

                    // Table Headers
                    SetCellData(worksheet, currentRow, 1, "DATE", 8, false, XLColor.Black, null, XLAlignmentHorizontalValues.Center);
                    SetCellData(worksheet, currentRow, 2, "OVERALL-STATUS", 8, false, XLColor.Black, null, XLAlignmentHorizontalValues.Center);
                    SetCellData(worksheet, currentRow, 3, "TIME", 8, false, XLColor.Black, null, XLAlignmentHorizontalValues.Center);
                    SetCellData(worksheet, currentRow, 4, "DEFECTIVE-PART", 8, false, XLColor.Black, null, XLAlignmentHorizontalValues.Center);
                    SetCellData(worksheet, currentRow, 5, "DEFECTIVE-DESCRIPTION", 7, false, XLColor.Black, null, XLAlignmentHorizontalValues.Center);
                    SetCellData(worksheet, currentRow, 6, "CHECKED-BY", 8, false, XLColor.Black, null, XLAlignmentHorizontalValues.Center);
                    SetCellData(worksheet, currentRow, 7, "SUGGESTED-REPLACEMENT-REPAIR", 6, false, XLColor.Black, null, XLAlignmentHorizontalValues.Center);
                    SetCellData(worksheet, currentRow, 8, "REMARK/ANALYSIS", 8, false, XLColor.Black, null, XLAlignmentHorizontalValues.Center);

                    currentRow++;
                    DataTable firstInsertion = dt.First();
                    foreach (DataRow dataCell in firstInsertion.Rows)
                    {
                        Datetotext convert = new Datetotext();
                        bool status = (bool)dataCell["overall_status"];
                        DateTime _date = (DateTime)dataCell["datemark"];
                        string date_string = _date.Day.ToString() + "-" + convert.getMonthAsShortText(_date);

                        SetCellData(worksheet, currentRow, 1, date_string, 10, false, XLColor.Black, null);
                        SetCellData(worksheet, currentRow, 2, status ? "Defective" : "Satisfactory", 10, false, XLColor.Black, null);
                        SetCellData(worksheet, currentRow, 3, convert.getTime12HoursPreset(_date), 10, false, XLColor.Black, null);
                        SetCellData(worksheet, currentRow, 4, dataCell["defect_part"].ToString(), 8, false, XLColor.Black, null);
                        SetCellData(worksheet, currentRow, 5, dataCell["defec_desc"].ToString(), 8, false, XLColor.Black, null);
                        SetCellData(worksheet, currentRow, 6, dataCell["checked_by"].ToString(), 10, false, XLColor.Black, null);
                        SetCellData(worksheet, currentRow, 7, dataCell["suggested_replacement_repair"].ToString(), 10, false, XLColor.Black, null);
                        SetCellData(worksheet, currentRow, 8, dataCell["remark_analysis"].ToString(), 10, false, XLColor.Black, null);
                        currentRow++;
                    }
                    dt.RemoveAt(0);
                }
            }

            return workbook;
        }

        public XLWorkbook GenerateBulkExcelWorkbook(Dictionary<List<DataTable>,DataTable> bulk_group)
        {
            var workbook = new XLWorkbook();
            Datetotext date = new Datetotext();
            var worksheet = workbook.Worksheets.Add("Users Data");
            string projectRoot = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            var imageStream = new MemoryStream();
            Properties.Resources.LOGO.Save(imageStream, System.Drawing.Imaging.ImageFormat.Png);
            imageStream.Position = 0;

            var picture = worksheet.AddPicture(imageStream, "LOGO")
            .MoveTo(worksheet.Cell("A1"))
            .Scale(0.8);
            worksheet.PageSetup.PageOrientation = XLPageOrientation.Portrait;
            worksheet.PageSetup.Margins.Top = 0;
            worksheet.PageSetup.Margins.Bottom = 0;
            worksheet.PageSetup.Margins.Left = 0;
            worksheet.PageSetup.Margins.Right = 0;
            worksheet.PageSetup.Margins.Header = 0;
            worksheet.PageSetup.Margins.Footer = 0;
            worksheet.Column(1).Width = 6;
            worksheet.Column(2).Width = 12;
            worksheet.Column(3).Width = 10;
            worksheet.Column(4).Width = 12;
            worksheet.Column(5).Width = 13;
            worksheet.Column(6).Width = 13;
            worksheet.Column(7).Width = 16;
            worksheet.Column(8).Width = 12;

            string range_address = "D2:H3";
            worksheet.Range(range_address).Merge();
            var header_cell = worksheet.Cell("D2");
            header_cell.Value = "GOODYEAR CONTAINER CORP - MACHINE HISTORY";
            header_cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            header_cell.Style.Font.Bold = true;
            header_cell.Style.Font.FontSize = 16;


            int currentRow = 5;


            foreach (var entry in bulk_group)
            {
                List<DataTable> dataPerSec = entry.Key;

                if (entry.Value.Rows.Count > 0)
                {
                    foreach (DataRow row in entry.Value.Rows)
                    {
                        DateTime from = (DateTime)row["From_Date"];
                        DateTime to = (DateTime)row["to_Date"];
                        int rowStart_boarder = currentRow;

                        range_address = $"A{currentRow}:H{currentRow}";
                        worksheet.Range(range_address).Merge();
                        SetCellData(worksheet, currentRow, 1, row["Machine_Name"].ToString().ToUpper() + " MAINTENANCE MACHINE HISTORY", 14, true, XLColor.Black, XLColor.LightBlue, XLAlignmentHorizontalValues.Center);
                        currentRow++;
                        range_address = $"A{currentRow}:B{currentRow}";
                        worksheet.Range(range_address);
                        range_address = $"D{currentRow}:E{currentRow}";
                        worksheet.Range(range_address).Merge();
                        range_address = $"G{currentRow}:H{currentRow}";
                        worksheet.Range(range_address).Merge();
                        SetCellData(worksheet, currentRow, 1, "Location: " + row["Location"], 8);
                        SetCellData(worksheet, currentRow, 3, date.getMonthAsShortText(from) + " " + from.Day + " - " + date.getMonthAsShortText(to) + " " + to.Day, 8);
                        SetCellData(worksheet, currentRow, 4, "Machine Name: " + row["Machine_Name"], 10);
                        SetCellData(worksheet, currentRow, 7, "Monitored By: " + row["Monitored_By"].ToString(), 8, false, null, null, XLAlignmentHorizontalValues.Right);
                        currentRow++;
                        range_address = $"A{currentRow}:H{currentRow}";
                        worksheet.Range(range_address).Merge();
                        SetCellData(worksheet, currentRow, 1, from.Year.ToString(), 10, false, XLColor.Black, XLColor.LightBlue, XLAlignmentHorizontalValues.Center);
                        currentRow++;

                        // Table Headers
                        SetCellData(worksheet, currentRow, 1, "DATE", 8, false, XLColor.Black, null, XLAlignmentHorizontalValues.Center);
                        SetCellData(worksheet, currentRow, 2, "OVERALL-STATUS", 8, false, XLColor.Black, null, XLAlignmentHorizontalValues.Center);
                        SetCellData(worksheet, currentRow, 3, "TIME", 8, false, XLColor.Black, null, XLAlignmentHorizontalValues.Center);
                        SetCellData(worksheet, currentRow, 4, "DEFECTIVE-PART", 8, false, XLColor.Black, null, XLAlignmentHorizontalValues.Center);
                        SetCellData(worksheet, currentRow, 5, "DEFECTIVE-DESCRIPTION", 7, false, XLColor.Black, null, XLAlignmentHorizontalValues.Center);
                        SetCellData(worksheet, currentRow, 6, "CHECKED-BY", 8, false, XLColor.Black, null, XLAlignmentHorizontalValues.Center);
                        SetCellData(worksheet, currentRow, 7, "SUGGESTED-REPLACEMENT-REPAIR", 6, false, XLColor.Black, null, XLAlignmentHorizontalValues.Center);
                        SetCellData(worksheet, currentRow, 8, "REMARK/ANALYSIS", 8, false, XLColor.Black, null, XLAlignmentHorizontalValues.Center);

                        currentRow++;
                        DataTable firstInsertion = dataPerSec.First();
                        foreach (DataRow dataCell in firstInsertion.Rows)
                        {
                            Datetotext convert = new Datetotext();
                            bool status = (bool)dataCell["overall_status"];
                            DateTime _date = (DateTime)dataCell["datemark"];
                            string date_string = _date.Day.ToString() + "-" + convert.getMonthAsShortText(_date);

                            SetCellData(worksheet, currentRow, 1, date_string, 10, false, XLColor.Black, null);
                            SetCellData(worksheet, currentRow, 2, status ? "Defective" : "Satisfactory", 10, false, XLColor.Black, null);
                            SetCellData(worksheet, currentRow, 3, convert.getTime12HoursPreset(_date), 10, false, XLColor.Black, null);
                            SetCellData(worksheet, currentRow, 4, dataCell["defect_part"].ToString(), 8, false, XLColor.Black, null);
                            SetCellData(worksheet, currentRow, 5, dataCell["defec_desc"].ToString(), 8, false, XLColor.Black, null);
                            SetCellData(worksheet, currentRow, 6, dataCell["checked_by"].ToString(), 10, false, XLColor.Black, null);
                            SetCellData(worksheet, currentRow, 7, dataCell["suggested_replacement_repair"].ToString(), 10, false, XLColor.Black, null);
                            SetCellData(worksheet, currentRow, 8, dataCell["remark_analysis"].ToString(), 10, false, XLColor.Black, null);
                            currentRow++;
                        }
                        dataPerSec.RemoveAt(0);
                    }
                }

               
            }
            return workbook;
        }


        public void ExportToExcel(List<DataTable> dt, DataTable groupHighlight)
        {
            string filePath = file_path == null ? Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "UsersData.xlsx") : file_path;
            CloseSpecificExcelOrWpsFile(filePath);
            GenerateExcelWorkbook(dt, groupHighlight).SaveAs(filePath);

                MessageBox.Show($"Excel file saved at: {filePath}");

                if (auto_print)
                {

                }

                if (auto_open)
                {
                    Process openProcess = new Process();
                    openProcess.StartInfo.FileName = filePath;
                    openProcess.Start();
                }
        }

        public void ExportToExcel(Dictionary<List<DataTable>, DataTable> bulk_set)
        {
            string filePath = file_path == null ? Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "UsersData.xlsx") : file_path;
            CloseSpecificExcelOrWpsFile(filePath);
            GenerateBulkExcelWorkbook(bulk_set).SaveAs(filePath);

            MessageBox.Show($"Excel file saved at: {filePath}");

            if (auto_print)
            {

            }

            if (auto_open)
            {
                Process openProcess = new Process();
                openProcess.StartInfo.FileName = filePath;
                openProcess.Start();
            }
        }

        public void ExportToExcel(XLWorkbook workbook)
        {
            string filePath = file_path == null ? Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "UsersData.xlsx") : file_path;
            CloseSpecificExcelOrWpsFile(filePath);
            workbook.SaveAs(filePath);

            MessageBox.Show($"Excel file saved at: {filePath}");
            if (auto_open)
            {
                Process openProcess = new Process();
                openProcess.StartInfo.FileName = filePath;
                openProcess.Start();
            }
        }

        private int SetCellData(IXLWorksheet worksheet, int row, int col, string value, double fontSize = 12, bool isBold = false, XLColor fontColor = default, XLColor backgroundColor = default, XLAlignmentHorizontalValues alignment = XLAlignmentHorizontalValues.Left)
        {
            var cell = worksheet.Cell(row, col);

            cell.Style.Font.FontSize = fontSize;
            cell.Style.Font.Bold = isBold;
            cell.Value = value;

            if (fontColor != default)
                cell.Style.Font.FontColor = fontColor;

            if (backgroundColor != default)
                cell.Style.Fill.BackgroundColor = backgroundColor;

            cell.Style.Alignment.Horizontal = alignment;
            return row + 2;
        }

        private void CloseSpecificExcelOrWpsFile(string filePath)
        {
            try
            {
                // Check if the file is open by trying to access it exclusively
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                {
                    // File is not open by any other process, so just close the stream
                    Console.WriteLine("File is not open. No need to close.");
                }
            }
            catch (IOException)
            {
                // File is locked, so we try to close it by finding the process using it
                CloseProcessUsingFile(filePath);
            }

            // Ensure WPS files are also handled
            CloseWpsFile(filePath);
        }

        private void CloseProcessUsingFile(string filePath)
        {
            try
            {
                var excelProcesses = Process.GetProcessesByName("EXCEL"); // Get all Excel processes
                var wpsProcesses = Process.GetProcessesByName("wps"); // Get all WPS processes

                foreach (var process in excelProcesses.Concat(wpsProcesses))
                {
                    try
                    {
                        // Get the file handles used by this process
                        if (IsFileUsedByProcess(process, filePath))
                        {
                            process.Kill();
                            Console.WriteLine($"Closed the process using {filePath}");
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Failed to close process: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error finding processes: {ex.Message}");
            }
        }

        // Dummy method to check if a process is using the file
        private bool IsFileUsedByProcess(Process process, string filePath)
        {
            // Note: Implementing a proper check requires accessing system handles, which is complex.
            return true; // Assumes the first found process is the one using it.
        }

        private void CloseWpsFile(string filePath)
        {
            try
            {
                var wpsProcesses = Process.GetProcessesByName("wps");
                foreach (var process in wpsProcesses)
                {
                    if (IsFileLockedByProcess(process, filePath))
                    {
                        process.Kill();
                        process.WaitForExit();
                        Console.WriteLine("Closed WPS Office process.");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to close WPS: " + ex.Message);
            }
        }

        private bool IsFileLockedByProcess(Process process, string filePath)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    return false;
                }
            }
            catch
            {
                return true;
            }
        }

        public string ConvertExcelToHtml(XLWorkbook workbook)
        {
            StringBuilder html = new StringBuilder();

            html.Append("<html><head><style>");
            html.Append("table { border-collapse: collapse; width: 100%; }");
            html.Append("th, td { border: 1px solid black; padding: 8px; text-align: left; }");
            html.Append("</style></head><body>");

            foreach (IXLWorksheet sheet in workbook.Worksheets)
            {
                html.Append($"<h2>{sheet.Name}</h2>");
                html.Append("<table>");

                bool headerRow = true;
                foreach (IXLRow row in sheet.RowsUsed())
                {
                    html.Append("<tr>");
                    foreach (IXLCell cell in row.CellsUsed())
                    {
                        if (headerRow)
                            html.Append($"<th>{cell.Value}</th>");
                        else
                            html.Append($"<td>{cell.Value}</td>");
                    }
                    html.Append("</tr>");
                    headerRow = false;
                }
                html.Append("</table><br>");
            }

            html.Append("</body></html>");
            return html.ToString();
        }

        public void ShowExcelInWebView(string filePath, WebBrowser browser)
        {
            XLWorkbook workbook = new XLWorkbook(filePath);
            string htmlContent = ConvertExcelToHtml(workbook);

            // Load HTML in WebBrowser control
            browser.DocumentText = htmlContent;
        }

    }

}
