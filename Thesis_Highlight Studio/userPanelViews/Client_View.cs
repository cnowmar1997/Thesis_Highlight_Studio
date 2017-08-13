using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thesis_Highlight_Studio.UserPanel
{
    public partial class Client_View : UserControl
    {
        private Point MouseDownLocation;
        private static Client_View _instance;

        Provider provide = new Provider();
        TextBox tbuserId = new TextBox();
        TextBox tbGivenName = new TextBox();
        TextBox tbMiddleName = new TextBox();

        public static Client_View Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new Client_View();
                return _instance;

            }
        }

        public Client_View()
        {
            InitializeComponent();
            
        }

        private void viewClient()
        {
            listViewClient.Items.Clear();
            var list = provide.viewClient();

            if (list != null)
            {
                foreach (User use in list)
                {
                    ListViewItem item = new ListViewItem(use.userId.ToString());
                    item.SubItems.Add(use.familyName + ", " + use.givenName + " " + use.middleName);
                    item.SubItems.Add(use.nameOfSchool);
                    item.SubItems.Add(use.courseTitle);
                    item.SubItems.Add(use.mobileNumber);
                    item.SubItems.Add(use.landline);
                    item.SubItems.Add(use.emailAdd);
                    listViewClient.Items.Add(item);

                    

                }
            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                panel1.Left = e.X + panel1.Left - MouseDownLocation.X;
                panel1.Top = e.Y + panel1.Top - MouseDownLocation.Y;
            }
        }
        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmAddClient add = new frmAddClient();
            DimForm.Show(this.ParentForm, add);
        }
         
        private void Client_View_Load(object sender, EventArgs e)
        {

            viewClient();
            //tbSalesAndPurchases.Text = Provider.GetClientView_SalesandPurchases;
            //if (tbSalesAndPurchases.Text.Equals("salesAndPurchases"))
            //{
            //    panel1.Visible = false;
            //    contextMenuStrip1.Close();
            //}
        }

        private void updateCustomerAccToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            frmEditClient add = new frmEditClient();
            DimForm.Show(this.ParentForm, add);
        }

        private void listviewClient_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                if (listViewClient.FocusedItem.Bounds.Contains(e.Location) == true)
                    contextMenuStrip1.Show(Cursor.Position);

            tbuserId.Text = listViewClient.SelectedItems[0].Text;
            Provider.filter_ID = tbuserId.Text;
            //MessageBox.Show(tbuserId.Text);
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddClient add = new frmAddClient();
            DimForm.Show(this.ParentForm, add);
        }
 
    }
}
