namespace PersonApp
{
    partial class MenuPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPage));
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.btnCreatePerson = new System.Windows.Forms.Button();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.lstDetails = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDetailsHeader = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(700, 80);
            this.panelHeader.TabIndex = 13;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelForm.Controls.Add(this.lblName);
            this.panelForm.Controls.Add(this.lblAge);
            this.panelForm.Controls.Add(this.lblAddress);
            this.panelForm.Controls.Add(this.lblStudentID);
            this.panelForm.Controls.Add(this.txtName);
            this.panelForm.Controls.Add(this.txtAge);
            this.panelForm.Controls.Add(this.txtAddress);
            this.panelForm.Controls.Add(this.txtStudentID);
            this.panelForm.Location = new System.Drawing.Point(30, 95);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(20);
            this.panelForm.Size = new System.Drawing.Size(640, 160);
            this.panelForm.TabIndex = 14;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnCreatePerson);
            this.panelButtons.Controls.Add(this.btnCreateStudent);
            this.panelButtons.Location = new System.Drawing.Point(30, 270);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(640, 60);
            this.panelButtons.TabIndex = 15;
            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDetails.Controls.Add(this.lblDetailsHeader);
            this.panelDetails.Controls.Add(this.lstDetails);
            this.panelDetails.Location = new System.Drawing.Point(30, 345);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Padding = new System.Windows.Forms.Padding(20);
            this.panelDetails.Size = new System.Drawing.Size(640, 245);
            this.panelDetails.TabIndex = 16;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(20, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(20, 60);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(44, 23);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(20, 95);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(74, 23);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(20, 130);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(94, 23);
            this.lblStudentID.TabIndex = 3;
            this.lblStudentID.Text = "Student ID:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(130, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(480, 30);
            this.txtName.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(130, 58);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(480, 30);
            this.txtAge.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(130, 93);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(480, 30);
            this.txtAddress.TabIndex = 6;
            // 
            // txtStudentID
            // 
            this.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(130, 128);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(480, 30);
            this.txtStudentID.TabIndex = 7;
            // 
            // btnCreatePerson
            // 
            this.btnCreatePerson.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCreatePerson.FlatAppearance.BorderSize = 0;
            this.btnCreatePerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePerson.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePerson.ForeColor = System.Drawing.Color.White;
            this.btnCreatePerson.Location = new System.Drawing.Point(100, 10);
            this.btnCreatePerson.Name = "btnCreatePerson";
            this.btnCreatePerson.Size = new System.Drawing.Size(180, 40);
            this.btnCreatePerson.TabIndex = 8;
            this.btnCreatePerson.Text = "Create Person";
            this.btnCreatePerson.UseVisualStyleBackColor = false;
            this.btnCreatePerson.Click += new System.EventHandler(this.btnCreatePerson_Click);
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCreateStudent.FlatAppearance.BorderSize = 0;
            this.btnCreateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateStudent.ForeColor = System.Drawing.Color.White;
            this.btnCreateStudent.Location = new System.Drawing.Point(360, 10);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(180, 40);
            this.btnCreateStudent.TabIndex = 9;
            this.btnCreateStudent.Text = "Create Student";
            this.btnCreateStudent.UseVisualStyleBackColor = false;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnCreateStudent_Click);
            // 
            // lstDetails
            // 
            this.lstDetails.BackColor = System.Drawing.Color.White;
            this.lstDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDetails.FormattingEnabled = true;
            this.lstDetails.ItemHeight = 23;
            this.lstDetails.Location = new System.Drawing.Point(20, 50);
            this.lstDetails.Name = "lstDetails";
            this.lstDetails.Size = new System.Drawing.Size(600, 175);
            this.lstDetails.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(700, 80);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Person Management System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDetailsHeader
            // 
            this.lblDetailsHeader.AutoSize = true;
            this.lblDetailsHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDetailsHeader.Location = new System.Drawing.Point(15, 15);
            this.lblDetailsHeader.Name = "lblDetailsHeader";
            this.lblDetailsHeader.Size = new System.Drawing.Size(152, 28);
            this.lblDetailsHeader.TabIndex = 12;
            this.lblDetailsHeader.Text = "Person Details";
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(700, 620);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Management App";
            this.panelHeader.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button btnCreatePerson;
        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.ListBox lstDetails;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDetailsHeader;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelDetails;
    }
}