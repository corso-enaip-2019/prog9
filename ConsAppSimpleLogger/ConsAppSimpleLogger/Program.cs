using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppSimpleLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Ilogger logger = null;

            logger.LogInfo("info");

            logger.LogError("Error", new Exception("Error"));

            Console.ReadKey(true);

        }
    }

    class ConsoleLogger : Ilogger
    {
        public void LogError(string msg, Exception ex)
        {
            Console.WriteLine($"(msg) ({ex.Message})");
        }

        public void LogInfo(string msg)
        {
            Console.WriteLine(msg);
        }
    }


}
