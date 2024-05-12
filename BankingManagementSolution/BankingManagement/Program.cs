using BankingManagement;

class Program
{
    static void Main(string[] args)
    {
        // Create a user
        Console.WriteLine("enter userId");
        int userId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Username");
        string Name = Console.ReadLine();
        User user = new User(userId,Name);
        Console.WriteLine($"User created: ID - {user.UserId}, Name - {user.Name}");


        // Create different types of accounts for the user
        Account savingsAccount = new Account(101, user.Name, AccountType.Savings);
        Account currentAccount = new Account(201, user.Name, AccountType.Current);
        Account ppfAccount = new Account(301, user.Name, AccountType.PPF);

        // Deposit into savings and current accounts
        savingsAccount.Deposit(1000);
        currentAccount.Deposit(5000);

        // Transfer funds between accounts
        savingsAccount.Transfer(currentAccount, 500);

        // Try to transfer from PPF account (should throw exception)
        try
        {
            ppfAccount.Transfer(savingsAccount, 200);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        // Display balances after transactions
        Console.WriteLine($"Savings Account Balance: {savingsAccount.Balance:C}");
        Console.WriteLine($"Current Account Balance: {currentAccount.Balance:C}");
    }
}
