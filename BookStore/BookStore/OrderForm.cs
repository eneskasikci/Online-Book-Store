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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            totalLabel.Text = Shop.cart.PaymentAmount.ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Shop.cart.cancelOrder();
            this.Close();
        }

        private void makeOrderButton_Click(object sender, EventArgs e)
        {
            if (creditcardRadioButton.Checked ==true)
            {
                Shop.cart.placeOrder(paymentType.creditcard);
                if (emailRadioButton.Checked == true)
                    Shop.cart.sendInvoidcebyEmail();
                else
                    Shop.cart.sendInvoicebySMS();
            }
                
            if (cashRadioButton.Checked == true)
            {
                Shop.cart.placeOrder(paymentType.cash);
                if (emailRadioButton.Checked == true)
                    Shop.cart.sendInvoidcebyEmail();
                else
                    Shop.cart.sendInvoicebySMS();
            }
        }
    }
}
