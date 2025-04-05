using COMBINE_CHECKLIST_2024.DateToText;
using COMBINE_CHECKLIST_2024.Sections.MachineHistory;
using GrapeCity.DataVisualization.Chart;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace COMBINE_CHECKLIST_2024.Sections.Currugator
{
    public partial class Item_Record: Form
    {
        private Form myParent;


        public TextBox _checkby_textbox;
        public TextBox _defectivepart_textbox;
        public RichTextBox _defectivedescription_richtextbox;
        public RichTextBox _suggested_replacement_repair_richtextbox;
        public RichTextBox _remarks_or_analysis_richtextbox;

        public string my_target_time = "12:12AM";
        public DateTime my_targeted_date;
        public bool isDefect = true;
        public int ID_Edit = -1;
        public int ID_inQueue = -1;

        private SQL_Support sql = new SQL_Support("DESKTOP-HBKPAB1\\SQLEXPRESS", "GOODYEAR_MACHINE_HISTORY");


        public Item_Record(Form myParent)
        {
            InitializeComponent();
            Bind_All_PublicControls();
            this.myParent = myParent;

        }


        public Item_Record()
        {
            InitializeComponent();
            Bind_All_PublicControls();
        }

        private void Bind_All_PublicControls()
        {
        _checkby_textbox = this.checkby_textfield;
        _defectivepart_textbox = this.defective_tb;
        _defectivedescription_richtextbox = this.defective_description_rtb;
        _suggested_replacement_repair_richtextbox = this.suggestion_rtb;
        _remarks_or_analysis_richtextbox = this.remarks_rtb;
        }


        private void isdefect_toggle_btn_Click(object sender, EventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                this.trigger_button();
                grouping_of_items parent = this.Parent?.Parent?.Parent as grouping_of_items;
                if (parent is null) return;
                foreach (Control control in parent.items_in_flp.Controls)
                {
                    if (control is Item_Record item)
                    {
                        item.trigger_button(this.isDefect);
                    }
                }

            }
            else
            {
                trigger_button();
            }
        }
        public void trigger_button()
        {
            isDefect = !isDefect;
            isdefect_toggle_btn.BackColor = isDefect ? Color.Khaki : Color.Azure;
            isdefect_toggle_btn.Text = isDefect ? "DEFECTIVE" : "SATISFACTORY";
        }

        public void trigger_button(bool _isDefect)
        {
            isDefect = _isDefect;
            isdefect_toggle_btn.BackColor = isDefect ? Color.Khaki : Color.Azure;
            isdefect_toggle_btn.Text = isDefect ? "DEFECTIVE" : "SATISFACTORY";
        }

        public void setVarCharData(string defectPart, string defectDesc, string suggestedReplacementRepair, string remarkAnalysis, string checkby)
        {
            this.defective_tb.Text = defectPart;
            this.defective_description_rtb.Text = defectDesc;
            this.suggestion_rtb.Text = suggestedReplacementRepair;
            this.remarks_rtb.Text = remarkAnalysis;
            this.checkby_textfield.Text = checkby;
        }
        public void setIsDefect(bool isdefect)
        {
            isDefect = isdefect;
            isdefect_toggle_btn.BackColor = isDefect ? Color.Khaki : Color.Azure;
            isdefect_toggle_btn.Text = isDefect ? "DEFECTIVE" : "SATISFACTORY";
        }


        public string get_defectiveparts()
        {
            return sql.FilterQuery(defective_tb.Text.Equals(string.Empty)? "N/A" : defective_tb.Text);
        }

        public string get_defectiveDescription()
        {
            return sql.FilterQuery(defective_description_rtb.Text.Equals(string.Empty) ? "N/A" : defective_description_rtb.Text);
        }

        public string get_suggestion()
        {
            return sql.FilterQuery(suggestion_rtb.Text.Equals(string.Empty) ? "N/A" : suggestion_rtb.Text);
        }

        public void setAutoComplete()
        {
            AutoCompleteStringCollection checkedByCollection = new AutoCompleteStringCollection();
            AutoCompleteStringCollection defectiveParts = new AutoCompleteStringCollection();
            List<string> defect_desc_suggestion = new List<string>();
            List<string> srr_suggestion = new List<string>();
            List<string> remarks_suggestion = new List<string>();

            DataTable LogMachineTable_DataTable = sql.ExecuteQuery("SELECT * FROM LOG_MACHINETABLE;");
            foreach (DataRow row in sql.ExecuteQuery("SELECT DISTINCT defec_desc, frequency\r\nFROM (\r\n    SELECT TOP 3 defec_desc, COUNT(*) AS frequency\r\n    FROM LOG_MACHINETABLE\r\n    WHERE defec_desc IS NOT NULL AND defec_desc <> ''\r\n    GROUP BY defec_desc\r\n    ORDER BY frequency DESC\r\n) AS freq_data\r\n\r\nUNION\r\n\r\nSELECT defec_desc, NULL AS frequency\r\nFROM (\r\n    SELECT item.defec_desc\r\n    FROM LOG_MACHINETABLE item\r\n    JOIN GROUP_TABLE _group ON _group.GroupID = item.groupID\r\n\tJOIN EXECUTION_HISTORY record ON record.id = _group.historylog_id\r\n    WHERE item.defec_desc IS NOT NULL AND item.defec_desc <> ''\r\n    ORDER BY record.date_commit DESC\r\n    OFFSET 0 ROWS FETCH FIRST 1 ROWS ONLY\r\n) AS recent_data;\r\n").Rows) defect_desc_suggestion.Add(row["defec_desc"].ToString());
            foreach (DataRow row in sql.ExecuteQuery("SELECT DISTINCT suggested_replacement_repair, frequency\r\nFROM (\r\n    SELECT TOP 3 suggested_replacement_repair, COUNT(*) AS frequency\r\n    FROM LOG_MACHINETABLE\r\n    WHERE suggested_replacement_repair IS NOT NULL AND suggested_replacement_repair <> ''\r\n    GROUP BY suggested_replacement_repair\r\n    ORDER BY frequency DESC\r\n) AS freq_data\r\n\r\nUNION\r\n\r\nSELECT suggested_replacement_repair, NULL AS frequency\r\nFROM (\r\n    SELECT item.suggested_replacement_repair\r\n    FROM LOG_MACHINETABLE item\r\n    JOIN GROUP_TABLE _group ON _group.GroupID = item.groupID\r\n\tJOIN EXECUTION_HISTORY record ON record.id = _group.historylog_id\r\n    WHERE item.suggested_replacement_repair IS NOT NULL AND item.suggested_replacement_repair <> ''\r\n    ORDER BY record.date_commit DESC\r\n    OFFSET 0 ROWS FETCH FIRST 1 ROWS ONLY\r\n) AS recent_data;\r\n").Rows) srr_suggestion.Add(row["suggested_replacement_repair"].ToString());
            foreach (DataRow row in sql.ExecuteQuery("SELECT DISTINCT remark_analysis, frequency\r\nFROM (\r\n    SELECT TOP 3 remark_analysis, COUNT(*) AS frequency\r\n    FROM LOG_MACHINETABLE\r\n    WHERE remark_analysis IS NOT NULL AND remark_analysis <> ''\r\n    GROUP BY remark_analysis\r\n    ORDER BY frequency DESC\r\n) AS freq_data\r\n\r\nUNION\r\n\r\nSELECT remark_analysis, NULL AS frequency\r\nFROM (\r\n    SELECT item.remark_analysis\r\n    FROM LOG_MACHINETABLE item\r\n    JOIN GROUP_TABLE _group ON _group.GroupID = item.groupID\r\n\tJOIN EXECUTION_HISTORY record ON record.id = _group.historylog_id\r\n    WHERE item.remark_analysis IS NOT NULL AND item.remark_analysis <> ''\r\n    ORDER BY record.date_commit DESC\r\n    OFFSET 0 ROWS FETCH FIRST 1 ROWS ONLY\r\n) AS recent_data;\r\n").Rows) remarks_suggestion.Add(row["remark_analysis"].ToString());

            foreach (DataRow row in LogMachineTable_DataTable.Rows)
            {
                checkedByCollection.Add(row["checked_by"].ToString());
                defectiveParts.Add(row["defect_part"].ToString());
                
            }
            defect_desc_suggestion = defect_desc_suggestion.Distinct().ToList();
            srr_suggestion = srr_suggestion.Distinct().ToList();
            remarks_suggestion = remarks_suggestion.Distinct().ToList();

            defect_desc_suggestion.Remove("N/A");
            srr_suggestion.Remove("N/A");
            remarks_suggestion.Remove("N/A");

            setAutoComplete(checkby_textfield, checkedByCollection);
            setAutoComplete(defective_tb, defectiveParts);

            ContextMenuStrip contextmenustrip_defectdesc = new ContextMenuStrip();
            ContextMenuStrip contextmenustrip_ssr = new ContextMenuStrip();
            ContextMenuStrip contextmenustrip_remarks = new ContextMenuStrip();

            foreach (string a in defect_desc_suggestion) contextmenustrip_defectdesc.Items.Add(a, null, (sender, e) => change_richtextbox_text(defective_description_rtb, a));
            foreach (string a in srr_suggestion) contextmenustrip_ssr.Items.Add(a, null, (sender, e) => change_richtextbox_text(suggestion_rtb, a));
            foreach (string a in remarks_suggestion) contextmenustrip_remarks.Items.Add(a, null, (sender, e) => change_richtextbox_text(remarks_rtb, a));

            defective_description_rtb.ContextMenuStrip = contextmenustrip_defectdesc;
            suggestion_rtb.ContextMenuStrip = contextmenustrip_ssr;
            remarks_rtb.ContextMenuStrip = contextmenustrip_remarks;

        }
        private void change_richtextbox_text(RichTextBox rtb, string text)
        {
            rtb.Text = text;
        }

        public void set_defective_description(string text)
        {
            defective_description_rtb.Text = text;
        }

        private void setAutoComplete(TextBox textbox, AutoCompleteStringCollection acsc)
        {
            textbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textbox.AutoCompleteCustomSource = acsc;
        }

        public string get_remarks()
        {
            return sql.FilterQuery(remarks_rtb.Text.Equals(string.Empty) ? "N/A" : remarks_rtb.Text);
        }

        public int get_overallAnalysis()
        {
            return isDefect ? 1 : 0;
        }

        public string get_checkby()
        {
            return sql.FilterQuery(checkby_textfield.Text.Equals(string.Empty) ? "N/A" : checkby_textfield.Text);
        }


        private void changeTime_btn_Click(object sender, EventArgs e)
        {
            if (ID_Edit == -1)
            {
                TimeInterval_Picker tip = new TimeInterval_Picker(set_target_time);
                tip.ShowDialog();
            }
            else
            {
                TimeInterval_Picker tip = new TimeInterval_Picker(set_target_time, my_target_time);
                tip.ShowDialog();
            }
        }

        public void set_target_time(string text)
        {
            this.my_target_time = text;
            this.time_preview_tb.Text = text;
        }

        private void defective_description_rtb_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                grouping_of_items parent = this.Parent?.Parent?.Parent as grouping_of_items;
                if (parent is null) return;
                if (e.Control && e.KeyCode == Keys.Q)
                {
                    foreach (Control control in parent.items_in_flp.Controls)
                    {
                        if (control is Item_Record item)
                        {
                            item._defectivedescription_richtextbox.Text = this.defective_description_rtb.Text;
                        }
                    }
                }
                else if (e.Control && e.Shift && e.KeyCode == Keys.V)
                {
                    foreach (Control control in parent.items_in_flp.Controls)
                    {
                        if (control is Item_Record item)
                        {
                            item._defectivedescription_richtextbox.Text = Clipboard.GetText();
                        }
                    }
                }
            }
            catch{}
        }



        private void checkby_textfield_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                grouping_of_items parent = this.Parent?.Parent?.Parent as grouping_of_items;
                if (parent is null) return;
                if (e.Control && e.KeyCode == Keys.Q)
                {

                    foreach (Control control in parent.items_in_flp.Controls)
                    {
                        if (control is Item_Record item)
                        {
                            item._checkby_textbox.Text = this._checkby_textbox.Text;
                        }
                    }
                }
                else if (e.Control && e.Shift && e.KeyCode == Keys.V)
                {
                    foreach (Control control in parent.items_in_flp.Controls)
                    {
                        if (control is Item_Record item)
                        {
                            item._checkby_textbox.Text = Clipboard.GetText();
                        }
                    }
                }
            }
            catch { }
        }



        private void defective_tb_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                grouping_of_items parent = this.Parent?.Parent?.Parent as grouping_of_items;
                if (parent is null) return;
                if (e.Control && e.KeyCode == Keys.Q)
                {

                    foreach (Control control in parent.items_in_flp.Controls)
                    {
                        if (control is Item_Record item)
                        {
                            item._defectivepart_textbox.Text = this._defectivepart_textbox.Text;
                        }
                    }
                }
                else if (e.Control && e.Shift && e.KeyCode == Keys.V)
                {
                    foreach (Control control in parent.items_in_flp.Controls)
                    {
                        if (control is Item_Record item)
                        {
                            item._defectivepart_textbox.Text = Clipboard.GetText();
                        }
                    }
                }
            }
            catch { }
        }

        private void suggestion_rtb_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                grouping_of_items parent = this.Parent?.Parent?.Parent as grouping_of_items;
                if (parent is null) return;
                if (e.Control && e.KeyCode == Keys.Q)
                {

                    foreach (Control control in parent.items_in_flp.Controls)
                    {
                        if (control is Item_Record item)
                        {
                            item._suggested_replacement_repair_richtextbox.Text = this._suggested_replacement_repair_richtextbox.Text;
                        }
                    }
                }
                else if (e.Control && e.Shift && e.KeyCode == Keys.V)
                {
                    foreach (Control control in parent.items_in_flp.Controls)
                    {
                        if (control is Item_Record item)
                        {
                            item._suggested_replacement_repair_richtextbox.Text = Clipboard.GetText();
                        }
                    }
                }
            }
            catch { }
        }

        private void remarks_rtb_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                grouping_of_items parent = this.Parent?.Parent?.Parent as grouping_of_items;
                if (parent is null) return;
                if (e.Control && e.KeyCode == Keys.Q)
                {

                    foreach (Control control in parent.items_in_flp.Controls)
                    {
                        if (control is Item_Record item)
                        {
                            item._remarks_or_analysis_richtextbox.Text = this._remarks_or_analysis_richtextbox.Text;
                        }
                    }
                }
                else if (e.Control && e.Shift && e.KeyCode == Keys.V)
                {
                    foreach (Control control in parent.items_in_flp.Controls)
                    {
                        if (control is Item_Record item)
                        {
                            item._remarks_or_analysis_richtextbox.Text = Clipboard.GetText();
                        }
                    }
                }
            }
            catch { }
        }

        private void isdefect_toggle_btn_MouseEnter(object sender, EventArgs e)
        {
            try
            {
            List<string> guide = new List<string>()
            {
                "- Toggle Between Defective and Satisfactory", "CLICK+CTR\nApply changes of the Toggle Value to all other items"
            };
            grouping_of_items parent = this.Parent?.Parent?.Parent as grouping_of_items;
            if (parent is null) return;
            if (parent.main_parentcreate is null) return;
            Create main_parent = parent.main_parentcreate;

            main_parent.set_guide(guide);
            }
            catch { }
        }

        private void checkby_textfield_MouseEnter(object sender, EventArgs e)
        {
            try
            {
            List<string> guide = new List<string>()
            {
                "- The Person who operates to check the machines", "Leave the field Empty if N/A",
                "CTR+Q\nApply to all other items within the Group" , "CTR+SHIFT+V\n Apply paste from Clipboard to all items in the group"
            };

            grouping_of_items parent = this.Parent?.Parent?.Parent as grouping_of_items;
            Create main_parent = parent?.main_parentcreate;
                if (parent is null) return;
                if (parent.main_parentcreate is null || parent is null) return;
                main_parent.set_guide(guide);
            }
            catch { }

        }

        private void defective_tb_MouseEnter(object sender, EventArgs e)
        {
            try
            {
            List<string> guide = new List<string>()
            {
                "- The name of part of machine that is Defective","Leave the field Empty if N/A",
                "CTR+Q\nApply to all other items within the Group", "CTR+SHIFT+V\n Apply paste from Clipboard to all items in the group"
            };
            grouping_of_items parent = this.Parent?.Parent?.Parent as grouping_of_items;
                if (parent is null) return;
                if (parent.main_parentcreate is null || parent is null) return;
            Create main_parent = parent.main_parentcreate;

            main_parent.set_guide(guide);
            }catch{ }
        }


        private void defective_description_rtb_MouseEnter(object sender, EventArgs e)
        {
            try
            {
           List<string> guide = new List<string>()
            {
                "- Description of whether how or why it happened in that specific Defective Part","Leave the field Empty if N/A",
                "CTR+Q\nApply to all other items within the Group", "CTR+SHIFT+V\n Apply paste from Clipboard to all items in the group", "RIGHTCLICK\nShow a suggestion of an already existing data"
            };
            grouping_of_items parent = this.Parent?.Parent?.Parent as grouping_of_items;
                if (parent is null) return;
                if (parent.main_parentcreate is null || parent is null) return;
            Create main_parent = parent.main_parentcreate;
            

            main_parent.set_guide(guide);
            }
            catch { }
 
        }

        private void suggestion_rtb_MouseEnter(object sender, EventArgs e)
        {
            try
            {
            List<string> guide = new List<string>()
            {
                "- Describes what are the suggested improvements in that particular machine part","Leave the field Empty if N/A",
                "CTR+Q\nApply to all other items within the Group", "CTR+SHIFT+V\n Apply paste from Clipboard to all items in the group", "RIGHTCLICK\nShow a suggestion of an already existing data"
            };
            grouping_of_items parent = this.Parent?.Parent?.Parent as grouping_of_items;
                if (parent is null) return;
                if (parent.main_parentcreate is null || parent is null) return;
            Create main_parent = parent.main_parentcreate;

            main_parent.set_guide(guide);
            }
            catch { }

        }

        private void remarks_rtb_MouseEnter(object sender, EventArgs e)
        {
            try
            {
            List<string> guide = new List<string>()
            {
                "- The overall evaluation or explanation","Leave the field Empty if N/A",
                "CTR+Q\nApply to all other items within the Group", "CTR+SHIFT+V\n Apply paste from Clipboard to all items in the group", "RIGHTCLICK\nShow a suggestion of an already existing data"
            };
            grouping_of_items parent = this.Parent?.Parent?.Parent as grouping_of_items;
                if (parent is null) return;
                if (parent.main_parentcreate is null || parent is null) return;
            Create main_parent = parent.main_parentcreate;


            main_parent.set_guide(guide);

            }
            catch { }
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            try
            {
            List<string> guide = new List<string>()
            {
                "- Time Duration of when it happen",
                "Choose between Time-Specified or Time-Interval"
            };
            grouping_of_items parent = this.Parent?.Parent?.Parent as grouping_of_items;
                if (parent is null) return;
                if (parent.main_parentcreate is null) return;
            Create main_parent = parent.main_parentcreate;

            main_parent.set_guide(guide);
            }
            catch { }

        }
    }
}
