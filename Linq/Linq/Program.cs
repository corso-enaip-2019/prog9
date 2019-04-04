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
            List<Smartphone> list = SmartphoneList();

            IEnumerable<Smartphone> color = Filter<Smartphone>(list,new ColorFilter());

            foreach (Smartphone item in color)
            {
                Console.WriteLine($"{item._model}{item._version}{item._cost}{item._color}");
            }


            Console.ReadLine();

        }

        class Smartphone
        {
            public string _model;
            public string _version;
            public decimal _cost;
            public string _color;

            public Smartphone(string Model,string Version, decimal Cost,string Color)
            {
                Model = _model;
                Version = _version;
                Cost = _cost;
                Color = _color;
            }
        }
        private static List<Smartphone> SmartphoneList()
        {
            return new List<Smartphone>
            {
                 new Smartphone("Samsung","s7",250,"Blue"),
                 new Smartphone("IPhone","x",1000,"Black"),
                 new Smartphone("Huawei","p20",200,"Green")



            };
        }

        interface IFilter<T>
        {

            bool Filter(T item);

        }

        interface IProject<TInput, TOutput>
        {
            TOutput Project(TInput item);
        }

        class ColorFilter: IFilter<Smartphone>
        {
            public bool Filter(Smartphone s)
            {
                

                return s._color == "Black";



            }

        }

        private static IEnumerable<T> Filter<T>(IEnumerable<T> input, IFilter<T> condition)
        {
            List <T> output = new List<T>();

            foreach (T item in input)
            {
                if (condition.Filter(item))
                {
                    output.Add(item);
                }
            }


            return output;
        }




        //        Creare una classe per smartphone, con proprietà: modello, versione, costo, colore.

        //Crea una lista con gli smartphone finti.

        //Creare un metodo che filtra l'elenco in base al colore (ad esempio, desidero solo quelli grigio scuro). Il metodo restituisce un nuovo elenco di smartphone.

        //Crea un metodo che filtra la lista restituendo solo quelli che costano meno di una certa quantità(passati come parametro).
    }
}
