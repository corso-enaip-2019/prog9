using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternVisitor
{
    //Implementiamo il ConcreteVisitor del pattern imnplementando l'interfaccia IVisitor
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

        public void visit(ItemSoldInPieces visitable)
        {
            if (visitable == null)
            {
                throw new ArgumentException("Null visitable!");
            }
            product = visitable.NumberOfPieces * visitable.UnitPrice;
        }

        public void visit(ItemSoldInWeight visitable)
        {
            if (visitable == null)
            {
                throw new ArgumentException("Null visitable!");
            }
            product = visitable.Weight * visitable.UnitPrice;
        }
    }
}