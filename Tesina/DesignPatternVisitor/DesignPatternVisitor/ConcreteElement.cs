using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternVisitor
{
    //Definizione della classe astratta che rappresenterà ogni prodotto
    public abstract class Element : IVisitable
    {
        internal abstract string Code { get; set; }
        internal abstract string Description { get; set; }
        internal abstract double UnitPrice { get ;set; }

        public abstract void Accept(IVisitor visitor);
    }

    //Definiamo la classe astratta per ogni ConcreteElement
    public class ItemSoldInWeight : Element
    {
        internal override string Code { get; set; }
        internal override string Description { get; set; }
        internal override double UnitPrice { get; set; }

        internal double Weight { get; set; }

        public override void Accept (IVisitor visitor)
        {
            visitor.visit(this);
        }

        public ItemSoldInWeight(string code,string description,double unitPrice,double weight)
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

        internal int NumberOfPieces { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.visit(this);
        }

        public ItemSoldInPieces(string code,string description,double unitPrice,int numberOfPieces)
        {
            Code = code;
            Description = description;
            UnitPrice = unitPrice;
            NumberOfPieces = numberOfPieces;
        }
    }
}
