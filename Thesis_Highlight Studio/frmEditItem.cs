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
    public partial class frmEditItem : MaterialForm
    {

        private readonly MaterialSkinManager skinManager;

        Provider provide = new Provider();

        TextBox tbItemId = new TextBox();
        TextBox _tbItemId = new TextBox();

        public frmEditItem()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            _tbItemId.Text = Provider.filter_ID;
            tbItemId.Text = Provider.filter_ID;
            itemId = int.Parse(tbItemId.Text);
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
        private static int _itemId;

        public int itemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        private void getData()
        {
            var itmList = provide.getItem(itemId);
            if (itmList != null)
            {

                tbName.Text = itmList.name;
                tbDescription.Text = itmList.description;
                tbPrice.Text = itmList.price;

            }
        }
        public void updateItem()
        {
            var itmList = new Itemlist();
            string _itemId = _tbItemId.Text;
            itmList.name = tbName.Text;
            itmList.description = tbDescription.Text;
            itmList.price = tbPrice.Text;


            if (provide.updateItem(tbName.Text, tbDescription.Text, tbPrice.Text, _tbItemId.Text))
            {
                CMsgBox.Show("Item successfully updated.");
                this.Close();
            }
        } 
        #endregion

        #region EVENTS
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            updateItem();
        }

        private void frmEditItem_Load(object sender, EventArgs e)
        {
            getData();
        } 
        #endregion
        


    }
}
