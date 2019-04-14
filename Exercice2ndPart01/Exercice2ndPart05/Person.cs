using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2ndPart05
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Height { get; set; }
        public Address HomeAddress { get; set; }

        public List<Car> CarsList = new List<Car>();

        public Person(string name, string surname, string height, Address address, List<Car> cars )
        {
            Name = name;
            Surname = surname;
            Height = height;
            HomeAddress = address;
            CarsList = cars;
        }
    }
}

//Istanziare un elenco di persone.

//Ogni istanza ha queste semplici proprietà: Nome, Cognome, Altezza.

//Ogni istanza ha anche una proprietà HomeAddress di tipo Address.L'indirizzo della classe ha Street, Number, ZipCode, City.

//Ogni istanza di persona ha anche un elenco di automobili. La classe Car ha modello, marca, chilometraggio.

//Dare ad ogni campo il tipo corretto (es: il nome è una stringa).

//Dato l'elenco di persone con dati falsi, iterate attraverso di loro stampando sulla Console tutti i loro dati, rientrando correttamente per migliorare la leggibilità.
