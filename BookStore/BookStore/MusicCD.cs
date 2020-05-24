using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    enum CDType { Romance=1, HardRock = 2, Country = 3};
    class MusicCD:Product
    {
        private string singer;
        private CDType type;
        public override void printProperties()
        {

        }
    }
}
