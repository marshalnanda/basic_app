using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

namespace practice_app
{
    public partial class login_singup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           DBMain.ShowAll(GridView1);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.Form["Account_ID"]);
            string pass = Request.Form["password"];
            //if(name.Equals("marshal") && pass.Equals("mar123"))
            //{
            //    Response.Redirect("Home.aspx");
            //}
            if(DBMain.GetAuthentication(id, pass))
            {
                ArrayList details = DBMain.Getdetails(id, pass);
                Session["Name"] = details[0];
                Session["p_no"] = details[1];
                Session["balance"] = details[2];
                //Session["Name"] = DBMain.Getdetails(id, pass)[0];
                //Session["p_no"] = DBMain.Getdetails(id, pass)[1];
                //Session["balance"] = DBMain.Getdetails(id, pass)[2];
                Response.Redirect("Home.aspx");

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        { 
            string UserName = Request.Form["Name"];
            string UserPassword = Request.Form["Password_signup"];
            string UserPhoneNumber= Request.Form["PhoneNumber"];

            User user = new User(UserName, UserPassword, UserPhoneNumber) ;
            if (DBMain.InsertToDB(user))
            {
                Response.Redirect("Registerationconfirmation.aspx?status="+"true");//other way to send data -> cookies and sessions
            }
            else
            {
                Response.Redirect("Registerationconfirmation.aspx?status=" + "false");
            }

        }
    }
}