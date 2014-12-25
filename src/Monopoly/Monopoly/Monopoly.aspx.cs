using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MonopolyController;
using IMonopoly;
using System.Web.Services;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
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

            if (diceController.isDiceDouble())
            {
                mGameController.GetOutPlayerFromJail();
            }
            if (!mGameController.IsInJail(currentPlayerIndex))
            {
                cube.Attributes.CssStyle.Clear();
                cube.Attributes.Add("class", GetDiceCSS(dieOne));
                cube2.Attributes.CssStyle.Clear();
                cube2.Attributes.Add("class", GetDiceCSS(dieTwo));

                dad.Attributes.CssStyle.Add("margin-top", "-400px");
                dad.Attributes.CssStyle.Add("transition", "margin 5s");
                //ScriptManager.RegisterStartupScript(this, GetType(), "setDiceOneValue", "setDiceOneValue(show-back);", true);
                //ScriptManager.RegisterStartupScript(this, GetType(), "setDiceTwoValue", "setDiceTwoValue(show-left);", true);

                lbLogs.Items.Add("Dice1 : " + dieOne +
                                 ", Dice2 : " + dieTwo);
                lbLogs.Items.Add("Player " + mGameController.getPlayerName(currentPlayerIndex) +
                     " is moved " + (dieOne + dieTwo) + " space");

                int lastState = getCurrentIndex(currentPlayerIndex, dieOne + dieTwo);
                lbLogs.Items.Add("Player " + mGameController.getPlayerName(currentPlayerIndex) +
                                 "s current space is " + lastState);
                movePlayer(currentPlayerIndex, lastState);
            }
            if (diceController.isDiceDouble())
            {
                btnRollDice.Visible = true;
            }
            else
            {
                btnFinishTurn.Visible = true;
            }
        }
        private string GetDiceCSS(int number)
        {
            switch (number)
            {
                case 1:
                    return "show-front";
                case 2:
                    return "show-back";
                case 3:
                    return "show-right";
                case 4:
                    return "show-left";
                case 5:
                    return "show-top";
                case 6:
                    return "show-bottom";
                default:
                    return "show-front";
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
            bool inJail = mGameController.IsInJail(currentPlayerIndex);
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
