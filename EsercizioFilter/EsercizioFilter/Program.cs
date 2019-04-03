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

            List<string> Mock = new List<string>() { "Tom","234","Argilla","56","Jet","2897","Arg","342","Ali" };
            
            foreach (var item in Mock)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            
            foreach (var item in Ribalta(Mock))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }

        public static List<string> Ribalta(List<string> ListaInserita)
        {

            List<string> MockRibaltate = new List<string>();

            foreach (string item in ListaInserita)
            {
                string result = new string(item.Reverse().ToArray());
                MockRibaltate.Add(result);
            }

            return MockRibaltate;

            //string Salva = "";

            //for (int i = 0; i < ListaInserita.Count ; i++)
            //{
            //    string Parola = ListaInserita[i];

                
            //    for (int j = Parola.Length; j <= 0 ; j--)
            //    {
                    
                    
                    
            //    }


            //    MockRibaltate.Add(Salva);
            //}

            //return MockRibaltate;

        }


        //lista di stringhe ribaltate

        //lista di stringa che ritorna la lunghezza in int di ogni parola



        //Filter:
        // string con lenght <3
        // string che inizia per a
        //string convertibile in int
    }
}
