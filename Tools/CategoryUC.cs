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
    public partial class CategoryUC : UserControl
    {
        string id_shop;
        public CategoryUC(string _id)
        {
            InitializeComponent();

            id_shop = _id;

            List<string> shop_list = SQLClass.MySelect("SELECT id, name, pic FROM shops WHERE id = '" + id_shop + "'");
            try 
            { 
                ShopPictureBox.Load("../../Pictures/" + shop_list[2]);            
            }
            catch (Exception) { }
            
            ShopNameLabel.Text = shop_list[1];


            List<string> categors_list = SQLClass.MySelect("SELECT id, name, pic, id_shop FROM categors WHERE id_shop = '" + id_shop + "'");
            int x = 3;
            int y = 265;
            for (int i = 0; i < categors_list.Count; i += 4)
            {
                Label lbl = new Label();
                lbl.Location = new Point(x, y+190);
                lbl.Size = new Size(200, 30);
                lbl.Text = categors_list[i + 1];
                Controls.Add(lbl);

                PictureBox pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + categors_list[i + 2]);
                }
                catch (Exception) { }
                pb.Location = new Point(x, y);
                pb.Size = new Size(240, 180);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = categors_list[i];
                pb.Click += new EventHandler(pb_Click);
                Controls.Add(pb);

                x += 280;

            }

            DesingUC.ApplyDesign(this);
        }

        private void pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            ToolsUC tools = new ToolsUC(pb.Tag.ToString());
            tools.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(tools);
        }
    }
}
