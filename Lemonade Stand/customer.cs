using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Customer
    {

        //member variables
        int minimum = 1;
        int maximum = 100;
        public int purchasingIdentifier;
        Random rnd;

        //constructor
   

        //member methods
        public void BuysLemonade(Forecast forecast, Random rnd)
        {

            Player player = new Player();
            Recipe recipe = new Recipe();

            if (recipe.lemonsPerPitcher >= 8)
            {
                maximum -= 10;
            }
            if (recipe.lemonsPerPitcher <= 4)
            {
                maximum -= 10;
            }
            if (recipe.honeyPerPitcher >= 11)
            {
                maximum -= 10;
            }
            if (recipe.honeyPerPitcher <= 6)
            {
                maximum -= 10;
            }
            if (recipe.cubesPerGlass <= 2)
            {
                maximum -= 10;
            }
            //if (recipe.cubesPerGlass <= 3 && temperature >= 85)
            //{
            //    maximum -= 10;
            //}
            if (forecast.Precipiatation <= 2)
            {
                maximum -= 20;
            }
            if (forecast.Precipiatation == 3 || forecast.Precipiatation == 4)
            {
                maximum -= 10;
            }

            //Random random = new Random();
            
            purchasingIdentifier = rnd.Next(minimum, maximum);




            //int availableCustomers = 100;
            //int satisfiedCustomers = 0;

            //for(int i=1; i<availableCustomers; i++)
            //{
            //    if (purchasingIdentifier >= 30)
            //    {
            //        satisfiedCustomers += 1;
            //    }
            //    /*else
            //    {
            //        Console.WriteLine("Customer doesn't buy lemonade.");
            //    }*/
            //}

            //Console.WriteLine(satisfiedCustomers + " customers bought lemonade.");

            

        }
        //buy lemonade

    }
}
