using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.CommandOperations.OrderType
{
    class GoToUtilityOrder : Order
    {
        public GoToUtilityOrder() : base(null, null) { }
        public override bool ApplyOrder()
        {
            throw new NotImplementedException();
        }
    }
}
