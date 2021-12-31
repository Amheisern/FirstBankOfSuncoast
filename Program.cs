using System;

namespace FirstBankOfSuncoast
{
    class Program
    {
        public class Transaction
        {
            public string Account { get; set; }
            public string Amount { get; set; }
            public string Type { get; set; }
            // public DateTime Date { get; set; } = DateTime.Now;
        }

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


            DisplayGreeting();

            var keepGoing = true;

            while (keepGoing)
            {
                ShowMenu();
                var choice = Console.ReadLine();
            }
        }
    }
}
