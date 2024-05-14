using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public class AccountService
    {
        public void Transfer(Account fromAccount, Account toAccount, double Amount)
        {
            if (!fromAccount.CanTransfer())
            {
                Console.WriteLine("Transfer not allowed from this account type.");
            }

            if (fromAccount.Balance < Amount)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }

            fromAccount.Withdraw(Amount);
            toAccount.Deposit(Amount);
            TransactionLogger.Log($"Transfer: {Amount} from Account: {fromAccount.AccountId} to Account: {toAccount.AccountId}");
        }
    }
}
