class Program
{
    static void Main(string[] args)
    {
        // Create an object of BankAccount
        BankAccount account = new BankAccount("ACC1001", 5000);

        // Display account number
        Console.WriteLine("Account Number: " + account.AccountNumber);

        // Deposit money
        account.Deposit(1400);

        // Withdraw money
        account.Withdraw(3000);

        // Display remaining balance
        Console.WriteLine("Remaining Balance: " + account.Balance);

        Console.ReadLine();
    }
}