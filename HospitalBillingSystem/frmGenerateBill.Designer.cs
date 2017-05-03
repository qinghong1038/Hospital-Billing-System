namespace HospitalBillingSystem
{
    partial class frmGenerateBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPatientHistory = new System.Windows.Forms.Panel();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblSelectAppointment = new System.Windows.Forms.Label();
            this.cbAppointmentDetails = new System.Windows.Forms.ComboBox();
            this.panelAppointmentDetails = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblDateofBirthValue = new System.Windows.Forms.Label();
            this.lblDateofbirth = new System.Windows.Forms.Label();
            this.lblAppointmentDateValue = new System.Windows.Forms.Label();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.lblAppointmentIdValue = new System.Windows.Forms.Label();
            this.lblAppointmentId = new System.Windows.Forms.Label();
            this.lblPatientNameValue = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.chkPaid = new System.Windows.Forms.CheckBox();
            this.lblPaid = new System.Windows.Forms.Label();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelPatientHistory.SuspendLayout();
            this.panelAppointmentDetails.SuspendLayout();
            this.panelPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPatientHistory
            // 
            this.panelPatientHistory.BackColor = System.Drawing.Color.Transparent;
            this.panelPatientHistory.Controls.Add(this.lblMainTitle);
            this.panelPatientHistory.Controls.Add(this.lblSelectAppointment);
            this.panelPatientHistory.Controls.Add(this.cbAppointmentDetails);
            this.panelPatientHistory.Location = new System.Drawing.Point(12, 12);
            this.panelPatientHistory.Name = "panelPatientHistory";
            this.panelPatientHistory.Size = new System.Drawing.Size(513, 91);
            this.panelPatientHistory.TabIndex = 10;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.lblMainTitle.Location = new System.Drawing.Point(13, 12);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(231, 32);
            this.lblMainTitle.TabIndex = 5;
            this.lblMainTitle.Text = "Appointment History";
            // 
            // lblSelectAppointment
            // 
            this.lblSelectAppointment.AutoSize = true;
            this.lblSelectAppointment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectAppointment.Location = new System.Drawing.Point(28, 55);
            this.lblSelectAppointment.Name = "lblSelectAppointment";
            this.lblSelectAppointment.Size = new System.Drawing.Size(170, 23);
            this.lblSelectAppointment.TabIndex = 7;
            this.lblSelectAppointment.Text = "Select Appointment :";
            // 
            // cbAppointmentDetails
            // 
            this.cbAppointmentDetails.FormattingEnabled = true;
            this.cbAppointmentDetails.ItemHeight = 16;
            this.cbAppointmentDetails.Location = new System.Drawing.Point(216, 54);
            this.cbAppointmentDetails.Name = "cbAppointmentDetails";
            this.cbAppointmentDetails.Size = new System.Drawing.Size(271, 24);
            this.cbAppointmentDetails.TabIndex = 6;
            this.cbAppointmentDetails.SelectedIndexChanged += new System.EventHandler(this.cbAppointmentDetails_SelectedIndexChanged);
            // 
            // panelAppointmentDetails
            // 
            this.panelAppointmentDetails.BackColor = System.Drawing.Color.Transparent;
            this.panelAppointmentDetails.Controls.Add(this.lblTitle);
            this.panelAppointmentDetails.Controls.Add(this.lblSubTitle);
            this.panelAppointmentDetails.Controls.Add(this.lblDateofBirthValue);
            this.panelAppointmentDetails.Controls.Add(this.lblDateofbirth);
            this.panelAppointmentDetails.Controls.Add(this.lblAppointmentDateValue);
            this.panelAppointmentDetails.Controls.Add(this.lblAppointmentDate);
            this.panelAppointmentDetails.Controls.Add(this.lblAppointmentIdValue);
            this.panelAppointmentDetails.Controls.Add(this.lblAppointmentId);
            this.panelAppointmentDetails.Controls.Add(this.lblPatientNameValue);
            this.panelAppointmentDetails.Controls.Add(this.lblPatientName);
            this.panelAppointmentDetails.Location = new System.Drawing.Point(12, 109);
            this.panelAppointmentDetails.Name = "panelAppointmentDetails";
            this.panelAppointmentDetails.Size = new System.Drawing.Size(943, 559);
            this.panelAppointmentDetails.TabIndex = 11;
            this.panelAppointmentDetails.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(373, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(223, 32);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "MEDANTA Medicity";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.lblSubTitle.Location = new System.Drawing.Point(410, 46);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(151, 28);
            this.lblSubTitle.TabIndex = 8;
            this.lblSubTitle.Text = "dedicated to life";
            // 
            // lblDateofBirthValue
            // 
            this.lblDateofBirthValue.AutoSize = true;
            this.lblDateofBirthValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateofBirthValue.Location = new System.Drawing.Point(721, 126);
            this.lblDateofBirthValue.Name = "lblDateofBirthValue";
            this.lblDateofBirthValue.Size = new System.Drawing.Size(14, 23);
            this.lblDateofBirthValue.TabIndex = 9;
            this.lblDateofBirthValue.Text = ":";
            // 
            // lblDateofbirth
            // 
            this.lblDateofbirth.AutoSize = true;
            this.lblDateofbirth.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateofbirth.Location = new System.Drawing.Point(590, 126);
            this.lblDateofbirth.Name = "lblDateofbirth";
            this.lblDateofbirth.Size = new System.Drawing.Size(125, 23);
            this.lblDateofbirth.TabIndex = 8;
            this.lblDateofbirth.Text = "Date of birth :";
            // 
            // lblAppointmentDateValue
            // 
            this.lblAppointmentDateValue.AutoSize = true;
            this.lblAppointmentDateValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDateValue.Location = new System.Drawing.Point(721, 93);
            this.lblAppointmentDateValue.Name = "lblAppointmentDateValue";
            this.lblAppointmentDateValue.Size = new System.Drawing.Size(14, 23);
            this.lblAppointmentDateValue.TabIndex = 7;
            this.lblAppointmentDateValue.Text = ":";
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDate.Location = new System.Drawing.Point(544, 93);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(171, 23);
            this.lblAppointmentDate.TabIndex = 6;
            this.lblAppointmentDate.Text = "Appointment Date :";
            // 
            // lblAppointmentIdValue
            // 
            this.lblAppointmentIdValue.AutoSize = true;
            this.lblAppointmentIdValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentIdValue.Location = new System.Drawing.Point(251, 93);
            this.lblAppointmentIdValue.Name = "lblAppointmentIdValue";
            this.lblAppointmentIdValue.Size = new System.Drawing.Size(14, 23);
            this.lblAppointmentIdValue.TabIndex = 5;
            this.lblAppointmentIdValue.Text = ":";
            // 
            // lblAppointmentId
            // 
            this.lblAppointmentId.AutoSize = true;
            this.lblAppointmentId.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentId.Location = new System.Drawing.Point(96, 93);
            this.lblAppointmentId.Name = "lblAppointmentId";
            this.lblAppointmentId.Size = new System.Drawing.Size(149, 23);
            this.lblAppointmentId.TabIndex = 4;
            this.lblAppointmentId.Text = "Appointment Id :";
            // 
            // lblPatientNameValue
            // 
            this.lblPatientNameValue.AutoSize = true;
            this.lblPatientNameValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientNameValue.Location = new System.Drawing.Point(251, 126);
            this.lblPatientNameValue.Name = "lblPatientNameValue";
            this.lblPatientNameValue.Size = new System.Drawing.Size(14, 23);
            this.lblPatientNameValue.TabIndex = 3;
            this.lblPatientNameValue.Text = ":";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(116, 126);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(129, 23);
            this.lblPatientName.TabIndex = 2;
            this.lblPatientName.Text = "Patient Name :";
            // 
            // chkPaid
            // 
            this.chkPaid.AutoSize = true;
            this.chkPaid.BackColor = System.Drawing.Color.Transparent;
            this.chkPaid.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPaid.Location = new System.Drawing.Point(32, 52);
            this.chkPaid.Name = "chkPaid";
            this.chkPaid.Size = new System.Drawing.Size(64, 27);
            this.chkPaid.TabIndex = 12;
            this.chkPaid.Text = "Paid";
            this.chkPaid.UseVisualStyleBackColor = false;
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.BackColor = System.Drawing.Color.Transparent;
            this.lblPaid.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.lblPaid.Location = new System.Drawing.Point(13, 12);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(189, 32);
            this.lblPaid.TabIndex = 5;
            this.lblPaid.Text = "Payment History";
            // 
            // panelPayment
            // 
            this.panelPayment.BackColor = System.Drawing.Color.Transparent;
            this.panelPayment.Controls.Add(this.btnSave);
            this.panelPayment.Controls.Add(this.lblPaid);
            this.panelPayment.Controls.Add(this.chkPaid);
            this.panelPayment.Location = new System.Drawing.Point(626, 12);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new System.Drawing.Size(329, 91);
            this.panelPayment.TabIndex = 11;
            this.panelPayment.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(111, 47);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmGenerateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HospitalBillingSystem.Properties.Resources.appt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 1003);
            this.Controls.Add(this.panelPayment);
            this.Controls.Add(this.panelAppointmentDetails);
            this.Controls.Add(this.panelPatientHistory);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmGenerateBill";
            this.Text = "Generate Bill";
            this.Load += new System.EventHandler(this.frmGenerateBill_Load);
            this.panelPatientHistory.ResumeLayout(false);
            this.panelPatientHistory.PerformLayout();
            this.panelAppointmentDetails.ResumeLayout(false);
            this.panelAppointmentDetails.PerformLayout();
            this.panelPayment.ResumeLayout(false);
            this.panelPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPatientHistory;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblSelectAppointment;
        private System.Windows.Forms.ComboBox cbAppointmentDetails;
        private System.Windows.Forms.Panel panelAppointmentDetails;
        private System.Windows.Forms.Label lblAppointmentIdValue;
        private System.Windows.Forms.Label lblAppointmentId;
        private System.Windows.Forms.Label lblPatientNameValue;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblDateofBirthValue;
        private System.Windows.Forms.Label lblDateofbirth;
        private System.Windows.Forms.Label lblAppointmentDateValue;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox chkPaid;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Panel panelPayment;
        private System.Windows.Forms.Button btnSave;
    }
}