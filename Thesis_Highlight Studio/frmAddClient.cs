﻿using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Thesis_Highlight_Studio
{
    public partial class frmAddClient : MaterialForm
    {
        Provider provide = new Provider();
        private readonly MaterialSkinManager skinManager;
        
        public frmAddClient()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        #region dllImport
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string lastName = tbFamilyName.Text;
            string firstName = tbGivenName.Text;
            string middleName = tbMiddleName.Text;                   
            
            string typeOfUser  = "CLIENT";
            string userName = tbUserName.Text;
            string passWOrd = tbPassWord.Text;
            string fullName = lastName + "," + " " + firstName + " " + middleName;
            string nameOfSchool = tbSchoolName.Text; 
            string courseTitle = tbCourse.Text; 
            string mobileNumber= tbMobileNumber.Text; 
            string landline = tbLandline.Text; 
            string emailAdd = tbEmail.Text;

            if (provide.insertClient(typeOfUser, userName, passWOrd, fullName, nameOfSchool, courseTitle, mobileNumber, landline, emailAdd))
            {
                CMsgBox.Show("Customer information successfully added to database.", "INFORMATION",CMsgBox.CMsgBtns.OK);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         

    }
}
