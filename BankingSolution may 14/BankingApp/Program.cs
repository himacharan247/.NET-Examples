// See https://aka.ms/new-console-template for more information
using BankingApp;
using static BankingApp.AccountType;

class Program
{
    public static void Main(String[] args)
    {
        var user = new User(1, "John Doe");

        var savingsAccount = new SavingsAccount(101, user.Name, 1000.0);
        var currentAccount = new CurrentAccount(102, user.Name, 500.0);
        var ppfAccount = new PPFAccount(103, user.Name, 2000.0);

        savingsAccount.Deposit(500.0);
        savingsAccount.Withdraw(200.0);

        var accountService = new AccountService();

   
        accountService.Transfer(savingsAccount, currentAccount, 300.0);

        try
        {
            accountService.Transfer(ppfAccount, savingsAccount, 100.0);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}