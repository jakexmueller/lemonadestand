using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Game
    {

        //member variables
        //pitchers to make
        //recipe
        Weather weather = new Weather();
        Player player = new Player();
        Store store = new Store();
        //Recipe recipe = new Recipe();
        

        //constructor

        //member methods

        public void RunGame() {
            //UserInterface userInterface = new UserInterface();
            Console.WriteLine(UserInterface.Rules);
                weather = UserInterface.DisplayWeather(weather);
            // Player player = new Player();
            player.GoShopping(store);
            Recipe recipe = player.MakeRecipe();
            UserInterface.DisplayRecipe(recipe);
            

        }

        

    }
}
