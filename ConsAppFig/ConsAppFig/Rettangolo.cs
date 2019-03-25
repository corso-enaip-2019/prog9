using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppFig
{
    class Rettangolo:Figura
    {
        public Rettangolo(double Base,double Altezza)
        {
            Base = _base;
            Altezza = _altezza;
        }

        private double _base { get; }
        private double _altezza { get; }

        public override string nomeFigura()
        {
            return "Rettangolo";
        }

        public override double Perimetro()
        {
            return (_base*2)+(_altezza*2); 
        }
        public override double Area()
        {
            return (_base * _altezza);
        }
    }
}
