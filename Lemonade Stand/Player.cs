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
        int bankAccount = 50;
        Recipe myRecipe = new Recipe();
        
        Inventory inventory = new Inventory();

        public string priceToCharge;
        public int costOfMaterials;



        //constructor

        //properties
        public int BankAccount
        {
            get
            {
                return bankAccount;
            }
            set
            {
                bankAccount = value;
            }
        }

        //member methods


        public void GoShopping(Store store)
        {
            string amountOfIce;
            string numberOfLemons;
            string amountOfHoney;
            string bagsOfCups;
            //int costOfMaterials;
            //public string priceToCharge;


            Console.WriteLine("You have $" + BankAccount + " in your account");
            Console.WriteLine("Ice costs $5 per bag of 50 cubes.");
            Console.WriteLine("Lemons cost $1 each.");
            Console.WriteLine("Honey costs $1 per cup.");
            Console.WriteLine("Cups cost $3 for every bag of 15 cups.");

            Console.WriteLine("How many bags of ice do you want to purchase?");
            amountOfIce = Console.ReadLine();
            inventory.amountOfIce += Int32.Parse(amountOfIce);
            bankAccount -= (Int32.Parse(amountOfIce))*store.IcePrice;
            Console.WriteLine("Account: $" + bankAccount);

            Console.WriteLine("How many lemons do you want to buy?");
            numberOfLemons = Console.ReadLine();
            inventory.numberOfLemons += Int32.Parse(numberOfLemons);
            bankAccount -= (Int32.Parse(numberOfLemons)) * store.LemonPrice;
            Console.WriteLine("Account: $" + bankAccount);

            Console.WriteLine("How many cups of honey do you want to buy?");
            amountOfHoney = Console.ReadLine();
            inventory.amountOfHoney += Int32.Parse(amountOfHoney);
            bankAccount -= (Int32.Parse(amountOfHoney)) * store.HoneyPrice;
            Console.WriteLine("Account: $" + bankAccount);

            Console.WriteLine("How many bags of cups do you want to buy?");
            bagsOfCups = Console.ReadLine();
            inventory.numberOfCups += Int32.Parse(bagsOfCups);
            bankAccount -= (Int32.Parse(bagsOfCups)) * store.CupsPrice;
            Console.WriteLine("Account: $" + bankAccount);

            costOfMaterials = ((Int32.Parse(amountOfIce)) * store.IcePrice) + ((Int32.Parse(numberOfLemons)) * store.LemonPrice) + ((Int32.Parse(amountOfHoney)) * store.HoneyPrice) + ((Int32.Parse(bagsOfCups)) * store.CupsPrice);

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
            Console.WriteLine("How much would you like to charge for a cup (in $)? .50, 1.00, 1.50, 2.00, or 2.50?");
            priceToCharge = Console.ReadLine();
            
            return myRecipe;

        }
    }
}
