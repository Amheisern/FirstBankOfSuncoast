using System.Collections.Generic;
using System.Linq;
using System;
using System.IO;
using System.Globalization;
using CsvHelper;

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

            private string FileName = "transaction.csv";
            public void LoadTransaction()
            {
                if (File.Exists(FileName))
                {
                    var fileReader = new StreamReader(FileName);

                    var csvReader = new CsvReader(fileReader, CultureInfo.InvariantCulture);

                    // Replace our BLANK list of employees with the ones that are in the CSV file
                    Transactions = csvReader.GetRecords<Transaction>().ToList();

                    fileReader.Close();
                }
            }

            public void SaveTransaction()
            {
                var fileWriter = new StreamWriter(FileName);

                var csvWriter = new CsvWriter(fileWriter, CultureInfo.InvariantCulture);

                csvWriter.WriteRecords(Transactions);

                fileWriter.Close();
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
