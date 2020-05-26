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
        public List<Book> booksList = new List<Book>();
        public static List<Magazine> magazineList = new List<Magazine>();
        public static List<MusicCD> musicCDList = new List<MusicCD>();
        public static ShoppingCart cart = new ShoppingCart(Login.customerList[customerindex].CustomerID);
        public static int customerindex;
        int X, Y, count;
        public Shop(int logincustomerindex)
        {
            InitializeComponent();
            timer.Start();
            customerindex = logincustomerindex;
            welcomeCLabel.Text = "Welcome " + Login.customerList[logincustomerindex].Username;
            Util.LoadBooks(booksList);
            Util.LoadMagazines(magazineList);
            Util.LoadCDs(musicCDList);

            X = 76; Y = 66; count = 0;
            foreach (Book book in booksList)
            {
                BookControl bookcontrol = new BookControl(book);
                count++;
                bookcontrol.Location = new System.Drawing.Point(X, Y);
                if (count % 2 == 0)
                {
                    Y += 260;
                    X -= 840;
                }
                X += 420;
                bookcontrol.Size = new System.Drawing.Size(387, 232);
                booksPanel.Controls.Add(bookcontrol);
            }
            X = 76; Y = 66; count = 0;
            foreach (Magazine magazine in magazineList)
            {
                MagazineControl magazinecontrol = new MagazineControl(magazine);
                count++;
                magazinecontrol.Location = new System.Drawing.Point(X, Y);
                if (count % 2 == 0)
                {
                    Y += 260;
                    X -= 840;
                }
                X += 420;
                magazinecontrol.Size = new System.Drawing.Size(387, 232);
                magazinesPanel.Controls.Add(magazinecontrol);
            }
            X = 76; Y = 66; count = 0;
            foreach (MusicCD musicCD in musicCDList)
            {
                MusicCDControl cdControl = new MusicCDControl(musicCD);
                count++;
                cdControl.Location = new System.Drawing.Point(X, Y);
                if (count % 2 == 0)
                {
                    Y += 260;
                    X -= 840;
                }
                X += 420;
                cdControl.Size = new System.Drawing.Size(387, 232);
                cdsPanel.Controls.Add(cdControl);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
            sidecolorButton.Location = new System.Drawing.Point(304, 116);
            magazinesPanel.Visible = false;
            cdsPanel.Visible = false;
            shoppingCartPanel.Visible = false;
            homepagePanel.Visible = false;
            booksPanel.Visible = true;
        }

        private void magazinesButton_Click(object sender, EventArgs e)
        {
            sidecolorButton.Location = new System.Drawing.Point(500, 116);
            cdsPanel.Visible = false;
            shoppingCartPanel.Visible = false;
            homepagePanel.Visible = false;
            booksPanel.Visible = false;
            magazinesPanel.Visible = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            cartCountLabel.Text = cart.ItemsToPurchase.Count.ToString();
            totalLabel.Text = cart.PaymentAmount.ToString();
            productsLabel.Text = cart.printProducts();
            summaryPanel.Size = new System.Drawing.Size(307, 178+cart.ItemsToPurchase.Count * 20);
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            if (Shop.cart.ItemsToPurchase.Count==0)
                MessageBox.Show("Your cart is empty please select items");
            else
            {
                OrderForm order = new OrderForm();
                order.ShowDialog();
            }
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
            X = 76; Y = 140;
            sidecolorButton.Location = new System.Drawing.Point(892, 116);
            homepagePanel.Visible = false;
            booksPanel.Visible = false;
            magazinesPanel.Visible = false;
            cdsPanel.Visible = false;

            shoppingCartPanel.Controls.Clear();
            shoppingCartPanel.Controls.Add(this.summaryPanel);
            shoppingCartPanel.Controls.Add(this.myCartLabel);
            foreach (ItemToPurchase item in cart.ItemsToPurchase)
            {
                ShoppingCartControl cartcontrol = new ShoppingCartControl(item);
                cartcontrol.Location = new System.Drawing.Point(X, Y);
                Y += 240;
                cartcontrol.Size = new System.Drawing.Size(387, 232);
                shoppingCartPanel.Controls.Add(cartcontrol);
            }

            productsLabel.Text = cart.printProducts();
            shoppingCartPanel.Visible = true;
        }
    }
}
