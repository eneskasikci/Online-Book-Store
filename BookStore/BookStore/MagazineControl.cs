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
        public MagazineControl(Magazine magazine)
        {
            InitializeComponent();

            idLabel.Text += magazine.ID;
            nameLabel.Text += magazine.Name;
            priceLabel.Text += magazine.Price;
            issueLabel.Text += magazine.Issue;
            typeLabel.Text += magazine.Type;
            magazinePictureBox.BackgroundImage =
            (Bitmap)Properties.Resources.ResourceManager.GetObject(magazine.Name);
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
    }
}
