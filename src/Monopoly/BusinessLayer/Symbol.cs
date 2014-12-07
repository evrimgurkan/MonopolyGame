using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class Symbol
    {
        public enum SymbolType
        {
            HORSE,
            TOWER,
            CAR,
            BOOK,
            TREE
        }
        private SymbolType symboltype;
        public SymbolType symbol
        {
            get { return symboltype; }
            set { symboltype = value; }
        }

        //TODO: symbol image should be added.

        public Symbol(SymbolType type)
        {
            symboltype = type;
        }
    }
}
