using System;

namespace FirstBankOfSuncoast
{
    partial class Program
    {

        static void DisplayGreeting()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("    Welcome to 1st Bank of Suncoast     ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
        }
        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();
            return userInput;
        }
        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            int userInput;
            var isThisGoodInput = Int32.TryParse(Console.ReadLine(), out userInput);
            if (isThisGoodInput)
            {
                return userInput;
            }
            else
            {
                Console.WriteLine("Sorry, that isn't a valid input, I'm using 0 as your answer.");
                return 0;
            }
        }
        //--------------------------- methods and Classes -----------------------------
        static void ShowMenu()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Checking ");
            Console.WriteLine("2. Saving ");
            Console.WriteLine("3. Transfer ");
            Console.WriteLine("4. Quit ");
            Console.WriteLine("**************************");
        }
        static void Main(string[] args)
        {
            var database = new TransactionDatabase();
            //database.LoadTransaction();
            var keepGoing = true;
            DisplayGreeting();



            while (keepGoing)
            {
                ShowMenu();
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("**************************");
                        Console.WriteLine("Welcome to your checking account?");
                        Console.WriteLine("Please choose an action!");
                        Console.WriteLine("1. Withdraw ");
                        Console.WriteLine("2. Deposit ");
                        Console.WriteLine("3. Display ");
                        Console.WriteLine("**************************");

                        break;
                    case "2":
                        Console.WriteLine("**************************");
                        Console.WriteLine("What would your saving account?");
                        Console.WriteLine("Please choose an action!");
                        Console.WriteLine("1. Withdraw ");
                        Console.WriteLine("2. Deposit ");
                        Console.WriteLine("3. Display ");
                        Console.WriteLine("**************************");

                        break;
                    case "3":
                        // ??
                        break;
                    case "4":
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("That was not a valid selection!");
                        break;

                }
            }
        }
    }
}
