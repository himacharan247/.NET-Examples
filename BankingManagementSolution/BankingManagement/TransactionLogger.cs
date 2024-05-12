using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingManagement
{
    public static class TransactionLogger
    {
        public static void LogTransaction(string transactionDetails)
        {
            Console.WriteLine(transactionDetails);
            // Additional logic to log to file, database, etc. can be added here
        }
    }
}
