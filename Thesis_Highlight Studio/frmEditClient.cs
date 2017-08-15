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
            userId = int.Parse(tbUserId.Text);
        }

        #region DLLImport
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

        #region Methods
        private static int _userId;

        private Client oldClient;

        private bool isEdited;

        public int userId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public bool ClientUpdate()
        {
            var entry = StoreValues();
            if (entry != null)
            {
                string query = GenUpdateString(entry);
                if (provide.updateClient(query))
                {
                    CMsgBox.Show("Successfully Updated!", "INFORMATION");
                    this.Close(); 
                    return true;
                }
            }
            return false;
        }

        public bool HasBeenEdited()
        {
            StoreValues();
            return this.isEdited;
        }

        public Client StoreValues()
        {       
            var newClient = new Client();
            try
            {
                this.isEdited = false;
                newClient.userId = this.userId;

                if (hasChanged(oldClient.userName, tbUserName.Text))
                {
                    newClient.userName = tbUserName.Text;
                    this.isEdited = true;
                }
                if (hasChanged(oldClient.passWord, tbPassWord.Text))
                {
                    newClient.passWord = tbPassWord.Text;
                    this.isEdited = true;
                }
                if (hasChanged(oldClient.familyName, tbFamilyName.Text))
                {
                    newClient.familyName = tbFamilyName.Text;
                    this.isEdited = true;
                }
                if (hasChanged(oldClient.givenName, tbGivenName.Text))
                {
                    newClient.givenName = tbGivenName.Text;
                    this.isEdited = true;
                }
                if (hasChanged(oldClient.middleName, tbMiddleName.Text))
                {
                    newClient.middleName = tbMiddleName.Text;
                    this.isEdited = true;
                }
                if (hasChanged(oldClient.nameOfSchool, tbSchoolName.Text))
                {
                    newClient.nameOfSchool = tbSchoolName.Text;
                    this.isEdited = true;
                }
                if (hasChanged(oldClient.courseTitle, tbCourse.Text))
                {
                    newClient.courseTitle = tbCourse.Text;
                    this.isEdited = true;
                }
                if (hasChanged(oldClient.mobileNumber, tbMobileNumber.Text))
                {
                    newClient.mobileNumber = tbMobileNumber.Text;
                    this.isEdited = true;
                }
                if (hasChanged(oldClient.landline, tbLandline.Text))
                {
                    newClient.landline = tbLandline.Text;
                    this.isEdited = true;
                }
                if (hasChanged(oldClient.emailAdd, tbEmail.Text))
                {
                    newClient.emailAdd = tbEmail.Text;
                    this.isEdited = true;
                }


            }
            catch (Exception ex)
            {

                CMsgBox.Show(ex.ToString());
                return null;
            }
            return newClient;
        }

        private bool hasChanged(string deffaultValue, string newValue)
        {
            if (deffaultValue.Equals(newValue))
                return false;
            return true;
        }

        private void LoadValues()
        {
            var clnt = provide.getClient(userId);
            if (clnt != null)
            {
                tbUserName.Text = clnt.userName;
                tbPassWord.Text = clnt.passWord;
                tbFamilyName.Text = clnt.familyName;
                tbGivenName.Text = clnt.givenName;
                tbMiddleName.Text = clnt.middleName;
                tbSchoolName.Text = clnt.nameOfSchool;
                tbCourse.Text = clnt.courseTitle;
                tbMobileNumber.Text = clnt.mobileNumber;
                tbLandline.Text = clnt.landline;
                tbEmail.Text = clnt.emailAdd;
            }
        }

        private string GenUpdateString(Client client)
        {

            string query = string.Empty;
            query += "UPDATE tblUser SET ";
            query += string.IsNullOrEmpty(client.userName) ? string.Empty : "userName = '" + client.userName + "',";
            query += string.IsNullOrEmpty(client.passWord) ? string.Empty : "passWord = '" + client.passWord + "',";
            query += string.IsNullOrEmpty(client.familyName) ? string.Empty : "familyName = '" + client.familyName + "',";
            query += string.IsNullOrEmpty(client.givenName) ? string.Empty : "givenName = '" + client.givenName + "',";
            query += string.IsNullOrEmpty(client.middleName) ? string.Empty : "middleName = '" + client.middleName + "',";
            query += string.IsNullOrEmpty(client.nameOfSchool) ? string.Empty : "nameOfSchool = '" + client.nameOfSchool + "',";
            query += string.IsNullOrEmpty(client.courseTitle) ? string.Empty : "courseTitle = '" + client.courseTitle + "',";
            query += string.IsNullOrEmpty(client.mobileNumber) ? string.Empty : "mobileNumber = '" + client.mobileNumber + "',";
            query += string.IsNullOrEmpty(client.landline) ? string.Empty : "landline = '" + client.landline + "',";
            query += string.IsNullOrEmpty(client.emailAdd) ? string.Empty : "emailAdd = '" + client.emailAdd + "',";
            query = query.Remove(query.Length - 1);
            query += " WHERE userId=" + oldClient.userId + ";";

            return query;

            //client.userId = tbUserId.Text;
            //client.userName = string.IsNullOrWhiteSpace(tbUsername.Text) ? null : tbUsername.Text;
            //client.passWord = string.IsNullOrWhiteSpace(tbPassword.Text) ? null : tbPassword.Text;
            //client.familyName = string.IsNullOrWhiteSpace(tbFamilyName.Text) ? null : tbFamilyName.Text;
            //client.givenName = string.IsNullOrWhiteSpace(tbGivenName.Text) ? null : tbGivenName.Text;
            //client.middleName = string.IsNullOrWhiteSpace(tbMiddleName.Text) ? null : tbMiddleName.Text;
            //client.nameOfSchool = string.IsNullOrWhiteSpace(tbSchoolName.Text) ? null : tbSchoolName.Text;
            //client.courseTitle = string.IsNullOrWhiteSpace(tbCourse.Text) ? null : tbCourse.Text;
            //client.mobileNumber = string.IsNullOrWhiteSpace(tbMobileNumber.Text) ? null : tbMobileNumber.Text;
            //client.landline = string.IsNullOrWhiteSpace(tbLandline.Text) ? null : tbLandline.Text;
            //client.emailAdd = string.IsNullOrWhiteSpace(tbEmail.Text) ? null : tbEmail.Text;

        }
        #endregion

        #region Events
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ClientUpdate();
        }

        private void frmEditClient_Load(object sender, EventArgs e)
        {
            LoadValues();
        } 
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
        #endregion

       
    }
}
