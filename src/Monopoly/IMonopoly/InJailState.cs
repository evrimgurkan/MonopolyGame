using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMonopoly
{
    public class InJailState : State
    {
        public InJailState() { }

        #region State Members

        public bool IsInJail()
        {
            return true;
        }

        #endregion
    }
}
