using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BookStore
{
    public enum MagType {Lifestyle=1, News=2, Sport=3, Computer=4, Technology=5};
    public class Magazine:Product
    {
        private string issue;
        private MagType type;

        public Magazine(string id, string name, string price, string issue, string type)
        {
            this.id = int.Parse(id);
            this.name = name;
            this.price = Decimal.Parse(price, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
            this.issue = issue;
            switch(type){
                case "1": this.type = MagType.Lifestyle;break;
                case "2":this.type = MagType.News;break;
                case "3":this.type = MagType.Sport;break;
                case "4":this.type = MagType.Computer;break;
                case "5":this.type = MagType.Technology;break;
            }
        }

        public int ID { get { return id; } }
        public string Name { get { return name; } }
        public decimal Price { get { return price; } }
        public string Issue { get { return issue; } }
        public MagType Type { get { return type; } }

        public override void printProperties()
        {

        }
    }
}
