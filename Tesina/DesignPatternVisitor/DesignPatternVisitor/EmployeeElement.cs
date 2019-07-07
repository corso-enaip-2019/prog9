using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternVisitor
{
    //Element
    abstract class Element
    {
        public abstract string Name { get;set;}
        public abstract double AnnualSalary { get; set; }
        public abstract int PaidTimeOffDays { get; set; }
    }

    //Concrete element
    class EmployeeElement : Element , IVisitable
    {
        public override string Name { get; set; }
        public override double AnnualSalary { get; set; }
        public override int PaidTimeOffDays { get; set; }

        public EmployeeElement(string name,double annualSalary,int paidTimeOffDays)
        {
            Name = name;
            AnnualSalary = annualSalary;
            PaidTimeOffDays = paidTimeOffDays;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
