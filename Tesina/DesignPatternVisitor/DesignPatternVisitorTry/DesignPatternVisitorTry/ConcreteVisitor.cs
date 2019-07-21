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
                var pw = (ItemSoldInWeight)visitable;
                product = pw.UnitPrice * pw.Weight;
            }
            else if (visitable is ItemSoldInPieces)
            {
                var pp = (ItemSoldInPieces)visitable;
                product = pp.UnitPrice * pp.NumberOfPieces;
            }
            else
            {
                throw new ArgumentException("Unknown visitable type!");
            }
        }
    }
}
