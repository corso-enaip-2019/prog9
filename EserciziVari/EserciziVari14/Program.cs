using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziVari14
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1,x = 1; i <= 10; i++)
            {
                Console.Write(Convert.ToString(x).PadRight(3));
                if (i > 1)
                {
                    for (int j = 2,y = 2; j <= i; j++ ,y++)
                    {
                        Console.Write(Convert.ToString(y).PadRight(3));
                    }
                }

                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
