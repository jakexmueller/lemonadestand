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
        
        Inventory inventory = new Inventory();
        


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


        public void GoShopping(Store store)
        {
            string amountOfIce;
            string numberOfLemons;
            string amountOfHoney;
            string bagsOfCups;


            Console.WriteLine("You have $" + BankAccount + " in your account");
            Console.WriteLine("Ice costs $5 per bag of 50 cubes.");
            Console.WriteLine("Lemons cost $1 each.");
            Console.WriteLine("Honey costs $1 per cup.");
            Console.WriteLine("Cups cost $3 for every bag of 15 cups.");

            Console.WriteLine("How many bags of ice do you want to purchase?");
            amountOfIce = Console.ReadLine();
            inventory.amountOfIce += Int32.Parse(amountOfIce);

            Console.WriteLine("How many lemons do you want to buy?");
            numberOfLemons = Console.ReadLine();
            inventory.numberOfLemons += Int32.Parse(numberOfLemons);

            Console.WriteLine("How many cups of honey do you want to buy?");
            amountOfHoney = Console.ReadLine();
            inventory.amountOfHoney += Int32.Parse(amountOfHoney);

            Console.WriteLine("How many bags of cups do you want to buy?");
            bagsOfCups = Console.ReadLine();
            inventory.numberOfCups += Int32.Parse(bagsOfCups);
        }

        public Recipe MakeRecipe()
        {
            string lemonsPerPitcher;
            string honeyPerPitcher;
            string cubesPerGlass;

            Console.WriteLine("Now it's time to make your lemonade! Your current inventory is:");
            Console.WriteLine(inventory.amountOfIce + " bags of 50 ice cubes");
            Console.WriteLine(inventory.numberOfLemons + " lemons");
            Console.WriteLine(inventory.amountOfHoney + " cups of honey");
            Console.WriteLine(inventory.numberOfCups + " bags of 15 cups");
            Console.WriteLine("Each pitcher makes 10 cups of lemonade");
            Console.WriteLine("How many lemons do you want in each pitcher?");
            lemonsPerPitcher = Console.ReadLine();
            myRecipe.lemonsPerPitcher = Int32.Parse(lemonsPerPitcher);
            Console.WriteLine("How many tablespoons of honey do you want in each pitcher? (16 tablespoons in a cup)");
            honeyPerPitcher = Console.ReadLine();
            myRecipe.honeyPerPitcher = Int32.Parse(honeyPerPitcher);
            Console.WriteLine("How many ice cubes do you want in each glass? A full glass is 5 cubes.");
            cubesPerGlass = Console.ReadLine();
            myRecipe.cubesPerGlass = Int32.Parse(cubesPerGlass);
            return myRecipe;

        }

    }
}
