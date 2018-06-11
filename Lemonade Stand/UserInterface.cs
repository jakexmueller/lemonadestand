using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    static class UserInterface
    {

        //member variables
        
        //*rules*
        //*weather*
        //previous day profit
        //week profit
        //ice cost
        //lemon cost
        //honey cost
        //glass cost
        //recipe
        //day cost
        //item price
        //today proft
        //glasses sold

        static string rules = "These are the rules";



        //constructor
        //UserInterface userInterface = new UserInterface();

        //properties
        public static string Rules
        {
            get
            {
                return rules;
            }
        }


        //member methods
        
        public static Weather DisplayWeather(Weather weather)
        {
            weather.GetTemperature();
            weather.GetPrecipitationStatus();
            //weather.GetCloudLevel();
            return weather;
        }

        public static void DisplayRecipe()
        {
            Console.WriteLine();
        }
        
       


    }
}
