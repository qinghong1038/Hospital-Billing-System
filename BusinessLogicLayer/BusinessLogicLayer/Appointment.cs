using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BusinessLogicLayer
{
    public class Appointment
    {
        ConnectionString objConnectionString = new ConnectionString();
        private int appointmentid;
        private int patientid;
        private int doctorid;
        private DateTime appointmentdate;
        private string appointmenttime;
        private DateTime datecreated;
        private int createdby;
        private DateTime datemodified;
        private int modifiedby;

        public int Appointmentid
        {
            get { return appointmentid; }
            set { appointmentid = value; }
        }

        public int Patientid
        {
            get { return patientid; }
            set { patientid = value; }
        }

        public int Doctorid
        {
            get { return doctorid; }
            set { doctorid = value; }
        }

        public DateTime Appointmentdate
        {
            get { return appointmentdate; }
            set { appointmentdate = value; }
        }

        public string Appointmenttime
        {
            get { return appointmenttime; }
            set { appointmenttime = value; }
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

        public int InsertAppointment(Appointment DataObjectAppointment)
        {
            int insertedAppointmentId = -1;
            string query = "insert into appointment(patient_id,doctor_id,appointment_date,appointment_time,date_created,created_by) values (@patient_id,@doctor_id,@appointment_date,@appointment_time,@date_created,@created_by)";
            SqlConnection con = objConnectionString.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter sp_patient_id = cmd.Parameters.Add("@patient_id", SqlDbType.Int, 10, "patient_id");
            SqlParameter sp_doctor_id = cmd.Parameters.Add("@doctor_id", SqlDbType.Int, 10, "doctor_id");
            SqlParameter sp_appointment_date = cmd.Parameters.Add("@appointment_date", SqlDbType.DateTime, 12, "appointment_date");
            SqlParameter sp_appointment_time = cmd.Parameters.Add("@appointment_time", SqlDbType.VarChar, 10, "appointment_time");
            SqlParameter sp_date_created = cmd.Parameters.Add("@date_created", SqlDbType.DateTime, 12, "date_created");
            SqlParameter sp_created_by = cmd.Parameters.Add("@created_by", SqlDbType.Int, 10, "created_by");

            sp_patient_id.Value = DataObjectAppointment.Patientid;
            sp_doctor_id.Value = DataObjectAppointment.Doctorid;
            sp_appointment_date.Value = DataObjectAppointment.Appointmentdate;
            sp_appointment_time.Value = DataObjectAppointment.Appointmenttime;
            sp_date_created.Value = DataObjectAppointment.Datecreated;
            sp_created_by.Value = DataObjectAppointment.Createdby;
            int rowsReturned = cmd.ExecuteNonQuery();
            if (rowsReturned > 0)
            {
                insertedAppointmentId = GetAppointmentId(DataObjectAppointment);
            }
            con.Close();
            return insertedAppointmentId;
        }

        private int GetAppointmentId(Appointment DataObjectAppointment)
        {
            int appointmentId = -1;
            string query = "select appointment_id from appointment where patient_id=@patient_id";
            SqlConnection con = objConnectionString.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter sp_patient_id = cmd.Parameters.Add("@patient_id", SqlDbType.Int, 10, "patient_id");

            sp_patient_id.Value = DataObjectAppointment.Patientid;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                appointmentId = Convert.ToInt32(dr[0].ToString());
            }
            con.Close();
            return appointmentId;
        }

        public void GetAppointmentList(ComboBox cbAppointmentList)
        {
            cbAppointmentList.Items.Clear();
            string query = "select distinct appointment_id, (select convert(varchar,appointment_date, 105)) as \"appointment_date\" from patient_history_view where paid='N'";
            SqlConnection con = objConnectionString.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbAppointmentList.Items.Add(dr[0].ToString() + " | " + dr[1].ToString());
            }
            cbAppointmentList.Items.Insert(0, "Select Appointment");
            cbAppointmentList.SelectedIndex = 0;
            con.Close();
        }

        public DataSet GetAppointmentDetails(Appointment DataObjectAppointment)
        {
            DataSet dsAppointmentDetails = new DataSet();
            string query = "select * from patient_history_view where appointment_id=@appointment_id";
            SqlConnection con = objConnectionString.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter sp_appointment_id = cmd.Parameters.Add("@appointment_id", SqlDbType.Int, 10, "appointment_id");

            sp_appointment_id.Value = DataObjectAppointment.Appointmentid;
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = cmd;
            adap.Fill(dsAppointmentDetails);
            con.Close();
            return dsAppointmentDetails;
        }
    }
}
