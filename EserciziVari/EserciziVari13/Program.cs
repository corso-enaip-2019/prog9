using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziVari13
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 49; i <= 60; i++)
            {

                if (i != 49)
                {
                    Console.Write(Convert.ToString(i).PadRight(6));

                }
                else
                    Console.Write("  ".PadRight(6));
                for (int j = 50; j <= 60; j++)
                {
                    if (i != 49)
                    {
                        Console.Write(Convert.ToString(j * i).PadRight(6));
                    }
                    else
                        Console.Write(Convert.ToString(j).PadRight(6));
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
