using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BusinessLogicLayer
{
    public class Provience
    {
        ConnectionString objConnectionString = new ConnectionString();
        private int provienceid;
        private string proviencedescription;


        public int ProvienceId
        {
            get { return provienceid; }
            set { provienceid = value; }
        }

        public string ProvienceDescription
        {
            get { return proviencedescription; }
            set { proviencedescription = value; }
        }

        public void GetProvienceList(ComboBox cbProvienceList)
        {
            cbProvienceList.Items.Clear();
            string query = "select provience_id,provience_description from provience";
            SqlConnection con = objConnectionString.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbProvienceList.Items.Add(dr[1].ToString());
            }
            cbProvienceList.Items.Insert(0, "Select Provience");
            cbProvienceList.SelectedIndex = 0;
            con.Close();
        }

        public int GetProvienceId(Provience DataObjectProvience)
        {
            int provienceid = -1;
            string query = "select provience_id from provience where provience_description=@provience_description";
            SqlConnection con = objConnectionString.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter sp_provience_description = cmd.Parameters.Add("@provience_description", SqlDbType.VarChar, 2, "provience_description");
            sp_provience_description.Value = DataObjectProvience.ProvienceDescription;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                provienceid = Convert.ToInt32(dr[0].ToString());
            }
            con.Close();
            return provienceid;
        }

        public string GetProvienceDescription(Provience DataObjectProvience)
        {
            string provience_description = string.Empty;
            string query = "select provience_description from provience where provience_id=@provience_id";
            SqlConnection con = objConnectionString.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter sp_provienceid = cmd.Parameters.Add("@provience_id", SqlDbType.Int, 10, "provience_id");
            sp_provienceid.Value = DataObjectProvience.ProvienceId;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                provience_description = dr[0].ToString();
            }
            con.Close();
            return provience_description;
        }
    }
}
