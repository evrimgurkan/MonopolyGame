using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Monopoly
{
    public partial class Info : System.Web.UI.UserControl
    {
        public string Cash
        {
            set { this.lblCash.Text = value; }
            //get { return this.lblCash.Text; } // is necessary?
        }

        public void changeName(string name)
        {
            lblName.Visible = true;
            lblName.Text = name;
        }

        public void addProperty(string property)
        {
            this.lbProps.Items.Add(property);
        }

        public void removeProperty(string property)
        {
            this.lbProps.Items.Remove(property);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Load all items in the list box.
                int nItem = Convert.ToInt32(lbProps.Items.Count * 17);
                lbProps.Height = nItem; //Set height depends on the font size.
                lbProps.Width = 800; //This will ensure the list item won't be shrinked!
            }
        }
    }
}