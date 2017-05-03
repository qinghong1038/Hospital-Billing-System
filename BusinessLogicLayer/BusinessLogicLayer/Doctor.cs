using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BusinessLogicLayer
{
    public class Doctor
    {
        ConnectionString objConnectionString = new ConnectionString();
        private int doctorid;
        private string firstname;
        private string lastname;


        public int DoctorId
        {
            get { return doctorid; }
            set { doctorid = value; }
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }


        public void GetDoctorsList(ComboBox cbDoctorsList)
        {
            cbDoctorsList.Items.Clear();
            string query = "select doctor_id,firstname,lastname from doctor";
            SqlConnection con = objConnectionString.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbDoctorsList.Items.Add(dr[1].ToString() + " " + dr[2].ToString());
            }
            cbDoctorsList.Items.Insert(0, "Select Doctor");
            cbDoctorsList.SelectedIndex = 0;
            con.Close();
        }

        public int GetDoctorId(Doctor DataObjectDoctor)
        {
            int doctorid = -1;
            string query = "select doctor_id from doctor where firstname=@firstname and lastname=@lastname";
            SqlConnection con = objConnectionString.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter sp_firstname = cmd.Parameters.Add("@firstname", SqlDbType.VarChar, 20, "firstname");
            SqlParameter sp_lastname = cmd.Parameters.Add("@lastname", SqlDbType.VarChar, 20, "lastname");

            sp_firstname.Value = DataObjectDoctor.Firstname;
            sp_lastname.Value = DataObjectDoctor.Lastname;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                doctorid = Convert.ToInt32(dr[0].ToString());
            }
            con.Close();
            return doctorid;
        }
    }
}
