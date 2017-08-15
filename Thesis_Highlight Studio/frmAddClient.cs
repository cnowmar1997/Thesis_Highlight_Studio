using System;
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
        

        TextBox tbTypeofUser = new TextBox();
        TextBox tbStatus = new TextBox();

        

        public frmAddClient()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.tbTypeofUser.Text = "CLIENT";
            this.tbStatus.Text = "ACTIVE";
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

        

        #region Methods

        private static Client clnt;

        public Client getClient
        {
            get
            {
                return StoreValues();
            }
        }

        public bool ClientAdd()
        {
            var entry = StoreValues();
            if (entry != null)
            {
                if (provide.addClient(entry))
                {
                    CMsgBox.Show("Customer information successfully added to database.", "INFORMATION", CMsgBox.CMsgBtns.OK);
                    return true;
                }
            }

            return false; 
        }

        private Client StoreValues()
        {
            try
            {
                clnt = new Client();
                clnt.typeOfUser = string.IsNullOrWhiteSpace(tbTypeofUser.Text) ? null : tbTypeofUser.Text;
                clnt.userName = string.IsNullOrWhiteSpace(tbUserName.Text) ? null : tbUserName.Text;
                clnt.passWord = string.IsNullOrWhiteSpace(tbPassWord.Text) ? null : tbPassWord.Text;
                clnt.familyName = string.IsNullOrWhiteSpace(tbFamilyName.Text) ? null : tbFamilyName.Text;
                clnt.givenName = string.IsNullOrWhiteSpace(tbGivenName.Text) ? null : tbGivenName.Text;
                clnt.middleName = string.IsNullOrWhiteSpace(tbMiddleName.Text) ? null : tbMiddleName.Text;
                clnt.nameOfSchool = string.IsNullOrWhiteSpace(tbSchoolName.Text) ? null : tbSchoolName.Text;
                clnt.courseTitle = string.IsNullOrWhiteSpace(tbCourse.Text) ? null : tbCourse.Text;
                clnt.mobileNumber = string.IsNullOrWhiteSpace(tbMobileNumber.Text) ? null : tbMobileNumber.Text;
                clnt.landline = string.IsNullOrWhiteSpace(tbLandline.Text) ? null : tbLandline.Text;
                clnt.emailAdd = string.IsNullOrWhiteSpace(tbEmail.Text) ? null : tbEmail.Text;
                clnt.status = string.IsNullOrWhiteSpace(tbStatus.Text) ? null : tbStatus.Text;
            }
            catch (Exception ex)
            {

                CMsgBox.Show(ex.ToString());
                return null;
            }

            return clnt;
        }
        #endregion

        #region Events      
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ClientAdd();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
