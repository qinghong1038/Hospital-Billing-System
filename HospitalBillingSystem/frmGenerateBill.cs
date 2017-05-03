using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace HospitalBillingSystem
{
    public partial class frmGenerateBill : Form
    {
        private int sessionKey;
        ToolTip objToolTip = new ToolTip();
        Appointment objAppointment = new Appointment();
        TableLayoutPanel tlpProcedureDetails = new TableLayoutPanel();
        const decimal HST = .13m;

        public frmGenerateBill()
        {
            InitializeComponent();
            objAppointment.GetAppointmentList(cbAppointmentDetails);
            Clear();
            ClearAppointmentDetails();
        }

        public void SessionKey(int skey)
        {
            this.sessionKey = skey;
        }

        private void frmGenerateBill_Load(object sender, EventArgs e)
        {
            objToolTip.SetToolTip(cbAppointmentDetails, "Select Appointment");
            objToolTip.SetToolTip(btnSave, "Click here to Save Bill");
        }

        public void Clear()
        {
            panelAppointmentDetails.Visible = false;
            panelPayment.Visible = false;
            cbAppointmentDetails.SelectedIndex = 0;
            chkPaid.Checked = false;
        }

        public void ClearAppointmentDetails()
        {
            panelAppointmentDetails.Visible = false;
            lblPatientNameValue.Text = "";
            lblDateofBirthValue.Text = "";
            lblAppointmentIdValue.Text = "";
            lblAppointmentDateValue.Text = "";
        }

        public Boolean valid()
        {
            return check_ComboBox(cbAppointmentDetails, "Select Appointment.")
                && check_CheckBox(chkPaid, "Please Check Paid Option.");
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

        public Boolean check_CheckBox(CheckBox chkControl, string errMessage)
        {
            if (chkControl.Checked == false)
            {
                DisplayMessage(errMessage, "Required Field", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                chkControl.Focus();
                return false;
            }
            else return true;
        }

        public void DisplayMessage(string message, string caption, MessageBoxButtons msgBoxButton, MessageBoxIcon msgBoxIcon, MessageBoxDefaultButton msgBoxDefaultButton)
        {
            MessageBox.Show(message, caption, msgBoxButton, msgBoxIcon, msgBoxDefaultButton);
        }

        private void cbAppointmentDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAppointmentDetails.SelectedIndex != 0)
            {
                string selectedValue = cbAppointmentDetails.SelectedItem.ToString().Split('|')[0].Trim();
                objAppointment.Appointmentid = Convert.ToInt32(selectedValue);
                DataSet dsAppointmentDetails = objAppointment.GetAppointmentDetails(objAppointment);
                lblAppointmentIdValue.Text = dsAppointmentDetails.Tables[0].Rows[0]["APPOINTMENT_ID"].ToString();
                lblAppointmentDateValue.Text = dsAppointmentDetails.Tables[0].Rows[0]["APPOINTMENT_DATE"].ToString();
                lblPatientNameValue.Text = dsAppointmentDetails.Tables[0].Rows[0]["PATIENT_NAME"].ToString();
                lblDateofBirthValue.Text = dsAppointmentDetails.Tables[0].Rows[0]["DOB"].ToString();
                LoadProcedureList(dsAppointmentDetails);
                panelAppointmentDetails.Visible = true;
                panelPayment.Visible = true;
            }
            else
            {
                ClearAppointmentDetails();
                Clear();
            }
        }

        public void LoadProcedureList(DataSet ds)
        {
            tlpProcedureDetails.Dispose();
            if (!IsDisposed)
            {
                int row = 0;
                decimal subTotal = 0m;
                decimal hstTolal = 0m;
                decimal grandTotal = 0m;
                tlpProcedureDetails = new TableLayoutPanel();
                tlpProcedureDetails.ColumnCount = 3;
                tlpProcedureDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
                tlpProcedureDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                tlpProcedureDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
                tlpProcedureDetails.Location = new System.Drawing.Point(108, 150);
                tlpProcedureDetails.Name = "tlpProcedureDetails";
                tlpProcedureDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
                tlpProcedureDetails.Size = new System.Drawing.Size(600, 150);

                tlpProcedureDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                tlpProcedureDetails.Controls.Add(new Label() { Text = "Procedure Code", Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), AutoSize = true, TextAlign = ContentAlignment.MiddleCenter }, 0, 0);
                tlpProcedureDetails.Controls.Add(new Label() { Text = "Description", Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), AutoSize = true, TextAlign = ContentAlignment.MiddleCenter }, 1, 0);
                tlpProcedureDetails.Controls.Add(new Label() { Text = "Price", Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), AutoSize = true, TextAlign = ContentAlignment.BottomRight }, 2, 0);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    int rownum = ++row;
                    tlpProcedureDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                    tlpProcedureDetails.Controls.Add(new Label() { Text = ds.Tables[0].Rows[i]["PROCEDURE_ID"].ToString(), AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))) }, 0, rownum);
                    tlpProcedureDetails.Controls.Add(new Label() { Text = ds.Tables[0].Rows[i]["PROCEDURE_DESCRIPTION"].ToString(), AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))) }, 1, rownum);
                    tlpProcedureDetails.Controls.Add(new Label() { Text = ds.Tables[0].Rows[i]["PROCEDURE_COST"].ToString(), AutoSize = true, TextAlign = ContentAlignment.BottomRight, Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))) }, 2, rownum);
                    subTotal += Convert.ToDecimal(ds.Tables[0].Rows[i]["PROCEDURE_COST"].ToString());
                }

                int blankRowNum = ++row;
                tlpProcedureDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                tlpProcedureDetails.Controls.Add(new Label() { Text = "" }, 0, blankRowNum);
                tlpProcedureDetails.Controls.Add(new Label() { Text = "" }, 1, blankRowNum);
                tlpProcedureDetails.Controls.Add(new Label() { Text = "" }, 2, blankRowNum);

                int subTotalRowNum = ++row;
                tlpProcedureDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                tlpProcedureDetails.Controls.Add(new Label() { Text = "" }, 0, subTotalRowNum);
                tlpProcedureDetails.Controls.Add(new Label() { Text = "Subtotal : ", TextAlign = ContentAlignment.BottomRight, Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))) }, 1, subTotalRowNum);
                tlpProcedureDetails.Controls.Add(new Label() { Text = subTotal.ToString("c2"), Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))) }, 2, subTotalRowNum);

                int hstRowNum = ++row;
                hstTolal = (HST * subTotal);
                tlpProcedureDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                tlpProcedureDetails.Controls.Add(new Label() { Text = "" }, 0, hstRowNum);
                tlpProcedureDetails.Controls.Add(new Label() { Text = "HST (13%) : ", TextAlign = ContentAlignment.BottomRight, Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))) }, 1, hstRowNum);
                tlpProcedureDetails.Controls.Add(new Label() { Text = hstTolal.ToString("c2"), Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))) }, 2, hstRowNum);

                int totalRowNum = ++row;
                grandTotal = subTotal + hstTolal;
                tlpProcedureDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                tlpProcedureDetails.Controls.Add(new Label() { Text = "" }, 0, totalRowNum);
                tlpProcedureDetails.Controls.Add(new Label() { Text = "Total : ", TextAlign = ContentAlignment.BottomRight, Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))) }, 1, totalRowNum);
                tlpProcedureDetails.Controls.Add(new Label() { Text = grandTotal.ToString("c2"), Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))) }, 2, totalRowNum);

                panelAppointmentDetails.Controls.Add(tlpProcedureDetails);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                PatientHistory objPatientHistory = new PatientHistory();
                objPatientHistory.Paid = "Y";
                objPatientHistory.Datemodified = System.DateTime.Now;
                objPatientHistory.Modifiedby = this.sessionKey;
                objPatientHistory.Appointmentid = Convert.ToInt32(cbAppointmentDetails.SelectedItem.ToString().Split('|')[0].Trim());
                objPatientHistory.UpdatePatientHistory(objPatientHistory);
                DisplayMessage("Payment Done.", "Successful..!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                ClearAppointmentDetails();
                Clear();
                objAppointment.GetAppointmentList(cbAppointmentDetails);
            }
        }
    }
}
