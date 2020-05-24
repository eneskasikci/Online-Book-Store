using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    abstract class Product
    {
        private string name;
        private int ID;
        private float price;
        public abstract void printProperties();
    }
}
