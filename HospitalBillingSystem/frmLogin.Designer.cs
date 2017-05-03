namespace HospitalBillingSystem
{
    partial class frmLogin
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
            this.lblCaption = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.White;
            this.lblMainTitle.Location = new System.Drawing.Point(486, 285);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(465, 37);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "WELCOME TO MEDANTA MEDICITY";
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblCaption.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.lblCaption.Location = new System.Drawing.Point(635, 328);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(203, 37);
            this.lblCaption.TabIndex = 1;
            this.lblCaption.Text = "dedicated to life";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(523, 392);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(108, 28);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username :";
            // 
            // txtUsername
            // 
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(642, 392);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(280, 22);
            this.txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(528, 432);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(102, 28);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(642, 435);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(280, 22);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(642, 479);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(85, 40);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(749, 479);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 40);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HospitalBillingSystem.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1378, 999);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.lblMainTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to MEDANTA Medicity";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnReset;
    }
}

