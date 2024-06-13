using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera
{
    //Implementerar ett transaktionskonto som ärver från klassen Account
    public class CheckingAccount : Account
    {
        public CheckingAccount(string accountId) : base(accountId) { }
        public override string AccountType => "Checking Account";
    }
}
