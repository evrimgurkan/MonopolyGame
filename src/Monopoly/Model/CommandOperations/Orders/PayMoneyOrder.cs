﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.CommandOperations.OrderType;

namespace Model.CommandOperations.Orders
{
    class PayMoneyOrder : PayMoneyToBankOrder
    {
        public PayMoneyOrder(CommandReceiver _affected, CommandReceiver _affecting,int amount)
            : base(_affected, _affecting, amount)
        {
        }

        public override bool ApplyOrder()
        {
            return base.ApplyOrder();
        }
    }
}
