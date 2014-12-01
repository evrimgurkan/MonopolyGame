using System;
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

        public PropertyCellGroup(int _houseCost, int _hotelCost,CellColor _color)
        {
            houseCost = _houseCost;
            hotelCost = _hotelCost;
            groupColor = _color;
        }

        public void addCell(PropertyCell _propCell)
        {
            cells.Add(_propCell);
        }


    }
}
