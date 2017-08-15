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
        Provider provide = new Provider();

        TextBox tbItemId = new TextBox();

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

        private void viewItem()
        {
            listView1.Items.Clear();
            var list = provide.viewItem();

            if (list != null)
            {
                foreach (Itemlist itm in list)
                {
                    ListViewItem item = new ListViewItem(itm.itemId.ToString());
                    item.SubItems.Add(itm.name);
                    item.SubItems.Add(itm.description);
                    item.SubItems.Add(itm.price);
                    listView1.Items.Add(item);

                }
            }

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddItem add = new frmAddItem();
            DimForm.Show(this.ParentForm, add);
        }

        private void Item_View_Load(object sender, EventArgs e)
        {
            viewItem();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                if (listView1.FocusedItem.Bounds.Contains(e.Location) == true)
                    contextMenuStrip1.Show(Cursor.Position);

            tbItemId.Text = listView1.SelectedItems[0].Text;
            Provider.filter_ID = tbItemId.Text;
        }

        private void updateItemInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditItem item = new frmEditItem();
            DimForm.Show(this.ParentForm, item);
        }
    }
}
