using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BookStore
{
    public class Book: Product
    {
        private string isbn;
        private string author;
        private string publisher;
        private int page;

        public Book(string id, string name, string price, string isbn, string author, string publisher, string page)
        {
            this.id = int.Parse(id);
            this.name = name;
            this.price =  Decimal.Parse(price, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
            this.isbn = isbn;
            this.author = author;
            this.publisher = publisher;
            this.page = int.Parse(page);
        }

        public string ISBN { get { return isbn; } }
        public string Author { get { return author; } }
        public string Publisher { get { return publisher; } }
        public int Page { get { return page; } }

        public override void printProperties()
        {

        }
    }
}
