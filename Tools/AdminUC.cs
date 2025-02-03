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
    public partial class AdminUC : UserControl
    {
        public AdminUC()
        {
            InitializeComponent();
        }

        private void AdminShopsBtn_Click(object sender, EventArgs e)
        {
            AdminShopsUC adminshops = new AdminShopsUC();
            adminshops.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(adminshops);
        }

        private void AdminCatBtn_Click(object sender, EventArgs e)
        {
            AdminCatUC admincat = new AdminCatUC();
            admincat.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(admincat);
        }

        private void AdminProdBtn_Click(object sender, EventArgs e)
        {
            AdminProductUC adminprod = new AdminProductUC();
            adminprod.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(adminprod);
        }

        private void AdminUsersBtn_Click(object sender, EventArgs e)
        {
            AdminUsersUC adminusers = new AdminUsersUC();
            adminusers.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(adminusers);
        }
    }
}
