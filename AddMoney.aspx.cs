using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practice_app
{
    public partial class AddMoney : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.Form["AccountID"]);
            string pswd = Request.Form["password"];
            int Amt = Convert.ToInt32(Request.Form["DepositAmount"]);
            if(DBMain.updateBalance(id, pswd, Amt))
            {
                Label1.Visible = true;
                Label1.Text = "Update succesfull";
            }

        }
    }
}