using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternVisitor2
{
    //Definizione della classe astratta che rappresenterà ogni prodotto
    public abstract class Element
    {
        public abstract string Code { get; set; }
        public abstract string Description { get; set; }
    }

    //Definiamo la classe astratta per ogni ConcreteElement
    public class ItemSoldInWeight : Element, IVisitable
    {
        public override string Code { get; set; }
        public override string Description { get; set; }

        public double UnitPrice { get; set; }
        public double Weight { get; set; }

        public ItemSoldInWeight(string code,string description,double unitPrice,double weight)
        {
            Code = code;
            Description = description;
            UnitPrice = unitPrice;
            Weight = weight;
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }

    public class ItemSoldInPieces : Element , IVisitable
    {
        public override string Code { get; set; }
        public override string Description { get; set; }

        public double UnitPrice;
        public int NumberOfPieces;

        public ItemSoldInPieces(string code,string description,double unitPrice,int numberOfPieces)
        {
            Code = code;
            Description = description;
            UnitPrice = unitPrice;
            NumberOfPieces = numberOfPieces;
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
