using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2ndPart07
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> numberSeries = ListInt();
            PrintList(numberSeries);

            Console.WriteLine();

            ReversePrintList(numberSeries);
            Console.WriteLine();

            PrintInvertedList(numberSeries);
            Console.WriteLine();

            PrintReverseListAndInvertedList(numberSeries);
            Console.Read();
        }

        static List<List<int>> ListInt()
        {
            List<List<int>> intList = new List<List<int>>();

            for (int i = 1; i <= 4; i++)
            {
                List<int> rigaList = new List<int>();
                for (int j = 0; j < i; j++)
                {
                    rigaList.Add(j + 1);
                }
                intList.Add(rigaList);
            }
            return intList;
        }

        static void PrintList(List<List<int>> list)
        {
            foreach (var item in list)
            {
                foreach (var ite in item)
                {
                    Console.Write(ite);
                }
                Console.WriteLine();
            }
        }

        static void ReversePrintList(List<List<int>> list)
        {
            foreach (var item in list)
            {
                item.Reverse();
                foreach (var ite in item)
                {
                    Console.Write(ite);
                }
                Console.WriteLine();
                item.Reverse();
            }
        }

        static void PrintInvertedList(List<List<int>> list)
        {
            list.Reverse();
            foreach (var item in list)
            {
                item.Reverse();
                
                foreach (var ite in item)
                {
                    Console.Write(ite);
                }
                Console.WriteLine();
                item.Reverse();
            }
            list.Reverse();
        }

        static void PrintReverseListAndInvertedList(List<List<int>> list)
        {

            foreach (var item in list)
            {
                item.Reverse();
                foreach (var ite in item)
                {
                    Console.Write(ite);
                }
                Console.WriteLine();
                item.Reverse();
            }

            Console.WriteLine();

            list.Reverse();
            foreach (var item in list)
            {
                item.Reverse();

                foreach (var ite in item)
                {
                    Console.Write(ite);
                }
                Console.WriteLine();
                item.Reverse();
            }
            list.Reverse();
        }
    }
}

//Crea una lista<Elenco<int>> e compila con questi numeri:

//1
//1 2
//1 2 3
//1 2 3 4

//Ogni riga è una lista diversa; l'intero elenco di liste contiene tutte le righe.
//Creare un metodo per generare un elenco di questo tipo, passando come parametro il numero di righe desiderate.
//Creare un metodo che inverta l'ordine di ogni riga.Per esempio:

//1
//1 2
//1 2 3

//diventa:

//1
//2 1
//3 2 1

//Crea una lista che inverte l'ordine delle righe. Per esempio:

//1
//1 2
//1 2 3

//diventa:

//1 2 3
//1 2
//1

//Scrivi anche un metodo che stampa un intero elenco di liste.Usalo per stampare:

//    l'elenco originale
//    quelli invertiti
//    una lista ottenuta applicando entrambi i metodi alla stessa lista.