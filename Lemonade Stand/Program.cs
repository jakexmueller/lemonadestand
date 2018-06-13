using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Program
    {
        static void Main(string[] args)
        {
            //SOLID Design Principle : Single Responsibility Principle - Eech class in my program has a sole and main purpose designated to it.
            //SOLID Design Principle : Interface Segreagation Principle - No unessential methods are used in any of the classes in my program.
            Game myGame = new Game();
            myGame.RunGame();
            
          

            Console.ReadLine();
        }
    }
}
