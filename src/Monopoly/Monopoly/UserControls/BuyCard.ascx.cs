using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace Monopoly.UserControls
{
    public partial class BuyCard : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void updateCardInfo(Color color, int title, int rent, 
                                    int oneHouseRent, int twoHouseRent,
                                    int threeHouseRent, int fourHouseRent,
                                    int hotelRent, int mortgagedValue,
                                    int housePrice, int hotelPrice)
        {
            pnlTitle.BackColor      = color;
            lblTitle.Text           = title.ToString();
            lblRent.Text            = rent.ToString();
            lblOneHouseRent.Text    = oneHouseRent.ToString();
            lblTwoHousesRent.Text   = twoHouseRent.ToString();
            lblThreeHousesRent.Text = threeHouseRent.ToString();
            lblFourHousesRent.Text  = fourHouseRent.ToString();
            lblHotelRent.Text       = hotelRent.ToString();
            lblMortgagedValue.Text  = mortgagedValue.ToString();
            lblHousePrice.Text      = housePrice.ToString();
            lblHotelPrice.Text      = hotelPrice.ToString();
        }
    }
}