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
    public partial class frmAddUser : MaterialForm
    {

        public frmAddUser()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.tbStatus.Text = "ACTIVE";
            cmbTypeofUser.SelectedItem = userTypes[0];
            cmbTypeofUser.Items.Add(userTypes[1]);
            cmbTypeofUser.Items.Add(userTypes[2]);

        }

        

        #region DLL import
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

        #region Declaration
        private readonly MaterialSkinManager skinManager;

        Provider provide = new Provider();

        TextBox tbStatus = new TextBox();

        private string[] userTypes = { "SELECT", "STAFF", "CUSTOMER" };

        private static User cust;

        public User getCustomer
        {
            get
            {
                return customer_StoreValues();
            }
        } 
        #endregion

        #region Methods 
        //STAFF
        private User staff_StoreValues()
        {
            try
            {
                cust = new User();
                cust.typeOfUser = string.IsNullOrWhiteSpace(cmbTypeofUser.Text) ? null : cmbTypeofUser.Text;
                cust.userName = string.IsNullOrWhiteSpace(tbUserName.Text) ? null : tbUserName.Text;
                cust.passWord = string.IsNullOrWhiteSpace(tbPassWord.Text) ? null : tbPassWord.Text;
                cust.familyName = string.IsNullOrWhiteSpace(tbFamilyName.Text) ? null : tbFamilyName.Text;
                cust.givenName = string.IsNullOrWhiteSpace(tbGivenName.Text) ? null : tbGivenName.Text;
                cust.middleName = string.IsNullOrWhiteSpace(tbMiddleName.Text) ? null : tbMiddleName.Text;
                cust.nameOfSchool = string.IsNullOrWhiteSpace(tbSchoolName.Text) ? null : tbSchoolName.Text;
                cust.courseTitle = string.IsNullOrWhiteSpace(tbCourse.Text) ? null : tbCourse.Text;
                cust.mobileNumber = string.IsNullOrWhiteSpace(tbMobileNumber.Text) ? null : tbMobileNumber.Text;
                cust.landline = string.IsNullOrWhiteSpace(tbLandline.Text) ? null : tbLandline.Text;
                cust.emailAdd = string.IsNullOrWhiteSpace(tbEmail.Text) ? null : tbEmail.Text;
                cust.status = string.IsNullOrWhiteSpace(tbStatus.Text) ? null : tbStatus.Text;
            }
            catch (Exception ex)
            {

                CMsgBox.Show(ex.ToString());
                return null;
            }

            return cust;
        }

        //CUSTOMER
        private bool customer_Add()
        {
            var entry = customer_StoreValues();
            if (entry != null)
            {
                if (provide.addCustomer(entry))
                {
                    CMsgBox.Show("Customer information successfully added to database.", "INFORMATION", CMsgBox.CMsgBtns.OK);
                    return true;
                }
            }

            return false;
        }

        private User customer_StoreValues()
        {
            try
            {
                cust = new User();
                cust.typeOfUser = string.IsNullOrWhiteSpace(cmbTypeofUser.Text) ? null : cmbTypeofUser.Text;
                cust.userName = string.IsNullOrWhiteSpace(tbUserName.Text) ? null : tbUserName.Text;
                cust.passWord = string.IsNullOrWhiteSpace(tbPassWord.Text) ? null : tbPassWord.Text;
                cust.familyName = string.IsNullOrWhiteSpace(tbFamilyName.Text) ? null : tbFamilyName.Text;
                cust.givenName = string.IsNullOrWhiteSpace(tbGivenName.Text) ? null : tbGivenName.Text;
                cust.middleName = string.IsNullOrWhiteSpace(tbMiddleName.Text) ? null : tbMiddleName.Text;
                cust.nameOfSchool = string.IsNullOrWhiteSpace(tbSchoolName.Text) ? null : tbSchoolName.Text;
                cust.courseTitle = string.IsNullOrWhiteSpace(tbCourse.Text) ? null : tbCourse.Text;
                cust.mobileNumber = string.IsNullOrWhiteSpace(tbMobileNumber.Text) ? null : tbMobileNumber.Text;
                cust.landline = string.IsNullOrWhiteSpace(tbLandline.Text) ? null : tbLandline.Text;
                cust.emailAdd = string.IsNullOrWhiteSpace(tbEmail.Text) ? null : tbEmail.Text;
                cust.status = string.IsNullOrWhiteSpace(tbStatus.Text) ? null : tbStatus.Text;
            }
            catch (Exception ex)
            {

                CMsgBox.Show(ex.ToString());
                return null;
            }

            return cust;
        }
        #endregion

        #region EVENTS
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbTypeofUser_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbTypeofUser.SelectedItem == "STAFF")
            {
                materialLabel15.Visible = false;
                materialLabel14.Visible = false;

                tbSchoolName.Visible = false;
                tbCourse.Visible = false;

                gbUserPrivilege.Visible = false;
            }
            else if (cmbTypeofUser.SelectedItem == "CUSTOMER")
            {
                materialLabel15.Visible = true;
                materialLabel14.Visible = true;

                tbSchoolName.Visible = true;
                tbCourse.Visible = true;

                gbUserPrivilege.Visible = true;
            }
        } 

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
