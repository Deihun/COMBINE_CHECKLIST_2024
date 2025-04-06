using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMBINE_CHECKLIST_2024.SQLFolder;

namespace COMBINE_CHECKLIST_2024.Addons
{
    class theme_management
    {
        string theme = "";
        public theme_management()
        {
            var savecache = new savecacheHandler();
            theme = savecache.Theme;
        }
        public void SetGradientBackground(Form form)
        {
            Color color1 = ColorTranslator.FromHtml(get_hex_gradiant1());
            Color color2 = ColorTranslator.FromHtml(get_hex_gradiant2());

            Bitmap bmp = new Bitmap(form.Width, form.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Rectangle(0, 0, form.Width, form.Height),
                color1,
                color2,
                LinearGradientMode.Vertical)) // Change direction if needed
            {
                g.FillRectangle(brush, 0, 0, form.Width, form.Height);
            }
            form.BackgroundImage = bmp;
        }

        public Color get_font_color()
        {
            switch (theme)
            {
                case "standard":
                    return Color.White;
                case "lavender":
                    return ColorTranslator.FromHtml("#f9e3ff");
                case "sky":
                    return ColorTranslator.FromHtml("#001330");
                default:
                    return Color.White;
            }
        }
        public Color get_font_color2()
        {
            switch (theme)
            {
                case "darkmode":
                    return Color.White;
                default:
                    return Color.Black;
            }
        }

        public Color get_color_top_board()
        {
            switch (theme)
            {
                case "standard":
                    return Color.DarkOliveGreen;
                case "lavender":
                    return ColorTranslator.FromHtml("#402b3a");
                case "sky":
                    return ColorTranslator.FromHtml("#9cadb8");
                case "spicy":
                    return ColorTranslator.FromHtml("#70311c");
                case "gray":
                    return ColorTranslator.FromHtml("#6d6e6b");
                case "darkmode":
                    return ColorTranslator.FromHtml("#1d2226");
                default:
                    return Color.DarkOliveGreen;
            }
        }

        public Color get_color_buttonPerItem()
        {
            switch (theme)
            {
                case "standard":
                    return Color.YellowGreen;
                case "lavender":
                    return ColorTranslator.FromHtml("#53495c");
                case "sky":
                    return ColorTranslator.FromHtml("#b6bbbf");
                case "spicy":
                    return ColorTranslator.FromHtml("#997367");
                case "gray":
                    return ColorTranslator.FromHtml("#8c8c8c");
                case "darkmode":
                    return ColorTranslator.FromHtml("#454545");
                default:
                    return Color.YellowGreen;
            }
        }

        public Color get_color_from_theme_dashboard()
        {
            switch (theme)
            {
                case "standard":
                    return Color.SeaGreen;
                case "lavender":
                    return ColorTranslator.FromHtml("#543c61");
                case "sky":
                    return ColorTranslator.FromHtml("#bcd4d2");
                case "spicy":
                    return ColorTranslator.FromHtml("#913f00");
                case "gray":
                    return ColorTranslator.FromHtml("#7f807c");
                case "darkmode":
                    return ColorTranslator.FromHtml("#0e1012");
                default:
                    return Color.SeaGreen;
            }
        }

        public Color get_color_bottom_bar()
        {
            switch (theme)
            {
                case "standard":
                    return Color.OliveDrab;
                case "lavender":
                    return ColorTranslator.FromHtml("#573657");
                case "sky":
                    return ColorTranslator.FromHtml("#b2c9d4");
                case "spicy":
                    return ColorTranslator.FromHtml("#9c4019");
                case "gray":
                    return ColorTranslator.FromHtml("#a1a1a1");
                case "darkmode":
                    return ColorTranslator.FromHtml("#232729");
                default:
                    return Color.OliveDrab;

            }
        }
        private string get_hex_gradiant1()
        {
            switch (theme)
            {
                case "standard":
                    return "#D1FFC3";
                case "lavender":
                    return "#ffe8ff";
                case "sky":
                    return "#cffff9";
                case "gray":
                    return "#edf2df";
                case "spicy":
                    return "#fcd8a4";
                case "darkmode":
                    return "#242c30";
                default:
                    return "#D1FFC3";
            }
        }

        private string get_hex_gradiant2()
        {
            switch (theme)
            {
                case "standard":
                    return "#79AE86";
                case "lavender" :
                    return "#df94ff";
                case "sky":
                    return "#59c2ff";
                case "gray":
                    return "#cdcfc8";
                case "spicy":
                    return "#eba773";
                case "darkmode":
                    return "#17232b";

                default:
                    return "#79AE86";
            }
        }
    }
}
