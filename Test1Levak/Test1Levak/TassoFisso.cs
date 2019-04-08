using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1Levak
{
    public class TassoFisso : ILoanCalculator
    {
        int MutuoAnni = 10;
        double MutuoFisso = 3;
        public double InitialAmount = 0;
        public double FinalAmount = 0;
        public bool IsClient = true;

        double ILoanCalculator.InitialAmount => InitialAmount;
        double ILoanCalculator.FinalAmount => FinalAmount;
        bool ILoanCalculator.IsClient => IsClient;

        public double Calculate(IInputOutput inputOutput)
        {
            string cifraRichiesta = inputOutput.AskForString("");
            InitialAmount = VerificaInserimento(cifraRichiesta);

            if (IsClient == false)
            {
                FinalAmount = ((InitialAmount / 100) * MutuoFisso) * MutuoAnni;
            }
            else if (IsClient == true)
            {
                MutuoFisso = 2.5 ;
                FinalAmount = ((InitialAmount / 100) * MutuoFisso) * MutuoAnni;
            }
            return FinalAmount;
        }

        static double VerificaInserimento(string s)
        {
            double numeroInserito;
            while (true)
            {
                bool numberOk = double.TryParse(Console.ReadLine(), out numeroInserito);
                if (numberOk == true)
                {
                    break;
                }
                else
                    Console.WriteLine("Non hai inserito un numero,riprova");
            }
            return numeroInserito;
        }
    }
}
