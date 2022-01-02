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
                var descriptionString = ($"{Type} of ${Amount} to {Account}");

                return descriptionString;
            }

        }
    }
}
