using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MonopolyController;
using IMonopoly;

namespace Monopoly
{
    public partial class _Default : System.Web.UI.Page , Observer
    {
        private static MonopolyGameController mGameController = new MonopolyGameController();
        private static DiceController diceController = new DiceController();
        private static int playersCount = -1;
        private static int currentPlayerIndex = -1;

        protected void Page_Load(object sender, EventArgs e)
        {
            mGameController.Attach(this);

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
            diceController.RollDice();
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

            // TODO: UI should be update for in jail state player. 
            // A pop up should be displayed and choice between roll dice or pay money
            bool inJail = mGameController.IsInJail();
            lbLogs.Items.Add(mGameController.getPlayerName(currentPlayerIndex) + " is in Jail ???  " + inJail.ToString());
        }

        #region Observer Members

        // Update Comes From Controller
        public void Update()
        {
        }

        public void SendMessageToView(string message, int money)
        {
            lbLogs.Items.Add(message + " money : " + money.ToString());
        }

        #endregion
    }
}
