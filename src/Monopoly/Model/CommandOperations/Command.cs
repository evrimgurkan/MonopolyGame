using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.CommandOperations
{
    public abstract class Command
    {
        protected CommandReceiver receiver;
        protected Order commandOrder;

        // Constructor 
        public Command(CommandReceiver _receiver, Order _order)
        {
            this.receiver = _receiver;
            commandOrder = _order;
        }

        public abstract void Execute();
    }
}
