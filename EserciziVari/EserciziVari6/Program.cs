using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziVari6
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
            double Exponent = System.Math.Pow(FirstNumber,SecondNumber);

            Console.WriteLine($@"The sum from {FirstNumber} and {SecondNumber} is {Sum}
The substract from {FirstNumber} and {SecondNumber} is {Subtraction}
The multiplication from {FirstNumber} and {SecondNumber} is {Multiplication}
The divide from {FirstNumber} and {SecondNumber} is {Divide}
The elevetion power of {FirstNumber} with value {SecondNumber} is {Exponent}");
            Console.Read();


        }
    }
}
