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
    public partial class DesignButtonForm : Form
    {
        Button btn;
        public DesignButtonForm(Button _btn)
        {
            InitializeComponent();
            btn = _btn;
            
        }

        private void ButtonFontBTN_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = btn.Font;
            fontDialog1.Color = btn.ForeColor;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                btn.Font = fontDialog1.Font;
                btn.ForeColor = fontDialog1.Color;

                DesignButtonForm_Load(null, null);

                SQLClass.MyUpDate("DELETE FROM uniquedesign WHERE type = '" + btn.GetType() + "' AND parameter = 'Font' AND name = '" + btn.Name + "' AND form = '" + btn.FindForm().Name + "'");
                SQLClass.MyUpDate("DELETE FROM uniquedesign WHERE type = '" + btn.GetType() + "' AND parameter = 'Font_Color' AND name = '" + btn.Name + "' AND form = '" + btn.FindForm().Name + "'");

                SQLClass.MyUpDate("INSERT INTO uniquedesign (type, parameter, name, form, value) VALUE ('" + btn.GetType() + "', 'Font', '" + btn.Name + "', '" + btn.FindForm().Name + "', '" + btn.Font.Name + ";" + btn.Font.Size.ToString() + "')");
                SQLClass.MyUpDate("INSERT INTO uniquedesign (type, parameter, name, form, value) VALUE ('" + btn.GetType() + "', 'Font_Color', '" + btn.Name + "', '" + btn.FindForm().Name + "', '" + btn.ForeColor.ToArgb() + "')");

            }
        }

        
        private void ButtonColorBTN_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = btn.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btn.BackColor = colorDialog1.Color;

                DesignButtonForm_Load(null, null);

                SQLClass.MyUpDate("DELETE FROM uniquedesign WHERE type = '" + btn.GetType() + "' AND parameter = 'Color' AND name = '" + btn.Name + "' AND form = '" + btn.FindForm().Name + "'");

                SQLClass.MyUpDate("INSERT INTO uniquedesign (type, parameter, name, form, value) VALUE ('" + btn.GetType() + "', 'Color', '" + btn.Name + "', '" + btn.FindForm().Name + "', '" + btn.BackColor.ToArgb() + "')");

            }

        }

        private void DesignButtonForm_Load(object sender, EventArgs e)
        {
            ExampleButton.Text = btn.Text;
            ExampleButton.BackColor = btn.BackColor;
            ExampleButton.Size = btn.Size;
            ExampleButton.ForeColor = btn.ForeColor;
            ExampleButton.Font = btn.Font;
        }
    }
}
