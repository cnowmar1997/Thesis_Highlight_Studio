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
    public partial class frm_Admin : MaterialForm
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


        public frm_Admin()
        {
            InitializeComponent();
            Mainpnl.AutoScroll = true;
     
            // Mainpnl.AutoScrollMinSize = new Size(0, 0);
            //Mainpnl.AutoScrollPosition = new Point(0,0);
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

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
        void populate()
        {
            var list = P.Notes();
            if (list.Any())
            {
                foreach (var tra in list)
                {
                    UserPanel.PnlNotes.Stack(this.Mainpnl, tra.WhatToDo, tra.description, tra.time, tra.date);
                }
            }
            else
            {
                CMsgBox.Show("Empty");
            }
        }

        void reset_buttons()
        {
            materialRaisedButton1.Enabled = true;
            materialRaisedButton2.Enabled = true;
            materialRaisedButton3.Enabled = true;
            materialRaisedButton4.Enabled = true;
            materialRaisedButton5.Enabled = true;
            materialRaisedButton6.Enabled = true;

            materialRaisedButton1.BackColor = retBackColor;
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

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Mainpnl.Controls.Clear();
            try
            {
                reset_buttons();
                if (Mainpnl.Controls.Count < 1)
                {
                    reset_buttons();
                    if (Mainpnl.Controls.Count < 1)
                    {  
                        Mainpnl.Controls.Add(UserPanel.Client_Views.Instance);
                        UserPanel.Client_Views.Instance.Dock = DockStyle.Fill;
                    }
                    else
                    {
                        Mainpnl.Controls.Clear();
                        Mainpnl.Controls.Add(UserPanel.Client_Views.Instance);
                        UserPanel.Client_Views.Instance.Dock = DockStyle.Fill;
                    }
                    Button btn = sender as Button;
                    btn.Enabled = false;
                    btn.BackColor = btnBackColor;
                    UserPanel.Client_Views.Instance.Focus();
                }
            }
            catch (Exception ex)
            {
                CMsgBox.Show(ex.Message);     
            }
        }

        private void frm_Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CMsgBox.Show("Are you sure you want to logout?", "Logging off........", CMsgBox.CMsgBtns.YesNo) == DialogResult.Yes)
            {
                skinManager.RemoveFormToManage(this);
                Login log = new Login();
                log.Show();
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void frm_Dashboard_Load(object sender, EventArgs e)
        {
            //populate();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Mainpnl.Controls.Clear();
            try
            {
                reset_buttons();
                if (Mainpnl.Controls.Count < 1)
                {
                    reset_buttons();
                    if (Mainpnl.Controls.Count < 1)
                    {
                        Mainpnl.Controls.Add(UserPanel.Client_Views.Instance);
                        UserPanel.Client_Views.Instance.Dock = DockStyle.Fill;
                    }
                    else
                    {
                        Mainpnl.Controls.Clear();
                        Mainpnl.Controls.Add(UserPanel.Client_Views.Instance);
                        UserPanel.Client_Views.Instance.Dock = DockStyle.Fill;
                    }
                    Button btn = sender as Button;
                    btn.Enabled = false;
                    btn.BackColor = btnBackColor;
                    UserPanel.Client_Views.Instance.Focus();
                }
            }
            catch (Exception ex)
            {
                CMsgBox.Show(ex.Message);
            }
        }
    }
}
