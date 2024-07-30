public static class Bank
    {
        public static List<string> transactionHistory = new List<string>();

        public static void DisplayBankInfo()
        {
            Console.WriteLine("Welcome to the Bank");
            Console.WriteLine($"Total Accounts: {Account.accounts.Count}");
        }

        public static void TrackTransaction(string description)
        {
            transactionHistory.Add(description);
            Console.WriteLine($"Transaction recorded: {description}");
        }
    }