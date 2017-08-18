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

        #region Methods
        User c = new User();

        private void viewStaff()
        {
            lvStaff.Items.Clear();
            var list = provide.viewStaff();

            if (list != null)
            {
                foreach (User use in list)
                {
                    ListViewItem item = new ListViewItem(use.userId.ToString());
                    item.SubItems.Add(use.familyName + ", " + use.givenName + " " + use.middleName);
                    item.SubItems.Add(use.mobileNumber + "/" + use.landline);
                    item.SubItems.Add(use.emailAdd);
                    lvStaff.Items.Add(item);
                }
            }
        }

        private void viewClient()
        {
            //c.status = "ACTIVE";
            lvCustomer.Items.Clear();
            var list = provide.viewCustomer();

            if (list != null)
            {
                foreach (User use in list)
                {
                    ListViewItem item = new ListViewItem(use.userId.ToString());
                    item.SubItems.Add(use.familyName + ", " + use.givenName + " " + use.middleName);
                    item.SubItems.Add(use.nameOfSchool);
                    item.SubItems.Add(use.courseTitle);
                    item.SubItems.Add(use.mobileNumber + "/" + use.landline);
                    item.SubItems.Add(use.emailAdd);
                    lvCustomer.Items.Add(item);

                }
            }

        }

        private void deleteClient()
        {
            c.status = "INACTIVE";
            if (provide.deleteCustomer(int.Parse(tbuserId.Text), c.status))
            {
                CMsgBox.Show("Data successfully deleted!", "INFORMATION");
                viewClient();
            }
        } 
        #endregion

        #region EVENTS      
        private void Client_View_Load(object sender, EventArgs e)
        {
            viewClient();
        }

        private void updateCustomerAccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditClient client = new frmEditClient();
            DimForm.Show(this.ParentForm, client);
        }

        private void listviewClient_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                if (lvCustomer.FocusedItem.Bounds.Contains(e.Location) == true)
                    contextMenuStrip1.Show(Cursor.Position);

            tbuserId.Text = lvCustomer.SelectedItems[0].Text;
            Provider.filter_ID = tbuserId.Text;
            //MessageBox.Show(tbuserId.Text);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUser add = new frmAddUser();
            DimForm.Show(this.ParentForm, add);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteClient();
        } 
        #endregion

        private void btnCustTable_Click(object sender, EventArgs e)
        {
            lvCustomer.Visible = true;
            lvStaff.Visible = false;
            viewClient(); ;
        }

        private void btnStaffTable_Click(object sender, EventArgs e)
        {
            lvCustomer.Visible = false;
            lvStaff.Visible = true;
            viewStaff();
        }
 
    }
}
