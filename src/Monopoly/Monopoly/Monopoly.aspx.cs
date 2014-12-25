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
    public partial class _Default : System.Web.UI.Page, Observer
    {
        private static MonopolyGameController mGameController = new MonopolyGameController();
        private static DiceController diceController = new DiceController();
        private static int playersCount = -1;
        private static int currentPlayerIndex = -1;
        private static int lastState = 0;

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

                //dad.Attributes.CssStyle.Add("margin-top", "-400px");
                //ScriptManager.RegisterStartupScript(this, GetType(), "setDiceOneValue", "setDiceOneValue(show-back);", true);
                //ScriptManager.RegisterStartupScript(this, GetType(), "setDiceTwoValue", "setDiceTwoValue(show-left);", true);

                lbLogs.Items.Add("Dice1 : " + dieOne +
                                 ", Dice2 : " + dieTwo);
                lbLogs.Items.Add("Player " + mGameController.getPlayerName(currentPlayerIndex) +
                     " is moved " + (dieOne + dieTwo) + " space");

                lastState = getCurrentIndex(currentPlayerIndex, dieOne + dieTwo);
                lbLogs.Items.Add("Player " + mGameController.getPlayerName(currentPlayerIndex) +
                                 "s current space is " + lastState);
                movePlayer(currentPlayerIndex, lastState);

                CalculateIconPosition(lastState);
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

        private void CalculateIconPosition(int position)
        {
            int l = 0, r = 0, t= 0, b = 0;
            for (int i = 0; i < position + 1; i++)
            {

                if (i < 11)
                {
                    l += 110;
                    int pos = l;
                    string str = "-" + pos.ToString() + "px";
                    dad.Attributes.CssStyle.Add("margin-left", str);
                }
                else if (i > 10 && i < 21)
                {
                    t += 85;
                    int pos = t;
                    string str = "-" + pos.ToString() + "px";
                    dad.Attributes.CssStyle.Add("margin-top", str);
                }
                else if (i > 20 && i < 31)
                {
                    r += 110;
                    int pos = r;
                    string str = pos.ToString() + "px";
                    dad.Attributes.CssStyle.Add("margin-left", str);
                }
                else
                {
                    b += 85;
                    int pos = b;
                    string str = pos.ToString() + "px";
                    dad.Attributes.CssStyle.Add("margin-top", str);
                }
            }
            dad.Attributes.CssStyle.Add("transition", "margin 5s");
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

        #region Observer Members


        public void AddLog(string message)
        {
            lbLogs.Items.Add(message);
        }

        public void OpenItemsPage(int color, int title, int rent, int oneHouseRent, int twoHouseRent, int threeHouseRent, int fourHouseRent, int hotelRent, int mortgagedValue, int housePrice, int hotelPrice)
        {

        }

        public void updateBankInfo(int cash, string property, bool shouldBeDeleted)
        {
            bankInfo.Cash = cash.ToString();
            if (property != "")
            {
                if (shouldBeDeleted)
                {
                    bankInfo.removeProperty(property);
                }
                else
                {
                    bankInfo.addProperty(property);
                }
            }

        }

        #endregion
    }
}
