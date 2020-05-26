using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace BookStore
{
    public partial class BookControl : UserControl
    {
        Book thisbook;
        public BookControl(Book book)
        {
            InitializeComponent();
            thisbook = book;
            idLabel.Text += book.ID;
            nameLabel.Text += book.Name;
            isbnLabel.Text += book.ISBN;
            authorLabel.Text += book.Author;
            publisherLabel.Text += book.Publisher;
            priceLabel.Text += book.Price;
            pageLabel.Text += book.Page;
            bookPictureBox.BackgroundImage = 
            (Bitmap)Properties.Resources.ResourceManager.GetObject(book.ID.ToString());
        }

        private void bookPictureBox_MouseHover(object sender, EventArgs e)
        {
            bookPictureBox.Size = new System.Drawing.Size(150, 201);
            bookPictureBox.Location = new System.Drawing.Point(5, 25);
        }

        private void bookPictureBox_MouseLeave(object sender, EventArgs e)
        {
            bookPictureBox.Size = new System.Drawing.Size(110, 161);
            bookPictureBox.Location = new System.Drawing.Point(29, 36);
        }

        private void addtoCartButton_Click(object sender, EventArgs e)
        {
            int flag = 0;
            foreach(ItemToPurchase item in Shop.cart.ItemsToPurchase)
            {
                if (item.Product.Name == thisbook.Name)
                {
                    MessageBox.Show("Item already exists in cart");flag = 1;
                    break;
                }
            }

            if (flag==0)
            {
                ItemToPurchase item = new ItemToPurchase();
                item.Product = thisbook;
                item.Quantity = 1;
                Shop.cart.addProduct(item);
            }
        }
    }
}
