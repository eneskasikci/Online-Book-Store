using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void placeOrder() { }
        public void cancelOrder() { }
        public void sendInvoicebySMS(){}
        public void sendInvoidcebyEmail() { }
    }
}
