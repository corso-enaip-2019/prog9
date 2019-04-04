using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioFilter
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> Mock = new List<string>() { "Tom", "234", "Argilla", "56", "Jet", "2897", "Arg", "342", "Ali" };

            foreach (var item in Mock)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("____________________");


            foreach (var item in Ribalta(Mock))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in Lunghezza(Mock))
            {


                Console.WriteLine($"La parola è lunga {item} caratteri");

            }

            Console.WriteLine("___________________________________");

            foreach (var item in Mock)
            {

                Console.WriteLine(FilterLenght3(item));
            }



            Console.WriteLine("_______________________________________");

            foreach (var item in Mock)
            {

                Console.WriteLine(FilterA(item));
            }

            Console.WriteLine("___________________________");

            foreach (var item in Mock)
            {
                Console.WriteLine(FilterInt(item));
            }

            Console.ReadLine();

        }

        public static List<string> Ribalta(List<string> ListaInserita)
        {
            List<string> MockRibaltate = new List<string>();

            foreach (string item in ListaInserita)
            {
                //string result = new string(item.Reverse().ToArray());
                //MockRibaltate.Add(result);

                string result = "";
                for (int i = item.Length - 1; i >= 0; i--)
                    result += item[i];
                MockRibaltate.Add(result);
            }

            return MockRibaltate;

        }
        public static List<int> Lunghezza(List<string> ListaInserita)
        {
            List<int> MockLunghezza = new List<int>();


            foreach (string item in ListaInserita)
            {

                MockLunghezza.Add(item.Length);
            }

            return MockLunghezza;
        }



        //lista di stringhe ribaltate

        //lista di stringa che ritorna la lunghezza in int di ogni parola

        public static string FilterLenght3(string x)
        {
            string Riporto = null;
            if (x.Length == 3)
            {
                Riporto = x;
            }
            return Riporto;

        }
        public static string FilterA(string a)
        {
            string Riporto = null;
            if (a.IndexOf("A", 0) != -1|| a.IndexOf("a",0) != -1)
            {
                Riporto = a;
            }
            return Riporto;

        }


        public static int? FilterInt(string a)
        {
            int? NumberFalse = null;
            int Number;
            bool NumberOK = int.TryParse(a, out Number);

            if (NumberOK == true)
            {
                return Number;
            }
            else
                return NumberFalse;



        }

        //Filter:
        // string con lenght <3
        // string che inizia per a
        //string convertibile in int
    }
}
