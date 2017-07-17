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
    public partial class frm_Client : MaterialForm
    {
        DimForm df = new DimForm();
        Provider P = new Provider();
        private MaterialSkinManager skinManager;
        Color btnBackColor = Color.FromArgb(36, 89, 82);
        Color retBackColor = Color.FromArgb(55, 71, 79);
        private int _startWidth = 42;
        private int _endWidth = 200;
        private int _stepSize = 10;
        private int _startOpen = 5;
        private int _endOpen = 163;
        private int _startlist = 1306;
        private int _endlist = 1135;
        private int _moveView = 48;
        private int _endmoveView = 219;

        public frm_Client()
        {
            InitializeComponent();
            //Mainpnl.AutoScroll = true;

            //// Mainpnl.AutoScrollMinSize = new Size(0, 0);
            ////Mainpnl.AutoScrollPosition = new Point(0,0);
            //int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            //style |= NativeWinAPI.WS_EX_COMPOSITED;
            //NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
            //skinManager = MaterialSkinManager.Instance;
            //skinManager.AddFormToManage(this);
            //skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //skinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        internal static class NativeWinAPI
        {
            internal static readonly int GWL_EXSTYLE = -20;
            internal static readonly int WS_EX_COMPOSITED = 0x02000000;

            [DllImport("user32")]
            internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32")]
            internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        }

    }
}
