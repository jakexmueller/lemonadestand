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

        //constructor

        //member methods
        public void BuysLemonade()
        {

            Player player = new Player();
            Recipe recipe = player.MakeRecipe();

            if (recipe.lemonsPerPitcher >= 8)
            {
                maximum -= 10;
            }
            if (recipe.lemonsPerPitcher <= 4)
            {
                maximum -= 10;
            }

            Random random = new Random();
            int purchasingIdentifier;
            purchasingIdentifier = random.Next(minimum, maximum);
            if (purchasingIdentifier >= 30)
            {
                Console.WriteLine("Customer buys lemonade");
            }
            else
            {
                Console.WriteLine("Customer doesn't buy lemonade.");
            }

        }
        //buy lemonade

    }
}
