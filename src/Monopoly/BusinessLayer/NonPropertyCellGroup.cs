using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    class NonPropertyCellGroup : CellGroup
    {
        public NonPropertyCellGroup(string _name) // name ?
        {

        }
        public void addCell(Cell _cell)
        {
            cells.Add(_cell);
        }
    }
}
