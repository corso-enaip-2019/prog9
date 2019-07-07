using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternVisitor2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Si vuole creare un supermarket dove si vendono due tipi di oggetti: quelli venduti a peso e quelli venduti a pezzi.

            List<IVisitable> elements = new List<IVisitable>();

            var p1 = new ItemSoldInPieces("C01", "cereali", 2.20D, 2);
            var p2 = new ItemSoldInPieces("C02", "Quaderno", 1.10D, 1);
            var p3 = new ItemSoldInWeight("C03", "Mele", 2.50D, 2.0D);

            elements.Add(p1);
            elements.Add(p2);
            elements.Add(p3);

            double TotalCost = CalculateCost(elements);

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Codice: {0} | Descrizione: {1}| Prezzo unitario: {2:C}| Pezzi: {3}" ,p1.Code,p1.Description,p1.UnitPrice,p1.NumberOfPieces);
            Console.WriteLine("Codice: {0} | Descrizione: {1}| Prezzo unitario: {2:C}| Pezzi:{3}", p2.Code, p2.Description, p2.UnitPrice, p2.NumberOfPieces);
            Console.WriteLine("Codice: {0} | Descrizione: {1}| Prezzo unitario al kg: {2:C}| Kili: {3}", p3.Code, p3.Description, p3.UnitPrice, p3.Weight);

            Console.WriteLine("TotalCost = {0:C} " , TotalCost );
            Console.Read();
        }

        private static double CalculateCost(List<IVisitable> elements)
        {
            double total = 0.0D;
            IVisitor visitor = new ShoppingVisitor();

            foreach (var item in elements)
            {
                total = total + item.Accept(visitor);
            }
            return total;
        }
    }

}
