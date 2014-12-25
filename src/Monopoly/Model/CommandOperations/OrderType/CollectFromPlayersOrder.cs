using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.CommandOperations.OrderType
{
    class CollectFromPlayersOrder : Order
    {
        private Player player;
        private Bank bank;
        protected int amount;
        protected CollectFromPlayersOrder(CommandReceiver _affected, CommandReceiver _affecting, int _amount)
            : base(_affected, _affecting)
        {
            player = (Player)base.affected;
            bank = (Bank)base.affecting;
            amount = _amount;
        }

        public override bool ApplyOrder()
        {
            GameController controller = GameController.GameControllerInstance;
            int playerCount = controller.getPlayersCount();
            for (int i = 0; i < playerCount; i++)
            {
                Player p = controller.getPlayer(i);
                bank.takeMoneyFromPlayer(amount, p);
            }
            return bank.payMoneyToPlayer(amount * playerCount, player);
        }
    }
}
