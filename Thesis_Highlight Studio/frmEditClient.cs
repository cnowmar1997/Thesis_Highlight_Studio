using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;

namespace Thesis_Highlight_Studio
{
    public partial class frmEditClient : MaterialForm
    {

        private readonly MaterialSkinManager skinManager;

        Provider provide = new Provider();
        TextBox tbUserId = new TextBox();

        public static bool isChanged;

        public frmEditClient()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            tbUserId.Text = Provider.filter_ID;

        }

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

        private void retrieveData()
        {
            var list = provide.retrieveUser(tbUserId.Text);
            if (list != null)
            {
                foreach (User u in list)
                {
                    tbUsername.Text = u.userName;
                    tbPassword.Text = u.passWord;
                    tbFamilyName.Text = u.familyName;
                    tbGivenName.Text = u.givenName;
                    tbMiddleName.Text = u.middleName;
                    tbSchoolName.Text = u.nameOfSchool;
                    tbCourse.Text = u.courseTitle;
                    tbMobileNumber.Text = u.mobileNumber;
                    tbLandline.Text = u.landline;
                    tbEmail.Text = u.emailAdd;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var user = new User();
            
            
            string userId = tbUserId.Text;
            string userName = string.IsNullOrWhiteSpace(tbUsername.Text) ? null : tbUsername.Text;
            string passWord = string.IsNullOrWhiteSpace(tbPassword.Text) ? null : tbPassword.Text;
            string familyName = string.IsNullOrWhiteSpace(tbFamilyName.Text) ? null : tbFamilyName.Text;
            string givenName = string.IsNullOrWhiteSpace(tbGivenName.Text) ? null : tbGivenName.Text;
            string middleName = string.IsNullOrWhiteSpace(tbMiddleName.Text) ? null : tbMiddleName.Text;
            string nameOfSchool = string.IsNullOrWhiteSpace(tbSchoolName.Text) ? null : tbSchoolName.Text;
            string courseTitle = string.IsNullOrWhiteSpace(tbCourse.Text) ? null : tbCourse.Text;
            string mobileNumber = string.IsNullOrWhiteSpace(tbMobileNumber.Text) ? null : tbMobileNumber.Text;
            string landline = string.IsNullOrWhiteSpace(tbLandline.Text) ? null : tbLandline.Text;
            string emailAdd = string.IsNullOrWhiteSpace(tbEmail.Text) ? null : tbEmail.Text;

 
            if (CMsgBox.Show(this, "Do you want to save this changes?", "Confirm", CMsgBox.CMsgBtns.YesNo) == DialogResult.Yes)
            {
                if (provide.updateClient(userName, passWord, familyName, givenName, middleName, nameOfSchool, courseTitle, mobileNumber, landline, emailAdd, userId))
                {
                    CMsgBox.Show("Successfully Updated!", "INFORMATION");
                    this.Close(); 
                }
            }
         
        }

        private void frmEditClient_Load(object sender, EventArgs e)
        {
            retrieveData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
