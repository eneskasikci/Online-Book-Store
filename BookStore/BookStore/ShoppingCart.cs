using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    enum paymentType { cash = 1, creditcard = 2};
    public class ShoppingCart
    {
        private int customerID;
        private ArrayList itemsToPurchase;
        private int paymentAmount;
        private paymentType type;

        public void printProducts() { }
        public void addProduct() { }
        public void removeProduct() { }
        public void placeOrder() { }
        public void cancelOrder() { }
        public void sendInvoicebySMS() { }
        public void sendInvoidcebyEmail() { }
    }
}
