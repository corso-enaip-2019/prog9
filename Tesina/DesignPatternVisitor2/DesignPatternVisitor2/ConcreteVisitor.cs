using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternVisitor2
{
    //Implementiamo il ConcreteVisitor del pattern imnplementando l'interfaccia IVisitor
    public class ShoppingVisitor : IVisitor
    {
        public double Visit(ItemSoldInWeight item)
        {
            return item.Weight * item.UnitPrice;
        }

        public double Visit(ItemSoldInPieces item)
        {
            return item.NumberOfPieces * item.UnitPrice;
        }
    }
    
}
