using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2ndPart05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = PersonList();
            foreach (var item in people)
            {
                Tema();
                Console.WriteLine("Scheda Individuo:");
                Console.ResetColor();
                Console.WriteLine($"Nome:{item.Name} | Cognome:{item.Surname} | Altezza:{item.Height} cm");

                Tema();
                Console.WriteLine("Ubicato in:");
                Console.ResetColor();
                WriteAddress(item.HomeAddress);

                Tema();
                Console.WriteLine("Possiede :");
                Console.ResetColor();
                WriteCar(item.CarsList);

                Console.WriteLine("_________________________________________________________");
                Console.WriteLine();
            }
            Console.Read();
        }
      
        static void Tema()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        static List<Person> PersonList()
        {
            List<Car> gigiCars = new List<Car>();
            gigiCars.Add(new Car("Polo", "Wolkswagen", 15000m));

            List<Car> josephCars = new List<Car>();
            josephCars.Add(new Car("Serie3", "Bmw",10000m));
            josephCars.Add(new Car("Serie 1", "Fiat",350000m));

            Person Joseph = new Person("Joseph", "Joestar", "1.90", new Address("strada di fiume", 148, 34180, "Trieste"), josephCars);
            Person Gigi = new Person("Gigi", "La trottola", "1.50", new Address("via ginnastica", 20, 34128, "Trieste"), gigiCars);

            List<Person> personList = new List<Person>();
            personList.Add(Joseph);
            personList.Add(Gigi);

            return personList;
        }


        static void WriteAddress(Address address)
        {
            Console.WriteLine($"{address.Street} {address.Number} {address.ZipCode} {address.City}");
        }

        static void WriteCar(List<Car> c)
        {
            foreach (var item in c)
            {
                Console.WriteLine($"{item.Mark} {item.Model} {item.Chilometrage}");
            }
        }
    }
}

//Istanziare un elenco di persone.

//Ogni istanza ha queste semplici proprietà: Nome, Cognome, Altezza.

//Ogni istanza ha anche una proprietà HomeAddress di tipo Address.L'indirizzo della classe ha Street, Number, ZipCode, City.

//Ogni istanza di persona ha anche un elenco di automobili. La classe Car ha modello, marca, chilometraggio.

//Dare ad ogni campo il tipo corretto (es: il nome è una stringa).

//Dato l'elenco di persone con dati falsi, iterate attraverso di loro stampando sulla Console tutti i loro dati, rientrando correttamente per migliorare la leggibilità.
