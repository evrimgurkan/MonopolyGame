using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class UtilityCell : Cell
    {
        private int rentAmount;
        public int rentPrice
        {
            get { return rentAmount; }
        }

        public UtilityCell(CellGroup _cellGrp, int _mortgageVal, string _name, int _cellprice)
        {
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

            if (ownedCellCount == 1)
            {
                rentAmount = (controller.getDice().diceOne + controller.getDice().diceTwo) * 4;
            }
            else
            {
                rentAmount = (controller.getDice().diceOne + controller.getDice().diceTwo) * 10;
            }
        }

        public override void applyAction()
        {
            GameController controller = GameController.GameControllerInstance;
            if (this.hasOwner)
            {
                // Pay rent
                calculateRentAmount();
                // TODO: Check Player cash
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
                    controller.getBank().takeMoneyFromPlayer(this.purchasePrice, controller.getCurrentPlayer());
                    this.owner = controller.getCurrentPlayer(); // Is there anything else ? 
                    controller.getCurrentPlayer().AddAssest(this);
                }
                else
                {
                    //TODO: Update ui, Sell property to pay rent price
                }
            }
        }
    }
}
