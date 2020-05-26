using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public abstract class Product
    {
        protected int id;
        protected string name;
        protected decimal price;
        public abstract void printProperties();

        public int ID { get { return id; } }
        public string Name { get { return name; } }
        public decimal Price { get { return price; } }
    }
}
