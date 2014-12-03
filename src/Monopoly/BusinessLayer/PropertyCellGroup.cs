﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    class PropertyCellGroup : CellGroup
    {
        public enum CellColor
        {
            Red,
            Blue,
            Yellow,
            Green,
            Orange,
            Brown,
            Cyan,
            Purple
        }

        private CellColor groupColor;
        public CellColor color
        {
            get
            {
                return groupColor;
            }
            set
            {
                groupColor = value;
            }
        }


        public PropertyCellGroup(CellColor _color)
        {
            this.cells = new List<Cell>();
            groupColor = _color;
        }

        public void addCell(PropertyCell _propCell)
        {
            this.cells.Add(_propCell);
        }

        public List<Cell> getOwnedCells()
        {
            return this.cells; //TODO
        }

        public List<Cell> getUnOwnedCells()
        {
            return this.cells;//TODO
        }
    }
}