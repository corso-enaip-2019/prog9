using System;

namespace ConsAppEsercizio
{
    class Program
    {
        static void Main(string[] args)
        {

            //Print10Prime();


            PrintPrimeForN();

            Console.Read();

        }

        static void Print(int n)
        {
            Console.WriteLine($"{n} is prime? {IsPrime(n)}");
        }

        static bool IsPrime(int n)
        {
            if (n<2)
            {
                return false;
            }
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }


            }

            return true;
        }

        static void Print10Prime()
        {
            int.TryParse(Console.ReadLine(), out int n);

            int i = 0;
            while (i != 10)
            {

                if (IsPrime(n))
                {

                    Console.WriteLine($"{n} is prime");
                    i++;
                }
                n++;
            }


        }

        static void PrintPrimeForN()
        {
            Console.WriteLine("Quanti numeri primi vuoi visualizzare?");

            int.TryParse(Console.ReadLine(), out int number);

            Console.WriteLine();

            int Val = 2;
            int cycleN = 0;
            while (cycleN != number)
            {
                if (IsPrime(Val))
                {

                    Console.WriteLine($"{Val}");
                    cycleN++;
                }
                Val++;
            }

            if (number == 0)
            {
                Console.WriteLine("Non hai numeri primi");
            }
        }

    }
}
