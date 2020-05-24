using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
            
        }
        int X, Y, count;

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            BookControl book = new BookControl();
            count++;
            book.Location = new System.Drawing.Point(X, Y);
            if (count%2==0)
            {
                Y += 260;
                X -= 840;
            }
            X += 420;
            book.Size = new System.Drawing.Size(387, 232);
            booksPanel.Controls.Add(book);
        }

        private void homepageButton_Click(object sender, EventArgs e)
        {
            sidecolorButton.Location = new System.Drawing.Point(108, 116);
            booksPanel.Visible = false;
            magazinesPanel.Visible = false;
            cdsPanel.Visible = false;
            shoppingCartPanel.Visible = false;
            homepagePanel.Visible = true;
        }

        private void booksButton_Click(object sender, EventArgs e)
        {
            X = 76; Y = 66; count = 0;
            sidecolorButton.Location = new System.Drawing.Point(304, 116);
            magazinesPanel.Visible = false;
            cdsPanel.Visible = false;
            shoppingCartPanel.Visible = false;
            homepagePanel.Visible = false;
            booksPanel.Visible = true;
        }

        private void magazinesButton_Click(object sender, EventArgs e)
        {
            X = 76; Y = 66; count = 0;
            sidecolorButton.Location = new System.Drawing.Point(500, 116);
            cdsPanel.Visible = false;
            shoppingCartPanel.Visible = false;
            homepagePanel.Visible = false;
            booksPanel.Visible = false;
            magazinesPanel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MagazineControl magazine = new MagazineControl();
            count++;
            magazine.Location = new System.Drawing.Point(X, Y);
            if (count % 2 == 0)
            {
                Y += 260;
                X -= 840;
            }
            X += 420;
            magazine.Size = new System.Drawing.Size(387, 232);
            magazinesPanel.Controls.Add(magazine);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusicCDControl CD = new MusicCDControl();
            count++;
            CD.Location = new System.Drawing.Point(X, Y);
            if (count % 2 == 0)
            {
                Y += 260;
                X -= 840;
            }
            X += 420;
            CD.Size = new System.Drawing.Size(387, 232);
            cdsPanel.Controls.Add(CD);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShoppingCartControl cart = new ShoppingCartControl();
            count++;
            cart.Location = new System.Drawing.Point(X, Y);
            Y += 240;
            cart.Size = new System.Drawing.Size(387, 232);
            shoppingCartPanel.Controls.Add(cart);
        }

        private void cdButton_Click(object sender, EventArgs e)
        {
            X = 76; Y = 66; count = 0;
            sidecolorButton.Location = new System.Drawing.Point(696, 116);
            shoppingCartPanel.Visible = false;
            homepagePanel.Visible = false;
            booksPanel.Visible = false;
            magazinesPanel.Visible = false;
            cdsPanel.Visible = true;
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            X = 76; Y = 66; count = 0;
            sidecolorButton.Location = new System.Drawing.Point(892, 116);
            homepagePanel.Visible = false;
            booksPanel.Visible = false;
            magazinesPanel.Visible = false;
            cdsPanel.Visible = false;
            shoppingCartPanel.Visible = true;
        }
    }
}
