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

        public int customerindex;
        int X, Y, count;
        public Shop(int logincustomerindex)
        {
            InitializeComponent();
            customerindex = logincustomerindex;
            welcomeCLabel.Text = "Welcome " + Login.customerList[logincustomerindex].Username;
            Util.LoadBooks(booksList);
            Util.LoadMagazines(magazineList);
            Util.LoadCDs(musicCDList);
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
            X = 76; Y = 66; count = 0;
            sidecolorButton.Location = new System.Drawing.Point(304, 116);
            magazinesPanel.Visible = false;
            cdsPanel.Visible = false;
            shoppingCartPanel.Visible = false;
            homepagePanel.Visible = false;

            foreach(Book book in booksList)
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
            magazinesPanel.Visible = true;
        }

        private void cdButton_Click(object sender, EventArgs e)
        {
            X = 76; Y = 66; count = 0;
            sidecolorButton.Location = new System.Drawing.Point(696, 116);
            shoppingCartPanel.Visible = false;
            homepagePanel.Visible = false;
            booksPanel.Visible = false;
            magazinesPanel.Visible = false;

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
