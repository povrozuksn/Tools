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
    public partial class ToolsUC : UserControl
    {
        string id_category;
        public ToolsUC(string _id)
        {
            InitializeComponent();
            id_category = _id;

            List<string> category_list = SQLClass.MySelect("SELECT id, name, pic FROM categors WHERE id = '" + id_category + "'");
            CategoryPB.Load("../../Pictures/" + category_list[2]);
            CategoryLabel.Text = category_list[1];

            List<string> tools_list = SQLClass.MySelect("SELECT id, name, pic FROM tools WHERE id_category = '" + id_category + "'");
            int x = 3;
            int y = 265;
            for (int i = 0; i < tools_list.Count; i += 3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(x, y + 190);
                lbl.Size = new Size(200, 30);
                lbl.Text = tools_list[i + 1];
                Controls.Add(lbl);

                PictureBox pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + tools_list[i + 2]);
                }
                catch (Exception) { }
                pb.Location = new Point(x, y);
                pb.Size = new Size(240, 180);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = tools_list[i];
                pb.Click += new EventHandler(pb_Click);
                Controls.Add(pb);

                x += 280;

            }

            DesingUC.ApplyDesign(this);
        }
        private void pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            ProductUC product = new ProductUC(pb.Tag.ToString());
            product.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(product);
        }

    }
}
