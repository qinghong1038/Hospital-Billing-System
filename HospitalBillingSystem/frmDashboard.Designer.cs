namespace HospitalBillingSystem
{
    partial class frmDashboard
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
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oldPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientHistoryReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(20, 25);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem,
            this.billToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuMainMenu.Size = new System.Drawing.Size(1018, 24);
            this.mnuMainMenu.TabIndex = 1;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPatientToolStripMenuItem,
            this.oldPatientToolStripMenuItem,
            this.patientHistoryReportToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // newPatientToolStripMenuItem
            // 
            this.newPatientToolStripMenuItem.Name = "newPatientToolStripMenuItem";
            this.newPatientToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newPatientToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.newPatientToolStripMenuItem.Text = "&New Patient";
            this.newPatientToolStripMenuItem.Click += new System.EventHandler(this.newPatientToolStripMenuItem_Click);
            // 
            // oldPatientToolStripMenuItem
            // 
            this.oldPatientToolStripMenuItem.Name = "oldPatientToolStripMenuItem";
            this.oldPatientToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.oldPatientToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.oldPatientToolStripMenuItem.Text = "&Old Patient";
            this.oldPatientToolStripMenuItem.Click += new System.EventHandler(this.oldPatientToolStripMenuItem_Click);
            // 
            // patientHistoryReportToolStripMenuItem
            // 
            this.patientHistoryReportToolStripMenuItem.Name = "patientHistoryReportToolStripMenuItem";
            this.patientHistoryReportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.patientHistoryReportToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.patientHistoryReportToolStripMenuItem.Text = "Patient History";
            this.patientHistoryReportToolStripMenuItem.Click += new System.EventHandler(this.patientHistoryReportToolStripMenuItem_Click);
            // 
            // billToolStripMenuItem
            // 
            this.billToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateBillToolStripMenuItem});
            this.billToolStripMenuItem.Name = "billToolStripMenuItem";
            this.billToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.billToolStripMenuItem.Text = "Bill";
            // 
            // generateBillToolStripMenuItem
            // 
            this.generateBillToolStripMenuItem.Name = "generateBillToolStripMenuItem";
            this.generateBillToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.generateBillToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.generateBillToolStripMenuItem.Text = "Generate &Bill";
            this.generateBillToolStripMenuItem.Click += new System.EventHandler(this.generateBillToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1018, 699);
            this.ControlBox = false;
            this.Controls.Add(this.mnuMainMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMainMenu;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome, to MEDANATA Medicity";
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oldPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientHistoryReportToolStripMenuItem;
    }
}