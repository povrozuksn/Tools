using System;
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

        private void LabelFontBTN_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = LABEL_FONT;
            fontDialog1.Color = LABEL_COLOR_FONT;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                LABEL_FONT = fontDialog1.Font;
                LABEL_COLOR_FONT = fontDialog1.Color;

                DesingUC_Load(null, null);
            }
        }

        private void DesingUC_Load(object sender, EventArgs e)
        {
            label2.Font = LABEL_FONT;
            label2.ForeColor = LABEL_COLOR_FONT;
        }
    }
}
