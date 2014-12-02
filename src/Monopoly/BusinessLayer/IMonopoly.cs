using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    interface IMonopoly
    {
        bool enableEndTurnBtn();
        bool enablePlayerTurn();
        bool enablePurchaseBtn();
        bool isDrawCardBtnEnabled();
        bool isEndTurnBtnEnabled();
        bool isTradeBtnEnabled();
        void movePlayer();
        void openRespondDialog();
        void openTradeDialog();
        void setBuyHouseEnabled();
        void setDrawCardEnabled();
        void setEndTurnEnabled();
        void setGetOutOfJailEnabled();
        void setPurchasePropertyEnabled();
        void setRollDiceEnabled();
        void setTradeEnabled();
        void showBuyHouseDialog();
        void showMessage();
        void startGame();
        void update();
    }
}
