using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    class Symbol
    {
        private string symbolName;
        public string name
        {
            get { return symbolName; }
            set { symbolName = value; }
        }

        //TODO: symbol image should be added.

        public Symbol()
        {
            symbolName = "";
        }
    }
}
