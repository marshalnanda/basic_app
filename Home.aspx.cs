using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practice_app.javascript
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Name"] != null)
                Label1.Text = Session["Name"].ToString().ToUpper();
            if (Session["p_no"] != null)
                Label2.Text = Session["p_no"].ToString();
            if (Session["balance"] != null)
                Label3.Text = Session["balance"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddMoney.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WithdrawMoney.aspx");
        }
    }
}