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

        private static User add_Staff;

        private static User add_Cust;

        public User getStaff
        {
            get
            {
                return staffStoreValues();
            }
        } 

        public User getCustomer
        {
            get
            {
                return customerStoreValues();
            }
        } 
        #endregion

        #region Methods 
        //STAFF
        private bool staff_Add()
        {
            var entry = customerStoreValues();
            if (entry != null)
            {
                if (provide.addStaff(entry))
                {
                    CMsgBox.Show("Staff information successfully added to database.", "INFORMATION", CMsgBox.CMsgBtns.OK);
                    return true;
                }
            }

            return false;
        }

        private User staffStoreValues()
        {
            //try
            //{
            add_Staff = new User();
            add_Staff.typeOfUser = string.IsNullOrWhiteSpace(cmbTypeofUser.Text) ? null : cmbTypeofUser.Text;
            add_Staff.userName = string.IsNullOrWhiteSpace(tbUserName.Text) ? null : tbUserName.Text;
            add_Staff.passWord = string.IsNullOrWhiteSpace(tbPassWord.Text) ? null : tbPassWord.Text;
            add_Staff.familyName = string.IsNullOrWhiteSpace(tbFamilyName.Text) ? null : tbFamilyName.Text;
            add_Staff.givenName = string.IsNullOrWhiteSpace(tbGivenName.Text) ? null : tbGivenName.Text;
            add_Staff.middleName = string.IsNullOrWhiteSpace(tbMiddleName.Text) ? null : tbMiddleName.Text;
            add_Staff.address = string.IsNullOrWhiteSpace(tbAddress.Text) ? null : tbAddress.Text;
            add_Staff.mobileNumber = string.IsNullOrWhiteSpace(tbMobileNumber.Text) ? null : tbMobileNumber.Text;
            add_Staff.landline = string.IsNullOrWhiteSpace(tbLandline.Text) ? null : tbLandline.Text;
            add_Staff.emailAdd = string.IsNullOrWhiteSpace(tbEmail.Text) ? null : tbEmail.Text;
            add_Staff.status = string.IsNullOrWhiteSpace(tbStatus.Text) ? null : tbStatus.Text;
            //}
            //catch (Exception ex)
            //{
            //    CMsgBox.Show(ex.ToString());
            //    return null;
            //}
            return add_Staff;
        }

        //CUSTOMER
        private bool customer_Add()
        {
            var entry = customerStoreValues();
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

        private User customerStoreValues()
        {
            try
            {
                add_Cust = new User();
                add_Cust.typeOfUser = string.IsNullOrWhiteSpace(cmbTypeofUser.Text) ? null : cmbTypeofUser.Text;
                add_Cust.userName = string.IsNullOrWhiteSpace(tbUserName.Text) ? null : tbUserName.Text;
                add_Cust.passWord = string.IsNullOrWhiteSpace(tbPassWord.Text) ? null : tbPassWord.Text;
                add_Cust.familyName = string.IsNullOrWhiteSpace(tbFamilyName.Text) ? null : tbFamilyName.Text;
                add_Cust.givenName = string.IsNullOrWhiteSpace(tbGivenName.Text) ? null : tbGivenName.Text;
                add_Cust.middleName = string.IsNullOrWhiteSpace(tbMiddleName.Text) ? null : tbMiddleName.Text;
                add_Cust.nameOfSchool = string.IsNullOrWhiteSpace(tbSchoolName.Text) ? null : tbSchoolName.Text;
                add_Cust.courseTitle = string.IsNullOrWhiteSpace(tbCourse.Text) ? null : tbCourse.Text;
                add_Cust.mobileNumber = string.IsNullOrWhiteSpace(tbMobileNumber.Text) ? null : tbMobileNumber.Text;
                add_Cust.landline = string.IsNullOrWhiteSpace(tbLandline.Text) ? null : tbLandline.Text;
                add_Cust.emailAdd = string.IsNullOrWhiteSpace(tbEmail.Text) ? null : tbEmail.Text;
                add_Cust.status = string.IsNullOrWhiteSpace(tbStatus.Text) ? null : tbStatus.Text;
            }
            catch (Exception ex)
            {

                CMsgBox.Show(ex.ToString());
                return null;
            }

            return add_Cust;
        }
        #endregion

        #region EVENTS
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbTypeofUser.SelectedItem == "STAFF")
            {
                //MessageBox.Show(tbAddress.Text);
                staff_Add();
            }
            else if (cmbTypeofUser.SelectedItem == "CUSTOMER")
            {
                customer_Add();
            }
        }

        private void cmbTypeofUser_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbTypeofUser.SelectedItem == "STAFF")
            {
                materialLabel15.Visible = false;
                materialLabel14.Visible = false;
                tbSchoolName.Visible = false;
                tbCourse.Visible = false;

                materialLabel8.Visible = true;
                tbAddress.Visible = true;



                gbUserPrivilege.Visible = true;
            }
            else if (cmbTypeofUser.SelectedItem == "CUSTOMER")
            {
                materialLabel15.Visible = true;
                materialLabel14.Visible = true;
                tbSchoolName.Visible = true;
                tbCourse.Visible = true;

                materialLabel8.Visible = false;
                tbAddress.Visible = false;

                gbUserPrivilege.Visible = false;
            }
        } 

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
