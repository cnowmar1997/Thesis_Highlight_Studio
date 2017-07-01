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
    public partial class frm_Dashboard : MaterialForm
    {
        private MaterialSkinManager skinManager;
        private int _startWidth = 42;
        private int _endWidth = 200;
        private int _stepSize = 10;
        private int _startOpen = 5;
        private int _endOpen = 163;
        private int _startlist = 1306;
        private int _endlist = 1135;
        private int _moveView = 48;
        private int _endmoveView = 219;

        public frm_Dashboard()
        {
            InitializeComponent();
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

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


        private void timer_Open_Tick(object sender, EventArgs e)
        {
            if (Menu_panel.Width == 42 & Mainpnl.Width == 1306 & Mainpnl.Left == 48)
            {
                Menu_panel.Width = _startWidth;
                Menu_label.Left = _startOpen;
                Mainpnl.Width = _startlist;
                Mainpnl.Left = _moveView;
             }

            Menu_panel.Width += _stepSize;
            Menu_label.Left += _stepSize;
            Mainpnl.Width += _stepSize;
            Mainpnl.Left += _stepSize;

            if (Menu_panel.Width > _endWidth & Menu_label.Left > _endOpen & Mainpnl.Width > _endlist & Mainpnl.Left > _endmoveView)
            {
                Menu_panel.Width = _endWidth;
                Menu_label.Left = _endOpen;
                Mainpnl.Width = _endlist;
                Mainpnl.Left = _endmoveView;
            }

            if (Menu_panel.Width == 200 || Mainpnl.Width == 1135 & Mainpnl.Left == 219)
            {
                timer_Open.Enabled = false;
            }
               

        }

        private void timer_Close_Tick(object sender, EventArgs e)
        {
            if (Menu_panel.Width == 200 || Mainpnl.Width == 1135 & Mainpnl.Left == 219)
            {
                Menu_panel.Width = _endWidth;
                Menu_label.Left = _endOpen;
                Mainpnl.Width = _endlist;
                Mainpnl.Left = _endmoveView;
            }
            Menu_panel.Width -= _stepSize;
            Menu_label.Left -= _stepSize;
            Mainpnl.Width += _stepSize;
            Mainpnl.Left -= _stepSize;
            if (Menu_panel.Width < _startWidth & Menu_label.Left < _startOpen || Mainpnl.Width > _endlist & Mainpnl.Left < _moveView)
            {
                Menu_panel.Width = _startWidth;
                Menu_label.Left = _startOpen;
                Mainpnl.Width = _startlist;
                Mainpnl.Left = _moveView;

            }
            if (Menu_panel.Width == 42 || Mainpnl.Width == 1306 & Mainpnl.Left == 48)
            {
                timer_Close.Enabled = false;
            }
        }

        private void Menu_panel_MouseEnter(object sender, EventArgs e)
        {
            bool mouse_on_control = true;
            foreach (Control c in Controls)
            {
                mouse_on_control |= c.RectangleToScreen(c.ClientRectangle).Contains(Cursor.Position);
            }

            if (mouse_on_control)
            {
                Menu_label.ForeColor = Color.WhiteSmoke;
                materialRaisedButton1.Visible = true;
                materialRaisedButton2.Visible = true;
                materialRaisedButton3.Visible = true;
                materialRaisedButton4.Visible = true;
                materialRaisedButton5.Visible = true;
                materialRaisedButton6.Visible = true;
                timer_Open.Enabled = true;
                timer_Close.Enabled = false;
            }
        }

        private void Menu_panel_MouseLeave(object sender, EventArgs e)
        {
            bool mouse_on_control = false;
            foreach (Control c in Controls)
            {
                mouse_on_control |= c.RectangleToScreen(c.ClientRectangle).Contains(Cursor.Position);
            }
            if (!mouse_on_control)
            {
                Menu_label.ForeColor = SystemColors.ControlText;
                materialRaisedButton1.Visible = false;
                materialRaisedButton2.Visible = false;
                materialRaisedButton3.Visible = false;
                materialRaisedButton4.Visible = false;
                materialRaisedButton5.Visible = false;
                materialRaisedButton6.Visible = false;
                timer_Open.Enabled = false;
                timer_Close.Enabled = true;
            }
        }
    }
}
