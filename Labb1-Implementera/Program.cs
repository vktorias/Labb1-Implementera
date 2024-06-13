// Designmönster som implementeras i programmet:
// 1. Factory Method
// 2. Singleton
// 3. Strategy

namespace Labb1_Implementera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapar bank instans(Singleton)
            Bank bank = Bank.Instance;

            //Skapar konton med Factory Metoden
            Account account1 = bank.CreateAccount("savings", "ACC1001");
            Account account2 = bank.CreateAccount("checking", "ACC1002");

            //Gör insättningar och uttag för konto 1 och 2
            account1.Deposit(700);
            account1.Withdraw(210);
            account2.Deposit(1000);
            account2.Withdraw(650);

            //Använder Strategy för att beräkna räntan
            IInterestStrategy savingsInterestStrategy = new SavingsInterest();
            IInterestStrategy checkingInterestStrategy = new CheckingInterest();

            decimal savingsInterest = savingsInterestStrategy.CalcurateInterest(account1.Balance);
            decimal checkingInterest = checkingInterestStrategy.CalcurateInterest(account2.Balance);

            Console.WriteLine($"Savings Account Interest: {savingsInterest}");
            Console.WriteLine($"Checking Account Interest {checkingInterest}");
        }
    }
}
