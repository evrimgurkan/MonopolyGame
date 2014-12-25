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

        private void calculateRentAmount()
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

            rentAmount *= Convert.ToInt32(Math.Pow(2, ownedCellCount));
        }

        public override void applyAction()
        {
            GameController controller = GameController.GameControllerInstance;

            ////
            //controller.SendMessageToView("benden sana gelsin be güzelim biz ayakta da gireiz RAILROAD", 1000);
            ////

            if (this.hasOwner)
            {
                // Pay rent
                calculateRentAmount();
                // TODO: Check Player cash
                if (controller.getCurrentPlayer().cash > this.rentPrice)
                {
                    controller.getBank().takeMoneyFromPlayer(rentPrice, controller.getCurrentPlayer());
                    controller.getBank().payMoneyToPlayer(rentPrice, this.owner);

                    // update ui with
                    // controller.getCurrentPlayer().cash 
                    // controller.getBank().cash
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
                // Update UI with showing Buy operation
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
