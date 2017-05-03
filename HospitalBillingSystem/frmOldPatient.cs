using System;
using System.Data;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace HospitalBillingSystem
{
    public partial class frmOldPatient : Form
    {
        private int sessionKey;
        ToolTip objToolTip = new ToolTip();
        Patient objPatient = new Patient();
        Doctor objDoctor = new Doctor();
        Procedure objProcedure = new Procedure();

        public frmOldPatient()
        {
            InitializeComponent();
            objPatient.GetPatientList(cbPatient);
            objDoctor.GetDoctorsList(cbDoctor);
            objProcedure.GetProcedureList(lbProcedureList);
            Clear();
            ClearPatientDetails();
        }

        public void SessionKey(int skey)
        {
            this.sessionKey = skey;
        }

        private void frmOldPatient_Load(object sender, EventArgs e)
        {
            objToolTip.SetToolTip(cbPatient, "Select Patient");
            objToolTip.SetToolTip(cbDoctor, "Select Doctor");
            objToolTip.SetToolTip(dtAppointmentDate, "Enter Appointment Date");
            objToolTip.SetToolTip(cbAppointmentTime, "Select Appointment Time");
            objToolTip.SetToolTip(lbProcedureList, "Select Procedure List");
            objToolTip.SetToolTip(btnBookAppointment, "Click here to Book Appointment");
            objToolTip.SetToolTip(btnReset, "Click here to Reset");
        }

        public void Clear()
        {
            panelPatientDetails.Visible = false;
            panelAppointment.Visible = false;
            cbPatient.SelectedIndex = 0;
            cbDoctor.SelectedIndex = 0;
            dtAppointmentDate.Value = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
            cbAppointmentTime.SelectedIndex = 0;
            lbProcedureList.ClearSelected();
        }

        public void ClearPatientDetails()
        {
            panelPatientDetails.Visible = false;
            panelAppointment.Visible = false;
            lblFirstnameValue.Text = string.Empty;
            lblAppartmentNoValue.Text = string.Empty;
            lblStreetNameValue.Text = string.Empty;
            lblCityValue.Text = string.Empty;
            lblProvienceValue.Text = string.Empty;
            lblPostalCodeValue.Text = string.Empty;
            lblDateofBirthValue.Text = string.Empty;
            lblEmailValue.Text = string.Empty;
            lblContactNoValue.Text = string.Empty;
        }

        public Boolean valid()
        {
            return check_ComboBox(cbPatient, "Select Patient.")
                && check_ComboBox(cbDoctor, "Select Doctor.")
                && check_ComboBox(cbAppointmentTime, "Select Appointment Time.")
                && check_ListBox(lbProcedureList, "Select Procedure.");
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

        public Boolean check_ListBox(ListBox lbControl, string errMessage)
        {
            if (lbControl.SelectedIndex == -1)
            {
                DisplayMessage(errMessage, "Required Field", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                lbControl.Focus();
                return false;
            }
            else return true;
        }

        public void DisplayMessage(string message, string caption, MessageBoxButtons msgBoxButton, MessageBoxIcon msgBoxIcon, MessageBoxDefaultButton msgBoxDefaultButton)
        {
            MessageBox.Show(message, caption, msgBoxButton, msgBoxIcon, msgBoxDefaultButton);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearPatientDetails();
            Clear();
        }

        private void cbPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPatient.SelectedIndex != 0)
            {
                PatientHistory objPatientHistory = new PatientHistory();
                objPatient.Firstname = cbPatient.SelectedItem.ToString().Split(' ')[0];
                objPatient.Lastname = cbPatient.SelectedItem.ToString().Split(' ')[1];

                objPatientHistory.Patientid = objPatient.GetPatientId(objPatient);
                DataSet dsPatientHistory = objPatientHistory.GetPatientDetails(objPatientHistory);
                if (dsPatientHistory.Tables[0].Rows.Count > 0)
                {
                    lblFirstnameValue.Text = dsPatientHistory.Tables[0].Rows[0]["PATIENT_NAME"].ToString();
                    lblAppartmentNoValue.Text = dsPatientHistory.Tables[0].Rows[0]["ADDRESS_LINE_1"].ToString();
                    lblStreetNameValue.Text = dsPatientHistory.Tables[0].Rows[0]["ADDRESS_LINE_2"].ToString();
                    lblCityValue.Text = dsPatientHistory.Tables[0].Rows[0]["CITY"].ToString();
                    lblProvienceValue.Text = dsPatientHistory.Tables[0].Rows[0]["PROVIENCE_DESCRIPTION"].ToString();
                    lblPostalCodeValue.Text = dsPatientHistory.Tables[0].Rows[0]["POSTAL_CODE"].ToString();
                    lblDateofBirthValue.Text = dsPatientHistory.Tables[0].Rows[0]["DOB"].ToString();
                    lblEmailValue.Text = dsPatientHistory.Tables[0].Rows[0]["EMAIL"].ToString();
                    lblContactNoValue.Text = dsPatientHistory.Tables[0].Rows[0]["CONTACT_NO"].ToString();
                    panelPatientDetails.Visible = true;
                    panelAppointment.Visible = true;
                }
            }
            else
            {
                ClearPatientDetails();
            }
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                objPatient.Firstname = cbPatient.SelectedItem.ToString().Split(' ')[0];
                objPatient.Lastname = cbPatient.SelectedItem.ToString().Split(' ')[1];
                int patientid = objPatient.GetPatientId(objPatient);
                if (patientid > 0)
                {
                    objDoctor.Firstname = cbDoctor.SelectedItem.ToString().Split(' ')[0];
                    objDoctor.Lastname = cbDoctor.SelectedItem.ToString().Split(' ')[1];
                    int doctorid = objDoctor.GetDoctorId(objDoctor);
                    if (doctorid > 0)
                    {
                        Appointment objAppointment = new Appointment();
                        objAppointment.Patientid = patientid;
                        objAppointment.Doctorid = doctorid;
                        objAppointment.Appointmentdate = dtAppointmentDate.Value;
                        objAppointment.Appointmenttime = cbAppointmentTime.SelectedItem.ToString();
                        objAppointment.Datecreated = System.DateTime.Now;
                        objAppointment.Createdby = this.sessionKey;
                        int appointmentid = objAppointment.InsertAppointment(objAppointment);
                        if (appointmentid > 0)
                        {
                            for (int i = 0; i < lbProcedureList.SelectedItems.Count; i++)
                            {
                                PatientHistory objPatientHistory = new PatientHistory();
                                objPatientHistory.Patientid = patientid;
                                objPatientHistory.Appointmentid = appointmentid;
                                objPatientHistory.Doctorid = doctorid;
                                objProcedure.Proceduredescription = lbProcedureList.SelectedItems[i].ToString();
                                objPatientHistory.Procedureid = objProcedure.GetProcedureId(objProcedure);
                                objPatientHistory.Datecreated = System.DateTime.Now;
                                objPatientHistory.Createdby = this.sessionKey;
                                int patienthistoryid = objPatientHistory.InsertPatientHistory(objPatientHistory);
                            }
                        }
                    }
                }
                DisplayMessage("Appointment Booked.", "Successful..!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                ClearPatientDetails();
                Clear();
            }
        }
    }
}
