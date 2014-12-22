using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class PropertyCell : Cell
    {
        private int hotelCost;
        public int hotelPrice
        {
            get { return hotelCost; }
            set { hotelCost = value; }
        }

        private int onehouseCost;
        public int onehousePrice
        {
            get { return onehouseCost; }
            set { onehouseCost = value; }
        }

        private int twohouseCost;
        public int twohousePrice
        {
            get { return twohouseCost; }
            set { twohouseCost = value; }
        }

        private int threehouseCost;
        public int threehousePrice
        {
            get { return threehouseCost; }
            set { threehouseCost = value; }
        }

        private int fourhouseCost;
        public int fourhousePrice
        {
            get { return fourhouseCost; }
            set { fourhouseCost = value; }
        }

        private int rentAmount;
        public int rentPrice
        {
            get { return rentAmount; }
            set { rentAmount = value; }
        }

        public PropertyCell(CellGroup _cellGrp, int _mortgageVal, string _name, int _cellprice,
            int _hotelPrice, int _onehouseCost, int _twohouseCost, int _threehouseCost, int _fourhouseCost, int _rentPrice)
        {
            hotelCost = _hotelPrice;
            onehouseCost = _onehouseCost;
            twohouseCost = _twohouseCost;
            threehouseCost = _threehouseCost;
            fourhouseCost = _fourhouseCost;
            rentAmount = _rentPrice;
            this.cellGroup = _cellGrp;
            this.mortgageValue = _mortgageVal;
            this.isMortgaged = false;
            this.name = _name;
            this.owner = null;
            this.hasOwner = false;
            this.purchasePrice = _cellprice;
        }

        public override void applyAction()
        {

        }
    }
}
