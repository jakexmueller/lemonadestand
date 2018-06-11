using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather
    {
        Forecast forecast = new Forecast();
        Random random = new Random();



        //member variables
        private int dayTemperature;

        //constructor

        //properties
        public int DayTemperature
        {
            get
            {
                return dayTemperature;
            }
            set
            {
                dayTemperature = value;
            }
        }

        //member methods

        public int GetDayTemperature()
        {
            //Random random = new Random();
            
            dayTemperature = forecast.GetTemperature();
            return dayTemperature;
        }

        public int ChangeInTemperature()
        {
            int percentageChange = random.Next(1, 15);
            int addOrSubtract = random.Next(0, 2);
            int newTemperature;
            if (addOrSubtract == 0)
            {
                newTemperature = ((dayTemperature * percentageChange / 100) + dayTemperature);
                Console.WriteLine("Temperature increased to " + newTemperature);
                return newTemperature;
            }
            else if (addOrSubtract == 1)
            {
                newTemperature = (dayTemperature - (dayTemperature * percentageChange / 100));
                Console.WriteLine("Temperature lowered to " + newTemperature);
                return newTemperature;
            }
            else
            {
                Console.WriteLine("The forecast waas correct at " + dayTemperature);
                return dayTemperature;
            }
            
        }

        

    }
}
