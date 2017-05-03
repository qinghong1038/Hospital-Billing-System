using System;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace HospitalBillingSystem
{
    public partial class frmNewPatient : Form
    {
        private int sessionKey;

        ToolTip objToolTip = new ToolTip();
        Provience objProvience = new Provience();
        Procedure objProcedure = new Procedure();
        Doctor objDoctor = new Doctor();

        public frmNewPatient()
        {
            InitializeComponent();
            objProvience.GetProvienceList(cbProvience);
            objDoctor.GetDoctorsList(cbDoctor);
            objProcedure.GetProcedureList(lbProcedureList);
            Clear();
        }

        public void SessionKey(int skey)
        {
            this.sessionKey = skey;
        }

        private void frmNewPatient_Load(object sender, EventArgs e)
        {
            objToolTip.SetToolTip(txtFirstname, "Enter Firstname");
            objToolTip.SetToolTip(txtLastname, "Enter Lastname");
            objToolTip.SetToolTip(dtDateofbirth, "Enter Date of birth");
            objToolTip.SetToolTip(txtEmail, "Enter Email id");
            objToolTip.SetToolTip(txtContactNo, "Enter Contact No");
            objToolTip.SetToolTip(txtAppartmentNo, "Enter Appartment No");
            objToolTip.SetToolTip(txtStreet, "Enter Street");
            objToolTip.SetToolTip(txtCity, "Enter City");
            objToolTip.SetToolTip(cbProvience, "Select Provience");
            objToolTip.SetToolTip(txtPostalCode, "Enter Postal Code");
            objToolTip.SetToolTip(cbDoctor, "Select Doctor");
            objToolTip.SetToolTip(dtAppointmentDate, "Enter Appointment Date");
            objToolTip.SetToolTip(cbAppointmentTime, "Select Appointment Time");
            objToolTip.SetToolTip(lbProcedureList, "Select Procedure List");
            objToolTip.SetToolTip(btnBookAppointment, "Click here to Book Appointment");
            objToolTip.SetToolTip(btnReset, "Click here to Reset");
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                Patient objPatient = new Patient();
                objPatient.Firstname = txtFirstname.Text;
                objPatient.Lastname = txtLastname.Text;
                objPatient.Addresslineone = txtAppartmentNo.Text;
                objPatient.Addresslinetwo = txtStreet.Text;
                objPatient.City = txtCity.Text;
                objProvience.ProvienceDescription = cbProvience.SelectedItem.ToString();
                objPatient.ProvienceId = objProvience.GetProvienceId(objProvience);
                objPatient.Postalcode = txtPostalCode.Text;
                objPatient.Dob = dtDateofbirth.Value;
                objPatient.Email = txtEmail.Text;
                objPatient.Contactno = txtContactNo.Text;
                objPatient.Datecreated = System.DateTime.Now;
                objPatient.Createdby = this.sessionKey;
                int patientid = objPatient.InsertPatient(objPatient);
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
                Clear();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtFirstname.Text = "";
            txtLastname.Text = "";
            dtDateofbirth.Value = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
            txtEmail.Text = "";
            txtContactNo.Text = "";
            txtAppartmentNo.Text = "";
            txtStreet.Text = "";
            txtCity.Text = "";
            cbProvience.SelectedIndex = 0;
            txtPostalCode.Text = "";
            cbDoctor.SelectedIndex = 0;
            dtAppointmentDate.Value = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
            cbAppointmentTime.SelectedIndex = 0;
            lbProcedureList.ClearSelected();
            txtFirstname.Focus();
        }

        public Boolean valid()
        {
            return check_Textbox(txtFirstname, "Firstname is a required field.")
                && check_Textbox(txtLastname, "Lastname is a required field.")
                && check_Textbox(txtEmail, "Email id is a required field.")
                && check_Textbox(txtContactNo, "Contact No is a required field.")
                && check_Textbox(txtAppartmentNo, "Appartment No is a required field.")
                && check_Textbox(txtStreet, "Street name is a required field.")
                && check_Textbox(txtCity, "City is a required field.")
                && check_ComboBox(cbProvience, "Select Provience.")
                && check_Textbox(txtPostalCode, "Postal Code a required field.")
                && check_ComboBox(cbDoctor, "Select Doctor.")
                && check_ComboBox(cbAppointmentTime, "Select Appointment Time.")
                && check_ListBox(lbProcedureList, "Select Procedure.");
        }

        public Boolean check_Textbox(TextBox txtControl, string errMessage)
        {
            if (txtControl.Text == string.Empty)
            {
                DisplayMessage(errMessage, "Required Field", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtControl.Focus();
                return false;
            }
            else return true;
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
    }
}
