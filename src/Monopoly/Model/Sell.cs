using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class Sell
    {
        public Sell()
        {

        }

        public void SellItem(Player player, Cell cell)
        {
            PropertyCell pCell = (PropertyCell)cell;
            int currentCellHouseCount = pCell.houseCount;

            if (pCell.owner.playerID == player.playerID)
            {
                GameController controller = GameController.GameControllerInstance;
                if (pCell.hasHotel)
                {
                    PropertyCellGroup pCellGroup = (PropertyCellGroup)pCell.cellGroup;
                    controller.getBank().payMoneyToPlayer((pCellGroup.costPerHotel / 2), controller.getCurrentPlayer());
                    pCell.houseCount = 4;
                    pCell.hasHotel = false;

                    controller.AddLog("Player " + controller.getCurrentPlayer().name +
                                        " sold hotel " + pCell.name);
                    controller.updateBankInfo(controller.getBank().cash, pCell.name, false);
                    // TODO: UI should be updated
                }
                else if ((currentCellHouseCount <= 4) && (currentCellHouseCount > 0))
                {
                    PropertyCell nextCell = null;
                    bool isSellable = true;
                    for (int i = 1; i < pCell.cellGroup.Count(); i++)
                    {
                        nextCell = (PropertyCell)pCell.cellGroup.GetNextCell(pCell);
                        if (nextCell != null &&
                            (nextCell.hasHotel ||
                             nextCell.houseCount >= currentCellHouseCount))
                        {
                            isSellable = false;
                        }
                    }
                    if (isSellable)
                    {
                        PropertyCellGroup pCellGroup = (PropertyCellGroup)pCell.cellGroup;
                        controller.getBank().payMoneyToPlayer((pCellGroup.costPerHouse / 2), controller.getCurrentPlayer());
                        pCell.houseCount--;
                        controller.AddLog("Player " + controller.getCurrentPlayer().name +
                                             " sold house " + pCell.name);
                        controller.updateBankInfo(controller.getBank().cash, pCell.name, false);

                        // TODO: UI should be updated
                    }
                }
            }
            else
            {
                // TODO: Notify error in else statement
                GameController controller = GameController.GameControllerInstance;
                controller.AddLog("Player " + controller.getCurrentPlayer().name +
                                    " has not this property");
            }
        }
    }
}
