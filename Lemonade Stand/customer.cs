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
        
        public int purchasingIdentifier;
        //Random rnd;

        //constructor
   

        //member methods
        public void BuysLemonade(Forecast forecast, Random rnd)
        {
            int minimum = 1;
            int maximum = 100;

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
            if (forecast.Precipiatation <= 2)
            {
                maximum -= 20;
            }
            if (forecast.Precipiatation == 3 || forecast.Precipiatation == 4)
            {
                maximum -= 10;
            }

            purchasingIdentifier = rnd.Next(minimum, maximum);

        }
        

    }
}
