using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera
{
    //Abstrakt klass för att representera ett bankkonto
    public abstract class Account
    {
        public string AccountId { get; }
        public decimal Balance { get; private set; }

        //Konstruktor för att initiera konto-ID och sätta startbalans till 0
        protected Account(string accountId)
        {
            AccountId = accountId;
            Balance = 0;
        }

        public abstract string AccountType { get; }

        //Metod för att sätta in pengar på kontot
        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount} into {AccountId}. New balance is {Balance}.");
        }

        //Metod för att ta ut pengar från kontot
        public void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdraw {amount} from {AccountId}. New balance is {Balance}.");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
    }
}
