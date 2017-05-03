using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BusinessLogicLayer
{
    public class Patient
    {
        ConnectionString objConnectionString = new ConnectionString();
        private int patientid;
        private string firstname;
        private string lastname;
        private string addresslineone;
        private string addresslinetwo;
        private string city;
        private int provienceId;
        private string proviencedescription;
        private string postalcode;
        private DateTime dob;
        private string email;
        private string contactno;
        private DateTime datecreated;
        private int createdby;
        private DateTime datemodified;
        private int modifiedby;

        public int Patientid
        {
            get { return patientid; }
            set { patientid = value; }
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

        public string Addresslineone
        {
            get { return addresslineone; }
            set { addresslineone = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Addresslinetwo
        {
            get { return addresslinetwo; }
            set { addresslinetwo = value; }
        }

        public int ProvienceId
        {
            get { return provienceId; }
            set { provienceId = value; }
        }

        public string Proviencedescription
        {
            get { return proviencedescription; }
            set { proviencedescription = value; }
        }

        public string Postalcode
        {
            get { return postalcode; }
            set { postalcode = value; }
        }

        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Contactno
        {
            get { return contactno; }
            set { contactno = value; }
        }

        public DateTime Datecreated
        {
            get { return datecreated; }
            set { datecreated = value; }
        }

        public int Createdby
        {
            get { return createdby; }
            set { createdby = value; }
        }

        public DateTime Datemodified
        {
            get { return datemodified; }
            set { datemodified = value; }
        }

        public int Modifiedby
        {
            get { return modifiedby; }
            set { modifiedby = value; }
        }

        public int InsertPatient(Patient DataObjectPatient)
        {
            int insertedPateintId = -1;
            string query = "insert into patient(firstname,lastname,address_line_1,address_line_2,city,provience_id,postal_code,dob,email,contact_no,date_created,created_by) values (@firstname,@lastname,@address_line_1,@address_line_2,@city,@provience_id,@postal_code,@dob,@email,@contact_no,@date_created,@created_by)";
            SqlConnection con = objConnectionString.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter sp_firstname = cmd.Parameters.Add("@firstname", SqlDbType.VarChar, 20, "firstname");
            SqlParameter sp_lastname = cmd.Parameters.Add("@lastname", SqlDbType.VarChar, 20, "lastname");
            SqlParameter sp_address_line_1 = cmd.Parameters.Add("@address_line_1", SqlDbType.VarChar, 25, "address_line_1");
            SqlParameter sp_address_line_2 = cmd.Parameters.Add("@address_line_2", SqlDbType.VarChar, 25, "address_line_2");
            SqlParameter sp_city = cmd.Parameters.Add("@city", SqlDbType.VarChar, 20, "city");
            SqlParameter sp_provience_id = cmd.Parameters.Add("@provience_id", SqlDbType.Int, 10, "provience_id");
            SqlParameter sp_postal_code = cmd.Parameters.Add("@postal_code", SqlDbType.VarChar, 7, "postal_code");
            SqlParameter sp_dob = cmd.Parameters.Add("@dob", SqlDbType.DateTime, 12, "dob");
            SqlParameter sp_email = cmd.Parameters.Add("@email", SqlDbType.VarChar, 25, "email");
            SqlParameter sp_contact_no = cmd.Parameters.Add("@contact_no", SqlDbType.VarChar, 12, "contact_no");
            SqlParameter sp_date_created = cmd.Parameters.Add("@date_created", SqlDbType.DateTime, 12, "date_created");
            SqlParameter sp_created_by = cmd.Parameters.Add("@created_by", SqlDbType.Int, 10, "created_by");

            sp_firstname.Value = DataObjectPatient.Firstname;
            sp_lastname.Value = DataObjectPatient.Lastname;
            sp_address_line_1.Value = DataObjectPatient.Addresslineone;
            sp_address_line_2.Value = DataObjectPatient.Addresslinetwo;
            sp_city.Value = DataObjectPatient.City;
            sp_provience_id.Value = DataObjectPatient.ProvienceId;
            sp_postal_code.Value = DataObjectPatient.Postalcode;
            sp_dob.Value = DataObjectPatient.Dob;
            sp_email.Value = DataObjectPatient.Email;
            sp_contact_no.Value = DataObjectPatient.Contactno;
            sp_date_created.Value = DataObjectPatient.Datecreated;
            sp_created_by.Value = DataObjectPatient.Createdby;

            int rowsReturned = cmd.ExecuteNonQuery();
            if (rowsReturned > 0)
            {
                insertedPateintId = GetPatientId(DataObjectPatient);
            }
            con.Close();
            return insertedPateintId;
        }

        public int GetPatientId(Patient DataObjectPatient)
        {
            int patientId = -1;
            string query = "select patient_id from patient where firstname=@firstname and lastname=@lastname";
            SqlConnection con = objConnectionString.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter sp_firstname = cmd.Parameters.Add("@firstname", SqlDbType.VarChar, 20, "firstname");
            SqlParameter sp_lastname = cmd.Parameters.Add("@lastname", SqlDbType.VarChar, 20, "lastname");

            sp_firstname.Value = DataObjectPatient.Firstname;
            sp_lastname.Value = DataObjectPatient.Lastname;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                patientId = Convert.ToInt32(dr[0].ToString());
            }
            con.Close();
            return patientId;
        }

        public void GetPatientList(ComboBox cbPatientList)
        {
            cbPatientList.Items.Clear();
            string query = "select patient_id,firstname,lastname from patient";
            SqlConnection con = objConnectionString.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbPatientList.Items.Add(dr[1].ToString().ToUpper() + " " + dr[2].ToString().ToUpper());
            }
            cbPatientList.Items.Insert(0, "Select Patient");
            cbPatientList.SelectedIndex = 0;
            con.Close();
        }
    }
}
