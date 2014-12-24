using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMonopoly
{
    public class PlayableState : State
    {
        public PlayableState()
        {
        }

        #region State Members

        public bool IsInJail()
        {
            return false;
        }

        #endregion
    }
}
