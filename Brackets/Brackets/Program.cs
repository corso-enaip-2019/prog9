using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brackets
{
    class Program
    {
        static void Main(string[] args)
        {

            bool ok = CheckBrackets(@"    namespace Brackets
                {
                    class Program
                    {
                        static void Main(string[] args)
                        {
                            bool ok = CheckBrackets("")
                            Console.ReadLine();
                        }
                        static bool CheckBrackets(string text)
                        {
                        }
                    }
                ");

            string strOk = ok ? "OK" : "KO";
            Console.WriteLine($"Text is { ok }");

            Console.ReadLine();




        }


        static List<char> openingBrackets = new List<char>();
        static List<char> closingBrackets = new List<char>();


        /// <summary>
        /// Verifica se il testo passato contiene un numero coerente di parentesi di apertura e chiusura "(",   "["  ,  "{"
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        static bool CheckBrackets(string text)
        {
            openingBrackets.Add('(');
            openingBrackets.Add('[');
            openingBrackets.Add('{');

            closingBrackets.Add(')');
            closingBrackets.Add(']');
            closingBrackets.Add('}');

            Stack<char> Brackets = new Stack<char>();

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];



                if (openingBrackets.Contains(currentChar))
                {
                    Brackets.Push(currentChar);
                }

            }

            return true;
            //    if (currentChar == '(')
            //    {
            //        stackChar.Push(+1);
            //    }
            //    else if (currentChar == ')')
            //    {
            //        stackChar.Pop();
            //    }
                
            //}

            //if (stackChar.Count < 0 || stackChar.Count > 0)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
        }
    }
}



//Stack<char> TstackCharOp = new Stack<char>();
//Stack<char> TstackCharCl = new Stack<char>();

//Stack<char> QstackCharOp = new Stack<char>();
//Stack<char> QstackCharCl = new Stack<char>();

//Stack<char> GstackCharOp = new Stack<char>();
//Stack<char> GstackCharCl = new Stack<char>();

//if (currentChar == '(')
//{
//    TstackCharOp.Push(currentChar);
//}

//if (currentChar == ')')
//{
//    TstackCharCl.Push(currentChar);
//}


//if (currentChar == '[')
//{
//    QstackCharOp.Push(currentChar);
//}

//if (currentChar == ']')
//{
//    QstackCharCl.Push(currentChar);
//}

//if (currentChar == '{')
//{
//    GstackCharOp.Push(currentChar);
//}

//if (currentChar == '}')
//{
//    GstackCharCl.Push(currentChar);
//}

//if (TstackCharOp.Count != TstackCharCl.Count && QstackCharOp.Count != QstackCharCl.Count && GstackCharOp.Count != GstackCharCl.Count)
//{
//    return true;
//}
//else
//{
//    return false;
//}