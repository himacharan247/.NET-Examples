using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingManagement
{
    public enum AccountType
    {
        Savings,
        Current,
        PPF
    }

    public class Account
    {
        public int AccountId { get; }
        public string AccountHolderName { get; }
        public decimal Balance { get; private set; }
        public AccountType Type { get; }

        public Account(int accountId, string accountHolderName, AccountType type)
        {
            AccountId = accountId;
            AccountHolderName = accountHolderName;
            Type = type;
            Balance = 0; // Initialize balance to zero
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive.");

            Balance += amount;
            TransactionLogger.LogTransaction($"Deposited {amount:C} into account {AccountId}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be positive.");

            if (Balance < amount)
                throw new InvalidOperationException("Insufficient balance.");

            Balance -= amount;
            TransactionLogger.LogTransaction($"Withdrawn {amount:C} from account {AccountId}");
        }

        public void Transfer(Account destinationAccount, decimal amount)
        {
            if (Type == AccountType.PPF)
                throw new InvalidOperationException("PPF accounts cannot transfer funds.");

            Withdraw(amount);
            destinationAccount.Deposit(amount);
            TransactionLogger.LogTransaction($"Transferred {amount:C} from account {AccountId} to account {destinationAccount.AccountId}");
        }
    }
}
