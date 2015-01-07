using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShop
{
    public partial class SuperShopUI : Form
    {
        public SuperShopUI()
        {
            InitializeComponent();
        }

        private SuperShop aSuperShop;
        private void save_Button_Click(object sender, EventArgs e)
        {
            aSuperShop = new SuperShop(shopNameTextBox.Text, shopAddressTextBox.Text);
            MessageBox.Show("Shop Created");
        }

        private void add_Item_Button_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(productIdTextBox.Text);
            int quantity = Convert.ToInt32(quantityTextBox.Text);
            Product aProduct = new Product(productId, quantity);
            string alert = aSuperShop.AddItem(aProduct);
            MessageBox.Show(alert);
        }

        private void ShowDetailsButton_Click(object sender, EventArgs e)
        {

        }

    }
}
