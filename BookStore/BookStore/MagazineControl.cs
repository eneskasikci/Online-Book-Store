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
    public partial class MagazineControl : UserControl
    {
        Magazine thismagazine;
        public MagazineControl(Magazine magazine)
        {
            InitializeComponent();
            thismagazine = magazine;
            idLabel.Text += magazine.ID;
            nameLabel.Text += magazine.Name;
            priceLabel.Text += magazine.Price;
            issueLabel.Text += magazine.Issue;
            typeLabel.Text += magazine.Type;
            magazinePictureBox.BackgroundImage =
            (Bitmap)Properties.Resources.ResourceManager.GetObject(magazine.ID.ToString());
        }

        private void magazinePictureBox_MouseHover(object sender, EventArgs e)
        {
            magazinePictureBox.Size = new System.Drawing.Size(150, 185);
            magazinePictureBox.Location = new System.Drawing.Point(5, 30);
        }

        private void magazinePictureBox_MouseLeave(object sender, EventArgs e)
        {
            magazinePictureBox.Size = new System.Drawing.Size(110, 145);
            magazinePictureBox.Location = new System.Drawing.Point(29, 36);
        }

        private void addtoCartButton_Click(object sender, EventArgs e)
        {
            int flag = 0;
            foreach (ItemToPurchase item in Shop.cart.ItemsToPurchase)
            {
                if (item.Product.Name == thismagazine.Name)
                {
                    MessageBox.Show("Item already exists in cart"); flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                ItemToPurchase item = new ItemToPurchase();
                item.Product = thismagazine;
                item.Quantity = 1;
                Shop.cart.addProduct(item);
            }
        }
    }
}
