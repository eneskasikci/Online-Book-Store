using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace BookStore
{
    public enum paymentType { cash = 1, creditcard = 2};
    public class ShoppingCart
    {
        private int customerID;
        private List<ItemToPurchase> itemsToPurchase = new List<ItemToPurchase>();
        private decimal paymentAmount;
        private paymentType type;

        public ShoppingCart (int customerID)
        {
            this.customerID = customerID;
        }

        public List<ItemToPurchase> ItemsToPurchase { get { return itemsToPurchase; } set { itemsToPurchase = value; } }
        public string printProducts()
        {
            string product="";
            foreach (var item in itemsToPurchase)
            {
                product += item.Product.Name + "   " + item.Quantity + Environment.NewLine;
            }
            return product;
        }

        public void addProduct(ItemToPurchase item)
        {
            itemsToPurchase.Add(item);
        }

        public void removeProduct(int index)
        {
            itemsToPurchase.RemoveAt(index);
        }

        public decimal PaymentAmount { get { calculateTotalAmount(); return paymentAmount; } }
        public int CustomerID { get {return customerID; } }
        public paymentType Type { set {type =value; } }

        public void calculateTotalAmount()
        {
            paymentAmount = 0;
            foreach (var item in itemsToPurchase)
                paymentAmount += item.Product.Price*item.Quantity;
        }

        public void placeOrder(paymentType type) 
        {
            this.type = type;
        }
        public void cancelOrder()
        {
            MessageBox.Show("Are you sure want to cancel your order?");
        }
        public void sendInvoicebySMS()
        {
            MessageBox.Show("Your order is completed and Invoice sended to SMS");
        }

        public void sendInvoidcebyEmail()
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp-mail.outlook.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("ooplab2_23@outlook.com", "BoburshohEnesMurat");
            MailMessage eposta = new MailMessage();
            eposta.From = new MailAddress("ooplab2_23@outlook.com");
            eposta.To.Add(Login.customerList[Shop.customerindex].Email);
            eposta.Subject = "Your order is completed";
            eposta.Body = "Order Summary: " + Environment.NewLine + printProducts() + Environment.NewLine + 
            "Payment Type: " + type + Environment.NewLine + "Total cost: " + paymentAmount;
                
            int sent = 0;
            try
            {
                smtp.Send(eposta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while sending email." + ex.Message);
                sent = -1;
            }
            if (sent == 0)
            {
                MessageBox.Show("Your order is completed and Invoice sended to Email");
            }
        }
    }
}
