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

        //constructor

        //member methods

        public void RunGame() {
            //UserInterface userInterface = new UserInterface();
            Console.WriteLine(UserInterface.Rules);
                weather = UserInterface.DisplayWeather(weather);
            Player player = new Player();
            player.MakeRecipe();
            }

        

    }
}
