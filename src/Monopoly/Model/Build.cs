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
            int currentCellHouseCount = cell.houseCount;

            if (cell.owner.playerID == player.playerID)
            {
                if (currentCellHouseCount == 4)
                {
                    Cell nextCell = null;
                    bool isBuildable = false;
                    GameController controller = GameController.GameControllerInstance;
                    for (int i = 1; i < cell.cellGroup.Count(); i++)
                    {
                        nextCell = cell.cellGroup.GetNextCell(cell);
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
                        cell.houseCount = 0;
                        cell.hasHotel = true;
                        // TODO: UI should be updated
                    }
                }
                else if ((currentCellHouseCount < 4) &&
                        !cell.hasHotel)
                {
                    Cell nextCell = null;
                    bool isBuildable = false;
                    GameController controller = GameController.GameControllerInstance;
                    for (int i = 1; i < cell.cellGroup.Count(); i++)
                    {
                        nextCell = cell.cellGroup.GetNextCell(cell);
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
                        cell.houseCount++;
                        // TODO: UI should be updated
                    }
                }

            }
            // TODO: Notify error in else statement
        }
    }
}
