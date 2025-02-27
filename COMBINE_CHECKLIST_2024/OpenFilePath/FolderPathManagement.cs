using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;
using System.IO;

namespace COMBINE_CHECKLIST_2024.OpenFilePath
{
    class FolderPathManagement
    {
        public FolderPathManagement()
        {

        }

        public string ShowSaveFileDialog()
        {
            return ShowSaveFileDialog(defaultFileName: ""); // Calls the overloaded method with no default name
        }

        public string ShowSaveFileDialog(string defaultFileName)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Save As",
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                DefaultExt = "xlsx",
                AddExtension = true,
                FileName = defaultFileName // Set the default file name
            })
            {
                DialogResult result = saveFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    return saveFileDialog.FileName;
                }

                return string.Empty;
            }
        }
    }
}
