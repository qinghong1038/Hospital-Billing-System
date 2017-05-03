namespace HospitalBillingSystem
{
    partial class frmNewPatient
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
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.panelPateint = new System.Windows.Forms.Panel();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.cbProvience = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtAppartmentNo = new System.Windows.Forms.TextBox();
            this.dtDateofbirth = new System.Windows.Forms.DateTimePicker();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblEmailid = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblProvience = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblAppartmentNo = new System.Windows.Forms.Label();
            this.lblDateofbirth = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panelPateint.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.lblMainTitle.Location = new System.Drawing.Point(12, 13);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(218, 32);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "Patient Information";
            // 
            // panelPateint
            // 
            this.panelPateint.BackColor = System.Drawing.Color.Transparent;
            this.panelPateint.Controls.Add(this.txtPostalCode);
            this.panelPateint.Controls.Add(this.cbProvience);
            this.panelPateint.Controls.Add(this.txtCity);
            this.panelPateint.Controls.Add(this.txtContactNo);
            this.panelPateint.Controls.Add(this.txtEmail);
            this.panelPateint.Controls.Add(this.txtStreet);
            this.panelPateint.Controls.Add(this.txtAppartmentNo);
            this.panelPateint.Controls.Add(this.dtDateofbirth);
            this.panelPateint.Controls.Add(this.txtLastname);
            this.panelPateint.Controls.Add(this.txtFirstname);
            this.panelPateint.Controls.Add(this.lblContactNo);
            this.panelPateint.Controls.Add(this.lblEmailid);
            this.panelPateint.Controls.Add(this.lblPostalCode);
            this.panelPateint.Controls.Add(this.lblProvience);
            this.panelPateint.Controls.Add(this.lblCity);
            this.panelPateint.Controls.Add(this.lblStreet);
            this.panelPateint.Controls.Add(this.lblAppartmentNo);
            this.panelPateint.Controls.Add(this.lblDateofbirth);
            this.panelPateint.Controls.Add(this.lblLastname);
            this.panelPateint.Controls.Add(this.lblFirstname);
            this.panelPateint.Controls.Add(this.lblMainTitle);
            this.panelPateint.Location = new System.Drawing.Point(12, 12);
            this.panelPateint.Name = "panelPateint";
            this.panelPateint.Size = new System.Drawing.Size(998, 334);
            this.panelPateint.TabIndex = 1;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(671, 257);
            this.txtPostalCode.MaxLength = 7;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(264, 22);
            this.txtPostalCode.TabIndex = 20;
            // 
            // cbProvience
            // 
            this.cbProvience.FormattingEnabled = true;
            this.cbProvience.Location = new System.Drawing.Point(671, 214);
            this.cbProvience.Name = "cbProvience";
            this.cbProvience.Size = new System.Drawing.Size(264, 24);
            this.cbProvience.TabIndex = 18;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(671, 178);
            this.txtCity.MaxLength = 20;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(264, 22);
            this.txtCity.TabIndex = 16;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(181, 261);
            this.txtContactNo.MaxLength = 10;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(263, 22);
            this.txtContactNo.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(181, 220);
            this.txtEmail.MaxLength = 25;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(671, 108);
            this.txtStreet.MaxLength = 25;
            this.txtStreet.Multiline = true;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(264, 51);
            this.txtStreet.TabIndex = 14;
            // 
            // txtAppartmentNo
            // 
            this.txtAppartmentNo.Location = new System.Drawing.Point(671, 69);
            this.txtAppartmentNo.MaxLength = 25;
            this.txtAppartmentNo.Name = "txtAppartmentNo";
            this.txtAppartmentNo.Size = new System.Drawing.Size(264, 22);
            this.txtAppartmentNo.TabIndex = 12;
            // 
            // dtDateofbirth
            // 
            this.dtDateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateofbirth.Location = new System.Drawing.Point(180, 176);
            this.dtDateofbirth.Name = "dtDateofbirth";
            this.dtDateofbirth.Size = new System.Drawing.Size(264, 22);
            this.dtDateofbirth.TabIndex = 6;
            this.dtDateofbirth.Value = new System.DateTime(2017, 4, 24, 23, 59, 59, 0);
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(181, 122);
            this.txtLastname.MaxLength = 20;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(263, 22);
            this.txtLastname.TabIndex = 4;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(181, 67);
            this.txtFirstname.MaxLength = 20;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(263, 22);
            this.txtFirstname.TabIndex = 2;
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.Location = new System.Drawing.Point(68, 259);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(107, 23);
            this.lblContactNo.TabIndex = 9;
            this.lblContactNo.Text = "Contact No :";
            // 
            // lblEmailid
            // 
            this.lblEmailid.AutoSize = true;
            this.lblEmailid.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailid.Location = new System.Drawing.Point(96, 220);
            this.lblEmailid.Name = "lblEmailid";
            this.lblEmailid.Size = new System.Drawing.Size(79, 23);
            this.lblEmailid.TabIndex = 7;
            this.lblEmailid.Text = "Email id :";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalCode.Location = new System.Drawing.Point(556, 259);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(109, 23);
            this.lblPostalCode.TabIndex = 19;
            this.lblPostalCode.Text = "Postal Code :";
            // 
            // lblProvience
            // 
            this.lblProvience.AutoSize = true;
            this.lblProvience.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvience.Location = new System.Drawing.Point(572, 218);
            this.lblProvience.Name = "lblProvience";
            this.lblProvience.Size = new System.Drawing.Size(93, 23);
            this.lblProvience.TabIndex = 17;
            this.lblProvience.Text = "Provience :";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(616, 176);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(48, 23);
            this.lblCity.TabIndex = 15;
            this.lblCity.Text = "City :";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(601, 106);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(63, 23);
            this.lblStreet.TabIndex = 13;
            this.lblStreet.Text = "Street :";
            // 
            // lblAppartmentNo
            // 
            this.lblAppartmentNo.AutoSize = true;
            this.lblAppartmentNo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppartmentNo.Location = new System.Drawing.Point(526, 65);
            this.lblAppartmentNo.Name = "lblAppartmentNo";
            this.lblAppartmentNo.Size = new System.Drawing.Size(139, 23);
            this.lblAppartmentNo.TabIndex = 11;
            this.lblAppartmentNo.Text = "Appartment No :";
            // 
            // lblDateofbirth
            // 
            this.lblDateofbirth.AutoSize = true;
            this.lblDateofbirth.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateofbirth.Location = new System.Drawing.Point(59, 175);
            this.lblDateofbirth.Name = "lblDateofbirth";
            this.lblDateofbirth.Size = new System.Drawing.Size(116, 23);
            this.lblDateofbirth.TabIndex = 5;
            this.lblDateofbirth.Text = "Date of birth :";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(83, 120);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(92, 23);
            this.lblLastname.TabIndex = 3;
            this.lblLastname.Text = "Lastname :";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(82, 67);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(93, 23);
            this.lblFirstname.TabIndex = 1;
            this.lblFirstname.Text = "Firstname :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cbAppointmentTime);
            this.panel1.Controls.Add(this.lblAppointmentDate);
            this.panel1.Controls.Add(this.dtAppointmentDate);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnBookAppointment);
            this.panel1.Controls.Add(this.lblProcedure);
            this.panel1.Controls.Add(this.lbProcedureList);
            this.panel1.Controls.Add(this.lblAppointmentTime);
            this.panel1.Controls.Add(this.cbDoctor);
            this.panel1.Controls.Add(this.lblDoctor);
            this.panel1.Controls.Add(this.lblSubTitle);
            this.panel1.Location = new System.Drawing.Point(12, 352);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 375);
            this.panel1.TabIndex = 2;
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
            this.cbAppointmentTime.Location = new System.Drawing.Point(848, 83);
            this.cbAppointmentTime.Name = "cbAppointmentTime";
            this.cbAppointmentTime.Size = new System.Drawing.Size(87, 24);
            this.cbAppointmentTime.TabIndex = 26;
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDate.Location = new System.Drawing.Point(316, 84);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(161, 23);
            this.lblAppointmentDate.TabIndex = 23;
            this.lblAppointmentDate.Text = "Appointment Date :";
            // 
            // dtAppointmentDate
            // 
            this.dtAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAppointmentDate.Location = new System.Drawing.Point(490, 86);
            this.dtAppointmentDate.Name = "dtAppointmentDate";
            this.dtAppointmentDate.Size = new System.Drawing.Size(161, 22);
            this.dtAppointmentDate.TabIndex = 24;
            this.dtAppointmentDate.Value = new System.DateTime(2017, 4, 7, 0, 0, 0, 0);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReset.Location = new System.Drawing.Point(434, 302);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 40);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookAppointment.Location = new System.Drawing.Point(165, 302);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(248, 40);
            this.btnBookAppointment.TabIndex = 29;
            this.btnBookAppointment.Text = "Book Appointment";
            this.btnBookAppointment.UseVisualStyleBackColor = true;
            this.btnBookAppointment.Click += new System.EventHandler(this.btnBookAppointment_Click);
            // 
            // lblProcedure
            // 
            this.lblProcedure.AutoSize = true;
            this.lblProcedure.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcedure.Location = new System.Drawing.Point(23, 124);
            this.lblProcedure.Name = "lblProcedure";
            this.lblProcedure.Size = new System.Drawing.Size(97, 23);
            this.lblProcedure.TabIndex = 27;
            this.lblProcedure.Text = "Procedure :";
            // 
            // lbProcedureList
            // 
            this.lbProcedureList.FormattingEnabled = true;
            this.lbProcedureList.ItemHeight = 16;
            this.lbProcedureList.Location = new System.Drawing.Point(132, 124);
            this.lbProcedureList.Name = "lbProcedureList";
            this.lbProcedureList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbProcedureList.Size = new System.Drawing.Size(803, 164);
            this.lbProcedureList.Sorted = true;
            this.lbProcedureList.TabIndex = 28;
            // 
            // lblAppointmentTime
            // 
            this.lblAppointmentTime.AutoSize = true;
            this.lblAppointmentTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentTime.Location = new System.Drawing.Point(670, 85);
            this.lblAppointmentTime.Name = "lblAppointmentTime";
            this.lblAppointmentTime.Size = new System.Drawing.Size(162, 23);
            this.lblAppointmentTime.TabIndex = 25;
            this.lblAppointmentTime.Text = "Appointment Time :";
            // 
            // cbDoctor
            // 
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.Location = new System.Drawing.Point(132, 86);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(178, 24);
            this.cbDoctor.TabIndex = 22;
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.Location = new System.Drawing.Point(55, 85);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(71, 23);
            this.lblDoctor.TabIndex = 21;
            this.lblDoctor.Text = "Doctor :";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.lblSubTitle.Location = new System.Drawing.Point(12, 22);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(279, 32);
            this.lblSubTitle.TabIndex = 21;
            this.lblSubTitle.Text = "Appointment Information";
            // 
            // frmNewPatient
            // 
            this.AcceptButton = this.btnBookAppointment;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HospitalBillingSystem.Properties.Resources.appt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1378, 999);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPateint);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Patient";
            this.Load += new System.EventHandler(this.frmNewPatient_Load);
            this.panelPateint.ResumeLayout(false);
            this.panelPateint.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Panel panelPateint;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblDateofbirth;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblProvience;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblAppartmentNo;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblEmailid;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.DateTimePicker dtDateofbirth;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtAppartmentNo;
        private System.Windows.Forms.ComboBox cbProvience;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.ComboBox cbDoctor;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblAppointmentTime;
        private System.Windows.Forms.Label lblProcedure;
        private System.Windows.Forms.ListBox lbProcedureList;
        private System.Windows.Forms.Button btnBookAppointment;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DateTimePicker dtAppointmentDate;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.ComboBox cbAppointmentTime;
    }
}