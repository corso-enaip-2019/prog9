using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsAppCaffetteria.Beverage;

namespace ConsAppCaffetteria
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICoffee> coffees = new List<ICoffee>();
            coffees.Add(new Coffee(1.00, "Caffè"));
            coffees.Add(new Coffee(1.10, "Mocaccino"));

            foreach(ICoffee coffee in coffees)
            {

                
                Console.WriteLine(coffee.Description,coffee.Cost);
                
            }
            Console.ReadLine();
        }
    }
}
