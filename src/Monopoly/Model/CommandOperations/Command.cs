using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.CommandOperations
{
    public abstract class Command
    {
        protected Order order;

        // Constructor 
        public Command(Order _order)
        {
            order = _order;
        }

        public abstract bool Execute();
    }
}
