using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.CommandOperations.OrderType;

namespace Model.CommandOperations.Orders
{
    class GoToJailCardOrder : GoToJailOrder
    {
        public GoToJailCardOrder(CommandReceiver _affecting)
            : base(_affecting)
        {
        }

        public override bool ApplyOrder()
        {
            return base.ApplyOrder();
        }
    }
}
