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
        Store store = new Store();
        List<Customer> customers = new List<Customer>();
        Forecast forecast = new Forecast();
        List<String> daysOfTheWeek = new List<String>();
        List<int> dailyProfit = new List<int>();
        int totalProfit = 0;



        /*Day sunday = new Day();
        Day monday = new Day();q
        Day tuesday = new Day();
        Day wednesday = new Day();
        Day thursday = new Day();
        Day friday = new Day();
        Day saturday = new Day();*/
        Random rnd;
        //Recipe recipe = new Recipe();


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
            int satisfiedCustomers = 0;
            int minimumToPurchase = 30;
            for (int i  = 0; i <= customers.Count-1; i++)
            {
                customers[i].BuysLemonade(forecast, rnd);
                if(customers[i].purchasingIdentifier >= minimumToPurchase)
                {
                    //Console.WriteLine("Customer " + customers[i] + " Purchaeing identifier: " + customers[i].purchasingIdentifier);
                    satisfiedCustomers++;
                }
            }
            Console.WriteLine(satisfiedCustomers + " customers bought lemonade at $" + player.priceToCharge + " per cup");
            int revenue = satisfiedCustomers * Int32.Parse(player.priceToCharge);
            Console.WriteLine("Revenue = $" + revenue);
            int cost = player.costOfMaterials;
            Console.WriteLine("Cost = $" + cost);
            int profit = revenue - cost;
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
                //UserInterface userInterface = new UserInterface();
                Console.WriteLine(UserInterface.Rules);
                weather = UserInterface.DisplayWeather(weather);
                //Console.WriteLine(UserInterface.DisplayPrecipitation);
                forecast = UserInterface.DisplayPrecipitation(forecast);
                // Player player = new Player();
                player.GoShopping(store);
                Recipe recipe = player.MakeRecipe();
                UserInterface.DisplayRecipe(recipe);
                //StartSales();
                dailyProfit.Add(StartSales());
                
                totalProfit += StartSales();
                


            }



            Console.WriteLine("Total Running Profit: " + totalProfit);
            Console.WriteLine("Sunday profit: " + dailyProfit[0]);
            Console.WriteLine("Monday profit: " + dailyProfit[1]);
            Console.WriteLine("Tueday profit: " + dailyProfit[2]);
            Console.WriteLine("Wednesday profit: " + dailyProfit[3]);
            Console.WriteLine("Thursday profit: " + dailyProfit[4]);
            Console.WriteLine("Friday profit: " + dailyProfit[5]);
            Console.WriteLine("Saturday profit: " + dailyProfit[6]);

            //customer.BuysLemonade(forecast);



        }

        

    }
}
