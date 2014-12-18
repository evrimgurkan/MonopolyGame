using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
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
            Pink,
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

        private int hotelCost;
        public int costPerHotel
        {
            get { return hotelCost; }
            set { hotelCost = value; }
        }

        private int houseCost;
        public int costPerHouse
        {
            get { return houseCost; }
            set { houseCost = value; }
        }

        public PropertyCellGroup(CellColor _color, int _hotelCost, int _houseCost)
        {
            this.cells = new List<Cell>();
            groupColor = _color;
            houseCost = _houseCost;
            hotelCost = _hotelCost;
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
