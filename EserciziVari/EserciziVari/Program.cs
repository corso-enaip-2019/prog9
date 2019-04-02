using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziVari
{
    class Program
    {
        static void Main(string[] args)
        {
            int TrueNumb = 42;
            string Sentence = "The answer to all the quesions is ";


            Console.WriteLine($"{Sentence}{TrueNumb}");

            Console.WriteLine("Choise a number :");


            int NumberChosen;
            while (true)
            {
                bool NumberCorrect = Int32.TryParse(Console.ReadLine(), out NumberChosen);
                if (NumberCorrect == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The number chosen is not valid, try again");
                }
            }


            if (NumberChosen % TrueNumb == 0)
            {
                Console.WriteLine("The number choise is divisible for 42");
            }
            else
                Console.WriteLine("The number choise isn't divisible for 42");

            Console.Read();



        }
    }
}
