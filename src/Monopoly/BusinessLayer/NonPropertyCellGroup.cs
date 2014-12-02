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
            this.cells = new List<Cell>();
        }
        public void addCell(Cell _cell)
        {
            this.cells.Add(_cell);
        }
    }
}
