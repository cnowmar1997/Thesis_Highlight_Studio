namespace Thesis_Highlight_Studio
{
    partial class frmAddClient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSubmit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tbEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbLandline = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbMobileNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tbCourse = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbSchoolName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbMiddleName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbGivenName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbFamilyName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbPassWord = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbPassWord);
            this.panel1.Controls.Add(this.tbUserName);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.tbLandline);
            this.panel1.Controls.Add(this.tbMobileNumber);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.tbCourse);
            this.panel1.Controls.Add(this.tbSchoolName);
            this.panel1.Controls.Add(this.tbMiddleName);
            this.panel1.Controls.Add(this.tbGivenName);
            this.panel1.Controls.Add(this.tbFamilyName);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 514);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(534, 442);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(215, 23);
            this.btnCancel.TabIndex = 61;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Depth = 0;
            this.btnSubmit.Location = new System.Drawing.Point(302, 442);
            this.btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Primary = true;
            this.btnSubmit.Size = new System.Drawing.Size(215, 23);
            this.btnSubmit.TabIndex = 60;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 37);
            this.panel2.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add New Client";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 27);
            this.panel3.TabIndex = 42;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(744, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "✖";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Depth = 0;
            this.tbEmail.Hint = "Email";
            this.tbEmail.Location = new System.Drawing.Point(534, 277);
            this.tbEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.SelectedText = "";
            this.tbEmail.SelectionLength = 0;
            this.tbEmail.SelectionStart = 0;
            this.tbEmail.Size = new System.Drawing.Size(215, 23);
            this.tbEmail.TabIndex = 33;
            this.tbEmail.UseSystemPasswordChar = false;
            // 
            // tbLandline
            // 
            this.tbLandline.Depth = 0;
            this.tbLandline.Hint = "Landline";
            this.tbLandline.Location = new System.Drawing.Point(302, 277);
            this.tbLandline.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbLandline.Name = "tbLandline";
            this.tbLandline.PasswordChar = '\0';
            this.tbLandline.SelectedText = "";
            this.tbLandline.SelectionLength = 0;
            this.tbLandline.SelectionStart = 0;
            this.tbLandline.Size = new System.Drawing.Size(215, 23);
            this.tbLandline.TabIndex = 32;
            this.tbLandline.UseSystemPasswordChar = false;
            // 
            // tbMobileNumber
            // 
            this.tbMobileNumber.Depth = 0;
            this.tbMobileNumber.Hint = "Mobile Number";
            this.tbMobileNumber.Location = new System.Drawing.Point(70, 277);
            this.tbMobileNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbMobileNumber.Name = "tbMobileNumber";
            this.tbMobileNumber.PasswordChar = '\0';
            this.tbMobileNumber.SelectedText = "";
            this.tbMobileNumber.SelectionLength = 0;
            this.tbMobileNumber.SelectionStart = 0;
            this.tbMobileNumber.Size = new System.Drawing.Size(215, 23);
            this.tbMobileNumber.TabIndex = 31;
            this.tbMobileNumber.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(32, 235);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(113, 19);
            this.materialLabel2.TabIndex = 30;
            this.materialLabel2.Text = "Contact Details";
            // 
            // tbCourse
            // 
            this.tbCourse.Depth = 0;
            this.tbCourse.Hint = "Course";
            this.tbCourse.Location = new System.Drawing.Point(302, 183);
            this.tbCourse.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbCourse.Name = "tbCourse";
            this.tbCourse.PasswordChar = '\0';
            this.tbCourse.SelectedText = "";
            this.tbCourse.SelectionLength = 0;
            this.tbCourse.SelectionStart = 0;
            this.tbCourse.Size = new System.Drawing.Size(215, 23);
            this.tbCourse.TabIndex = 28;
            this.tbCourse.UseSystemPasswordChar = false;
            // 
            // tbSchoolName
            // 
            this.tbSchoolName.Depth = 0;
            this.tbSchoolName.Hint = "School";
            this.tbSchoolName.Location = new System.Drawing.Point(70, 183);
            this.tbSchoolName.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbSchoolName.Name = "tbSchoolName";
            this.tbSchoolName.PasswordChar = '\0';
            this.tbSchoolName.SelectedText = "";
            this.tbSchoolName.SelectionLength = 0;
            this.tbSchoolName.SelectionStart = 0;
            this.tbSchoolName.Size = new System.Drawing.Size(215, 23);
            this.tbSchoolName.TabIndex = 27;
            this.tbSchoolName.UseSystemPasswordChar = false;
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Depth = 0;
            this.tbMiddleName.Hint = "Middle Name";
            this.tbMiddleName.Location = new System.Drawing.Point(534, 130);
            this.tbMiddleName.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.PasswordChar = '\0';
            this.tbMiddleName.SelectedText = "";
            this.tbMiddleName.SelectionLength = 0;
            this.tbMiddleName.SelectionStart = 0;
            this.tbMiddleName.Size = new System.Drawing.Size(215, 23);
            this.tbMiddleName.TabIndex = 26;
            this.tbMiddleName.UseSystemPasswordChar = false;
            // 
            // tbGivenName
            // 
            this.tbGivenName.Depth = 0;
            this.tbGivenName.Hint = "Given Name";
            this.tbGivenName.Location = new System.Drawing.Point(302, 130);
            this.tbGivenName.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbGivenName.Name = "tbGivenName";
            this.tbGivenName.PasswordChar = '\0';
            this.tbGivenName.SelectedText = "";
            this.tbGivenName.SelectionLength = 0;
            this.tbGivenName.SelectionStart = 0;
            this.tbGivenName.Size = new System.Drawing.Size(215, 23);
            this.tbGivenName.TabIndex = 25;
            this.tbGivenName.UseSystemPasswordChar = false;
            // 
            // tbFamilyName
            // 
            this.tbFamilyName.Depth = 0;
            this.tbFamilyName.Hint = "Family Name";
            this.tbFamilyName.Location = new System.Drawing.Point(70, 130);
            this.tbFamilyName.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbFamilyName.Name = "tbFamilyName";
            this.tbFamilyName.PasswordChar = '\0';
            this.tbFamilyName.SelectedText = "";
            this.tbFamilyName.SelectionLength = 0;
            this.tbFamilyName.SelectionStart = 0;
            this.tbFamilyName.Size = new System.Drawing.Size(215, 23);
            this.tbFamilyName.TabIndex = 24;
            this.tbFamilyName.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(32, 96);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(130, 19);
            this.materialLabel1.TabIndex = 23;
            this.materialLabel1.Text = "Client Information";
            // 
            // tbPassWord
            // 
            this.tbPassWord.Depth = 0;
            this.tbPassWord.Hint = "Password";
            this.tbPassWord.Location = new System.Drawing.Point(302, 371);
            this.tbPassWord.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.PasswordChar = '\0';
            this.tbPassWord.SelectedText = "";
            this.tbPassWord.SelectionLength = 0;
            this.tbPassWord.SelectionStart = 0;
            this.tbPassWord.Size = new System.Drawing.Size(215, 23);
            this.tbPassWord.TabIndex = 65;
            this.tbPassWord.UseSystemPasswordChar = false;
            // 
            // tbUserName
            // 
            this.tbUserName.Depth = 0;
            this.tbUserName.Hint = "Username";
            this.tbUserName.Location = new System.Drawing.Point(70, 371);
            this.tbUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.PasswordChar = '\0';
            this.tbUserName.SelectedText = "";
            this.tbUserName.SelectionLength = 0;
            this.tbUserName.SelectionStart = 0;
            this.tbUserName.Size = new System.Drawing.Size(215, 23);
            this.tbUserName.TabIndex = 66;
            this.tbUserName.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(32, 328);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(126, 19);
            this.materialLabel3.TabIndex = 64;
            this.materialLabel3.Text = "Login Credentials";
            // 
            // frmAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 514);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddClient";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "      Add New Client";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbLandline;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbMobileNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbCourse;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbSchoolName;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbMiddleName;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbGivenName;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbFamilyName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRaisedButton btnSubmit;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbPassWord;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbUserName;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;

    }
}