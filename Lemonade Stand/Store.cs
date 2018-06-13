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

        int icePrice = 5; //for 1 bag of 50 cubes
        int lemonPrice = 1; //each
        int honeyPrice = 1; //for every cup
        int cupsPrice = 3; //for 1 bag of 15 cups


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

        public int CupsPrice
        {
            get
            {
                return cupsPrice;
            }
        }

        //member methods

    }
}
