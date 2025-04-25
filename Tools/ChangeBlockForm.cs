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
    public partial class ChangeBlockForm : Form
    {
        Control ctrl;
        public ChangeBlockForm(Control _ctrl)
        {
            InitializeComponent();

            ctrl = _ctrl;
            NameLabel.Text = "Название: " + _ctrl.Name;
            HeightTextBox.Text = _ctrl.Height.ToString();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            ctrl.Size = new Size(ctrl.Size.Width, Convert.ToInt32(HeightTextBox.Text));

            SQLClass.MyUpDate("DELETE FROM uniquedesign WHERE type = '" + ctrl.GetType() + "' AND parameter = 'Height' AND name = '" + ctrl.Name + "' AND form = '" + ctrl.FindForm().Name + "'");

            SQLClass.MyUpDate("INSERT INTO uniquedesign (type, parameter, name, form, value) VALUE ('" + ctrl.GetType() + "', 'Height', '" + ctrl.Name + "', '" + ctrl.FindForm().Name + "', '" + ctrl.Height + "')");

            Close();
        }
    }
}
