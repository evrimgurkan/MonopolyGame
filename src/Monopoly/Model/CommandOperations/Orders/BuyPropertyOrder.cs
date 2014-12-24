using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.CommandOperations.OrderType;

namespace Model.CommandOperations.Orders
{
    class BuyPropertyOrder : BuyPropertyCellOrder
    {
        public BuyPropertyOrder(CommandReceiver _affected, CommandReceiver _affecting, Cell _cell)
            : base(_affected, _affecting, _cell)
        {
        }

        public override bool ApplyOrder()
        {
            return base.ApplyOrder();
        }
    }
}
