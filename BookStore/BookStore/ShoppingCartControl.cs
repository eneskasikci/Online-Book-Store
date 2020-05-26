using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class ShoppingCartControl : UserControl
    {
        ItemToPurchase thisitem;
        public ShoppingCartControl(ItemToPurchase item)
        {
            InitializeComponent();
            thisitem = item;
            idLabel.Text += item.Product.ID;
            nameLabel.Text += item.Product.Name;
            priceLabel.Text += item.Product.Price;
            numericUpDown.Value = item.Quantity;
            itemPictureBox.BackgroundImage =
            (Bitmap)Properties.Resources.ResourceManager.GetObject(item.Product.ID.ToString());
        }

        int index, i;
        public void deletefromCartButton_Click(object sender, EventArgs e)
        {
            i = 0;
            foreach (var item in Shop.cart.ItemsToPurchase)
            {
                if (item.Product.ID == thisitem.Product.ID)
                { index = i; break; }i++;
            }
            Shop.cart.removeProduct(index);
            this.Hide();
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            i = 0;
            foreach (var item in Shop.cart.ItemsToPurchase)
            {
                if (item.Product.ID == thisitem.Product.ID)
                { index = i; break; }i++;
            }
            Shop.cart.ItemsToPurchase[index].Quantity = (int)numericUpDown.Value;
        }
    }
}
