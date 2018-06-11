using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Player
    {

        //member variables
        int bankAccount = 20;
        Recipe myRecipe = new Recipe();
        Store store = new Store();
        Inventory inventory = new Inventory();
        string amountOfIce;
        string numberOfLemons;
        string amountOfHoney;
        string numberOfCups;


        //constructor

        //properties
        public int BankAccount
        {
            get
            {
                return bankAccount;
            }
        }

        //member methods


        public void GoShopping()
        {
            //store = new Store();

            Console.WriteLine("You have $" + BankAccount + " in your account");

            Console.WriteLine("Ice costs $5 per bag of 50 cubes. How many bags of ice do you want to purchase?");
            amountOfIce = Console.ReadLine();
            inventory.amountOfIce = Int32.Parse(amountOfIce);

            Console.WriteLine("Lemons cost $1 each. How many lemons do you want to buy?");
            numberOfLemons = Console.ReadLine();
            inventory.numberOfLemons = Int32.Parse(numberOfLemons);

            Console.WriteLine("Honey costs $1 per cup. How many cups of honey do you want to buy?");
            amountOfHoney = Console.ReadLine();
            inventory.amountOfHoney = Int32.Parse(amountOfHoney);

            Console.WriteLine("Cups cost $3 for every bag of 15 cups. How many bags of cups do you want to buy?");
            numberOfCups = Console.ReadLine();
            inventory.numberOfCups = Int32.Parse(numberOfCups);
        }

        public void MakeRecipe()
        {
           

            Console.WriteLine();




        }

    }
}
