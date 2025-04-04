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
    public partial class Select_An_Item_To_Add_Form: Form
    {
        public Select_An_Item_To_Add_Form()
        {
            InitializeComponent();
        }

        private void add_new_item_btn_Click(object sender, EventArgs e)
        {
            AddIndependent_Item_Form addIndependent_Item_Form = new AddIndependent_Item_Form();
            addIndependent_Item_Form.ShowDialog();
        }
    }
}
