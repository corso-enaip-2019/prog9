using System;
using System.Collections.Generic;


namespace Exercice3rdPart02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personX = Createpeople();

            IEnumerable<Person> Over1975 = Filter(personX, s => s.AnnoDiNascita > 1975);

            foreach (var item in Over1975)
            {
                Console.WriteLine($"{item.Nome} {item.Cognome}");
                Console.WriteLine();
            }

            Console.WriteLine("__________________________________________________________");

            IEnumerable<string> yearAfter1975 = Project(personX, new Over1975StringProject());
            foreach (var item in yearAfter1975)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }

        static List<Person> Createpeople()
        {
            return new List<Person>
            {
                new Person("Francesco","Renga","via mulino a vento 10",1980,"M"),
                new Person("Marco","Masini","via roma 40",1967,"M"),
                new Person("Marco","Carta","via palladio 3",1980,"M"),
                new Person("Gianna","Nannini","via udine 20",1967,"F"),
                new Person("Arianna","Grande","salita di gretta 40",1993,"F")
            };
        }

        //interface IFilter<T>
        //{
        //    bool Filter(T item);
        //}

        static IEnumerable<T> Filter<T>(IEnumerable<T> input, Filter<T> condition)
        {
            List<T> output = new List<T>();

            foreach (T item in input)
                if (condition(item))
                    output.Add(item);

            return output;
        }

        static IEnumerable<TOutput> Project<TInput, TOutput>(IEnumerable<TInput> input, IProject<TInput, TOutput> projection)
        {
            List<TOutput> output = new List<TOutput>();

            foreach (TInput item in input)
            {
                TOutput projected = projection.Project(item);
                output.Add(projected);
            }
            return output;
        }
    }

    interface IProject<TInput, TOutput>
    {
        TOutput Project(TInput item);
    }

    class Over1975StringProject : IProject<Person,string>
    {
        public string Project(Person i)
        {
            if (i.AnnoDiNascita > 1975)
                return i.Nome +" "+ i.Cognome;
            else
                return null;
        }
    }

    class Person
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Indirizzo { get; set; }
        public int AnnoDiNascita { get; set; }
        public string Genere { get; set; }

        public Person(string nome, string cognome, string indirizzo, int annoDiNascita, string genere)
        {
            Nome = nome;
            Cognome = cognome;
            Indirizzo = indirizzo;
            AnnoDiNascita = annoDiNascita;
            Genere = genere;
        }
    }
    delegate bool Filter<T>(T item);
}

//Usando i metodi generici Filter() e Project() implementati in classe,
//vogliamo ottenere una lista dei nomi delle persone nate dopo il 1975, 
//partendo da una lista di oggetti di tipo Person, dove la classe Person ha Nome, Cognome, Indirizzo, anno di nascita , genere.

//I nomi risultanti sono la concatenazione di Nome + Cognome.

//Creare un elenco di simulatori, utilizzare i due membri per filtrare e proiettare l'elenco e stampare il risultato sulla console.