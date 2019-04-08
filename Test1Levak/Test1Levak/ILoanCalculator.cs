using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1Levak
{
    public interface ILoanCalculator
    {
        double InitialAmount { get; }
        double FinalAmount { get; }
        bool IsClient { get; }
        double Calculate(IInputOutput inputOutput);
    }
}
