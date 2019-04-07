using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2ndPart01
{
    class Program
    {
        static void Main(string[] args)
        {
            Room R = new Room();

            Console.WriteLine(R.Name);
            Console.WriteLine(R.CalculateTotalsurface());

            Console.Read();


        }
    }
}