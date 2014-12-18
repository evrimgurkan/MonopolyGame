using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class RailroadCell : Cell
    {
        private int rentAmount;
        public int rentPrice
        {
            get { return rentAmount; }
            set { rentAmount = value; }
        }

        public RailroadCell(CellGroup _cellGrp, int _mortgageVal, string _name, int _cellprice, int _rentPrice)
        {
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
