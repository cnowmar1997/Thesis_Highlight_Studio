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
    public partial class Item_View : UserControl
    {
        private static Item_View _instance;

        public static Item_View Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new Item_View();
                return _instance;

            }
        }

        public Item_View()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddItem add = new frmAddItem();
            DimForm.Show(this.ParentForm, add);
        }
    }
}
