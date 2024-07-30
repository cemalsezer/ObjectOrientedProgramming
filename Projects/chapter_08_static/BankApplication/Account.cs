public class Account
{
    private string accountNumber;
    private string owner;
    private double balance;
    public static List<Account> accounts = new List<Account>();

    public Account(string accountNumber, string owner, double balance)
    {
        this.accountNumber = accountNumber;
        this.owner = owner;
        this.balance = balance;
        accounts.Add(this);
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Bank.TrackTransaction($"Deposited {amount} to account {accountNumber}");
            Console.WriteLine($"Deposited {amount} to account {accountNumber}. New balance: {balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Bank.TrackTransaction($"Withdrew {amount} from account {accountNumber}");
                Console.WriteLine($"Withdrew {amount} from account {accountNumber}. New balance: {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
        else
        {
            Console.WriteLine("Withdrawal amount must be positive.");
        }
    }

    public void ViewBalance()
    {
        Console.WriteLine($"Account Number: {accountNumber}");
        Console.WriteLine($"Owner: {owner}");
        Console.WriteLine($"Balance: {balance}");
    }

       public string GetAccountNumber()
        {
            return accountNumber;
        }
}
