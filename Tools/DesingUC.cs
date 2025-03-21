using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tools
{
    public partial class DesingUC : UserControl
    {
        #region Свойства НАДПИСИ
        public static Font LABEL_FONT;
        public static Color LABEL_COLOR_FONT;
        #endregion

        #region Свойства ПАНЕЛИ
        public static Color PANEL_COLOR;
        #endregion

        #region
        public static Font TEXTBOX_FONT;
        public static Color TEXTBOX_COLOR_FONT;
        public static Color TEXTBOX_COLOR;
        #endregion


        public DesingUC()
        {
            InitializeComponent();
        }

        public static void ReadDesign()
        {
            #region Чтение параметров НАДПИСИ
            string label_color = SQLClass.MySelect("SELECT value FROM design WHERE type = 'System.Windows.Forms.Label' AND parameter = 'Font_Color'")[0];
            LABEL_COLOR_FONT = Color.FromArgb(Convert.ToInt32(label_color));

            string font = SQLClass.MySelect("SELECT value FROM design WHERE type = 'System.Windows.Forms.Label' AND parameter = 'Font'")[0];
            string[] parts = font.Split(new char[] {';'});
            LABEL_FONT = new Font(new FontFamily(parts[0]), (float)Convert.ToDouble(parts[1]));
            #endregion

            #region Чтение параметров ПАНЕЛИ
            string panel_color = SQLClass.MySelect("SELECT value FROM design WHERE type = 'System.Windows.Forms.Panel' AND parameter = 'BackColor'")[0];
            PANEL_COLOR = Color.FromArgb(Convert.ToInt32(panel_color));
            #endregion

            #region Чтение параметров TEXTBOXa

            #endregion
        }

        public static void ApplyDesign(Control Form)
        {
            foreach(Control control_element in Form.Controls)
            {
                if(control_element is Label)
                {
                    control_element.Font = LABEL_FONT;
                    control_element.ForeColor = LABEL_COLOR_FONT;
                }
                else
                {
                    ApplyDesign(control_element);
                }
                if (control_element is Panel)
                {
                    control_element.BackColor = PANEL_COLOR;
                }
                else
                {
                    ApplyDesign(control_element);
                }
            }
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

            ExamplePanel.BackColor = PANEL_COLOR;

            ExampleTextBox.Font = TEXTBOX_FONT;
            ExampleTextBox.ForeColor = TEXTBOX_COLOR_FONT;
            ExampleTextBox.BackColor = TEXTBOX_COLOR;
            
        }

        private void PanelColorBTN_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = PANEL_COLOR;

            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                PANEL_COLOR = colorDialog1.Color;
                DesingUC_Load(null, null);

                SQLClass.MyUpDate("DELETE FROM design WHERE type = '" + ExamplePanel.GetType() + "' AND parameter = 'BackColor'");

                SQLClass.MyUpDate("INSERT INTO design (type, parameter, value) VALUES ('" + ExamplePanel.GetType() + "', 'BackColor', '" + PANEL_COLOR.ToArgb() + "')");
            }

        }

        private void TextBoxFontBTN_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = TEXTBOX_FONT;
            fontDialog1.Color = TEXTBOX_COLOR_FONT;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                TEXTBOX_FONT = fontDialog1.Font;
                TEXTBOX_COLOR_FONT = fontDialog1.Color;

                DesingUC_Load(null, null);

                SQLClass.MyUpDate("DELETE FROM design WHERE type = '" + ExampleTextBox.GetType() + "' AND parameter = 'Font'");
                SQLClass.MyUpDate("DELETE FROM design WHERE type = '" + ExampleTextBox.GetType() + "' AND parameter = 'Font_Color'");

                SQLClass.MyUpDate("INSERT INTO design (type, parameter, value) VALUES ('" + ExampleTextBox.GetType() + "', 'Font', '" + TEXTBOX_FONT.Name + ";" + TEXTBOX_FONT.Size.ToString() + "')");
                SQLClass.MyUpDate("INSERT INTO design (type, parameter, value) VALUES ('" + ExampleTextBox.GetType() + "', 'Font_Color', '" + TEXTBOX_COLOR_FONT.ToArgb() + "')");
            }

        }

        private void TextBoxColorBTN_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = TEXTBOX_COLOR;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                TEXTBOX_COLOR = colorDialog1.Color;
                DesingUC_Load(null, null);

                SQLClass.MyUpDate("DELETE FROM design WHERE type = '" + ExampleTextBox.GetType() + "' AND parameter = 'BackColor'");

                SQLClass.MyUpDate("INSERT INTO design (type, parameter, value) VALUES ('" + ExampleTextBox.GetType() + "', 'BackColor', '" + TEXTBOX_COLOR.ToArgb() + "')");
            }

        }
    }
}
