using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public class AccountType
    {
        public class SavingsAccount : Account
        {
            public SavingsAccount(int accountId, string accountHolderName, double balance)
                : base(accountId, accountHolderName, balance) { }

            public override bool CanTransfer() => true;
        }

        public class CurrentAccount : Account
        {
            public CurrentAccount(int accountId, string accountHolderName, double balance)
                : base(accountId, accountHolderName, balance) { }

            public override bool CanTransfer() => true;
        }

        public class PPFAccount : Account
        {
            public PPFAccount( int AccountId, string AccountHolderName, double Balance)
                : base(AccountId, AccountHolderName, Balance) { }

            public override bool CanTransfer() => false;
        }
    }
}
