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
        private int playerID = 0;
        public static MonopolyGameController mGameController = new MonopolyGameController();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnAddPlayers_Click(object sender, ImageClickEventArgs e)
        {
            lblWarning.Visible = false;
            if ((txtName1.Text == "") &&
                (txtName2.Text == "") &&
                (txtName3.Text == "") &&
                (txtName4.Text == ""))
            {
                lblWarning.Visible = true;
            }
            else
            {
                if (txtName1.Text != "")
                {
                    mGameController.addPlayer(txtName1.Text, playerID);
                    playerID++;
                }
                if (txtName2.Text != "")
                {
                    mGameController.addPlayer(txtName2.Text, playerID);
                    playerID++;
                }
                if (txtName3.Text != "")
                {
                    mGameController.addPlayer(txtName3.Text, playerID);
                    playerID++;
                }
                if (txtName4.Text != "")
                {
                    mGameController.addPlayer(txtName4.Text, playerID);
                }
                btnStartGame.ImageUrl = "~/images/Buttons/StartGame.png";
                btnStartGame.Enabled = true;
                btnAddPlayers.ImageUrl = "~/images/Buttons/AddPlayersInactive.png";
                btnAddPlayers.Enabled = false;
            }
        }

        protected void btnStartGame_Click1(object sender, ImageClickEventArgs e)
        {
            mGameController.fillBoard();
            Response.Redirect(startGamePage);
        }        
    }
}
