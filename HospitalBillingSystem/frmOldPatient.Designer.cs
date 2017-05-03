namespace HospitalBillingSystem
{
    partial class frmOldPatient
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
            this.lblSelectPatient = new System.Windows.Forms.Label();
            this.cbPatient = new System.Windows.Forms.ComboBox();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.panelPatientHistory = new System.Windows.Forms.Panel();
            this.panelPatientDetails = new System.Windows.Forms.Panel();
            this.lblPostalCodeValue = new System.Windows.Forms.Label();
            this.lblProvienceValue = new System.Windows.Forms.Label();
            this.lblCityValue = new System.Windows.Forms.Label();
            this.lblStreetNameValue = new System.Windows.Forms.Label();
            this.lblAppartmentNoValue = new System.Windows.Forms.Label();
            this.lblContactNoValue = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblEmailValue = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDateofBirthValue = new System.Windows.Forms.Label();
            this.lblDateofbirth = new System.Windows.Forms.Label();
            this.lblFirstnameValue = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.panelAppointment = new System.Windows.Forms.Panel();
            this.cbAppointmentTime = new System.Windows.Forms.ComboBox();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.dtAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBookAppointment = new System.Windows.Forms.Button();
            this.lblProcedure = new System.Windows.Forms.Label();
            this.lbProcedureList = new System.Windows.Forms.ListBox();
            this.lblAppointmentTime = new System.Windows.Forms.Label();
            this.cbDoctor = new System.Windows.Forms.ComboBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.panelPatientHistory.SuspendLayout();
            this.panelPatientDetails.SuspendLayout();
            this.panelAppointment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectPatient
            // 
            this.lblSelectPatient.AutoSize = true;
            this.lblSelectPatient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectPatient.Location = new System.Drawing.Point(28, 55);
            this.lblSelectPatient.Name = "lblSelectPatient";
            this.lblSelectPatient.Size = new System.Drawing.Size(122, 23);
            this.lblSelectPatient.TabIndex = 7;
            this.lblSelectPatient.Text = "Select Patient :";
            // 
            // cbPatient
            // 
            this.cbPatient.FormattingEnabled = true;
            this.cbPatient.ItemHeight = 16;
            this.cbPatient.Location = new System.Drawing.Point(166, 54);
            this.cbPatient.Name = "cbPatient";
            this.cbPatient.Size = new System.Drawing.Size(271, 24);
            this.cbPatient.TabIndex = 6;
            this.cbPatient.SelectedIndexChanged += new System.EventHandler(this.cbPatient_SelectedIndexChanged);
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.lblMainTitle.Location = new System.Drawing.Point(13, 12);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(170, 32);
            this.lblMainTitle.TabIndex = 5;
            this.lblMainTitle.Text = "Patient History";
            // 
            // panelPatientHistory
            // 
            this.panelPatientHistory.BackColor = System.Drawing.Color.Transparent;
            this.panelPatientHistory.Controls.Add(this.lblMainTitle);
            this.panelPatientHistory.Controls.Add(this.lblSelectPatient);
            this.panelPatientHistory.Controls.Add(this.cbPatient);
            this.panelPatientHistory.Location = new System.Drawing.Point(12, 12);
            this.panelPatientHistory.Name = "panelPatientHistory";
            this.panelPatientHistory.Size = new System.Drawing.Size(673, 91);
            this.panelPatientHistory.TabIndex = 9;
            // 
            // panelPatientDetails
            // 
            this.panelPatientDetails.BackColor = System.Drawing.Color.Transparent;
            this.panelPatientDetails.Controls.Add(this.lblPostalCodeValue);
            this.panelPatientDetails.Controls.Add(this.lblProvienceValue);
            this.panelPatientDetails.Controls.Add(this.lblCityValue);
            this.panelPatientDetails.Controls.Add(this.lblStreetNameValue);
            this.panelPatientDetails.Controls.Add(this.lblAppartmentNoValue);
            this.panelPatientDetails.Controls.Add(this.lblContactNoValue);
            this.panelPatientDetails.Controls.Add(this.lblContactNo);
            this.panelPatientDetails.Controls.Add(this.lblEmailValue);
            this.panelPatientDetails.Controls.Add(this.lblEmail);
            this.panelPatientDetails.Controls.Add(this.lblAddress);
            this.panelPatientDetails.Controls.Add(this.lblDateofBirthValue);
            this.panelPatientDetails.Controls.Add(this.lblDateofbirth);
            this.panelPatientDetails.Controls.Add(this.lblFirstnameValue);
            this.panelPatientDetails.Controls.Add(this.lblFirstname);
            this.panelPatientDetails.Location = new System.Drawing.Point(12, 109);
            this.panelPatientDetails.Name = "panelPatientDetails";
            this.panelPatientDetails.Size = new System.Drawing.Size(1024, 196);
            this.panelPatientDetails.TabIndex = 10;
            this.panelPatientDetails.Visible = false;
            // 
            // lblPostalCodeValue
            // 
            this.lblPostalCodeValue.AutoSize = true;
            this.lblPostalCodeValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalCodeValue.Location = new System.Drawing.Point(155, 136);
            this.lblPostalCodeValue.Name = "lblPostalCodeValue";
            this.lblPostalCodeValue.Size = new System.Drawing.Size(14, 23);
            this.lblPostalCodeValue.TabIndex = 13;
            this.lblPostalCodeValue.Text = ":";
            // 
            // lblProvienceValue
            // 
            this.lblProvienceValue.AutoSize = true;
            this.lblProvienceValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvienceValue.Location = new System.Drawing.Point(155, 113);
            this.lblProvienceValue.Name = "lblProvienceValue";
            this.lblProvienceValue.Size = new System.Drawing.Size(14, 23);
            this.lblProvienceValue.TabIndex = 12;
            this.lblProvienceValue.Text = ":";
            // 
            // lblCityValue
            // 
            this.lblCityValue.AutoSize = true;
            this.lblCityValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityValue.Location = new System.Drawing.Point(155, 90);
            this.lblCityValue.Name = "lblCityValue";
            this.lblCityValue.Size = new System.Drawing.Size(14, 23);
            this.lblCityValue.TabIndex = 11;
            this.lblCityValue.Text = ":";
            // 
            // lblStreetNameValue
            // 
            this.lblStreetNameValue.AutoSize = true;
            this.lblStreetNameValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetNameValue.Location = new System.Drawing.Point(155, 67);
            this.lblStreetNameValue.Name = "lblStreetNameValue";
            this.lblStreetNameValue.Size = new System.Drawing.Size(14, 23);
            this.lblStreetNameValue.TabIndex = 10;
            this.lblStreetNameValue.Text = ":";
            // 
            // lblAppartmentNoValue
            // 
            this.lblAppartmentNoValue.AutoSize = true;
            this.lblAppartmentNoValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppartmentNoValue.Location = new System.Drawing.Point(155, 44);
            this.lblAppartmentNoValue.Name = "lblAppartmentNoValue";
            this.lblAppartmentNoValue.Size = new System.Drawing.Size(14, 23);
            this.lblAppartmentNoValue.TabIndex = 9;
            this.lblAppartmentNoValue.Text = ":";
            // 
            // lblContactNoValue
            // 
            this.lblContactNoValue.AutoSize = true;
            this.lblContactNoValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNoValue.Location = new System.Drawing.Point(686, 78);
            this.lblContactNoValue.Name = "lblContactNoValue";
            this.lblContactNoValue.Size = new System.Drawing.Size(14, 23);
            this.lblContactNoValue.TabIndex = 8;
            this.lblContactNoValue.Text = ":";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.Location = new System.Drawing.Point(573, 78);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(107, 23);
            this.lblContactNo.TabIndex = 7;
            this.lblContactNo.Text = "Contact No :";
            // 
            // lblEmailValue
            // 
            this.lblEmailValue.AutoSize = true;
            this.lblEmailValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailValue.Location = new System.Drawing.Point(686, 44);
            this.lblEmailValue.Name = "lblEmailValue";
            this.lblEmailValue.Size = new System.Drawing.Size(14, 23);
            this.lblEmailValue.TabIndex = 6;
            this.lblEmailValue.Text = ":";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(620, 44);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 23);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(70, 44);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(79, 23);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address :";
            // 
            // lblDateofBirthValue
            // 
            this.lblDateofBirthValue.AutoSize = true;
            this.lblDateofBirthValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateofBirthValue.Location = new System.Drawing.Point(686, 11);
            this.lblDateofBirthValue.Name = "lblDateofBirthValue";
            this.lblDateofBirthValue.Size = new System.Drawing.Size(14, 23);
            this.lblDateofBirthValue.TabIndex = 3;
            this.lblDateofBirthValue.Text = ":";
            // 
            // lblDateofbirth
            // 
            this.lblDateofbirth.AutoSize = true;
            this.lblDateofbirth.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateofbirth.Location = new System.Drawing.Point(564, 11);
            this.lblDateofbirth.Name = "lblDateofbirth";
            this.lblDateofbirth.Size = new System.Drawing.Size(116, 23);
            this.lblDateofbirth.TabIndex = 2;
            this.lblDateofbirth.Text = "Date of birth :";
            // 
            // lblFirstnameValue
            // 
            this.lblFirstnameValue.AutoSize = true;
            this.lblFirstnameValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstnameValue.Location = new System.Drawing.Point(155, 11);
            this.lblFirstnameValue.Name = "lblFirstnameValue";
            this.lblFirstnameValue.Size = new System.Drawing.Size(14, 23);
            this.lblFirstnameValue.TabIndex = 1;
            this.lblFirstnameValue.Text = ":";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(56, 11);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(93, 23);
            this.lblFirstname.TabIndex = 0;
            this.lblFirstname.Text = "Firstname :";
            // 
            // panelAppointment
            // 
            this.panelAppointment.BackColor = System.Drawing.Color.Transparent;
            this.panelAppointment.Controls.Add(this.cbAppointmentTime);
            this.panelAppointment.Controls.Add(this.lblAppointmentDate);
            this.panelAppointment.Controls.Add(this.dtAppointmentDate);
            this.panelAppointment.Controls.Add(this.btnReset);
            this.panelAppointment.Controls.Add(this.btnBookAppointment);
            this.panelAppointment.Controls.Add(this.lblProcedure);
            this.panelAppointment.Controls.Add(this.lbProcedureList);
            this.panelAppointment.Controls.Add(this.lblAppointmentTime);
            this.panelAppointment.Controls.Add(this.cbDoctor);
            this.panelAppointment.Controls.Add(this.lblDoctor);
            this.panelAppointment.Controls.Add(this.lblSubTitle);
            this.panelAppointment.Location = new System.Drawing.Point(12, 314);
            this.panelAppointment.Name = "panelAppointment";
            this.panelAppointment.Size = new System.Drawing.Size(1025, 339);
            this.panelAppointment.TabIndex = 11;
            this.panelAppointment.Visible = false;
            // 
            // cbAppointmentTime
            // 
            this.cbAppointmentTime.FormattingEnabled = true;
            this.cbAppointmentTime.Items.AddRange(new object[] {
            "Select",
            "12 AM",
            "1 AM",
            "2AM",
            "3 AM",
            "4 AM",
            "5 AM",
            "6 AM",
            "7 AM",
            "8 AM",
            "9 AM",
            "10 AM",
            "11 AM",
            "12 PM",
            "1 PM",
            "2 PM",
            "3 PM",
            "4 PM",
            "5 PM",
            "6 PM",
            "7 PM",
            "8 PM",
            "9 PM",
            "10 PM",
            "11 PM"});
            this.cbAppointmentTime.Location = new System.Drawing.Point(871, 58);
            this.cbAppointmentTime.Name = "cbAppointmentTime";
            this.cbAppointmentTime.Size = new System.Drawing.Size(87, 24);
            this.cbAppointmentTime.TabIndex = 36;
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDate.Location = new System.Drawing.Point(339, 54);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(161, 23);
            this.lblAppointmentDate.TabIndex = 33;
            this.lblAppointmentDate.Text = "Appointment Date :";
            // 
            // dtAppointmentDate
            // 
            this.dtAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAppointmentDate.Location = new System.Drawing.Point(513, 56);
            this.dtAppointmentDate.Name = "dtAppointmentDate";
            this.dtAppointmentDate.Size = new System.Drawing.Size(161, 22);
            this.dtAppointmentDate.TabIndex = 34;
            this.dtAppointmentDate.Value = new System.DateTime(2017, 4, 7, 0, 0, 0, 0);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReset.Location = new System.Drawing.Point(457, 272);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 40);
            this.btnReset.TabIndex = 40;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookAppointment.Location = new System.Drawing.Point(188, 272);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(248, 40);
            this.btnBookAppointment.TabIndex = 39;
            this.btnBookAppointment.Text = "Book Appointment";
            this.btnBookAppointment.UseVisualStyleBackColor = true;
            this.btnBookAppointment.Click += new System.EventHandler(this.btnBookAppointment_Click);
            // 
            // lblProcedure
            // 
            this.lblProcedure.AutoSize = true;
            this.lblProcedure.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcedure.Location = new System.Drawing.Point(44, 94);
            this.lblProcedure.Name = "lblProcedure";
            this.lblProcedure.Size = new System.Drawing.Size(97, 23);
            this.lblProcedure.TabIndex = 37;
            this.lblProcedure.Text = "Procedure :";
            // 
            // lbProcedureList
            // 
            this.lbProcedureList.FormattingEnabled = true;
            this.lbProcedureList.ItemHeight = 16;
            this.lbProcedureList.Location = new System.Drawing.Point(155, 94);
            this.lbProcedureList.Name = "lbProcedureList";
            this.lbProcedureList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbProcedureList.Size = new System.Drawing.Size(803, 164);
            this.lbProcedureList.Sorted = true;
            this.lbProcedureList.TabIndex = 38;
            // 
            // lblAppointmentTime
            // 
            this.lblAppointmentTime.AutoSize = true;
            this.lblAppointmentTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentTime.Location = new System.Drawing.Point(693, 55);
            this.lblAppointmentTime.Name = "lblAppointmentTime";
            this.lblAppointmentTime.Size = new System.Drawing.Size(162, 23);
            this.lblAppointmentTime.TabIndex = 35;
            this.lblAppointmentTime.Text = "Appointment Time :";
            // 
            // cbDoctor
            // 
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.Location = new System.Drawing.Point(155, 56);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(178, 24);
            this.cbDoctor.TabIndex = 32;
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.Location = new System.Drawing.Point(70, 57);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(71, 23);
            this.lblDoctor.TabIndex = 31;
            this.lblDoctor.Text = "Doctor :";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.lblSubTitle.Location = new System.Drawing.Point(13, 12);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(279, 32);
            this.lblSubTitle.TabIndex = 22;
            this.lblSubTitle.Text = "Appointment Information";
            // 
            // frmOldPatient
            // 
            this.AcceptButton = this.btnBookAppointment;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HospitalBillingSystem.Properties.Resources.appt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 1003);
            this.Controls.Add(this.panelAppointment);
            this.Controls.Add(this.panelPatientDetails);
            this.Controls.Add(this.panelPatientHistory);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmOldPatient";
            this.Text = "Old Patient";
            this.Load += new System.EventHandler(this.frmOldPatient_Load);
            this.panelPatientHistory.ResumeLayout(false);
            this.panelPatientHistory.PerformLayout();
            this.panelPatientDetails.ResumeLayout(false);
            this.panelPatientDetails.PerformLayout();
            this.panelAppointment.ResumeLayout(false);
            this.panelAppointment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSelectPatient;
        private System.Windows.Forms.ComboBox cbPatient;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Panel panelPatientHistory;
        private System.Windows.Forms.Panel panelPatientDetails;
        private System.Windows.Forms.Panel panelAppointment;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblDateofBirthValue;
        private System.Windows.Forms.Label lblDateofbirth;
        private System.Windows.Forms.Label lblFirstnameValue;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmailValue;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblPostalCodeValue;
        private System.Windows.Forms.Label lblProvienceValue;
        private System.Windows.Forms.Label lblCityValue;
        private System.Windows.Forms.Label lblStreetNameValue;
        private System.Windows.Forms.Label lblAppartmentNoValue;
        private System.Windows.Forms.Label lblContactNoValue;
        private System.Windows.Forms.ComboBox cbAppointmentTime;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.DateTimePicker dtAppointmentDate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBookAppointment;
        private System.Windows.Forms.Label lblProcedure;
        private System.Windows.Forms.ListBox lbProcedureList;
        private System.Windows.Forms.Label lblAppointmentTime;
        private System.Windows.Forms.ComboBox cbDoctor;
        private System.Windows.Forms.Label lblDoctor;
    }
}