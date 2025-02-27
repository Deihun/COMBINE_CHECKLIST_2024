using COMBINE_CHECKLIST_2024.DateToText;
using COMBINE_CHECKLIST_2024.ExcelManagement;
using DocumentFormat.OpenXml.Bibliography;
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

namespace COMBINE_CHECKLIST_2024.Sections.MachineHistoryViewer
{
    public partial class BulkPrintSelection: Form
    {
        private SQL_Support sql = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");
        AllData ad;
        public BulkPrintSelection()
        {
            InitializeComponent();
            ad = new AllData(this, selection_container_fl);
            ad._initializeData();
            dateTimePicker1.Enabled = false;
            selection_container_fl.AutoScroll = true;
            selection_container_fl.HorizontalScroll.Enabled = false;
            selection_container_fl.HorizontalScroll.Visible = false;
            selection_container_fl.HorizontalScroll.Maximum = 0;
            selection_container_fl.VerticalScroll.Enabled = true;
            selection_container_fl.VerticalScroll.Visible = true;
            selection_container_fl.AutoScrollMinSize = new Size(0, 1);

            DataTable results = sql.ExecuteQuery("SELECT DISTINCT [Machine_Name] FROM GROUP_TABLE;");
            foreach (DataRow r in results.Rows)
            {
                machineName_cb.Items.Add(r["Machine_Name"]);
            }
            results.Clear();
            
        }

        public void checkTrigger()
        {
            HistoryExcelGeneration excel = new HistoryExcelGeneration();
            web.DocumentText = excel.ConvertExcelToHtml(excel.GenerateBulkExcelWorkbook(ad.getCheckedID()));
        }
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void specificDate_rd_CheckedChanged(object sender, EventArgs e)
        {
            applyDisables();
        }

        private void applyDisables()
        {
            dateTimePicker1.Enabled = specificDate_rd.Checked;
            machineName_cb.Enabled = !specificDate_rd.Checked;
            year_cb.Enabled = !specificDate_rd.Checked;
            year_cb.Text = !specificDate_rd.Checked ? year_cb.Text : string.Empty;
            machineName_cb.Text = !specificDate_rd.Checked ? machineName_cb.Text : string.Empty;
        }

        private void Dropdownbox_rd_CheckedChanged(object sender, EventArgs e)
        {
            applyDisables();
        }

        private void machineName_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ad.FilterData_nonSpecificDate(year_cb.Text, machineName_cb.Text);
        }

        private void year_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ad.FilterData_nonSpecificDate(year_cb.Text, machineName_cb.Text);
        }

        private void clearfilter_btn_Click(object sender, EventArgs e)
        {
            machineName_cb.Text = "";
            year_cb.Text = "";
        }

        private void monitoredby_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class AllData
    {
        BulkPrintSelection parent;
        private SQL_Support sql = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");
        private Datetotext convertdate = new Datetotext();
        private FlowLayoutPanel container;
        List<SelectionItem> list = new List<SelectionItem>();
        public AllData(BulkPrintSelection parent, FlowLayoutPanel container)
        {
            this.parent = parent;
            this.container = container;
        }

        public List<int> getCheckedID()
        {
            List<int> _list = new List<int>();
            foreach(SelectionItem s in list)
            {
                if (s.getStoredBool()) _list.Add(s.storedID);
            }
            return _list;
        }
        public void _initializeData()
        {
            sql._isDebugShow = true;
            DataTable data = sql.ExecuteQuery("SELECT DISTINCT eh.ID," +
                "                        gt.Machine_Name," +
                "                        gt.Monitored_By," +
                "                        gt.Location," +
                "                        eh.date_commit" +
                "        FROM EXECUTION_HISTORY eh" +
                "        INNER JOIN GROUP_TABLE gt ON eh.ID = gt.GroupID" +
                "        WHERE gt.GroupID = (SELECT MIN(GroupID) FROM GROUP_TABLE WHERE GROUP_TABLE.GroupID = gt.GroupID)" 
                );
            foreach (DataRow row in data.Rows)
            {
                int id = Convert.ToInt32(row["ID"]);
                string machineName = row["Machine_Name"].ToString();
                DateTime date = (DateTime)row["date_commit"];
                _addNewData(id, date, machineName);
            }
        }
        public void loadAllData()
        {
            foreach (SelectionItem s in list)
            {
                s.Visible = true;
            }
        }

        public void loadAllData(DateTime filter)
        {
            foreach (SelectionItem s in list)
            {
                s.Visible = filter == s.target_date;
            }
        }

        public void hideAllData()
        {
            foreach (SelectionItem s in list)
            {
                s.Visible = false;
            }
        }

        public void FilterData_nonSpecificDate(string month, string MachineName)
        {
            hideAllData();

            foreach (SelectionItem s in list)
            {
                DateTime target_date = s.target_date;
                int selectedMonth = convertdate.getMonth(month);

                Console.WriteLine($"/DEBUGG Selected Month: {selectedMonth}, Target Date Month: {target_date.Month}, Month Filter: {month}");

                // Fix: Allow all months if `month` is empty
                bool isMonthValid = (month == "" || selectedMonth == target_date.Month);

                // Fix: Allow all machine names if `MachineName` is empty
                bool isMachineValid = (MachineName == "" || MachineName.Equals(s.machinename));

                if (isMonthValid && isMachineValid)
                {
                    s.Visible = true;
                }
            }
        }
        public void _addNewData(int id, DateTime date, string machinename)
        {
            SelectionItem si = new SelectionItem(id, date, parent);
            si.TopLevel = false;
            container.Controls.Add(si);
            list.Add(si);
            si.machinename = machinename;
            si.Show();
        }


    }
}
