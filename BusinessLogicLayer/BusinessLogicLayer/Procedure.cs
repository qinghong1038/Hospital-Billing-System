using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BusinessLogicLayer
{
    public class Procedure
    {
        ConnectionString objConnectionString = new ConnectionString();
        private int procedureid;
        private string proceduredescription;
        private int procedurecost;
        private DateTime datecreated;
        private int createdby;
        private DateTime datemodified;
        private int modifiedby;

        public int Procedureid
        {
            get { return procedureid; }
            set { procedureid = value; }
        }

        public string Proceduredescription
        {
            get { return proceduredescription; }
            set { proceduredescription = value; }
        }

        public int Procedurecost
        {
            get { return procedurecost; }
            set { procedurecost = value; }
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

        public void GetProcedureList(ListBox lbProcedureList)
        {
            string query = "select procedure_id,procedure_description from procedure_info";
            SqlConnection con = objConnectionString.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lbProcedureList.Items.Add(dr[1].ToString());
            }
            con.Close();
        }

        public int GetProcedureId(Procedure DataObjectProcedure)
        {
            int procedureid = -1;
            string query = "select procedure_id from procedure_info where procedure_description=@procedure_description";
            SqlConnection con = objConnectionString.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter sp_procedure_description = cmd.Parameters.Add("@procedure_description", SqlDbType.VarChar, 50, "procedure_description");
            sp_procedure_description.Value = DataObjectProcedure.Proceduredescription;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                procedureid = Convert.ToInt32(dr[0].ToString());
            }
            con.Close();
            return procedureid;
        }

        public string GetProcedureDescription(Procedure DataObjectProcedure)
        {
            string procedure_description = string.Empty;
            string query = "select procedure_description from procedure_info where procedure_id=@procedure_id";
            SqlConnection con = objConnectionString.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter sp_procedure_id = cmd.Parameters.Add("@procedure_id", SqlDbType.Int, 10, "procedure_id");

            sp_procedure_id.Value = DataObjectProcedure.Procedureid;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                procedure_description = dr[0].ToString();
            }
            con.Close();
            return procedure_description;
        }
    }
}
