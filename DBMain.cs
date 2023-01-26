using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;


namespace practice_app
{
    public class DBMain
    {
        public static void ShowAll(GridView GridView1)
        {
            string con = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM accounts", connection);
                connection.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                GridView1.DataSource = rdr;
                GridView1.DataBind();
            }
        }

        public static bool GetAuthentication(int id,string password)
        {
            bool flag = false;
            string con = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using(SqlConnection Connection = new SqlConnection(con))
            {
                string query = $"SELECT Account_ID, Password FROM accounts WHERE Account_ID = @id AND Password = @password";
                using (SqlCommand cmd = new SqlCommand(query, Connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@password", password);
                    Connection.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        int idFromDB = rdr.GetInt32(0);
                        string passwordFromDB = rdr.GetString(1);
                        if (idFromDB == id && passwordFromDB.Contains(password))
                        {
                            flag = true;
                        }
                    }
                }
            }
            return flag;
        }

        public static bool InsertToDB(User user)
        {
            bool status = false;
            string con = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using(SqlConnection connection = new SqlConnection(con))
            {
                string query = $"INSERT into accounts VALUES (@User_Name,@User_PhoneNumber,@Password,@Balance)";
                using(SqlCommand cmd=new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@User_Name", user.UserName);
                    cmd.Parameters.AddWithValue("@User_PhoneNumber", user.UserPhoneNumber);
                    cmd.Parameters.AddWithValue("@Password", user.UserPassword);
                    cmd.Parameters.AddWithValue("@Balance", user.UserBalance);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    status = true;
                }
            }
            return status;
        }
    }
}