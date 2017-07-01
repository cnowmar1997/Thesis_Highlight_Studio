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
    public partial class Client_Views : UserControl
    {
        private static Client_Views _instance;
        public static Client_Views Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new Client_Views();
                return _instance;

            }
        }
        public Client_Views()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            _AddClient add = new _AddClient();
            DimForm.Show(this.ParentForm, add);
        }
    }
}
