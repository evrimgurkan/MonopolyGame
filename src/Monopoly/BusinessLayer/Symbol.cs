using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class Symbol
    {
        private string symbolName;
        public string name
        {
            get { return symbolName; }
            set { symbolName = value; }
        }

        //TODO: symbol image should be added.

        public Symbol(string _name)
        {
            symbolName = _name;
        }
    }
}
