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

        static string rules = "The rules are simple. Every day this week, you will be selling lemonade.The amount of money you make depends on the weather and the recipe you decide to make.";



        //constructor


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
            weather.GetDayForecast();
            weather.ChangeInTemperature();
            return weather;
        }

        public static Forecast DisplayWeather(Forecast forecast)
        {
            forecast.GetTemperature();
            return forecast;
        }

        public static Forecast DisplayPrecipitation(Forecast forecast)
        {
            forecast.GetPrecipitationStatus();
            Console.WriteLine(forecast);
            return forecast;
        }

        public static void DisplayRecipe(Recipe recipe)
        {
            Console.Clear();
            Console.WriteLine("Today's recipe:");
            Console.WriteLine(recipe.lemonsPerPitcher + " lemons in each pitcher.");
            Console.WriteLine(recipe.honeyPerPitcher + " tablespoons of honey in each pitcher.");
            Console.WriteLine(recipe.cubesPerGlass + " ice cubes in each glass.");
        }
    }
}
