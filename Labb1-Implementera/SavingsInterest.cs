using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera
{
    // Strategy designmönster för ränteberäkning
    // 'SavingsInterest' impementerar 'IInterestStrategy'
    // Det gör att man inte behöver ändra koden för kontona för att byta ut olika beräkningsstrategier
    public class SavingsInterest : IInterestStrategy
    {
        // Metoden CalcurateInterest beräknar räntan baserat på kontosaldot.
        public decimal CalcurateInterest(decimal balance) => balance * 0.02M;
    }
}
