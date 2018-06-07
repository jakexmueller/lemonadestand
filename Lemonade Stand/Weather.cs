using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather
    {

        //member variables
        //*temperature*
        //rain
        //clouds

        private int temperature;
        private int rain;
        private int cloudLevel;


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

        public int Rain
        {
            get
            {
                return rain;
            }
            set
            {
                rain = value;
            }
        }

        public int CloudLevel
        {
            get
            {
                return cloudLevel;
            }
            set
            {
                cloudLevel = value;
            }
        }


        //member methods
       public int GetTemperature()
        {
            temperature = random.Next(55, 95);
            Console.WriteLine(Temperature);
            return temperature;
        }

        public int GetRainStatus()
        {
            rain = random.Next(1, 4);
            Console.WriteLine(Rain);
            return rain;
        }

        public int GetCloudLevel()
        {
            cloudLevel = random.Next(1, 4);
            Console.WriteLine(CloudLevel);
            return cloudLevel;
        }
    }
}
