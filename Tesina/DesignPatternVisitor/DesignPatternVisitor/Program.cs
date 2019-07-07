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
