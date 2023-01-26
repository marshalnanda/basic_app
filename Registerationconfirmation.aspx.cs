using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practice_app
{
    public partial class Registerationconfirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string status = Request.QueryString["status"];
            Label1.Text = "User Registration= " + status;
        }

    }
}