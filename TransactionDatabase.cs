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
        }
    }
}
