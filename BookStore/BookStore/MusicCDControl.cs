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
    public partial class MusicCDControl : UserControl
    {
        MusicCD thismusicCd;
        public MusicCDControl(MusicCD musicCd)
        {
            InitializeComponent();
            thismusicCd = musicCd;
            idLabel.Text += musicCd.ID;
            nameLabel.Text += musicCd.Name;
            priceLabel.Text += musicCd.Price;
            singerLabel.Text += musicCd.Singer;
            typeLabel.Text += musicCd.Type;
            cdPictureBox.BackgroundImage =
            (Bitmap)Properties.Resources.ResourceManager.GetObject(musicCd.ID.ToString());
        }

        private void cdPictureBox_MouseHover(object sender, EventArgs e)
        {
            cdPictureBox.Size = new System.Drawing.Size(150, 162);
            cdPictureBox.Location = new System.Drawing.Point(5, 30);
        }

        private void cdPictureBox_MouseLeave(object sender, EventArgs e)
        {
            cdPictureBox.Size = new System.Drawing.Size(110, 122);
            cdPictureBox.Location = new System.Drawing.Point(28, 53);
        }

        private void addtoCartButton_Click(object sender, EventArgs e)
        {
            int flag = 0;
            foreach (ItemToPurchase item in Shop.cart.ItemsToPurchase)
            {
                if (item.Product.Name == thismusicCd.Name)
                {
                    MessageBox.Show("Item already exists in cart"); flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                ItemToPurchase item = new ItemToPurchase();
                item.Product = thismusicCd;
                item.Quantity = 1;
                Shop.cart.addProduct(item);
            }
        }
    }
}
