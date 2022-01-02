using System;
using System.Collections.Generic;
using System.Linq;

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
            Console.WriteLine("3. Show transactions ");
            Console.WriteLine("4. Quit ");
            Console.WriteLine("**************************");
        }
        static void Main(string[] args)
        {
            var database = new TransactionDatabase();
            //database.LoadTransaction();

            var keepGoing = true;

            var initialSavingDeposit = new Transaction()
            {
                Amount = 10,
                Account = "Saving",
                Type = "Deposit",
            };
            var initialCheckingDeposit = new Transaction()
            {
                Amount = 10,
                Account = "Checking",
                Type = "Deposit",
            };

            // initialSavingDeposit.Amount = 10;
            // initialSavingDeposit.Account = "Saving";
            // initialSavingDeposit.Type = "Deposit";
            database.AddTransaction(initialSavingDeposit);
            database.AddTransaction(initialCheckingDeposit);


            DisplayGreeting();



            while (keepGoing)
            {
                ShowMenu();
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        //Checking menu
                        Console.WriteLine("**************************");
                        Console.WriteLine("Welcome to your checking account?");
                        Console.WriteLine("Please choose an action!");
                        Console.WriteLine("1. Withdraw ");
                        Console.WriteLine("2. Deposit ");
                        Console.WriteLine("3. Display Balance ");
                        Console.WriteLine("**************************");
                        var checkingChoice = Console.ReadLine();

                        if (checkingChoice == "1")
                        {
                            var transactionWithdraw = new Transaction();


                            transactionWithdraw.Account = "Checking";
                            transactionWithdraw.Amount = PromptForInteger("How much would you like to withdraw from checking: ");
                            transactionWithdraw.Type = "Withdraw";
                            // if (transactionWithdraw.Amount > TotalChecking(database))
                            // {
                            //     Console.WriteLine("nope");
                            // }
                            // else
                            // {
                            //     database.AddTransaction(transactionWithdraw);
                            // }

                        }
                        else if (checkingChoice == "2")
                        {
                            var transactionDeposit = new Transaction();

                            transactionDeposit.Account = "Checking";
                            transactionDeposit.Amount = PromptForInteger("How much would you like to deposit from checking: ");
                            transactionDeposit.Type = "Deposit";
                            database.AddTransaction(transactionDeposit);
                        }

                        else if (checkingChoice == "3")
                        {
                            // displays checking sum
                            TotalChecking(database);
                        }
                        else
                        {
                            Console.WriteLine("please choose a valid action");
                        }
                        // save csv code

                        break;
                    case "2":
                        Console.WriteLine("**************************");
                        Console.WriteLine("What would your saving account?");
                        Console.WriteLine("Please choose an action!");
                        Console.WriteLine("1. Withdraw ");
                        Console.WriteLine("2. Deposit ");
                        Console.WriteLine("3. Display Balance");
                        Console.WriteLine("**************************");
                        var savingsChoice = Console.ReadLine();

                        if (savingsChoice == "1")
                        {
                            var transactionWithdraw = new Transaction();


                            transactionWithdraw.Account = "Savings";
                            transactionWithdraw.Amount = PromptForInteger("How much would you like to withdraw from savings: ");
                            transactionWithdraw.Type = "Withdraw";
                            database.AddTransaction(transactionWithdraw);

                        }
                        else if (savingsChoice == "2")
                        {
                            var transactionDeposit = new Transaction();

                            transactionDeposit.Account = "Savings";
                            transactionDeposit.Amount = PromptForInteger("How much would you like to deposit from savings: ");
                            transactionDeposit.Type = "Deposit";
                            database.AddTransaction(transactionDeposit);
                        }

                        else if (savingsChoice == "3")
                        {
                            // displays saving sum
                            var totalSavingsDeposits = database.Transactions.
                                       Where(transaction => transaction.Account == "Savings" && transaction.Type == "Deposit").
                                       Sum(transaction => transaction.Amount);
                            var totalSavingsWithdraw = database.Transactions.
                                        Where(transaction => transaction.Account == "Savings" && transaction.Type == "Withdraw").
                                        Sum(transaction => transaction.Amount);

                            Console.WriteLine($" Your savings balance is {totalSavingsDeposits - totalSavingsWithdraw} ");
                        }
                        else
                        {
                            Console.WriteLine("please choose a valid action");
                        }
                        // save csv code
                        break;
                    case "3":
                        // Display the number of transactions 
                        Console.WriteLine($"There are {database.Transactions.Count} transactions");
                        foreach (var transaction in database.Transactions)
                        {
                            var descriptionString = transaction.Description();

                            Console.WriteLine(descriptionString);
                            // for each transaction in out list of transactios 
                        }
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

        private static void TotalChecking(TransactionDatabase database)
        {
            var totalCheckingDeposits = database.Transactions.
                        Where(transaction => transaction.Account == "Checking" && transaction.Type == "Deposit").
                        Sum(transaction => transaction.Amount);
            var totalCheckingWithdraw = database.Transactions.
                        Where(transaction => transaction.Account == "Checking" && transaction.Type == "Withdraw").
                        Sum(transaction => transaction.Amount);

            Console.WriteLine($" Your checking balance is {totalCheckingDeposits - totalCheckingWithdraw} ");
            // return TotalChecking;
        }
    }
}
