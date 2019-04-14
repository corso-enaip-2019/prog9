using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2ndPart05
{
    class Address
    {
        public string Street { get; set; }
        public int Number { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        
        public Address(string street,int number,int zipcode,string city)
        {
            Street = street;
            Number = number;
            ZipCode = zipcode;
            City = city;
        }
    }
}

//Istanziare un elenco di persone.

//Ogni istanza ha queste semplici proprietà: Nome, Cognome, Altezza.

//Ogni istanza ha anche una proprietà HomeAddress di tipo Address.L'indirizzo della classe ha Street, Number, ZipCode, City.

//Ogni istanza di persona ha anche un elenco di automobili. La classe Car ha modello, marca, chilometraggio.

//Dare ad ogni campo il tipo corretto (es: il nome è una stringa).

//Dato l'elenco di persone con dati falsi, iterate attraverso di loro stampando sulla Console tutti i loro dati, rientrando correttamente per migliorare la leggibilità.
