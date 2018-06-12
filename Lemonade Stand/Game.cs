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

        public void StartSales ()
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
        }

        public void RunGame() {
            //UserInterface userInterface = new UserInterface();
            Console.WriteLine(UserInterface.Rules);
                weather = UserInterface.DisplayWeather(weather);
            // Player player = new Player();
            player.GoShopping(store);
            Recipe recipe = player.MakeRecipe();
            UserInterface.DisplayRecipe(recipe);
            StartSales();
            
            //customer.BuysLemonade(forecast);

            

        }

        

    }
}
