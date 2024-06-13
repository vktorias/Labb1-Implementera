using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera
{
    //Designmöster för olika typer av ränteberäkningar
    public interface IInterestStrategy
    {
        decimal CalcurateInterest(decimal balance);
    }
}
