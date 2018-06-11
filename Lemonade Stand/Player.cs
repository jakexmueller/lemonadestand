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
        Recipe myRecipe;

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
        public void MakeRecipe()
        {
            myRecipe = new Recipe();

            Console.WriteLine("You have $" + BankAccount + " in your account");
            Console.WriteLine("How much ice do you want to purchase?");
            string amountOfIce = Console.ReadLine();

            Console.WriteLine("How many lemons do you want to buy?");
            string numberOfLemons = Console.ReadLine();
            myRecipe.numberOfLemons = Int32.Parse(numberOfLemons);

            Console.WriteLine("How much honey do you want to buy?");
            string amountOfHoney = Console.ReadLine();
            Console.WriteLine("How many cups do you want to buy?");
            string numberOfCups = Console.ReadLine();



        }
            

    }
}
