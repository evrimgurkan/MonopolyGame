using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.CommandOperations
{
    public abstract class Order
    {
        protected CommandReceiver affected;
        protected CommandReceiver affecting;

        protected Order(CommandReceiver _affected, CommandReceiver _affecting)
        {
            this.affected = _affected;
            this.affecting = _affecting;
        }

        public abstract bool ApplyOrder();
    }
}
