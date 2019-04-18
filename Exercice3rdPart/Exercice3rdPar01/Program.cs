using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3rdPar01
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertToStringDelegate lambdaConverti = N => N.ToString();
            ConvertToStringDelegate lambdaSeparatore = N => string.Format("{0:###,###,##}", N.ToString("N", new NumberFormatInfo()));
            ConvertToStringDelegate lambdaPariODispari = N => N % 2 == 0 ? "Pari" : "Dispari";

            List<int> numeriList = new List<int> { 1, 500000, 3754, 842493, 3, 8 };
            List<string> numeriSerie1 = NumeriList(numeriList, Converti);
            List<string> numeriSerie2 = NumeriList(numeriList, Separatore);
            List<string> numeriSerie3 = NumeriList(numeriList, Pari_o_Dispari);
            var ics = new IntToStringUtility();
            List<string> numeriSerie4 = NumeriList(numeriList, ics.UtilityConverti);
            List<string> numeriSerie5 = NumeriList(numeriList, ics.UtilitySeparatore);
            List<string> numeriSerie6 = NumeriList(numeriList, ics.UtilityPari_o_Dispari);

            List<string> numeriSerie7 = NumeriList(numeriList, lambdaConverti);
            List<string> numeriSerie8 = NumeriList(numeriList, lambdaSeparatore);
            List<string> numeriSerie9 = NumeriList(numeriList, lambdaPariODispari);

            List<List<string>> ListNumeriList = new List<List<string>>();
            ListNumeriList.Add(numeriSerie1);
            ListNumeriList.Add(numeriSerie2);
            ListNumeriList.Add(numeriSerie3);
            ListNumeriList.Add(numeriSerie4);
            ListNumeriList.Add(numeriSerie5);
            ListNumeriList.Add(numeriSerie6);
            ListNumeriList.Add(numeriSerie7);
            ListNumeriList.Add(numeriSerie8);
            ListNumeriList.Add(numeriSerie9);

            foreach (var item in ListNumeriList)
            {
                foreach (var i in item)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("____________________________");
            }
            Console.Read();
        }

        static List<string> NumeriList(List<int> list, ConvertToStringDelegate d)
        {
            var numeri = new List<string>();
            foreach (var item in list)
            {
                numeri.Add(d(item));
            }
            return numeri;
        }

        class IntToStringUtility
        {
            public string UtilityConverti(int n)
            {
                return n.ToString();
            }

            public string UtilitySeparatore(int n)
            {
            //    var ci = CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
                string s = n.ToString("N", new NumberFormatInfo());
                s = string.Format("{0:###,###,##}", s);

                return s;
            }

            public string UtilityPari_o_Dispari(int n)
            {
                string s;
                if (n % 2 == 0)
                    s = "pari";
                else
                    s = "dispari";

                return s;
            }

        }
        static string Converti(int n)
        {
            return n.ToString();
        }

        static string Separatore(int n)
        {
            //var ci = CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            string s = n.ToString("N", new NumberFormatInfo());
            s = string.Format("{0:###,###,###}", s);

            return s;
        }

        static string Pari_o_Dispari(int n)
        {
            string s;
            if (n % 2 == 0)
                s = "pari";
            else
                s = "dispari";

            return s;
        }
    }
    delegate string ConvertToStringDelegate(int n);
}


//Dichiara un delegato ConvertToStringDelegate che accetta un int e restituisce una stringa.

//Tre funzionalità hanno la forma di questo delegato:

//    uno prende un int e usa solo ToString() sull'int;
//    uno prende un int e lo converte in una stringa usando il coma ',' come separatore di migliaia
//    uno prende un int e restituisce una stringa che dice se l'int è pari o dispari.

//Implementa queste 3 funzionalità:

//    attraverso metodi statici nella classe Program
//    come metodi di istanza(cioè metodi non statici), su una classe IntToStringUtility
//    come funzioni lambda anonime

//Nella classe Program creare un metodo che:

//    accetta un elenco di numeri interi e una "istanza" del delegato ConvertToStringDelegate
//    restituisce una lista con i valori della stringa proiettata

//Nel principale:

//    crea una lista di int
//    passare i 9 metodi(le 3 funzionalità hanno tutte e 3 le implementazioni), creando 9 nuovi elenchi
//    stampare tutti gli elenchi sulla console.