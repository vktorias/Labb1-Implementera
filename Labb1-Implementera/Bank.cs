using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera
{
    //Singleton designmönster för Bank klassen
    public sealed class Bank
    {
        //En statisk, readonly instans av Bank, initialiserad med Lazy för trådsäker, fördröjd initialisering
        private static readonly Lazy<Bank> instance = new Lazy<Bank>(() => new Bank());
        //En Dictionary som lagrar konton med konto-ID som nyckel
        private readonly Dictionary<string, Account> accounts = new Dictionary<string, Account>();

        //Privat konstruktor för att förhindra direkt instansiering
        private Bank() { }

        public static Bank Instance => instance.Value;

        public Account CreateAccount(string accountType, string accountId)
        {
            // Använder AccountFactory för att skapa ett konto baserat på accountType och accountId
            Account account = AccountFactory.CreateAccount(accountType, accountId);
            accounts[accountId] = account;
            return account;
        }
    }
}
