using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziVari3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num3 = 3;
            int Num5 = 5;

            int Increment = 1;

            for (int i = 0; i < 100; i++)
            {
                if (Increment%Num3 == 0 || Increment%Num5 == 0)
                {
                    Console.WriteLine(Increment);
                }

                Increment++;
            }

            Console.WriteLine("____________________________________________________________");

            int Increment2 = 1;
            int Contatore = 0;
            for (int i = 0; i < 10000 ; i++)
            {
                if (Increment2 % Num3 == 0 || Increment2 % Num5 == 0)
                {
                    Console.WriteLine(Increment2);
                    Contatore++;
                }
                if (Contatore == 100)
                {
                    break;
                }
                Increment2++;

            }

            Console.Read();


            
        }
    }
}
