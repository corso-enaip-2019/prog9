using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternVisitor
{
    class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            EmployeeElement employee = element as EmployeeElement;

            employee.AnnualSalary *= 1.10;
            
            Console.WriteLine(string.Format("{0} {1}'s new income: {2}$", employee.GetType().Name, employee.Name, employee.AnnualSalary));
        }
    }

    class PaidTimeOfFVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            EmployeeElement employee = element as EmployeeElement;

            employee.PaidTimeOffDays += 3;

            Console.WriteLine("{0} {1}'s new vacation days: {2}", employee.GetType().Name, employee.Name, employee.PaidTimeOffDays);
        }
    }
}
