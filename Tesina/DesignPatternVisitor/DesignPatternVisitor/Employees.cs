using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternVisitor
{
    class Employees
    {
        private List<EmployeeElement> _employees = new List<EmployeeElement>();

        public void Attach(EmployeeElement employee)
        {
            _employees.Add(employee);
        }

        public void Detach(EmployeeElement employee)
        {
            _employees.Remove(employee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (EmployeeElement item in _employees)
            {
                item.Accept(visitor);
            }
            Console.WriteLine();
        }
    }

    class LineCook : EmployeeElement
    {
        public LineCook() : base("Nicola", 32000, 7)
        {
        }
    }

    class HeadChef : EmployeeElement
    {
        public HeadChef() : base("Jovan", 69015, 21)
        {
        }
    }

    class GeneralManager : EmployeeElement
    {
        public GeneralManager() : base("Barbara", 78000, 24)
        {
        }
    }
}
