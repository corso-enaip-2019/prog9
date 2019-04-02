using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziVari._10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 19; i >= -4; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("______________________________________________________");

            for (int i = -4; i <= 19 ; i += 3)
            {
                Console.WriteLine(i);
            }
            Console.Read();

        }
    }
}
