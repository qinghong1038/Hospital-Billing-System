using System;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class Login
    {
        ConnectionString objConnectionString = new ConnectionString();
        private string username;
        private string password;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int DoLogin(Login DataObjectLogin)
        {
            int loggedInUser = -1;
            string query = "select * from login where username=@username and password=@password";
            SqlConnection con = objConnectionString.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter sp_username = cmd.Parameters.Add("@username", SqlDbType.VarChar, 20, "username");
            SqlParameter sp_password = cmd.Parameters.Add("@password", SqlDbType.VarChar, 20, "password");

            sp_username.Value = DataObjectLogin.Username;
            sp_password.Value = DataObjectLogin.Password;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if ((DataObjectLogin.Username.ToLower() == dr[1].ToString().ToLower()) && (DataObjectLogin.Password.ToLower() == dr[2].ToString().ToLower()))
                {
                    loggedInUser = GetLoginId(DataObjectLogin);
                }
            }
            con.Close();
            return loggedInUser;
        }

        private int GetLoginId(Login DataObjectLogin)
        {
            int loginId = -1;
            string query = "select login_id from login where username=@username and password=@password";
            SqlConnection con = objConnectionString.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter sp_username = cmd.Parameters.Add("@username", SqlDbType.VarChar, 20, "username");
            SqlParameter sp_password = cmd.Parameters.Add("@password", SqlDbType.VarChar, 20, "password");

            sp_username.Value = DataObjectLogin.Username;
            sp_password.Value = DataObjectLogin.Password;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                loginId = Convert.ToInt32(dr[0].ToString());
            }
            con.Close();
            return loginId;
        }
    }
}
