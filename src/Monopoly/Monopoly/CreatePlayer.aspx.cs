using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MonopolyController;

namespace Monopoly
{
    public partial class CreatePlayer : System.Web.UI.Page
    {
        private static string startGamePage = "Monopoly.aspx";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        MonopolyGameController mGameController = new MonopolyGameController();

        protected void btnStartGame_Click(object sender, EventArgs e)
        {
            mGameController.fillBoard();
            Response.Redirect(startGamePage);
        }

        protected void btnAddPlayer_Click(object sender, EventArgs e)
        {
            mGameController.addPlayer(txtName.Text);
        }        
    }
}
