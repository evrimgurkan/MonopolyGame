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


        private int _houseCount;
        public int houseCount
        {
            get { return _houseCount; }
            set { _houseCount = value; }
        }

        private bool _hasHotel;
        public bool hasHotel
        {
            get { return _hasHotel; }
            set { _hasHotel = value; }
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

        private void calculateRentAmount()
        {
            if (hasHotel)
            {
                rentAmount = hotelPrice;
            }
            else if (houseCount > 0)
            {
                switch (houseCount)
                {
                    case 1:
                        rentAmount = onehouseCost;
                        break;
                    case 2:
                        rentAmount = twohouseCost;
                        break;
                    case 3:
                        rentAmount = threehouseCost;
                        break;
                    case 4:
                        rentAmount = fourhouseCost;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                int ownedCellCount = 1;
                Cell nextCell = null;
                GameController controller = GameController.GameControllerInstance;
                for (int i = 1; i < cellGroup.Count(); i++)
                {
                    nextCell = cellGroup.GetNextCell(this);
                    if (nextCell != null &&
                        nextCell.hasOwner &&
                        nextCell.owner.playerID == this.owner.playerID)
                    {
                        ownedCellCount++;
                    }
                }
                if (ownedCellCount == cellGroup.Count())
                {
                    rentAmount *= 2;
                }
            }
        }

        public override void applyAction()
        {
            GameController controller = GameController.GameControllerInstance;

            ////
            controller.SendMessageToView("benden sana gelsin be güzelim biz ayakta da gireiz PROPERTY", 1000);
            ////

            if (this.hasOwner)
            {
                // Pay rent
                calculateRentAmount();
                if (controller.getCurrentPlayer().cash > this.rentPrice)
                {
                    controller.getBank().takeMoneyFromPlayer(rentPrice, controller.getCurrentPlayer());
                    controller.getBank().payMoneyToPlayer(rentPrice, this.owner);
                }
                else
                {
                    //TODO: Update ui, Sell property to pay rent price
                }
            }
            else
            {
                // Buy property or cancel
                // TODO: UPDATE UI
                // TODO: Check user cash
                if (controller.getCurrentPlayer().cash > this.purchasePrice)
                {
                    // TODO: Order should be used by VIEW 

                    //controller.getBank().takeMoneyFromPlayer(this.purchasePrice, controller.getCurrentPlayer());
                    //this.owner = controller.getCurrentPlayer(); // Is there anything else ? 
                    //controller.getCurrentPlayer().AddAssest(this);
                }
                else
                {
                    //TODO: Update ui, Sell property to pay rent price
                }
            }
        }
    }
}
