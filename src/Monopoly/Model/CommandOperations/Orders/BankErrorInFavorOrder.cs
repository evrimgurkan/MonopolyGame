using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.CommandOperations.OrderType;

namespace Model.CommandOperations.Orders
{
    class BankErrorInFavorOrder : CollectFromBankOrder
    {
        public BankErrorInFavorOrder(CommandReceiver _affected, CommandReceiver _affecting)
            : base(_affected, _affecting, 75)
        {
        }

        public override bool ApplyOrder()
        {
            return base.ApplyOrder();
        }
    }
}
