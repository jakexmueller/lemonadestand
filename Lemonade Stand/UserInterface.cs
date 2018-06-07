using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class UserInterface
    {

        //member variables
        Weather weather = new Weather();
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

        string rules = "These are the rules";



        //constructor
        //UserInterface userInterface = new UserInterface();

        //properties
        public string Rules
        {
            get
            {
                return rules;
            }
        }


        //member methods
        
        public void DisplayWeather()
        {
            weather.GetTemperature();
            weather.GetRainStatus();
            weather.GetCloudLevel();        
        }
        
       


    }
}
