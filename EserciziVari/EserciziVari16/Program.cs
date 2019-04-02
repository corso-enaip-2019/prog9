using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziVari16
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inserisci un numero per calcolarne la potenza");
            int NumeroInserito;
            while (true)
            {
                bool NumberOk = int.TryParse(Console.ReadLine(), out NumeroInserito);
                if (NumberOk)
                {
                    break;
                }
                else
                    Console.WriteLine("Devi inserire un numero! Riprova...");
            }

            int Potenza;
            while (true)
            {
                bool NumberOk = int.TryParse(Console.ReadLine(), out Potenza);
                if (NumberOk)
                {
                    break;
                }
                else
                    Console.WriteLine("Devi inserire un numero! Riprova...");
            }
            int Risultato = NumeroInserito;
            for (int i = 1 ; i <= Potenza; i++)
            {

                Risultato = (NumeroInserito * Risultato);
                
                if (i == Potenza - 1)
                {
                    Console.WriteLine(Risultato);
                }


            }

            Console.Read();

        }
    }
}
