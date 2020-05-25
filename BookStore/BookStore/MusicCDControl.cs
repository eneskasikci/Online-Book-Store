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
        public MusicCDControl(MusicCD musicCd)
        {
            InitializeComponent();

            idLabel.Text += musicCd.ID;
            nameLabel.Text += musicCd.Name;
            priceLabel.Text += musicCd.Price;
            singerLabel.Text += musicCd.Singer;
            typeLabel.Text += musicCd.Type;
            cdPictureBox.BackgroundImage =
            (Bitmap)Properties.Resources.ResourceManager.GetObject(musicCd.Name);
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
    }
}
