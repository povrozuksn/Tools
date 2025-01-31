﻿using System;
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            string id_level1;
            string id_level2;

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
        }
    }
}
