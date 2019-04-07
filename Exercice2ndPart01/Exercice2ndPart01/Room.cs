using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2ndPart01
{
    public class Room
    {

        public string Name = "ProgrammersRoom";
        

        public List<Wall> TakeWallList()
        {
            return new List<Wall>
            {
                new Wall(5,7),
                new Wall(15,6),
                new Wall(10,17),
                new Wall(9,8),
            };
        }


        public decimal CalculateTotalsurface()
        {
            decimal totalSource = 0;
            foreach (Wall item in TakeWallList())
            {
                
                totalSource += item.CalculateseSurface(item);

            }
            return totalSource;

        }

    }

    //È presente una classe Wall con proprietà length e Height e un metodo per calcolarne la superficie.

    //C'è una classe room, che ha un nome, un elenco di 4 muri, e un metodo per calcolare la superficie totale (sommando tutte le superfici delle pareti).

    //Creare un'applicazione console che crei una stanza fittizia e che stampi la superficie totale sulla console.
}
