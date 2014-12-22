using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public abstract class CellGroup
    {
        public List<Cell> cells;

        public Cell GetNextCell(Cell _current)
        {
            for (int i = 0; i < cells.Count; i++)
            {
                if (cells[i].name != _current.name)
                {
                    return cells[i];
                }
            }
            return null;// TODO: should be handled
        }

        public int Count()
        {
            return cells.Count;
        }
    }
}
