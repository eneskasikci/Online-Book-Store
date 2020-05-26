using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BookStore
{
    public enum CDType { Rap=1, HardRock = 2, Country = 3};
    public class MusicCD:Product
    {
        private string singer;
        private CDType type;

        public MusicCD(string id, string name, string price, string singer, string type)
        {
            this.id = int.Parse(id);
            this.name = name;
            this.price = Decimal.Parse(price, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
            this.singer = singer;
            switch (type)
            {
                case "1": this.type = CDType.Rap; break;
                case "2": this.type = CDType.HardRock; break;
                case "3": this.type = CDType.Country; break;
            }
        }

        public string Singer { get { return singer; } }
        public CDType Type { get { return type; } }

        public override void printProperties()
        {

        }
    }
}
