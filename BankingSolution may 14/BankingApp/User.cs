using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankingApp
{
    public class User
    {
      public int UserId { get; set; }
   
     public string Name { get; internal set; }

        public User(int userId, string name)
        {
            UserId=userId; Name=Name;
        }
        public override string ToString()
        {
            return $"User(Id: {UserId}, Name: {Name})";
        }
    }
}
