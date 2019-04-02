using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziVari8Vari9
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write( p.Name); p.name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write( p.Surname); p.surname = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            while (true)
            {
                Console.Write( p.Age); bool NumberOK = int.TryParse(Console.ReadLine(), out p.age);
                if (NumberOK == true)
                {
                    break;
                }
                Console.WriteLine("It's not a number, try again");
            }
            Console.ResetColor();
            Console.Write( p.Work); p.work = Console.ReadLine();

            Console.WriteLine("End");
            Console.ReadLine();
        }

        class Person
        {
            public string Name = "Nome: ";
            public string name;
            public string Surname = "Cognome: ";
            public string surname;
            public string Age = "Età: ";
            public int age;
            public string Work = "Lavoro: ";
            public string work;


        }
    }
}
