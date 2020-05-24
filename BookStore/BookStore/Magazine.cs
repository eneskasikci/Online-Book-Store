using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    enum MagType {Actual=1, News=2, Sport=3, Computer=4, Technology=4};
    class Magazine:Product
    {
        private int issue;
        private MagType type;
        public override void printProperties()
        {

        }
    }
}
