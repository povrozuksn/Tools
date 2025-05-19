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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Tools
{
    public partial class MainForm : Form
    {
        public static string UserName = "";
        public static string Login = "";
        public static string UserSurname = "";
        public static int isAdmin;
        public static string OldVal = "RUB";
        public static string NewVal = "RUB";

        public MainForm()
        {
            InitializeComponent();

            HelloLabel.Visible = false;
            AdminButton.Visible = false;
            DesingButton.Visible = false;
            RegButton.Visible = true;

            ShopsUC shops = new ShopsUC();
            shops.Dock = DockStyle.Fill;
            InfoPanel.Controls.Add(shops);

            DesingUC.ReadDesign();
            DesingUC.ApplyDesign(this);

            APIClass.Weather();
            WeatherLabel.Text = "Температура: " + APIClass.temper + "°C";

            APIClass.Vals();
            ValsLabel.Text = "Курсы валют: $-" + APIClass.vals["USD"] + ", €-" + APIClass.vals["EUR"] + ", ¥-" + APIClass.vals["CNY"];
            ValComboBox.SelectedIndex = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string id_level1;
            string id_level2;

            DesingUC.BUTTON_CM = contextMenuStrip1;
            DesingUC.ApplyMenu(this);

            List<string> shops = SQLClass.MySelect("SELECT id, name FROM shops");
            for(int i=0; i<shops.Count; i+=2)
            {
                id_level1 = shops[i];
                TreeNode node0 = new TreeNode(shops[i+1]);
                node0.Tag = id_level1;
                treeView1.Nodes[0].Nodes.Add(node0);

                List<string> categors = SQLClass.MySelect("SELECT id, name FROM categors WHERE id_shop = '" + id_level1 + "'");
                for(int ii=0; ii<categors.Count; ii+=2)
                {
                    id_level2 = categors[ii];
                    TreeNode node1 = new TreeNode(categors[ii + 1]);
                    node1.Tag = id_level2;
                    node0.Nodes.Add(node1);

                    List<string> tools = SQLClass.MySelect("SELECT id, name FROM tools WHERE id_category = '" + id_level2 + "'");
                    for(int iii=0;iii<tools.Count; iii+=2)
                    {
                        TreeNode node2 = new TreeNode(tools[iii+1]);
                        node2.Tag = tools[iii];
                        node1.Nodes.Add(node2);
                    }

                }

            }
        
            
        
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Level == 0 && e.Node.Text == "Магазины")
            {
                ShopsUC shops = new ShopsUC();
                shops.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(shops);
            }
            else if(e.Node.Level == 1 && e.Node.Parent.Text == "Магазины")
            {
                CategoryUC cats = new CategoryUC(e.Node.Tag.ToString());
                cats.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(cats);
            }
            else if (e.Node.Level == 2 && e.Node.Parent.Parent.Text == "Магазины")
            {
                ToolsUC tools = new ToolsUC(e.Node.Tag.ToString());
                tools.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(tools);
            }
            else if (e.Node.Level == 3 && e.Node.Parent.Parent.Parent.Text == "Магазины")
            {
                ProductUC prod = new ProductUC(e.Node.Tag.ToString());
                prod.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(prod);
            }
            else if(e.Node.Level == 0 && e.Node.Text == "Администрирование")
            {
                AdminUC admin = new AdminUC();
                admin.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(admin);
            }
            else if (e.Node.Level == 1 && e.Node.Parent.Text == "Администрирование" && e.Node.Text == "Управление магазинами")
            {
                AdminShopsUC adminshops = new AdminShopsUC();
                adminshops.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(adminshops);
            }
            else if (e.Node.Level == 1 && e.Node.Parent.Text == "Администрирование" && e.Node.Text == "Управление категориями")
            {
                AdminCatUC admincats = new AdminCatUC();
                admincats.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(admincats);
            }
            else if (e.Node.Level == 1 && e.Node.Parent.Text == "Администрирование" && e.Node.Text == "Управление товарами")
            {
                AdminProductUC adminprod = new AdminProductUC();
                adminprod.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(adminprod);
            }
            else if (e.Node.Level == 1 && e.Node.Parent.Text == "Администрирование" && e.Node.Text == "Управление пользователями")
            {
                AdminUsersUC adminusers = new AdminUsersUC();
                adminusers.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(adminusers);
            }
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            List<string> user = SQLClass.MySelect("SELECT login, name, secondname, admin FROM users WHERE login = '" + LoginTextBox.Text + "' AND password = '" + PasTextBox.Text + "'");
            if (AuthButton.Text == "Выйти")
            {
                UserName = "";
                UserSurname = "";
                Login = "";
                isAdmin = 0;
                AuthPanel.Controls.Clear();
                AuthPanel.Controls.Add(label1);
                AuthPanel.Controls.Add(label2);
                LoginTextBox.Text = "";
                AuthPanel.Controls.Add(LoginTextBox);
                PasTextBox.Text = "";
                AuthPanel.Controls.Add(PasTextBox);
                AuthButton.Text = "Войти";
                AuthPanel.Controls.Add(AuthButton);
                HelloLabel.Text = "";
                HelloLabel.Visible = false;
                AdminButton.Visible = false;
                DesingButton.Visible = false;
                AuthPanel.Controls.Add(AdminButton);
                AuthPanel.Controls.Add(DesingButton);
                RegButton.Visible = true;
                AuthPanel.Controls.Add(RegButton);

            }
            else
            {
                if (user.Count > 0)
                {
                    Login = user[0];
                    UserName = user[1];
                    UserSurname = user[2];
                    isAdmin = Convert.ToInt32(user[3]);
                    AuthPanel.Controls.Clear();
                    AuthPanel.Controls.Add(HelloLabel);
                    HelloLabel.Visible = true;
                    HelloLabel.Text = "Приветствуем Вас, " + UserName + " " + UserSurname;
                    AuthPanel.Controls.Add(AdminButton);
                    AuthPanel.Controls.Add(DesingButton);
                    AuthButton.Text = "Выйти";
                    AdminButton.Visible = Convert.ToBoolean(isAdmin);
                    DesingButton.Visible = Convert.ToBoolean(isAdmin);
                    AuthPanel.Controls.Add(AuthButton);
                    RegButton.Visible = false;
                    AuthPanel.Controls.Add(RegButton);
                }
                else
                {
                    LoginTextBox.Text = "";
                    PasTextBox.Text = "";
                    var result = MessageBox.Show("Вы указали неверный логин/пароль или незарегистрированы. Хотите зарегистрироваться?", "Ошибка авторизации", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //RegForm regForm = new RegForm();
                        //regForm.ShowDialog();
                    }
                }
            }
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminUC admin = new AdminUC();
            admin.Dock = DockStyle.Fill;
            InfoPanel.Controls.Clear();
            InfoPanel.Controls.Add(admin);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isAdmin == 1 && treeView1.Nodes.Count == 1)
            {
                TreeNode node = new TreeNode("Администрирование");
                treeView1.Nodes.Add(node);

                TreeNode node1 = new TreeNode("Управление магазинами");
                node.Nodes.Add(node1);

                TreeNode node2 = new TreeNode("Управление категориями");
                node.Nodes.Add(node2);

                TreeNode node3 = new TreeNode("Управление товарами");
                node.Nodes.Add(node3);

                TreeNode node4 = new TreeNode("Управление пользователями");
                node.Nodes.Add(node4);
            }
            else if (isAdmin != 1 && treeView1.Nodes.Count > 1) 
            {
                treeView1.Nodes.RemoveAt(1);
            }
        }

        private void DesingButton_Click(object sender, EventArgs e)
        {
            DesingUC desing = new DesingUC();
            desing.Dock = DockStyle.Fill;
            InfoPanel.Controls.Clear();
            InfoPanel.Controls.Add(desing);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void DisignBottonCMS_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ContextMenuStrip cm = (ContextMenuStrip)(item.GetCurrentParent());
            Button btn = (Button)(cm.SourceControl);
            DesignButtonForm designButton = new DesignButtonForm(btn);
            designButton.ShowDialog();
        }

        private void ChangeBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ContextMenuStrip cm = (ContextMenuStrip)(item.GetCurrentParent());
            Panel panel = (Panel)cm.SourceControl;
            ChangeBlockForm changeBlock = new ChangeBlockForm(panel);
            changeBlock.ShowDialog();
        }

        private void changeWidthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ContextMenuStrip cm = (ContextMenuStrip)(item.GetCurrentParent());
            TreeView tv = (TreeView)cm.SourceControl;
            //TableLayoutPanel table = (TableLayoutPanel)tv.Parent;
            //TableLayoutPanelCellPosition pos = table.GetPositionFromControl(tv);

            ChangeHeightForm chf = new ChangeHeightForm(tv);
            chf.ShowDialog();

            tableLayoutPanel1.ColumnStyles[0].Width = ChangeHeightForm.width;
        }

        private void ValComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OldVal = NewVal;
            NewVal = ValComboBox.Text;

            double coef = APIClass.vals[OldVal] / APIClass.vals[NewVal];

            var pricelbl = Controls.Find("PriceLabel", true);

            foreach(Label lbl in pricelbl)
            {
                double price = Convert.ToDouble(lbl.Text);
                price = Math.Round((price * coef), 2);
                lbl.Text = price.ToString();
            }

            var vallbl = Controls.Find("ValLabel", true);

            foreach (Label lbl in vallbl)
            {
                if(NewVal=="RUB")
                {
                    lbl.Text = "Цена, руб.: ";
                }
                else if (NewVal == "USD")
                {
                    lbl.Text = "Цена, $: ";
                }
                else if (NewVal == "EUR")
                {
                    lbl.Text = "Цена, €: ";
                }
                else if (NewVal == "CNY")
                {
                    lbl.Text = "Цена, ¥: ";
                }
            }
        }
    }
}
