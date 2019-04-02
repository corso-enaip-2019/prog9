using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziVari5
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "Hello";
            string string2 = "World";
            string string3 = string1 + string2;
            string string4 = string2 + string1;

            Console.WriteLine(string3);
            Console.WriteLine(string4);

            Console.Read();
        }
    }
}
