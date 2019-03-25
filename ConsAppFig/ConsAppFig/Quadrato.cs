using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppFig
{
    class Quadrato:Figura
    {
        public Quadrato(double lato)
        {
            Lato = lato;
        }

        private double Lato { get; }


        public override string nomeFigura()
        {
            return "Quadrato";
        }

        public override double Perimetro()
        {
            return Lato * 4;

        }

        public override double Area()
        {
            return Math.Pow(Lato, 2);
        }
    }
}
