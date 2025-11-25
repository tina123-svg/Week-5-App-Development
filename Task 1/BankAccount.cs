public class BankAccount
{
    // Private fields
    private string accountNumber;
    private double balance;

    // Public property (Read-only)
    public string AccountNumber
    {
        get { return accountNumber; }
    }

    // Public property with private set (cannot set from outside)
    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value > 0)
                balance = value;
            else
                Console.WriteLine("Balance cannot be zero or negative!");
        }
    }

    // Constructor
    public BankAccount(string accountNumber, double initialBalance)
    {
        this.accountNumber = accountNumber;

        if (initialBalance > 0)
            this.balance = initialBalance;
        else
        {
            Console.WriteLine("Initial balance must be greater than zero. Setting balance to 1.");
            this.balance = 1;
        }
    }

    // Deposit Method
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be greater than zero!");
        }
    }

    // Withdraw Method
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdraw amount must be greater than zero!");
        }
        else if (amount > balance)
        {
            Console.WriteLine("Insufficient balance!");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }
    }
}