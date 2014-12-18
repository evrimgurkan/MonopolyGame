using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace MonopolyController
{
    public class MonopolyGameController
    {
        GameController gameController = GameController.GameControllerInstance;
        public void initBoard()
        {
            gameController.initilaise();
            gameController.initBoard();
        }

        public void fillBoard()
        {
            gameController.fillBoard();
        }

        public void addPlayer(string name)
        {
            gameController.addPlayer(name);
        }
    }
}
