namespace HospitalBillingSystem
{
    partial class frmPatientHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSelectPatient = new System.Windows.Forms.Label();
            this.cbPatient = new System.Windows.Forms.ComboBox();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.dgvPatientHistory = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lblSelectPatient);
            this.panel1.Controls.Add(this.cbPatient);
            this.panel1.Controls.Add(this.lblMainTitle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 137);
            this.panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(472, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 33);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSelectPatient
            // 
            this.lblSelectPatient.AutoSize = true;
            this.lblSelectPatient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectPatient.Location = new System.Drawing.Point(33, 65);
            this.lblSelectPatient.Name = "lblSelectPatient";
            this.lblSelectPatient.Size = new System.Drawing.Size(122, 23);
            this.lblSelectPatient.TabIndex = 3;
            this.lblSelectPatient.Text = "Select Patient :";
            // 
            // cbPatient
            // 
            this.cbPatient.FormattingEnabled = true;
            this.cbPatient.Location = new System.Drawing.Point(172, 65);
            this.cbPatient.Name = "cbPatient";
            this.cbPatient.Size = new System.Drawing.Size(271, 24);
            this.cbPatient.TabIndex = 2;
            this.cbPatient.Tag = "";
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.lblMainTitle.Location = new System.Drawing.Point(17, 14);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(170, 32);
            this.lblMainTitle.TabIndex = 1;
            this.lblMainTitle.Text = "Patient History";
            // 
            // dgvPatientHistory
            // 
            this.dgvPatientHistory.AllowUserToAddRows = false;
            this.dgvPatientHistory.AllowUserToDeleteRows = false;
            this.dgvPatientHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatientHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPatientHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.dgvPatientHistory.Location = new System.Drawing.Point(35, 200);
            this.dgvPatientHistory.Name = "dgvPatientHistory";
            this.dgvPatientHistory.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatientHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPatientHistory.RowTemplate.Height = 24;
            this.dgvPatientHistory.Size = new System.Drawing.Size(905, 340);
            this.dgvPatientHistory.TabIndex = 1;
            // 
            // frmPatientHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HospitalBillingSystem.Properties.Resources.appt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 1003);
            this.Controls.Add(this.dgvPatientHistory);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmPatientHistory";
            this.Text = "Patient History";
            this.Load += new System.EventHandler(this.frmPatientHistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSelectPatient;
        private System.Windows.Forms.ComboBox cbPatient;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvPatientHistory;
    }
}