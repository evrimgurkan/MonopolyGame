using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MonopolyController;

namespace Monopoly.UserControls
{
    public partial class BuyButtons : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuy_Click(object sender, EventArgs e)
        {
            MonopolyGameController mGameController = new MonopolyGameController();
            mGameController.buyCurrentProperty();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            // do nothing
            // continue to game
            // close current page
        }
    }
}