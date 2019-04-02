using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziVari15
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1, x = 1,z=20; i <= 10; i++, z-=2)
            {

                Console.Write(Convert.ToString(x).PadLeft(z));
                if (i > 1)
                {
                    for (int j = 2, y = 2; j <= i; j++, y++)
                    {
                        Console.Write(Convert.ToString(y).PadLeft(4));
                    }
                }

                Console.WriteLine();
            }
            Console.Read();


        }
    }
}
