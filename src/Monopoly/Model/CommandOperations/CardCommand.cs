using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.CommandOperations
{
    class CardCommand : Command
    {
        public CardCommand(CommandReceiver receiver, Order order) : base(receiver,order) 
        {  
        }

        public override void Execute()
        {
            //receiver.Action();
        }
    }
}
