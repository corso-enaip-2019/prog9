using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2ndPart04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> primes = GetPrimenumber1000000();

            Console.WriteLine("I numeri primi compresi fino a 1000000 sono:");
            foreach (var item in primes)
            {
                Console.WriteLine(item);
            }

            Console.Read();


            //Calcola tutti i numeri primi fino a 1.000.000.

            //Aggiungerli a un elenco.

            //Utilizzare la classe cronometro per misurare le prestazioni del metodo.

            //Alla fine arrestare il cronometro e stampare sulla console il tempo di esecuzione misurato

        }

        private static List<double> GetPrimenumber1000000()
        {
            List<double> primeList = new List<double>();

            for (int i = 2; i < 1000; i++)
            {
                if (IsPrime(i))
                {
                    primeList.Add(i);
                }

            }
            return primeList;

        }

        static bool IsPrime(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;

            return true;
        }
    }
}
