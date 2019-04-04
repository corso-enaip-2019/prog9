using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Smartphone> list = CreateSmartphoneList();

            IEnumerable<Smartphone> blackFilteredSmartphone = Filter<Smartphone>(list, new BlackColorFilter());

            foreach (Smartphone item in blackFilteredSmartphone)
            {
                Console.WriteLine($"{item.Model} {item.Version} {item.Cost} {item.Color}");
            }
            

            Console.ReadLine();

        }



        static List<Smartphone> CreateSmartphoneList()
        {
            return new List<Smartphone>
            {
                 new Smartphone("Samsung","s7",250,"Blue"),
                 new Smartphone("IPhone","x",1000,"Black"),
                 new Smartphone("Huawei","p20",200,"Green")



            };
        }

        static IEnumerable<T> Filter<T>(IEnumerable<T> input, IFilter<T> condition)
        {
            List<T> output = new List<T>();

            foreach (T item in input)
            {
                if (condition.Filter(item))
                {
                    output.Add(item);
                }
            }


            return output;
        }

        //Creare una classe per smartphone, con proprietà: modello, versione, costo, colore.

        //Crea una lista con gli smartphone finti.

        //Creare un metodo che filtra l'elenco in base al colore (ad esempio, desidero solo quelli grigio scuro). Il metodo restituisce un nuovo elenco di smartphone.

        //Crea un metodo che filtra la lista restituendo solo quelli che costano meno di una certa quantità(passati come parametro).
    }
    
    interface IFilter<T>
    {

        bool Filter(T item);

    }

    interface IProject<TInput, TOutput>
    {
        TOutput Project(TInput item);
    }

    class Smartphone
    {
        public string Model { get; }
        public string Version { get; }
        public decimal Cost { get; }
        public string Color { get; }

        public Smartphone(string model, string version, decimal cost, string color)
        {
            Model = model;
            Version = version;
            Cost = cost;
            Color = color;
        }
    }

    class BlackColorFilter : IFilter<Smartphone>
    {
        public bool Filter(Smartphone s)
        {
            
            return s.Color == "Black";
            
        }

    }

    
}
