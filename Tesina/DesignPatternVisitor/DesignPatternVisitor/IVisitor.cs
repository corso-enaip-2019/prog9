﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternVisitor2
{
    public interface IVisitor
    {
        void visit(ItemSoldInWeight visitable);
        void visit(ItemSoldInPieces visitable);
    }
}
