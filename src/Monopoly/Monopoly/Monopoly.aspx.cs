using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MonopolyController;

namespace Monopoly
{
    public partial class _Default : System.Web.UI.Page
    {
        private static MonopolyGameController mGameController = new MonopolyGameController();
        private static DiceController diceController = new DiceController();
        private static int playersCount = -1;
        private static int currentPlayerIndex = -1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (lbLogs.Items.Count == 0)
            {
                playersCount = mGameController.getPlayersCount();
                if (playersCount != 0)
                {
                    for (int i = 0; i < playersCount; i++)
                    {
                        lbLogs.Items.Add("Player name : " + mGameController.getPlayerName(i) +
                                         " Cash : " + mGameController.getPlayerCash(i));
                    }
                    currentPlayerIndex = 0; // start with first added player
                    lbLogs.Items.Add("Current player is : " + mGameController.getPlayerName(currentPlayerIndex));
                }
            }
        }

        public _Default getInstance()
        {
            return this;
        }

        protected void btnRollDice_Click(object sender, EventArgs e)
        {
            btnRollDice.Visible = false;
            int dieOne = diceController.getDieOneValue();
            int dieTwo = diceController.getDieTwoValue();
            lbLogs.Items.Add("Dice1 : " + dieOne +
                             ", Dice2 : " + dieTwo);
            lbLogs.Items.Add("Player " + mGameController.getPlayerName(currentPlayerIndex) +
                 " is moved " + (dieOne + dieTwo) + " space");

            int lastState = getCurrentIndex(currentPlayerIndex, dieOne + dieTwo);
            lbLogs.Items.Add("Player " + mGameController.getPlayerName(currentPlayerIndex) +
                             "s current space is " + lastState);
            movePlayer(currentPlayerIndex, lastState);
            if (diceController.isDiceDouble())
            {
                btnRollDice.Visible = true;
            }
            else
            {
                btnFinishTurn.Visible = true;
            }
        }

        private int getCurrentIndex(int playerIndex, int count)
        {
            return mGameController.getCurrentIndex(playerIndex, count);
        }

        private void movePlayer(int playerIndex, int count)
        {
            mGameController.movePlayer(playerIndex, count);
        }

        protected void btnFinishTurn_Click(object sender, EventArgs e)
        {
            finishTurn();
            btnFinishTurn.Visible = false;
            btnRollDice.Visible = true;
        }
        private void finishTurn()
        {
            // select next player
            currentPlayerIndex = mGameController.getNextPlayerIndex(currentPlayerIndex);
            lbLogs.Items.Add("Next player is : " + mGameController.getPlayerName(currentPlayerIndex));
        }
    }
}
