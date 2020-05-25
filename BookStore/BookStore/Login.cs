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
        public static List<Customer> customerList = new List<Customer>();
        private bool mouseDown;
        private Point lastLocation;
        public Login()
        {
            Util.LoadCustomer(customerList);
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
            for (int i = 0; i < customerList.Count; i++)
            {
                Customer customer = customerList[i];
                if (customer.IsValid(usernameTextBox.Text, passwordTextBox.Text))
                {
                    Shop shopform = new Shop(i);
                    shopform.ShowDialog();
                    errorMessageLabel.Text = "";
                    usernameTextBox.Text = "Username";
                    passwordTextBox.Text = "Password";
                    return;
                }
            }
            errorMessageLabel.ForeColor = Color.Red;
            errorMessageLabel.Text = "Incorrect Username or Password";
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            SignUp signupForm = new SignUp();
            signupForm.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Util.SaveCustomer(customerList);
            DialogResult result = MessageBox.Show("Do you realy want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
