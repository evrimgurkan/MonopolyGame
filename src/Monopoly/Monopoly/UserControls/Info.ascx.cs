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

        //public ListBox PropertiesList
        //{
        //    get { return this.lbProps; }
        //}

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

        }
    }
}