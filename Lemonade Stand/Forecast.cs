using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Forecast
    {
        //member variables
        //*temperature*
        //rain
        //clouds

        private int temperature;
        private int precipitation;
        


        //constructor
        Random random = new Random();

        //properties
        public int Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                temperature = value;
            }
        }

        public int Precipiatation
        {
            get
            {
                return precipitation;
            }
            set
            {
                precipitation = value;
            }
        }




        //member methods
        public int GetTemperature()
        {
            int minimumSummerTemperature = 55;
            int maximumSummerTemperature = 95;

            temperature = random.Next(minimumSummerTemperature, maximumSummerTemperature);
            Console.WriteLine("Today's temperature is forecasted to be " + Temperature);

            return temperature;
        }

        public string GetPrecipitationStatus()
        {
            precipitation = random.Next(1, 8);

            switch (precipitation)
            {
                case 1:
                    Console.WriteLine("Cloudy with Heavy Storms");
                    return "Cloudy with Heavy Storms";
                    
                case 2:
                    Console.WriteLine("Mostly Cloudy with Showers");
                    return "Mostly Cloudy with Showers";
                    
                case 3:
                    Console.WriteLine("Partly Cloudy with Showers");
                    return "Partly Cloudy with Showers";
                    
                case 4:
                    Console.WriteLine("Partly Cloudy");
                    return "Partly Cloudy";
                    
                case 5:
                    Console.WriteLine("Partly Cloudy");
                    return "Partly CLoudy";
                    
                case 6:
                    Console.WriteLine("Sunny");
                    return "Sunny";
                    
                case 7:
                    Console.WriteLine("Sunny");
                    return "Sunny";
                    
                case 8:
                    Console.WriteLine("Sunny");
                    return "Sunny";
                    
                default:
                    return "Defatult Case";
                    
            }
        }
          
        }
}


