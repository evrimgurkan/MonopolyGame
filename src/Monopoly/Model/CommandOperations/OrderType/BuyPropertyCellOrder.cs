using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.CommandOperations.OrderType
{
    class BuyPropertyCellOrder : Order
    {
        private Player player;
        private Bank bank;
        protected Cell cell;
        protected BuyPropertyCellOrder(CommandReceiver _affected, CommandReceiver _affecting, Cell _cell)
            : base(_affected, _affecting)
        {
            player = (Player)base.affected;
            bank = (Bank)base.affecting;
            cell = _cell;
        }

        public override bool ApplyOrder()
        {
            cell.owner = player;
            player.AddAssest(cell);
            return bank.takeMoneyFromPlayer(cell.purchasePrice, player);
        }
    }
}
