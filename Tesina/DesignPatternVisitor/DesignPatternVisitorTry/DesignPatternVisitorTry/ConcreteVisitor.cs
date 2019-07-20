using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternVisitorTry
{
    public class ShoppingVisitor : IVisitor
    {
        private double product;

        public ShoppingVisitor()
        {
            product = 0;
        }

        public double GetProduct()
        {
            return product;
        }

        public void visit(IVisitable visitable)
        {
            if (visitable == null)
            {
                throw new ArgumentException("Null visitable!");
            }
            if (visitable is ItemSoldInWeight)
            {
                var tn = (ItemSoldInWeight)visitable;
                product = tn.UnitPrice * tn.Weight;
            }
            else if (visitable is ItemSoldInPieces)
            {
                var tm = (ItemSoldInPieces)visitable;
                product = tm.UnitPrice * tm.NumberOfPieces;
            }
            else
            {
                throw new ArgumentException("Unknown visitable type!");
            }
        }
    }
}
