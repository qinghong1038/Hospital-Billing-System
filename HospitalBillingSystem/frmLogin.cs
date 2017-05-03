using System;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace HospitalBillingSystem
{
    public partial class frmLogin : Form
    {
        ToolTip objToolTip = new ToolTip();
        frmDashboard objDashboard = new frmDashboard();

        public frmLogin()
        {
            InitializeComponent();
            Clear();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            objToolTip.SetToolTip(txtUsername, "Enter Username");
            objToolTip.SetToolTip(txtPassword, "Enter Password");
            objToolTip.SetToolTip(btnLogin, "Click here to Login");
            objToolTip.SetToolTip(btnReset, "Click here to Reset");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                Login objLogin = new Login();
                objLogin.Username = txtUsername.Text;
                objLogin.Password = txtPassword.Text;
                int loginResposne = objLogin.DoLogin(objLogin);
                if (loginResposne > 0)
                {
                    Clear();
                    objDashboard.SessionKey(loginResposne);
                    if (objDashboard.IsDisposed)
                    {
                        objDashboard = new frmDashboard();
                    }
                    else
                    {
                        objDashboard.Show();
                    }
                }
                else
                {
                    Clear();
                    DisplayMessage("Invalid Username & Password", "Authentication Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        public Boolean valid()
        {
            return check_Textbox(txtUsername, "Username is a required field.")
                && check_Textbox(txtPassword, "Password is a required field.");
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

        public void DisplayMessage(string message, string caption, MessageBoxButtons msgBoxButton, MessageBoxIcon msgBoxIcon, MessageBoxDefaultButton msgBoxDefaultButton)
        {
            MessageBox.Show(message, caption, msgBoxButton, msgBoxIcon, msgBoxDefaultButton);
        }
    }
}
