using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingManagement
{
   public class User
{
    public int UserId { get; }
    public string Name { get; }

    public User(int userId, string name)
    {
        UserId = userId;
        Name = name;
    }
}
}
