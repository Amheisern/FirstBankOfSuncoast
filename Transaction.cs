using System.Collections.Generic;
using System.Linq;
using System;
namespace FirstBankOfSuncoast
{
    partial class Program
    {
        public class Transaction
        {
            // checking or savings
            public string Account { get; set; }
            //How much
            public int Amount { get; set; }
            // Deposit or Withdraw
            public string Type { get; set; }
            // public DateTime Date { get; set; } = DateTime.Now;

            public string Description()
            {
                var descriptionString = ($"********************************\n {Type} of ${Amount} to {Account}\n********************************\n");

                return descriptionString;
            }
            // public void CheckingSum(List<Transaction> transactions)
            // //public void CheckingSum(Transaction transactions)

            // {
            //     var totalCheckingDeposits = transactions
            //                                 .Where(transaction => transaction.Account == "Checking" && transaction.Type == "Deposit").
            //                                 Sum(transaction => transaction.Amount);
            //     var totalCheckingWithdraw = transactions
            //                 .Where(transaction => transaction.Account == "Checking" && transaction.Type == "Withdraw").
            //                 Sum(transaction => transaction.Amount);

            //     Console.WriteLine($" Your checking balance is {totalCheckingDeposits - totalCheckingWithdraw} ");


            // }
        }
    }
}
