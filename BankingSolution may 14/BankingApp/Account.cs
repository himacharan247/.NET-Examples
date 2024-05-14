using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public abstract class Account
    {
      public int AccountId {  get; set; }
       public string AccountHolderName {  get; set; }
        public double Balance {  get; set; }

        public Account(int accountId, string accountHolderName, double balance)
        {
            AccountId = accountId;
            AccountHolderName = accountHolderName;
            Balance = balance;
        }

      public void Deposit(double Amount)
        {
            Balance += Amount;
            TransactionLogger.Log($"Deposit {Amount:c} into Account: {AccountId}");
        }

       public void Withdraw(double Amount)
        {
            if (Balance >= Amount)
            {
                Balance -= Amount;
                TransactionLogger.Log($"{Amount:c} withdrawn from Account: {AccountId}");
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

        public abstract bool CanTransfer();
    }
}
