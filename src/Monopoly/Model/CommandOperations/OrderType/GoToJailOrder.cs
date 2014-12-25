using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.CommandOperations.OrderType
{
    class GoToJailOrder : Order
    {
        private Player player;
        protected GoToJailOrder(CommandReceiver _affecting)
            : base(null, _affecting)
        {
            player = (Player)base.affected;
        }

        private int CalculateJailPosition(GameController controller)
        {
            int currIndex = controller.getCurrentSpaceIndex(player);

            if (currIndex > 10)// Jail Space
            {
                return (currIndex - 10);
            }
            else
            {
                return (10 - currIndex);
            }
        }

        public override bool ApplyOrder()
        {
            GameController controller = GameController.GameControllerInstance;
            player.inJail = true;
            controller.moveBackPlayer(player, CalculateJailPosition(controller));// Go jail space
            return true;
        }
    }
}
