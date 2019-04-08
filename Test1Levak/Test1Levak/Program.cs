using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1Levak
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void Menu()
        {
            Console.WriteLine("Quanti soldi desidera ricevere in prestito?");
            
            Console.WriteLine("Desidera un mutuo a tasso fisso o a tasso variabile?");

            Console.WriteLine("E' già nostro cliente?");
        }

        public class ConsoleInputoutput : IInputOutput
        {
            public string AskForString(string message)
            {
                Console.WriteLine(message);
                return Console.ReadLine();
            }
            public void WriteMessage(string message)
            {
                Console.WriteLine(message);
            }
        }

        public class LoanApplication
        {
            public LoanApplication(IInputOutput inputOutput, ILoanCalculator loanCalculator)
            {
            }

            public void Run(ILoanCalculator loanCalculator)
            {
                //loanCalculator.Calculate();
            }
        }

    }
}
