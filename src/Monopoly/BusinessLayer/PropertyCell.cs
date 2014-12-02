using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    class PropertyCell : Cell
    {
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

        private int rentAmount;
        public int rentPrice
        {
            get { return rentAmount; }
            set { rentAmount = value; }
        }

        public PropertyCell(CellGroup _cellGrp, int _mortgageVal, string _name, int _cellprice,int _hotelCost, int _houseCost, int _rentPrice)
        {
            hotelCost = _hotelCost;
            houseCost = _houseCost;
            rentAmount = _rentPrice;
            this.cellGroup = _cellGrp;
            this.mortgageValue = _mortgageVal;
            this.isMortgaged = false;
            this.name = _name;
            this.owner = null;
            this.hasOwner = false;
            this.purchasePrice = _cellprice;
        }
    }
}
