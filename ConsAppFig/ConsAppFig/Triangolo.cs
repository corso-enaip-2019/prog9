using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppFig
{
    class Triangolo:Figura
    {
        public Triangolo(double Base, double Lato1, double Lato2,double Altezza)
        {
            Base = _base;
            Lato1 = _lato1;
            Lato2 = _lato2;
            Altezza = _altezza;
        }

        private double _base { get; }
        private double _lato1 { get; }
        private double _lato2 { get; }
        private double _altezza { get; }

        public override string nomeFigura()
        {
            return "Triangolo";
        }

        public override double Perimetro()
        {
            return (_base + _lato1 + _lato2);
        }

        public override double Area()
        {
            return ((_base * _altezza) / 2);
        }
    }
}
