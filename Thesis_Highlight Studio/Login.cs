using System;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thesis_Highlight_Studio
{
    public partial class Login : MaterialForm
    {
        private readonly MaterialSkinManager skinManager;
        public Login()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange700, TextShade.WHITE);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            skinManager.RemoveFormToManage(this);
            this.Hide();
            frmAdmin db = new frmAdmin();
            db.Show();
        }

      

    }
}
