using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class JailSpace : NonPurchasableSpace
    {
        private string spaceName;
        public string name
        {
            get { return spaceName; }
        }

        public JailSpace(string _name)
        {
            spaceName = _name;
        }

        public override void playAction()
        {
            // Do nothing
            GameController controller = GameController.GameControllerInstance;
            controller.AddLog("Player " + controller.getCurrentPlayer().name +
                                " is now in the Jail Space");
        }
    }
}
