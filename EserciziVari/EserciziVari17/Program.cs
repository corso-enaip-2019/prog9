using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziVari17
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inserisci un numero per calcolarne la potenza");
            int Moltiplicando;
            while (true)
            {
                bool NumberOk = int.TryParse(Console.ReadLine(), out Moltiplicando);
                if (NumberOk)
                {
                    break;
                }
                else
                    Console.WriteLine("Devi inserire un numero! Riprova...");
            }

            int Moltiplicatore;
            while (true)
            {
                bool NumberOk = int.TryParse(Console.ReadLine(), out Moltiplicatore);
                if (NumberOk)
                {
                    break;
                }
                else
                    Console.WriteLine("Devi inserire un numero! Riprova...");
            }
            int Prodotto = Moltiplicando;

            for (int i = 1; i < Moltiplicatore; i++)
            {

                Prodotto = (Moltiplicando + Prodotto);
                if (i == Moltiplicatore - 1)
                {
                    Console.WriteLine(Prodotto);

                }

            }

            Console.ReadLine();


        }
    }
}
