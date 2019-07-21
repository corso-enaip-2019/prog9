using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternVisitorTry
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Element> elements = new List<Element>();

            var sp1 = new ItemSoldInPieces("C01", "cereali", 2.20D, 2);
            var sp2 = new ItemSoldInPieces("C02", "Quaderno", 1.10D, 1);
            var sw1 = new ItemSoldInWeight("C03", "Mele", 2.50D, 2.0D);
            
            elements.Add(sp1);
            elements.Add(sp2);
            elements.Add(sw1);

            var ProductVisitor = new ShoppingVisitor();
            double TotalCost = 0;

            foreach (var item in elements)
            {
                ProductVisitor.visit(item);
                TotalCost += ProductVisitor.GetProduct();
            }

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Codice: {0} | Descrizione: {1}| Prezzo unitario: {2:C}| Pezzi: {3}", sp1.Code, sp1.Description, sp1.UnitPrice, sp1.NumberOfPieces);
            Console.WriteLine("Codice: {0} | Descrizione: {1}| Prezzo unitario: {2:C}| Pezzi:{3}", sp2.Code, sp2.Description, sp2.UnitPrice, sp2.NumberOfPieces);
            Console.WriteLine("Codice: {0} | Descrizione: {1}| Prezzo unitario al kg: {2:C}| Kili: {3}", sw1.Code, sw1.Description, sw1.UnitPrice, sw1.Weight);

            Console.WriteLine();
            Console.WriteLine("TotalCost = {0:C} ", TotalCost);
            Console.Read();
        }
    }
}
