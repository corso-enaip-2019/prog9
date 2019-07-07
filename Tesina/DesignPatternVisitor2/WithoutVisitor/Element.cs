using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutVisitor
{
    public abstract class Element
    {
        public abstract string Code { get; set; }
        public abstract string Description { get; set; }
    }

    public class ItemSoldInWeight : Element
    {
        public override string Code { get; set; }
        public override string Description { get; set; }

        public double UnitPrice { get; set; }
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
        public override string Code { get; set; }
        public override string Description { get; set; }

        public double UnitPrice;
        public int NumberOfPieces;

        public ItemSoldInPieces(string code, string description, double unitPrice, int numberOfPieces)
        {
            Code = code;
            Description = description;
            UnitPrice = unitPrice;
            NumberOfPieces = numberOfPieces;
        }
    }
}
