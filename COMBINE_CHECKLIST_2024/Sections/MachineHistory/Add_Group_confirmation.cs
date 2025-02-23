using COMBINE_CHECKLIST_2024.Sections.Currugator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMBINE_CHECKLIST_2024.Sections.MachineHistory
{
    public partial class Add_Group_confirmation: Form
    {

        private FlowLayoutPanel parent;
        private Create creation_parent;
        public Add_Group_confirmation(FlowLayoutPanel flowlayout, Create creation_parent)
        {
            InitializeComponent();
            from_dtpicker.Value = from_dtpicker.Value;
            to_dtpicker.Value = to_dtpicker.Value;
            parent = flowlayout;
            this.creation_parent = creation_parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void confirmation_btn_Click(object sender, EventArgs e)
        {
            DateTime datefrom = from_dtpicker.Value.Date;  
            DateTime dateTo = to_dtpicker.Value.Date;     


            if (datefrom > dateTo)
            {
                MessageBox.Show("Start date cannot be later than end date");
                return;
            }

            grouping_of_items group = new grouping_of_items(datefrom,dateTo);
            creation_parent.addNewGroups(group);
            group.TopLevel = false;
            parent.Controls.Add(group);
            group.Show();

            DateTime[] dateRange = getDateRangeArray(datefrom, dateTo);

            Console.WriteLine("Generated date range:");
            foreach (var date in dateRange)
            {
                Console.WriteLine(date.ToString("yyyy-MM-dd"));
            }

            foreach (DateTime range in dateRange)
            {
                Item_Record item = new Item_Record(group);
                item.setDate(range);
                group.add_item(item);
            }

            Console.WriteLine("Number of items added: " + dateRange.Length);

            this.Dispose();
        }
        


        private int getDayDifference(DateTime dateStart,DateTime dateEnd)
        {
            return Math.Abs((dateEnd - dateStart).Days);
        }


        private DateTime[] getDateRangeArray(DateTime start, DateTime end)
        {
            int dayDifference = getDayDifference(start, end);
            DateTime[] daterange = new DateTime[dayDifference + 1]; 

            for (int i = 0; i <= dayDifference; i++)
            {
                daterange[i] = start.AddDays(i);
            }

            return daterange;
        }

    }
}
