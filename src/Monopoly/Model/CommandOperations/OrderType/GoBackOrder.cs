﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.CommandOperations.OrderType
{
    class GoBackOrder : Order
    {
        public GoBackOrder() : base(null, null) { }
        public override bool ApplyOrder()
        {
            throw new NotImplementedException();
        }
    }
}
