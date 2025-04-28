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
    public partial class ChangeHeightForm : Form
    {
        Control ctrl;
        public ChangeHeightForm(Control _ctrl)
        {
            InitializeComponent();

            ctrl = _ctrl;
            NameLabel.Text = "Название: " + _ctrl.Name;
            WidthTextBox.Text = _ctrl.Width.ToString();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {

        }
    }
}
