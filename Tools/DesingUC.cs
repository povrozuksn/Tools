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

        #region Свойства ПАНЕЛИ
        public static Color PANEL_COLOR;
        #endregion

        #region Свойства ПОЛЯ ВВОДА
        public static Font TEXTBOX_FONT;
        public static Color TEXTBOX_COLOR_FONT;
        public static Color TEXTBOX_COLOR;
        #endregion

        #region Свойства КНОПКИ
        public static Font BUTTON_FONT;
        public static Color BUTTON_COLOR_FONT;
        public static Color BUTTON_COLOR;
        #endregion

        public static ContextMenuStrip BUTTON_CM;


        public DesingUC()
        {
            InitializeComponent();
        }

        public static void ReadDesign()
        {
            #region Чтение параметров НАДПИСИ
            string label_color = SQLClass.MySelect("SELECT value FROM design WHERE type = 'System.Windows.Forms.Label' AND parameter = 'Font_Color'")[0];
            LABEL_COLOR_FONT = Color.FromArgb(Convert.ToInt32(label_color));

            string label_font = SQLClass.MySelect("SELECT value FROM design WHERE type = 'System.Windows.Forms.Label' AND parameter = 'Font'")[0];
            string[] label_parts = label_font.Split(new char[] {';'});
            LABEL_FONT = new Font(new FontFamily(label_parts[0]), (float)Convert.ToDouble(label_parts[1]));
            #endregion

            #region Чтение параметров ПАНЕЛИ
            string panel_color = SQLClass.MySelect("SELECT value FROM design WHERE type = 'System.Windows.Forms.Panel' AND parameter = 'BackColor'")[0];
            PANEL_COLOR = Color.FromArgb(Convert.ToInt32(panel_color));
            #endregion

            #region Чтение параметров TEXTBOXa
            string textbox_fontcolor = SQLClass.MySelect("SELECT value FROM design WHERE type = 'System.Windows.Forms.TextBox' AND parameter = 'Font_Color'")[0];
            TEXTBOX_COLOR_FONT = Color.FromArgb(Convert.ToInt32(textbox_fontcolor));

            string textbox_font = SQLClass.MySelect("SELECT value FROM design WHERE type = 'System.Windows.Forms.TextBox' AND parameter = 'Font'")[0];
            string[] textbox_parts = textbox_font.Split(new char[] { ';' });
            TEXTBOX_FONT = new Font(new FontFamily(textbox_parts[0]), (float)Convert.ToDouble(textbox_parts[1]));

            string textbox_bgcolor = SQLClass.MySelect("SELECT value FROM design WHERE type = 'System.Windows.Forms.TextBox' AND parameter = 'BackColor'")[0];
            TEXTBOX_COLOR = Color.FromArgb(Convert.ToInt32(textbox_bgcolor));
            #endregion

            #region Чтение параметров КНОПКИ
            string button_fontcolor = SQLClass.MySelect("SELECT value FROM design WHERE type = 'System.Windows.Forms.Button' AND parameter = 'Font_Color'")[0];
            BUTTON_COLOR_FONT = Color.FromArgb(Convert.ToInt32(button_fontcolor));

            string button_font = SQLClass.MySelect("SELECT value FROM design WHERE type = 'System.Windows.Forms.Button' AND parameter = 'Font'")[0];
            string[] button_parts = button_font.Split(new char[] { ';' });
            BUTTON_FONT = new Font(new FontFamily(button_parts[0]), (float)Convert.ToDouble(button_parts[1]));

            string button_bgcolor = SQLClass.MySelect("SELECT value FROM design WHERE type = 'System.Windows.Forms.Button' AND parameter = 'BackColor'")[0];
            BUTTON_COLOR = Color.FromArgb(Convert.ToInt32(button_bgcolor));
            #endregion
        }

        public static void ReadUniqueDesign(Button btn)
        {
            #region Чтение параметров уникального дизайна КНОПКИ

            try
            {
                string button_fontcolor = SQLClass.MySelect("SELECT value FROM uniquedesign WHERE type = 'System.Windows.Forms.Button' AND parameter = 'Font_Color' AND name = '" + btn.Name + "' AND form = '" + btn.FindForm().Name + "'")[0];
                btn.ForeColor = Color.FromArgb(Convert.ToInt32(button_fontcolor));
            }
            catch (Exception) { }
            try
            {
                string button_font = SQLClass.MySelect("SELECT value FROM uniquedesign WHERE type = 'System.Windows.Forms.Button' AND parameter = 'Font' AND name = '" + btn.Name + "' AND form = '" + btn.FindForm().Name + "'")[0];
                string[] button_parts = button_font.Split(new char[] { ';' });
                btn.Font = new Font(new FontFamily(button_parts[0]), (float)Convert.ToDouble(button_parts[1]));
            }
            catch (Exception) { }
            try
            {
                string button_bgcolor = SQLClass.MySelect("SELECT value FROM uniquedesign WHERE type = 'System.Windows.Forms.Button' AND parameter = 'Color' AND name = '" + btn.Name + "' AND form = '" + btn.FindForm().Name + "'")[0];
                btn.BackColor = Color.FromArgb(Convert.ToInt32(button_bgcolor));
            }
            catch (Exception) { }
            #endregion

        }

        public static void ReadBlockDesign(Control block)
        {           
            #region Чтение размеров блока из БД 
            try
            {
                string height = SQLClass.MySelect("SELECT value FROM uniquedesign WHERE type = 'System.Windows.Forms.Panel' AND parameter = 'Height' AND name = '" + block.Name + "' AND form = '" + block.FindForm().Name + "'")[0];

                if (block is Panel)
                {
                    block.Size = new Size(block.Width, Convert.ToInt32(height));
                }

            }
            catch (Exception) { }
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
                    ReadBlockDesign(control_element as Panel);
                }
                else
                {
                    ApplyDesign(control_element);
                }
                if (control_element is TextBox)
                {
                    control_element.Font = TEXTBOX_FONT;
                    control_element.ForeColor = TEXTBOX_COLOR_FONT;
                    control_element.BackColor = TEXTBOX_COLOR;
                }
                else
                {
                    ApplyDesign(control_element);
                }
                if (control_element is Button)
                {
                    control_element.Font = BUTTON_FONT;
                    control_element.ForeColor = BUTTON_COLOR_FONT;
                    control_element.BackColor = BUTTON_COLOR;
                    ReadUniqueDesign(control_element as Button);
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

            ExampleButton.Font = BUTTON_FONT;
            ExampleButton.ForeColor = BUTTON_COLOR_FONT;
            ExampleButton.BackColor = BUTTON_COLOR;

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

        private void ButtonFontBTN_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = BUTTON_FONT;
            fontDialog1.Color = BUTTON_COLOR_FONT;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                BUTTON_FONT = fontDialog1.Font;
                BUTTON_COLOR_FONT = fontDialog1.Color;

                DesingUC_Load(null, null);

                SQLClass.MyUpDate("DELETE FROM design WHERE type = '" + ExampleButton.GetType() + "' AND parameter = 'Font'");
                SQLClass.MyUpDate("DELETE FROM design WHERE type = '" + ExampleButton.GetType() + "' AND parameter = 'Font_Color'");

                SQLClass.MyUpDate("INSERT INTO design (type, parameter, value) VALUES ('" + ExampleButton.GetType() + "', 'Font', '" + BUTTON_FONT.Name + ";" + BUTTON_FONT.Size.ToString() + "')");
                SQLClass.MyUpDate("INSERT INTO design (type, parameter, value) VALUES ('" + ExampleButton.GetType() + "', 'Font_Color', '" + BUTTON_COLOR_FONT.ToArgb() + "')");
            }
        }

        private void ButtonColorBTN_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = BUTTON_COLOR;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BUTTON_COLOR = colorDialog1.Color;
                DesingUC_Load(null, null);

                SQLClass.MyUpDate("DELETE FROM design WHERE type = '" + ExampleButton.GetType() + "' AND parameter = 'BackColor'");

                SQLClass.MyUpDate("INSERT INTO design (type, parameter, value) VALUES ('" + ExampleButton.GetType() + "', 'BackColor', '" + BUTTON_COLOR.ToArgb() + "')");
            }
        }

        public static void ApplyMenu(Control Form)
        {
            foreach (Control ctrl in Form.Controls)
            {
                if(ctrl is Button)
                {
                    ctrl.ContextMenuStrip = BUTTON_CM;
                }
                else
                {
                    ApplyMenu(ctrl);
                }
            }

        }
    }
}
