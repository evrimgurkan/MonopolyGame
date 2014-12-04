using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    class GoToJailSpace : Space
    {
        private string spaceName;
        public string name
        {
            get { return spaceName; }
        }

        public GoToJailSpace(string _name)
        {
            spaceName = _name;
        }

        public override void playAction()
        {
            // Do something
        }
    }
}
