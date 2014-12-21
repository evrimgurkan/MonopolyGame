using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MonopolyController;

namespace Monopoly
{
    public partial class NewGame : System.Web.UI.Page
    {
        private static string createPlayerPage = "CreatePlayer.aspx";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNewGame_Click(object sender, EventArgs e)
        {
            MonopolyGameController mGameController = new MonopolyGameController();
            mGameController.initBoard();
            Response.Redirect(createPlayerPage);
        }
    }
}
