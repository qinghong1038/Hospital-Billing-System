using System;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class PatientHistory
    {
        ConnectionString objConnectionString = new ConnectionString();
        private int patienthistoryid;
        private int patientid;
        private int appointmentid;
        private int doctorid;
        private int procedureid;
        private string paid;
        private DateTime datecreated;
        private int createdby;
        private DateTime datemodified;
        private int modifiedby;

        public int Patienthistoryid
        {
            get { return patienthistoryid; }
            set { patienthistoryid = value; }
        }

        public int Patientid
        {
            get { return patientid; }
            set { patientid = value; }
        }

        public int Appointmentid
        {
            get { return appointmentid; }
            set { appointmentid = value; }
        }

        public int Doctorid
        {
            get { return doctorid; }
            set { doctorid = value; }
        }

        public int Procedureid
        {
            get { return procedureid; }
            set { procedureid = value; }
        }

        public string Paid
        {
            get { return paid; }
            set { paid = value; }
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

        public int InsertPatientHistory(PatientHistory DataObjectPatientHistory)
        {
            int insertedPatientHistoryId = -1;
            string query = "insert into patient_history(patient_id,appointment_id,doctor_id,procedure_id,date_created,created_by) values (@patient_id,@appointment_id,@doctor_id,@procedure_id,@date_created,@created_by)";
            SqlConnection con = objConnectionString.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter sp_patient_id = cmd.Parameters.Add("@patient_id", SqlDbType.Int, 10, "patient_id");
            SqlParameter sp_appointment_id = cmd.Parameters.Add("@appointment_id", SqlDbType.Int, 10, "appointment_id");
            SqlParameter sp_doctor_id = cmd.Parameters.Add("@doctor_id", SqlDbType.Int, 10, "doctor_id");
            SqlParameter sp_procedure_id = cmd.Parameters.Add("@procedure_id", SqlDbType.Int, 10, "procedure_id");
            SqlParameter sp_date_created = cmd.Parameters.Add("@date_created", SqlDbType.DateTime, 12, "date_created");
            SqlParameter sp_created_by = cmd.Parameters.Add("@created_by", SqlDbType.Int, 10, "created_by");

            sp_patient_id.Value = DataObjectPatientHistory.Patientid;
            sp_appointment_id.Value = DataObjectPatientHistory.Appointmentid;
            sp_doctor_id.Value = DataObjectPatientHistory.Doctorid;
            sp_procedure_id.Value = DataObjectPatientHistory.Procedureid;
            sp_date_created.Value = DataObjectPatientHistory.Datecreated;
            sp_created_by.Value = DataObjectPatientHistory.Createdby;
            int rowsReturned = cmd.ExecuteNonQuery();
            if (rowsReturned > 0)
            {
                insertedPatientHistoryId = GetPatientHistoryId(DataObjectPatientHistory);
            }
            con.Close();
            return insertedPatientHistoryId;
        }

        private int GetPatientHistoryId(PatientHistory DataObjectPatientHistory)
        {
            int patientHistoryId = -1;
            string query = "select patient_history_id from patient_history where patient_id=@patient_id and appointment_id=@appointment_id";
            SqlConnection con = objConnectionString.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter sp_patient_id = cmd.Parameters.Add("@patient_id", SqlDbType.Int, 10, "patient_id");
            SqlParameter sp_appointment_id = cmd.Parameters.Add("@appointment_id", SqlDbType.Int, 10, "appointment_id");

            sp_patient_id.Value = DataObjectPatientHistory.Patientid;
            sp_appointment_id.Value = DataObjectPatientHistory.Appointmentid;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                patientHistoryId = Convert.ToInt32(dr[0].ToString());
            }
            con.Close();
            return patientHistoryId;
        }

        public DataSet GetPatientDetails(PatientHistory DataObjectPatientHistory)
        {
            DataSet dsPatientDetails = new DataSet();
            string query = "select * from patient_history_view where patient_id=@patient_id";
            SqlConnection con = objConnectionString.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter sp_patient_id = cmd.Parameters.Add("@patient_id", SqlDbType.Int, 10, "patient_id");

            sp_patient_id.Value = DataObjectPatientHistory.Patientid;
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = cmd;
            adap.Fill(dsPatientDetails);
            con.Close();
            return dsPatientDetails;
        }

        public void UpdatePatientHistory(PatientHistory DataObjectPatientHistory)
        {
            string query = "update patient_history set paid=@paid, date_modified=@date_modified,modified_by=@modified_by where appointment_id=@appointment_id";
            SqlConnection con = objConnectionString.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter sp_paid = cmd.Parameters.Add("@paid", SqlDbType.VarChar, 1, "paid");
            SqlParameter sp_date_modified = cmd.Parameters.Add("@date_modified", SqlDbType.DateTime, 12, "date_modified");
            SqlParameter sp_modified_by = cmd.Parameters.Add("@modified_by", SqlDbType.Int, 10, "modified_by");
            SqlParameter sp_appointment_id = cmd.Parameters.Add("@appointment_id", SqlDbType.Int, 10, "appointment_id");

            sp_paid.Value = DataObjectPatientHistory.Paid;
            sp_date_modified.Value = DataObjectPatientHistory.Datemodified;
            sp_modified_by.Value = DataObjectPatientHistory.Modifiedby;
            sp_appointment_id.Value = DataObjectPatientHistory.Appointmentid;
            int rowsReturned = cmd.ExecuteNonQuery();
        }
    }
}
