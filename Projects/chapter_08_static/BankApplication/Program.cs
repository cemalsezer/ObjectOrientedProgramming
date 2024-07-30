namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating sample accounts
            Account acc1 = new Account("123456789", "John Doe", 1000.00);
            Account acc2 = new Account("987654321", "Jane Smith", 1500.00);

            bool running = true;
            while (running)
            {
                Console.WriteLine("Banking System");
                Console.WriteLine("1. View Account Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. View Transaction History");
                Console.WriteLine("5. View Bank Info");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Write("Enter account number: ");
                        string accountNumber = Console.ReadLine();
                        Account account = Account.accounts.Find(a => a.GetAccountNumber() == accountNumber);
                        if (account != null)
                        {
                            account.ViewBalance();
                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }
                        break;

                    case "2":
                        Console.Write("Enter account number: ");
                        accountNumber = Console.ReadLine();
                        account = Account.accounts.Find(a => a.GetAccountNumber() == accountNumber);
                        if (account != null)
                        {
                            Console.Write("Enter amount to deposit: ");
                            if (double.TryParse(Console.ReadLine(), out double depositAmount))
                            {
                                account.Deposit(depositAmount);
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }
                        break;

                    case "3":
                        Console.Write("Enter account number: ");
                        accountNumber = Console.ReadLine();
                        account = Account.accounts.Find(a => a.GetAccountNumber() == accountNumber);
                        if (account != null)
                        {
                            Console.Write("Enter amount to withdraw: ");
                            if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                            {
                                account.Withdraw(withdrawAmount);
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Transaction History:");
                        foreach (var transaction in Bank.transactionHistory)
                        {
                            Console.WriteLine(transaction);
                        }
                        break;

                    case "5":
                        Bank.DisplayBankInfo();
                        break;

                    case "0":
                        running = false;
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 0 and 5.");
                        break;
                }
            }
        }
    }
}