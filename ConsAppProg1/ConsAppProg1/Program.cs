using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppProg1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("riga");
            //Console.ReadLine();

            //string str = "Hola";
            //str = string.Concat(str, "viva");


            //int i = 0;
            //if (i > 1 && i < 10)
            //{

            //}
            //else if (i > 2 || i == 5)
            //{

            //}
            //else
            //{

            //}

            //inserire all'utente 3 numeri interi e diamo come indicazione se quei numeri sono un potenziale triangolo

            int[] lato = new int[3];

            
            for (int i = 0; i < lato.Length; i++)
            {
                lato[i] = AskandCheckNumber("inserisci lato");

            }


            if (IsTriangle(lato[0], lato[1], lato[2]))
            {
                Console.WriteLine("è un triangolo");
            }
            else
            {
                Console.WriteLine("non è un triangolo");





                do
                {
                    int m = Math.Max(Math.Max(lato[0], lato[1]), lato[2]);

                    int index = Array.IndexOf(lato, m);

                    lato[index] = lato[index] -1;

                } while (!IsTriangle(lato[0], lato[1], lato[2]));

                Console.WriteLine($"Questi valori costituiscono un triangolo {lato[0]},{lato[1]},{lato[2]}");


            }
            Console.ReadLine();
        }

        /// <summary>
        /// Mostra all'utente il messaggio e converte il valore inserito in input in un intero
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>

        static int AskandCheckNumber(string message)
        {
            System.Diagnostics.Debug.WriteLine(string.Concat("Message: ", message));
            int convertedValue;
            Console.WriteLine(message);
            string input = Console.ReadLine();
            bool ConversionOk = int.TryParse(input, out convertedValue);
            if (!ConversionOk)
            {
                Console.WriteLine("l'input non è valido");
            }
            if (convertedValue <= 0)
            {
                Console.WriteLine("il valore deve essere positivo");

            }

            System.Diagnostics.Debug.WriteLine(string.Format("{0}:{1}", message, input));
            System.Diagnostics.Debug.WriteLine($"{message}:{input}");

            return convertedValue;
        }

        static bool IsTriangle(int a, int b, int c)

       {


            bool sumOk = a < b + c && b < a + c && c < a + b;
            bool diffOk = a > Math.Abs(b - c) && b > Math.Abs(a - c) && c > Math.Abs(a - b);

            return sumOk && diffOk;
        }
    }
}
