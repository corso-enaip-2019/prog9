using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternVisitor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Si vuole creare un supermarket dove si vendono due tipi di oggetti: quelli venduti a peso e quelli venduti a pezzi.

            List<Element> elements = new List<Element>();

            var p1 = new ItemSoldInPieces("C01", "cereali", 2.20D, 2);
            var p2 = new ItemSoldInPieces("C02", "Quaderno", 1.10D, 1);
            var w1 = new ItemSoldInWeight("C03", "Mele", 2.50D, 2.0D);

            elements.Add(p1);
            elements.Add(p2);
            elements.Add(w1);

            var ProductVisitor = new ShoppingVisitor();
            double TotalCost = 0;

            foreach (var item in elements)
            {
                item.Accept(ProductVisitor);
                TotalCost += ProductVisitor.GetProduct();
            }

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Codice: {0} | Descrizione: {1}| Prezzo unitario: {2:C}| Pezzi: {3}", p1.Code, p1.Description, p1.UnitPrice, p1.NumberOfPieces);
            Console.WriteLine("Codice: {0} | Descrizione: {1}| Prezzo unitario: {2:C}| Pezzi:{3}", p2.Code, p2.Description, p2.UnitPrice, p2.NumberOfPieces);
            Console.WriteLine("Codice: {0} | Descrizione: {1}| Prezzo unitario al kg: {2:C}| Kili: {3}", w1.Code, w1.Description, w1.UnitPrice, w1.Weight);

            Console.WriteLine();
            Console.WriteLine("Total cost = {0:C} ", TotalCost);
            Console.Read();
        }
    }
}