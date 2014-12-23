﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class GoSpace : NonPurchasableSpace
    {
        private string spaceName;
        public string name
        {
            get { return spaceName; }
        }

        public GoSpace(string _name)
        {
            spaceName = _name;
        }

        public override void playAction()
        {
            GameController controller = GameController.GameControllerInstance;
            controller.getBank().payMoneyToPlayer(controller.getPassingGoAmount(), controller.getCurrentPlayer());
        }
    }
}
