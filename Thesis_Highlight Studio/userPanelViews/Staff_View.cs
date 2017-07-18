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
    public partial class Staff_View : UserControl
    {

       private Point MouseDownLocation;
       private static Staff_View _instance;
       public static Staff_View Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new Staff_View();
                return _instance;

            }
        }
        public Staff_View()
        {
            InitializeComponent();
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
            frmAddUser add = new frmAddUser();
            DimForm.Show(this.ParentForm, add);
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                //if (listView1.FocusedItem.Bounds.Contains(e.Location) == true)
                contextMenuStrip1.Show(Cursor.Position);
        }
    }
}
