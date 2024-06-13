using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera
{
    //Factory designmönster för att skapa olika typer av konton
    public static class AccountFactory
    {
        public static Account CreateAccount(string accountType, string accountId)
        {
            // Använder switch-uttryck för att skapa och returnera rätt kontotyp baserat på accountType
            return accountType.ToLower() switch
            {
                "savings" => new SavingsAccount(accountId),
                "checking" => new CheckingAccount(accountId),
                _=> throw new ArgumentException($"Unknown account type: {accountType}")
            };
        }
    }
}
