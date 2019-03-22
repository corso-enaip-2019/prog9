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
            coffees.Add(new Coffee(1.00D, " Caffè"));
            coffees.Add(new Coffee(1.10D, " Mocaccino"));

            foreach(ICoffee coffee in coffees)
            {
                
                Console.Write(String.Format("{0:0.00}", coffee.Cost));
                Console.WriteLine(coffee.Description);
                
            }
            



            Console.ReadLine();
        }
    }
}
