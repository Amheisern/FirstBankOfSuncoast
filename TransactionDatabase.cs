using System.Collections.Generic;
using System.Linq;
using System;

namespace FirstBankOfSuncoast
{
    partial class Program
    {
        class TransactionDatabase
        {
            public List<Transaction> Transactions { get; set; } = new List<Transaction>();

            public void AddTransaction(Transaction newTransaction)
            {
                Transactions.Add(newTransaction);
            }



            // //public void CheckingSum(List<Transaction> transactions)
            // public Transaction CheckingSum(Transaction transactions)

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
