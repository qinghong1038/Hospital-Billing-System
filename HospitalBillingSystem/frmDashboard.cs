using System;
using System.Windows.Forms;

namespace HospitalBillingSystem
{
    public partial class frmDashboard : Form
    {
        private int sessionKey;

        public frmDashboard()
        {
            InitializeComponent();
        }

        public void SessionKey(int skey)
        {
            this.sessionKey = skey;
        }

        private void newPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewPatient objNewPatient = new frmNewPatient();
            objNewPatient.MdiParent = this;
            objNewPatient.Dock = DockStyle.Fill;
            objNewPatient.SessionKey(this.sessionKey);
            objNewPatient.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form objForm in this.MdiChildren)
            {
                objForm.Close();
            }
            this.Close();
        }

        private void oldPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOldPatient objOldPatient = new frmOldPatient();
            objOldPatient.MdiParent = this;
            objOldPatient.Dock = DockStyle.Fill;
            objOldPatient.SessionKey(this.sessionKey);
            objOldPatient.Show();
        }

        private void generateBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenerateBill objGenerateBill = new frmGenerateBill();
            objGenerateBill.MdiParent = this;
            objGenerateBill.Dock = DockStyle.Fill;
            objGenerateBill.SessionKey(this.sessionKey);
            objGenerateBill.Show();
        }

        private void patientHistoryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatientHistory objPatientHistory = new frmPatientHistory();
            objPatientHistory.MdiParent = this;
            objPatientHistory.Dock = DockStyle.Fill;
            objPatientHistory.SessionKey(this.sessionKey);
            objPatientHistory.Show();
        }
    }
}
