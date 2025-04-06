using COMBINE_CHECKLIST_2024.Addons;
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

namespace COMBINE_CHECKLIST_2024.Sections.HistoryLog
{
    public partial class History: Form
    {
        private SQL_Support sql;
        public History(SQL_Support sql)
        {
            InitializeComponent();
            this.sql = sql;
        }

        private void History_VisibleChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.ReadOnly = false;
            DataTable data = sql.ExecuteQuery("SELECT Date_Log,Context FROM HISTORY_;");
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var theme = new theme_management();
            theme.SetGradientBackground(this);
        }
    }
}
