using System;
using System.Windows.Forms;

namespace Thesis_Highlight_Studio
{
    public partial class DimForm : Form
    {
        public DimForm()
        {
            InitializeComponent();
        }

        private static DimForm dim;
        public static void Show(Form Owner, Form Child)
        {
            dim = new DimForm();
            dim.Owner = Owner;
            dim.Size = Owner.Size;
            dim.Location = Owner.Location;
            Child.Owner = dim;
            Child.FormClosed += (_, args) => { dim.Hide(); };
            Child.StartPosition = FormStartPosition.CenterParent;
            dim.Show();
            Child.ShowDialog();
        }
    }
}