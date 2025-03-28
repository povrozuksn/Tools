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
            ExampleButton.Text = btn.Text;
            ExampleButton.BackColor = btn.BackColor;
        }
    }
}
