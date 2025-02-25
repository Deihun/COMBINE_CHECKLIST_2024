using ClosedXML.Excel;
using COMBINE_CHECKLIST_2024.DateToText;
using COMBINE_CHECKLIST_2024.Sections.MachineHistory;
using SQL_Connection_support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace COMBINE_CHECKLIST_2024.Sections.Currugator
{
    public partial class Create: Form
    {
        public List <Form> groupOf_groupforms = new List<Form>();
        private Excel_export export = new Excel_export();
        public Create()
        {
            InitializeComponent();
        }

        private void additem_btn_Click(object sender, EventArgs e)
        {
            Add_Group_confirmation confirm = new Add_Group_confirmation(this.flowLayoutPanel1, this, monitor_tb.Text, machine_tb.Text, location_tb.Text);
            confirm.ShowDialog();
            //this.Controls.
            //Item_Record itemrecord = new Item_Record(flowLayoutPanel1);
            //itemrecord.TopLevel = false;
            //flowLayoutPanel1.Controls.Add(itemrecord);
            
            //itemrecord.Show();
        }

        public void addNewGroups(Form groups)
        {
            groupOf_groupforms.Add(groups);
        }

        private void create_new_history_btn_Click(object sender, EventArgs e)
        {
         order_a_SelectAsync();
        }

        private void order_a_SelectAsync()
        {
            SQL_Support sql = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");
            Dictionary<string, object> history_log = new Dictionary<string, object> { { "date_commit", DateTime.Now } };

            string query_construct;
            int _last_identity;
            int _last_id_identity;
            sql._isDebugShow = true;

            _last_id_identity = sql.InsertDataAndGetId("EXECUTION_HISTORY", history_log);

            foreach (Form groups in groupOf_groupforms)
                {
                    if (groups is grouping_of_items groupForm) // Correct type
                    {
                    Dictionary<string, object> groupData = new Dictionary<string, object>
                            {
                                {"From_Date", groupForm._from_dt},
                                {"historylog_id", _last_id_identity },
                                {"To_Date", groupForm._to_dt},
                                { "Monitored_By", groupForm.monitor},
                                { "Machine_Name", groupForm.machine},
                                { "Location", groupForm.location}
                            };
                    _last_identity = sql.InsertDataAndGetId("GROUP_TABLE", groupData);

                    //INCOMPLETE - NO MONITORED BY AND MACHINENAME YET
                    foreach (Form deepgroup in groupForm.group_of_logs)
                    {
                        if  (deepgroup is Item_Record logGroup)
                        {
                            Dictionary<string, object> logData = new Dictionary<string, object>
                            {
                                {"defect_part", logGroup.get_defectiveparts()},
                                {"defec_desc", logGroup.get_defectiveDescription()},
                                {"suggested_replacement_repair", logGroup.get_suggestion()},
                                {"remark_analysis", logGroup.get_remarks()},
                                {"overall_status", logGroup.get_overallAnalysis()},
                                {"checked_by", logGroup.get_checkby()},
                                {"groupID", _last_identity },
                                {"datemark", logGroup.my_targeted_date }
                            };
                            sql.InsertData("LOG_MACHINETABLE", logData);
                        }
                    }
                    }
            }
            export.generate_an_excel(_last_id_identity);
        }


        private void Create_Load(object sender, EventArgs e)
        {

        }
    }

    public class Excel_export
    {
        

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
            }catch (Exception e)
            {
                MessageBox.Show($"ERROR: {e}");
            }

            Console.WriteLine("\n\n" + debugString + "\n\n");
            ExportToExcel(_grouptable_list, historyLog_filteredContent);
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


        public void ExportToExcel(List<DataTable> dt, DataTable groupHighlight)
        {
            using (var workbook = new XLWorkbook())
            {
                Datetotext date = new Datetotext();
                var worksheet = workbook.Worksheets.Add("Users Data");
                worksheet.Column(1).Width = 18;
                worksheet.Column(2).Width = 18;
                worksheet.Column(3).Width = 28;
                worksheet.Column(4).Width = 18;
                worksheet.Column(5).Width = 18;
                worksheet.Column(6).Width = 18;
                worksheet.Column(7).Width = 18;
               

                // Header
                var header_cell = worksheet.Cell("B1");
                header_cell.Value = "GOODYEAR CONTAINER CORP - MACHINE HISTORY";
                header_cell.Style.Font.FontSize = 16;



                int currentRow = 3; 

                // Write group header (if available)
                if (groupHighlight.Rows.Count > 0)
                {
                    foreach (DataRow row in groupHighlight.Rows)
                    {
                        DateTime from = (DateTime)row["From_Date"];
                        DateTime to = (DateTime)row["to_Date"];
                        int rowStart_boarder = currentRow;

                        string range_address = $"A{currentRow}:G{currentRow}";
                        worksheet.Range(range_address).Merge();
                        SetCellData(worksheet, currentRow, 1, row["Machine_Name"].ToString().ToUpper() + " MAINTENANCE MACHINE HISTORY", 14, true, XLColor.Black, XLColor.LightBlue, XLAlignmentHorizontalValues.Center);
                        currentRow++;
                        range_address = $"C{currentRow}:E{currentRow}";
                        worksheet.Range(range_address).Merge();
                        range_address = $"F{currentRow}:G{currentRow}";
                        worksheet.Range(range_address).Merge();
                        SetCellData(worksheet, currentRow, 1, "Location: " + row["Location"], 8);
                        SetCellData(worksheet, currentRow, 2, date.getMonthAsText(from) + " " + from.Day +" - " + date.getMonthAsText(to) + " " + to.Day, 8);
                        SetCellData(worksheet, currentRow, 3, "Machine Name: " + row["Machine_Name"], 10);
                        SetCellData(worksheet, currentRow, 6, "Monitored By: " + row["Monitored_By"], 8, false, null,null, XLAlignmentHorizontalValues.Right);
                        currentRow++;
                        range_address = $"A{currentRow}:G{currentRow}";
                        worksheet.Range(range_address).Merge();
                        SetCellData(worksheet, currentRow, 1, from.Year.ToString() , 10, false, XLColor.Black, XLColor.LightBlue, XLAlignmentHorizontalValues.Center);
                        currentRow++;
                        //var _dataCell = worksheet.Cell(currentRow, 1);
                        //_dataCell.Value = "DEFECTIVE PARTS";
                        //_dataCell.Style.Font.Bold = true;
                        SetCellData(worksheet, currentRow, 1, "DEFECTIVE PARTS", 8, false, XLColor.Black, null);
                        SetCellData(worksheet, currentRow, 2, "DEFECTIVE DESCRIPTION", 8, false, XLColor.Black, null);
                        SetCellData(worksheet, currentRow, 3, "SUGGESTED REPLACEMENT/REPAIR", 8, false, XLColor.Black, null);
                        SetCellData(worksheet, currentRow, 4, "REMARK/ANALYSIS", 8, false, XLColor.Black, null);
                        SetCellData(worksheet, currentRow, 5, "CHECKED-BY", 8, false, XLColor.Black, null);
                        SetCellData(worksheet, currentRow, 6, "DATE", 8, false, XLColor.Black, null);
                        SetCellData(worksheet, currentRow, 7, "OVERALL-STATUS", 8, false, XLColor.Black, null);
                        currentRow++;

                        DataTable firstInsertion = dt.First();

                        


                        firstInsertion.Columns.Add("overall_status_new", typeof(string));
                        foreach (DataRow filterdata in firstInsertion.Rows)
                        { if (filterdata["overall_status"] is bool status) { filterdata["overall_status_new"] = status ? "Defective" : "Satisfaction";  }  }

                        firstInsertion.Columns.Remove("overall_status");
                        firstInsertion.Columns["overall_status_new"].ColumnName = "overall_status";

                        var CellData = worksheet.Cell(currentRow, 1);
                        CellData.InsertData(firstInsertion);
                        
                        currentRow += firstInsertion.Rows.Count-1;
                        int rowEnd_boarder = currentRow;
                        worksheet.Range($"A{rowStart_boarder}:G{rowEnd_boarder}").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        dt.RemoveAt(0);
                        currentRow += 2;
                    }

                }
                // Save File
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "UsersData.xlsx");
                workbook.SaveAs(filePath);
                MessageBox.Show($"Excel file saved at: {filePath}");
            }
        }


        private int SetCellData(IXLWorksheet worksheet, int row, int col, string value, double fontSize = 12, bool isBold = false, XLColor fontColor = default, XLColor backgroundColor = default, XLAlignmentHorizontalValues alignment = XLAlignmentHorizontalValues.Left)
        {
            var cell = worksheet.Cell(row, col);
            
            cell.Style.Font.FontSize = fontSize;
            cell.Style.Font.Bold = isBold;
            cell.Value = value;

            // Apply font color only if it's not the default
            if (fontColor != default)
                cell.Style.Font.FontColor = fontColor;

            // Apply background color only if it's not the default
            if (backgroundColor != default)
                cell.Style.Fill.BackgroundColor = backgroundColor;

            cell.Style.Alignment.Horizontal = alignment;
            return row + 2;
        }

    }
}

