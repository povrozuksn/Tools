using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Tools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();            

            ShopsUC shops = new ShopsUC();
            shops.Dock = DockStyle.Fill;
            InfoPanel.Controls.Add(shops); 
        }
    }
}
