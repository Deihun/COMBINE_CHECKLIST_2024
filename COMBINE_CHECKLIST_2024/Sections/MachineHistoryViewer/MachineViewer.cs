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
    public partial class MachineViewer: Form
    {
        List<Form> ViewList = new List<Form>();
        private SQL_Support sql = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");
        private gridview_adjustment g_adjust;
        private buttonPerHistory buttonManagement;
        public MachineViewer()
        {
            InitializeComponent();
            
            g_adjust = new gridview_adjustment(sql, dataPerSection);
            buttonManagement = new buttonPerHistory(this, button_container_flp);
            g_adjust.dataPerHistoryLog_flp = dataPerSection;
            buttonManagement.showAllResults();
        }

        

        public void addButton(int groupID)
        {
            ButtonItem buttonItem = new ButtonItem(groupID,this);
        }
        public void delButton(Form delbtn)
        {
            ViewList.Remove(delbtn);
            delbtn.Dispose();
        }
        public void resetButton()
        {
            foreach(Form reset in ViewList)
            {
                reset.Dispose();
            }
        }
        public void SetDataGridView(int id)
        {
            g_adjust.show_dataPerSection(id);

            //
            //dataGridView1.DataSource = MachineView.ExecuteQueryAsync(query);
        }

        private void MachineViewer_Load(object sender, EventArgs e)
        {

        }

        private void MachineViewer_VisibleChanged(object sender, EventArgs e)
        {
            buttonManagement.showAllResults();
        }
    }








    //FOR dataPerSection 
    public class gridview_adjustment
    {
        public FlowLayoutPanel dataPerHistoryLog_flp;
        private FlowLayoutPanel flowparent;
        private List<DataGridView> pergroups = new List<DataGridView>();
        private SQL_Support sql;

        public gridview_adjustment(SQL_Support sql, FlowLayoutPanel parent)
        {
            this.sql = sql;
            this.flowparent = parent;
        }
        public void show_dataPerSection(int _id)
        {
            _delete_all();

            List<int> group_id_of_item = new List<int>();
            string query = $"SELECT * FROM GROUP_TABLE WHERE historylog_id = {_id}; ";
            DataTable data = sql.ExecuteQuery(query);
            foreach (DataRow id in data.Rows)
            {
                group_id_of_item.Add(Convert.ToInt32(id["GroupID"]));
            }

            foreach (int id in group_id_of_item)
            {
                query = $"SELECT defect_part, defec_desc, suggested_replacement_repair, remark_analysis, overall_status, checked_by  FROM LOG_MACHINETABLE WHERE groupID = {id};";
                DataTable _data = sql.ExecuteQuery(query);
                _new_data_section(_data);
            }

        }

        public void _new_data_section(DataTable data)
        {
            DataGridView _data = new DataGridView();
            List<bool> statusList = new List<bool>();


            foreach (DataRow row in data.Rows)
            { statusList.Add((bool)row["overall_status"]);}

            data.Columns.Remove("overall_status");
            data.Columns.Add("Overall-Status", typeof(string));
            for (int i = 0; i < data.Rows.Count; i++)
            {
                data.Rows[i]["Overall-Status"] = statusList[i] ? "Defective" : "Satisfaction";
            }


            _data.DataSource = data;
            _data.AutoSize = true;
            flowparent.Controls.Add(_data);
            pergroups.Add(_data);

        }

        public void _delete_all()
        {
           foreach(DataGridView gridview in pergroups)
            {
                gridview.Dispose();
            }
            pergroups.Clear();
        }
    }






    public class buttonPerHistory
    {
        public List<ButtonItem> buttons = new List<ButtonItem>();
        private SQL_Support sql = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");
        private FlowLayoutPanel button_container;
        private MachineViewer parent;

        public buttonPerHistory(MachineViewer parent, FlowLayoutPanel button_container)
        {
            this.parent = parent;
            this.button_container = button_container;
        }

        public void _remove_all_buttons()
        {
            foreach (ButtonItem button in buttons){button.Dispose();}
            buttons.Clear();
        }

        public void _add_button(int id_of_history_log, DateTime history)
        {
            ButtonItem historylog_btn = new ButtonItem(id_of_history_log, parent);
            buttons.Add(historylog_btn);
            historylog_btn.TopLevel = false;
            historylog_btn.RenameBtn(history);
            button_container.Controls.Add(historylog_btn);
            historylog_btn.Show();
        }

        public void showAllResults()
        {
            _remove_all_buttons();
            sql._isDebugShow = true;
            DataTable data = sql.ExecuteQuery("SELECT * FROM EXECUTION_HISTORY");
            foreach (DataRow row in data.Rows)
            {
                int id = Convert.ToInt32(row["ID"]);
                DateTime history = Convert.ToDateTime(row["date_commit"]);
                _add_button(id, history);
            }
        }

        public void showResultsWithFilter(params string[] Filter )
        {
            
        }

    }



}
