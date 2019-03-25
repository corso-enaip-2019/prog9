using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppAnagrammi
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();
            Console.ReadLine();
        }

        public static void Menu()
        {
            Console.WriteLine(@"Seleziona una modalità: 
                                  1. Allenamento
                                  2. Sfida");

            int.TryParse(Console.ReadLine(), out int selection);

            switch (selection)
            {
                case 1:
                   // GamePlay1 game1 = new GamePlay1();
                   // Console.WriteLine(game1.Description);
                    
                    break;

                case 2:
                    GamePlay2 game2 = new GamePlay2();
                    Console.WriteLine(game2.Description);
                    break;

                default:
                    break;



                

            }



        }
        public static void Run()
        {

        }

    }
}
