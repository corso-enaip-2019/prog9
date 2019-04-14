﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2ndPart05
{
    class Car
    {
        public string Model { get; set; }
        public string Mark { get; set; }
        public decimal Chilometrage { get; set; }

        public Car(string model,string mark,decimal chilometrage)
        {
            Model = model;
            Mark = mark;
            Chilometrage = chilometrage;
        }
    }
}

//Istanziare un elenco di persone.

//Ogni istanza ha queste semplici proprietà: Nome, Cognome, Altezza.

//Ogni istanza ha anche una proprietà HomeAddress di tipo Address.L'indirizzo della classe ha Street, Number, ZipCode, City.

//Ogni istanza di persona ha anche un elenco di automobili. La classe Car ha modello, marca, chilometraggio.

//Dare ad ogni campo il tipo corretto (es: il nome è una stringa).

//Dato l'elenco di persone con dati falsi, iterate attraverso di loro stampando sulla Console tutti i loro dati, rientrando correttamente per migliorare la leggibilità.
