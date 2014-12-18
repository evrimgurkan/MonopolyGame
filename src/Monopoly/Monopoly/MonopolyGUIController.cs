using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace Monopoly
{
    public class MonopolyGUIController : IMonopolyGUI
    {
        private _Default pageInstance;
        public MonopolyGUIController()
        {
            pageInstance = pageInstance.getInstance();
        }

        public void movePlayer()
        {
            Console.WriteLine("MonopolyGUIController");
            Console.ReadLine();
        }
        public void showMessage()
        {
        }
        public void startGame()
        {
        }
    }
}
