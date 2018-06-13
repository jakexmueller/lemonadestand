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
        Weather weather = new Weather();
        Player player = new Player();
        Store store = new Store();
        List<Customer> customers = new List<Customer>();
        Forecast forecast = new Forecast();
        List<String> daysOfTheWeek = new List<String>();
        List<int> dailyProfit = new List<int>();
        int profit;
        int totalProfit = 0;

        Random rnd;


        //constructor
        public Game()
        {
            rnd = new Random();
            for(int i = 0; i < 100; i++ )
            {
                customers.Add(new Customer());
            }
        }

        //member methods

        
        public int StartSales ()
        {
           // int profit;
            int satisfiedCustomers = 0;
            int minimumToPurchase = 30;
            for (int i  = 0; i <= customers.Count-1; i++)
            {
                customers[i].BuysLemonade(forecast, rnd);
                if(customers[i].purchasingIdentifier >= minimumToPurchase)
                {
                    satisfiedCustomers++;
                }
            }
            Console.WriteLine(satisfiedCustomers + " customers bought lemonade at $" + player.priceToCharge + " per cup");
            int revenue = satisfiedCustomers * Int32.Parse(player.priceToCharge);
            Console.WriteLine("Revenue = $" + revenue);
            int cost = player.costOfMaterials;
            Console.WriteLine("Cost = $" + cost);
            profit = revenue - cost;
            Console.WriteLine("Profit = $" + profit);
            player.BankAccount += profit;
            Console.WriteLine("Account Balance = $" + player.BankAccount);

            return profit;
        }

        public void RunGame() {
            
            daysOfTheWeek.Add("Sunday");
            daysOfTheWeek.Add("Monday");
            daysOfTheWeek.Add("Tuesday");
            daysOfTheWeek.Add("Wednesday");
            daysOfTheWeek.Add("Thursday");
            daysOfTheWeek.Add("Friday");
            daysOfTheWeek.Add("Saturday");

            for (int i = 0; i < daysOfTheWeek.Count; i++)
                {
                Console.WriteLine(UserInterface.Rules);
                weather = UserInterface.DisplayWeather(weather);
                player.GoShopping(store);
                Recipe recipe = player.MakeRecipe();
                UserInterface.DisplayRecipe(recipe);
                dailyProfit.Add(profit);               
                totalProfit += StartSales(); // cannot call StartSales() method twice

                
            }

            Console.WriteLine("Total Running Profit: " + totalProfit);
            Console.WriteLine("Sunday profit: " + dailyProfit[0]);
            Console.WriteLine("Monday profit: " + dailyProfit[1]);
            Console.WriteLine("Tueday profit: " + dailyProfit[2]);
            Console.WriteLine("Wednesday profit: " + dailyProfit[3]);
            Console.WriteLine("Thursday profit: " + dailyProfit[4]);
            Console.WriteLine("Friday profit: " + dailyProfit[5]);
            Console.WriteLine("Saturday profit: " + dailyProfit[6]);

        }
    }
}
