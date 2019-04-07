using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2ndPart3
{
    class Program
    {
        static void Main(string[] args)
        {

            Random Rnd = new Random();
            int numeroEstratto = Rnd.Next(1, 10);


            int numeroScelto = 0;

            Console.WriteLine("Trova il numero estratto:");
            Console.WriteLine("Inserisci un numero da 1 a 10 (Hai 5 tentativi)");
            for (int i = 0; i < 5; i++)
            {

                while (true)
                {

                    bool numberOk = int.TryParse(Console.ReadLine(), out numeroScelto);
                    if (numberOk == true && numeroScelto > 0 && numeroScelto < 10)
                    {
                        break;
                    }
                    else if (numeroScelto<1 || numeroScelto>10)
                    {
                        Console.WriteLine("Hai inserito un numero fuori dal range");
                    }
                    else
                        Console.WriteLine("Non hai inserito un numero,riprova");
                }

                if (numeroScelto == numeroEstratto)
                {
                    Console.WriteLine("Hai indovinato il numero");
                    break;
                }
                else
                    Console.WriteLine("Il numero scelto non corrisponde al numero estratto");
            }
            if (numeroScelto != numeroEstratto)
            {
                Console.WriteLine($"Il numero corretto era il numero {numeroEstratto}");

            }

            Console.Read();

        }
    }
}
