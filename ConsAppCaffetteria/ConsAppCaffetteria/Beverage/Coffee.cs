using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppCaffetteria.Beverage
{
    public class Coffee : ICoffee
    {

        readonly double _cost;
        readonly string _name;

        public Coffee(double cost,string name)
        {
            _cost = cost;
            _name = name;
        }


        public string Description { get {return $"{ _cost }{_name}" ; } } 

        public double Cost { get { return _cost; } }
    }
}
