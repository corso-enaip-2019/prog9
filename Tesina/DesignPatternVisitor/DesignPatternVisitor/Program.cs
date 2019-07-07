using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternVisitor
{
    class Program
    {
        static void Main(string[] args)
        {   
            //In un ipotetico scenario di un ristorante,il management superiore ha deciso che è ora di premiare i suoi dipendenti che lavorano duramente dando loro aumenti e giorni festivi.
            //Il problema è che le classi che rappresentano i dipendenti sono già state create e non possono essere modificate.

            Employees e = new Employees();

            e.Attach(new LineCook());
            e.Attach(new HeadChef());
            e.Attach(new GeneralManager());

            e.Accept(new IncomeVisitor());
            e.Accept(new PaidTimeOfFVisitor());

            Console.Read();
        }
    }
}
