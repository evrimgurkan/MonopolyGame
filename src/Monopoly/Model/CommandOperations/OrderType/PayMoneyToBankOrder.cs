using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.CommandOperations.OrderType
{
    class PayMoneyToBankOrder : Order
    {
        private Player player;
        private Bank bank;
        protected int amount;
        protected PayMoneyToBankOrder(CommandReceiver _affected, CommandReceiver _affecting, int _amount)
            : base(_affected, _affecting)
        {
            player = (Player)base.affected;
            bank = (Bank)base.affecting;
            amount = _amount;
        }

        public override bool ApplyOrder()
        {
           return bank.takeMoneyFromPlayer(amount, player);
        }
    }
}
