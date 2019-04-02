using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziVari7
{
    class Program
    {
        static void Main(string[] args)
        {
            double FirstNumber;
            double SecondNumber;

            bool NumberOk;

            Console.WriteLine("Insert 2 number");
            while (true)
            {
                NumberOk = double.TryParse(Console.ReadLine(), out FirstNumber);
                if (NumberOk == true)
                {
                    break;
                }
                else
                    Console.WriteLine("This isn't a valid number, try again");

            }
            while (true)
            {
                NumberOk = double.TryParse(Console.ReadLine(), out SecondNumber);
                if (NumberOk == true)
                {
                    break;
                }
                else
                    Console.WriteLine("This isn't a valid number, try again");

            }

            double Sum = FirstNumber + SecondNumber;
            double Subtraction = FirstNumber - SecondNumber;
            double Multiplication = FirstNumber * SecondNumber;
            double Divide = FirstNumber / SecondNumber;
            double Exponent = System.Math.Pow(FirstNumber, SecondNumber);

            string sum = "sum";
            string subtraction = "subtraction";
            string multiplication = "moltiplication";
            string divide = "divide";
            string Ex = "exponent";



            Decoration(Sum,sum);
            Console.WriteLine();
            Decoration(Subtraction, subtraction);
            Console.WriteLine();
            Decoration(Multiplication, multiplication);
            Console.WriteLine();
            Decoration(Divide, divide);
            Console.WriteLine();
            Decoration(Exponent, Ex);

            Console.Read();



        }
        static void Decoration(double Op, string NameOp)
        {

            string decoration = $"== The {NameOp} is: {Op}! ==";

            string equal = "=";
            for (int i = 0; i < decoration.Length; i++)
            {
                equal += "=";
            }


            Console.WriteLine(equal);
            Console.WriteLine(decoration);
            Console.WriteLine(equal);

        }
        
    }
}
