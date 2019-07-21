using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternVisitorTry
{
    public abstract class Element : IVisitable
    {
        internal abstract string Code { get; set; }
        internal abstract string Description { get; set; }
        internal abstract double UnitPrice { get; set; }
    }

    public class ItemSoldInWeight : Element
    {
        internal override string Code { get; set; }
        internal override string Description { get; set; }
        internal override double UnitPrice { get; set; }

        public double Weight { get; set; }

        public ItemSoldInWeight(string code, string description, double unitPrice, double weight)
        {
            Code = code;
            Description = description;
            UnitPrice = unitPrice;
            Weight = weight;
        }
    }   

    public class ItemSoldInPieces : Element
    {
        internal override string Code { get; set; }
        internal override string Description { get; set; }
        internal override double UnitPrice { get; set; }

        public int NumberOfPieces { get; set; }

        public ItemSoldInPieces(string code, string description, double unitPrice, int numberOfPieces)
        {
            Code = code;
            Description = description;
            UnitPrice = unitPrice;
            NumberOfPieces = numberOfPieces;
        }
    }
}
