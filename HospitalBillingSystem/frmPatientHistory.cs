using System;
using System.Data;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace HospitalBillingSystem
{
    public partial class frmPatientHistory : Form
    {
        private int sessionKey;
        ToolTip objToolTip = new ToolTip();
        Patient objPatient = new Patient();

        public frmPatientHistory()
        {
            InitializeComponent();
            objPatient.GetPatientList(cbPatient);
            Clear();
        }

        public void SessionKey(int skey)
        {
            this.sessionKey = skey;
        }

        private void frmPatientHistory_Load(object sender, EventArgs e)
        {
            objToolTip.SetToolTip(cbPatient, "Select Patient");
        }

        public void Clear()
        {
            cbPatient.SelectedIndex = 0;
        }

        public Boolean valid()
        {
            return check_ComboBox(cbPatient, "Select Patient.");
        }

        public Boolean check_ComboBox(ComboBox cbControl, string errMessage)
        {
            if (cbControl.SelectedIndex == 0)
            {
                DisplayMessage(errMessage, "Required Field", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                cbControl.Focus();
                return false;
            }
            else return true;
        }

        public void DisplayMessage(string message, string caption, MessageBoxButtons msgBoxButton, MessageBoxIcon msgBoxIcon, MessageBoxDefaultButton msgBoxDefaultButton)
        {
            MessageBox.Show(message, caption, msgBoxButton, msgBoxIcon, msgBoxDefaultButton);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                PatientHistory objPatientHistory = new PatientHistory();
                objPatient.Firstname = cbPatient.SelectedItem.ToString().Split(' ')[0];
                objPatient.Lastname = cbPatient.SelectedItem.ToString().Split(' ')[1];

                objPatientHistory.Patientid = objPatient.GetPatientId(objPatient);
                DataSet dsPatientHistory = objPatientHistory.GetPatientDetails(objPatientHistory);
                //dgvPatientHistory.DataSource = dsPatientHistory.Tables[0];
                DataTable dtPatientHistory = new DataTable("PATIENT_HISTORY");
                dtPatientHistory.Columns.Add("APPOINTMENT_ID");
                dtPatientHistory.Columns.Add("APPOINTMENT_DATE");
                dtPatientHistory.Columns.Add("PROCEDURE_DESCRIPTION");
                dtPatientHistory.Columns.Add("PAID");

                for (int i = 0; i < dsPatientHistory.Tables[0].Rows.Count; i++)
                {
                    DataRow row = dtPatientHistory.NewRow();
                    row["APPOINTMENT_ID"] = dsPatientHistory.Tables[0].Rows[i]["APPOINTMENT_ID"].ToString();
                    row["APPOINTMENT_DATE"] = dsPatientHistory.Tables[0].Rows[i]["APPOINTMENT_DATE"].ToString();
                    row["PROCEDURE_DESCRIPTION"] = dsPatientHistory.Tables[0].Rows[i]["PROCEDURE_DESCRIPTION"].ToString();
                    row["PAID"] = dsPatientHistory.Tables[0].Rows[i]["PAID"].ToString();
                    dtPatientHistory.Rows.Add(row);
                }
                dgvPatientHistory.DataSource = dtPatientHistory;
            }
        }
    }
}