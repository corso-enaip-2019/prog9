using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziVari2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 7;
            int Double = Number * 2;
            int Triple = Number * 3;

            string StringDouble = $"The double of {Number} is ";
            string StringTriple = $"The triple of {Number} is ";

            Console.WriteLine($"{StringDouble}{Double}");
            Console.WriteLine($"{StringTriple }{ Triple}");
            Console.Read();

        }
    }
}
