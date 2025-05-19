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
    public partial class ProductUC : UserControl
    {
        string id_product;
        public ProductUC(string _id)
        {
            InitializeComponent();
            id_product = _id;

            List<string> product_list = SQLClass.MySelect("SELECT id, name, pic, price, quantity FROM tools WHERE id = '" + id_product + "'");
            ProductPB.Load("../../Pictures/" + product_list[2]);
            ProductLabel.Text = product_list[1];

            ValLabel.Text = "Цена, руб.: ";
            PriceLabel.Text = product_list[3];
            QuantityLabel.Text = "Количество: " + product_list[4] + " шт.";

            DesingUC.ApplyDesign(this);

        }
    }
}
