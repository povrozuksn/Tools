using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tools
{
    public partial class AdminShopsUC : UserControl
    {
        public AdminShopsUC()
        {
            InitializeComponent();
        }

        private void AdminShopsUC_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);

            List<string> cities = SQLClass.MySelect("SELECT id, Name FROM cities");

            CityComboBox.Items.Clear();
            for (int i = 0; i < cities.Count; i += 2)
            {
                CityComboBox.Items.Add(cities[i + 1]);
            }

            List<string> shops = SQLClass.MySelect("SELECT id, name, city FROM shops");

            int y = 50;
            for (int i = 0; i < shops.Count; i += 3)
            {
                Label lbl2 = new Label();
                lbl2.Text = shops[i + 1];
                lbl2.Location = new Point(100, y);
                lbl2.Size = new Size(200, 30);
                lbl2.Tag = shops[i];
                panel1.Controls.Add(lbl2);

                Label lbl3 = new Label();
                lbl3.Text = shops[i + 2];
                lbl3.Location = new Point(350, y);
                lbl3.Size = new Size(200, 30);
                panel1.Controls.Add(lbl3);

                Button btn = new Button();
                btn.Location = new Point(550, y);
                btn.Size = new Size(100, 30);
                btn.Text = "Удалить";
                btn.Click += new EventHandler(DelShopClick);
                panel1.Controls.Add(btn);

                y += 40;
            }
        }

        string adress;

        private void AddPicShopBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adress = openFileDialog1.FileName;
                PicShopPB.Load(adress);
                adress = Path.GetFileName(adress);
            }
        }

        private void AddShopBtn_Click(object sender, EventArgs e)
        {
            if (NameShopTB.Text != "" && CityComboBox.Text != "")
            {
                SQLClass.MyUpDate("INSERT INTO shops (name, rating, city, pic) VALUES ('" + NameShopTB.Text + "','" + RatingComboBox.Text + "','" + CityComboBox.Text + "','" + adress + "' )");
                MessageBox.Show("Сохранено");
                NameShopTB.Text = "";
                RatingComboBox.Text = "";
                CityComboBox.Text = "";
                PicShopPB.Image = null;
                AdminShopsUC_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Заполните обязательный поля");
            }
        }

        private void DelShopClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;
            foreach (Control control in panel1.Controls)
            {
                if (control.Location == new Point(100, y))
                {
                    SQLClass.MyUpDate("DELETE FROM shops WHERE id = '" + control.Tag + "'");
                    MessageBox.Show("Успешно удалено");
                }
            }
            AdminShopsUC_Load(sender, e);
        }
    }
}
