using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1Levak
{
    class TassoVariabile: ILoanCalculator
    {
        int MutuoAnni = 10;
        public List<double> InflazioniAnni = new List<double>() { 2 , 3 , 1.5 , 2.5 , 3 , 1.5 , 2 , 2 , 2.5 , 2};
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
                foreach (var item in InflazioniAnni)
                {
                    FinalAmount += ((InitialAmount / 100) * item) * MutuoAnni;
                }
            }
            else if (IsClient == true)
            {
                foreach (var item in InflazioniAnni)
                {
                    FinalAmount += ((InitialAmount / 100) * (item - 0.5)) * MutuoAnni;
                }
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
