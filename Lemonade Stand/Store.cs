using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Store
    {

        //member variables
        //ice cost
        //lemon cost
        //honey cost
        //glasses cost

        int icePrice = 1; //for every 25 cubes
        int lemonPrice = 1; //each
        int honeyPrice = 1; //for every cup
        int glassPrice = 1; //for every 5


        //constructor

        //properties
        public int IcePrice
        {
            get
            {
                return icePrice;
            }
        }

        public int LemonPrice
        {
            get
            {
                return lemonPrice;
            }
        }

        public int HoneyPrice
        {
            get
            {
                return honeyPrice;
            }
        }

        public int GlassPrice
        {
            get
            {
                return glassPrice;
            }
        }

        //member methods

    }
}
