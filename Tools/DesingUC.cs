﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tools
{
    public partial class DesingUC : UserControl
    {
        #region Свойства НАДПИСИ
        public static Font LABEL_FONT;
        public static Color LABEL_COLOR_FONT;
        #endregion

        public DesingUC()
        {
            InitializeComponent();
        }

        public static void ReadDesign()
        {
            string color = SQLClass.MySelect("SELECT value FROM design WHERE type = 'System.Windows.Forms.Label' AND parameter = 'Font_Color'")[0];
            LABEL_COLOR_FONT = Color.FromArgb(Convert.ToInt32(color));
        }

        private void LabelFontBTN_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = LABEL_FONT;
            fontDialog1.Color = LABEL_COLOR_FONT;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                LABEL_FONT = fontDialog1.Font;
                LABEL_COLOR_FONT = fontDialog1.Color;

                DesingUC_Load(null, null);

                SQLClass.MyUpDate("DELETE FROM design WHERE type = '" + label2.GetType() + "' AND parameter = 'Font'");
                SQLClass.MyUpDate("DELETE FROM design WHERE type = '" + label2.GetType() + "' AND parameter = 'Font_Color'");

                SQLClass.MyUpDate("INSERT INTO design (type, parameter, value) VALUES ('" + label2.GetType() + "', 'Font', '" + LABEL_FONT.Name + ";" + LABEL_FONT.Size.ToString() + "')");
                SQLClass.MyUpDate("INSERT INTO design (type, parameter, value) VALUES ('" + label2.GetType() + "', 'Font_Color', '" + LABEL_COLOR_FONT.ToArgb() + "')");
            }
        }

        private void DesingUC_Load(object sender, EventArgs e)
        {
            label2.Font = LABEL_FONT;
            label2.ForeColor = LABEL_COLOR_FONT;
        }
    }
}
