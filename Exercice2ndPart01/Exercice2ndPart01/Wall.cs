using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2ndPart01
{
    public class Wall
    {
        decimal Lenght;
        decimal Height;

        public Wall(decimal lenght,decimal height)
        {
            Lenght = lenght;
            Height = height;

        }

        public decimal CalculateseSurface(Wall w)
        {
            decimal surface = Lenght * Height;
            return surface;
        }

    }

    //È presente una classe Wall con proprietà length e Height e un metodo per calcolarne la superficie.

    //C'è una classe room, che ha un nome, un elenco di 4 muri, e un metodo per calcolare la superficie totale (sommando tutte le superfici delle pareti).

    //Creare un'applicazione console che crei una stanza fittizia e che stampi la superficie totale sulla console.
}
