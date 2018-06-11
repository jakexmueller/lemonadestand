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
            Console.WriteLine("Today's temperature will be " + Temperature);
            return temperature;
        }

        public void GetPrecipitationStatus()
        {
            int precipitation = random.Next(1, 8);

            switch (precipitation)
            {
                case 1:
                    Console.WriteLine("Cloudy with Heavy Storms");
                    break;
                case 2:
                    Console.WriteLine("Mostly Cloudy with Showers");
                    break;
                case 3:
                    Console.WriteLine("Partly Cloudy with Showers");
                    break;
                case 4:
                    Console.WriteLine("Partly Cloudy");
                    break;
                case 5:
                    Console.WriteLine("Partly CLoudy");
                    break;
                case 6:
                    Console.WriteLine("Sunny");
                    break;
                case 7:
                    Console.WriteLine("Sunny");
                    break;
                case 8:
                    Console.WriteLine("Sunny");
                    break;
                default:
                    Console.WriteLine("Defatult Case");
                    break;
            }
        }
          
        }
}


