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
    public partial class Login : Form
    {

        private bool mouseDown;
        private Point lastLocation;
        public Login()
        {
            InitializeComponent();
        }
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginUserNameTBX_Enter(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Username")
                usernameTextBox.Text = "";
        }

        private void loginUserNameTBX_Leave(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "")
                usernameTextBox.Text = "Username";
        }

        private void loginPasswordTBX_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Password")
                passwordTextBox.Text = "";
        }

        private void loginPasswordTBX_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
                passwordTextBox.Text = "Password";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Shop shopForm = new Shop();
            shopForm.ShowDialog();
        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            SignUp signupForm = new SignUp();
            signupForm.ShowDialog();
        }
    }
}
