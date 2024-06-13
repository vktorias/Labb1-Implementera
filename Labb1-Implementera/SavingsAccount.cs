using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera
{
    //Impementerar ett sparkonto som ärver från klassen Account
    public class SavingsAccount : Account
    {
        // Konstruktorn för SavingsAccount som anropar basklassens konstruktor med accountId
        public SavingsAccount(string accountId) : base(accountId) { }

        //Implementerar den abstrakta egenskapen AccountType
        //Returnerar en sträng som specificerar kontotypen som "Savings Account"
        public override string AccountType => "Savings Account";
    }
}
