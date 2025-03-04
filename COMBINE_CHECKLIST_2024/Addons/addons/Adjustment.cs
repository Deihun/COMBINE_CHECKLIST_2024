using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMBINE_CHECKLIST_2024.Addons
{
    using System.Drawing;
    using System.Windows.Forms;

    public class FormScaler
    {
        private SizeF _designTimeScale;

         public FormScaler()
        {
            // Assume design-time scale is 96 DPI (100%)
            _designTimeScale = new SizeF(96f, 96f);
        }

        public void ApplyScaling(Form form)
        {
            form.AutoScaleMode = AutoScaleMode.Dpi;
            if (form == null) return;

            // Get current system DPI
            using (Graphics g = form.CreateGraphics())
            {
                SizeF currentScale = new SizeF(g.DpiX, g.DpiY);

                // Calculate scaling factors
                float scaleX = currentScale.Width / _designTimeScale.Width;
                float scaleY = currentScale.Height / _designTimeScale.Height;

                // Apply scaling to the form and its controls
                ScaleControl(form, scaleX, scaleY);
            }
        }

        public void ScaleFormToParent(Form form, Control parent)
        {
            if (form == null || parent == null) return;

            // Ensure the form is not a top-level window
            form.TopLevel = false;

            // Calculate scaling factors based on parent's size
            float scaleX = (float)parent.ClientSize.Width / form.Width;
            float scaleY = (float)parent.ClientSize.Height / form.Height;
            float scale = Math.Min(scaleX, scaleY); // Maintain aspect ratio

            // Apply scaling to the form
            form.Width = (int)(form.Width * scale);
            form.Height = (int)(form.Height * scale);

            // Center the form within the parent
            form.Location = new Point(
                (parent.ClientSize.Width - form.Width) / 2,
                (parent.ClientSize.Height - form.Height) / 2
            );

        }


        private void ScaleControl(Control control, float scaleX, float scaleY)
        {
            if (control == null) return;

            // Scale control's size
            control.Width = (int)(control.Width * scaleX);
            control.Height = (int)(control.Height * scaleY);

            // Scale control's position
            control.Left = (int)(control.Left * scaleX);
            control.Top = (int)(control.Top * scaleY);

            // Scale font size
            if (control.Font != null)
            {
                float newFontSize = control.Font.Size * Math.Min(scaleX, scaleY);
                control.Font = new Font(control.Font.FontFamily, newFontSize, control.Font.Style);
            }

            // Recursively scale child controls
            foreach (Control child in control.Controls)
            {
                ScaleControl(child, scaleX, scaleY);
            }
        }
    }
}
