using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IMonopoly;

namespace Model
{
    class GoToJailSpace : NonPurchasableSpace
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
            // Update current player position to Jail space
            // update player.inJail

            GameController controller = GameController.GameControllerInstance;
            controller.getCurrentPlayer().inJail = true;
            controller.moveBackPlayer(controller.getCurrentPlayer(), 20);// Go jail space
            //controller.setState(new InJailState());
        }
    }
}
