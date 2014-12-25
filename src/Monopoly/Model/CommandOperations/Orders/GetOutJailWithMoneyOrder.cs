using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.CommandOperations.OrderType;

namespace Model.CommandOperations.Orders
{
    class GetOutJailWithMoneyOrder : GetOutPlayerFromJailOrder
    {
        public GetOutJailWithMoneyOrder(CommandReceiver _affected, CommandReceiver _affecting)
            : base(_affected, _affecting, 50)
        {
        }

        public override bool ApplyOrder()
        {
            return base.ApplyOrder();
        }
    }
}
