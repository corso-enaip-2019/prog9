using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziVari12
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 10; i++)
            {

                Console.Write(Convert.ToString(i).PadRight(6));

                for (int j = 1; j <= 10; j++)
                {

                    

                    if (i != 0)
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
