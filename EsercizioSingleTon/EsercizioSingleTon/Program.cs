using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioSingleTon
{
    class Program
    {
        static void Main(string[] args)
        {

            Person Mario = new Person("Mario", 35, 1500);

            JsonSaver.Instance.SaveOnFile(Mario);
            XmlSaver.Instance.SaveOnFile(Mario);
           

            Console.Read();

        }
    }
    


    class Person
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        public Person(string fullname,int age,decimal salary)
        {
            FullName = fullname;
            Age = age;
            Salary = salary;


        }

    }

    abstract class BaseSaver
    {
        public void SaveOnFile(Person p)
        {
            string formatted = FormatAsString(p);

            SaveOnFile(formatted);
        }

        protected abstract string FormatAsString(Person p);

        private void SaveOnFile(string formatted)
        {
            var fileName = GetFileName();

            var path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                fileName);

            File.WriteAllText(path, formatted);
        }

        protected abstract string GetFileName();
    }

    class JsonSaver : BaseSaver
    {

        static JsonSaver()
        {
            Instance = new JsonSaver();
        }

        public static JsonSaver Instance {get;}

        private JsonSaver() { }

        protected override string FormatAsString(Person p)
        {
            return
                "{" +
                    $"\"{nameof(Person.FullName)}\":\"{p.FullName}\"," +
                    $"\"{nameof(Person.Age)}\":{p.Age}," +
                    $"\"{nameof(Person.Salary)}\":{p.Salary}" +
                "}";
        }

        protected override string GetFileName()
        {
            return "person-as-json.txt";
        }
    }

    class XmlSaver : BaseSaver
    {
        static XmlSaver()
        {

            Instance = new XmlSaver();
        }

        public static XmlSaver Instance { get; }

        private XmlSaver() { }

        protected override string FormatAsString(Person p)
        {
            return
                $"<{nameof(Person)}>" +
                    $"<{nameof(Person.FullName)}>{p.FullName}</{nameof(Person.FullName)}>" +
                    $"<{nameof(Person.Age)}>{p.Age}</{nameof(Person.Age)}>" +
                    $"<{nameof(Person.Salary)}>{p.Salary}</{nameof(Person.Salary)}>" +
                $"</{nameof(Person)}>";
        }

        protected override string GetFileName()
        {
            return "person-as-xml.txt";
        }
    }


    
}
