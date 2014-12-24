using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class Build
    {
        // Checks;
        // Cash is enough
        // cell gorup is complete// should be checked in view
        // is mortgaged ? should be checked in view
        // build sequencially one by one
        public Build()
        {
        }

        public void AddHouse(Player player, Cell cell)
        {
            PropertyCell pCell = (PropertyCell)cell;
            int currentCellHouseCount = pCell.houseCount;

            if (pCell.owner.playerID == player.playerID)
            {
                GameController controller = GameController.GameControllerInstance;
                if (currentCellHouseCount == 4)
                {
                    PropertyCell nextCell = null;
                    bool isBuildable = false;
                    for (int i = 1; i < pCell.cellGroup.Count(); i++)
                    {
                        nextCell = (PropertyCell)pCell.cellGroup.GetNextCell(pCell);
                        if (nextCell != null &&
                            nextCell.hasOwner &&
                            nextCell.owner.playerID == player.playerID &&
                            nextCell.houseCount == currentCellHouseCount)
                        {
                            isBuildable = true;
                        }
                    }
                    if (isBuildable)
                    {
                        PropertyCellGroup pCellGroup = (PropertyCellGroup)pCell.cellGroup;
                        if (player.cash >= pCellGroup.costPerHotel)
                        {
                            controller.getBank().takeMoneyFromPlayer(pCellGroup.costPerHotel, controller.getCurrentPlayer());
                            pCell.houseCount = 0;
                            pCell.hasHotel = true;
                            // TODO: UI should be updated
                        }
                        else
                        {
                            // TODO: UI should be updated
                        }
                    }
                }
                else if ((currentCellHouseCount < 4) &&
                        !pCell.hasHotel)
                {
                    PropertyCell nextCell = null;
                    bool isBuildable = false;
                    for (int i = 1; i < pCell.cellGroup.Count(); i++)
                    {
                        nextCell = (PropertyCell)pCell.cellGroup.GetNextCell(pCell);
                        if (nextCell != null &&
                            nextCell.hasOwner &&
                            nextCell.owner.playerID == player.playerID &&
                            nextCell.houseCount >= currentCellHouseCount)
                        {
                            isBuildable = true;
                        }
                    }
                    if (isBuildable)
                    {
                        PropertyCellGroup pCellGroup = (PropertyCellGroup)pCell.cellGroup;

                        if (player.cash >= pCellGroup.costPerHouse)
                        {
                            controller.getBank().takeMoneyFromPlayer(pCellGroup.costPerHouse, controller.getCurrentPlayer());
                            pCell.houseCount++;
                            // TODO: UI should be updated
                        }
                        else
                        {
                            // TODO: UI should be updated
                        }
                    }
                }

            }
            else
            {
                // TODO: Notify error in else statement
            }
        }
    }
}
