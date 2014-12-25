using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.CommandOperations
{
    class ActionCommand : Command
    {
        public ActionCommand(Order cardOrder)
            : base(cardOrder) 
        {
        }

        public override bool Execute()
        {
           return order.ApplyOrder();
        }
    }
}
