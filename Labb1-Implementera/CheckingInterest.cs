using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera
{
    // Implementerar 'IInterestStrategy' för ett transaktionskonto
    public class CheckingInterest : IInterestStrategy
    {
        // Metoden CalculateInterest beräknar räntan baserat på det aktuella saldot
        public decimal CalcurateInterest(decimal balance) => balance * 0.01M;
    }
}
