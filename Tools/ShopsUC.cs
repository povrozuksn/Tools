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
    public partial class ShopsUC : UserControl
    {
        public ShopsUC()
        {
            InitializeComponent();

            List<string> shops_list = SQLClass.MySelect("SELECT id, name, pic FROM shops");

            int x = 30;
            int y = 50;
            for (int i = 0; i < shops_list.Count; i += 3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(x, y + 200);
                lbl.Size = new Size(200, 30);
                lbl.Text = shops_list[i + 1];
                Controls.Add(lbl);

                PictureBox pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + shops_list[i + 2]);
                }
                catch (Exception) { }
                pb.Location = new Point(x, y);
                pb.Size = new Size(260, 200);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = shops_list[i];
                pb.Click += new EventHandler(pb_Click);
                Controls.Add(pb);

                x += 280;
                
            }

            DesingUC.ApplyDesign(this);
        }

        private void pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            CategoryUC categors = new CategoryUC(pb.Tag.ToString());
            categors.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(categors);
        }
    }
}
