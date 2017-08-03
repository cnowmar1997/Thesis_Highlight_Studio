using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thesis_Highlight_Studio.userPanelViews
{
    public partial class transactionClientView : UserControl
    {

        private Point MouseDownLocation;
        private static transactionClientView _instance;

        public static transactionClientView Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new transactionClientView();
                return _instance;

            }
        }
        public transactionClientView()
        {
            InitializeComponent();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                if (listView1.FocusedItem.Bounds.Contains(e.Location) == true)
                    contextMenuStrip1.Show(Cursor.Position);

        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesAndPurchases SandP = new frmSalesAndPurchases();
            DimForm.Show(this.ParentForm, SandP);
        }
    }
}
