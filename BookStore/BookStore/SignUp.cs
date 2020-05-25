using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class SignUp : Form
    {
        private bool mouseDown;
        private int ID=1111;
        private Point lastLocation;
        public SignUp()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void signupButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTextBox.Text != "" && usernameTextBox.Text != "" && 
                    passwordTextBox.Text != "" && emailTextBox.Text != "" && addressTextBox.Text != "")
                {
                    if (Util.IsDoubleUsername(usernameTextBox.Text))
                    {
                        MessageBox.Show("Such username exists", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!IsValidMail(emailTextBox.Text))
                    {
                        MessageBox.Show("Wrong Email Format", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    Customer customer = new Customer();
                    customer.saveCustomer(ID, nameTextBox.Text, addressTextBox.Text,
                    emailTextBox.Text, usernameTextBox.Text, passwordTextBox.Text); ID++;
                    Login.customerList.Add(customer);
                    Util.SaveCustomer(Login.customerList); 
                    MessageBox.Show("Sign Up successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nameTextBox.Text = "";
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";
                    emailTextBox.Text = "";
                    addressTextBox.Text = "";
                }

                else
                    MessageBox.Show("Fields can not be empty", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        bool IsValidMail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        }

        private void icon2Button_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.UseSystemPasswordChar)
            {
                passwordTextBox.UseSystemPasswordChar = false;
                icon1Button.BringToFront();
            }
            else
                passwordTextBox.UseSystemPasswordChar = true;
                icon1Button.BringToFront();
        }

        private void icon1Button_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.UseSystemPasswordChar)
            {
                passwordTextBox.UseSystemPasswordChar = false;
                icon2Button.BringToFront();
            }
            else
                passwordTextBox.UseSystemPasswordChar = true;
            icon2Button.BringToFront();
        }
    }
}
