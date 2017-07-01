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

namespace Thesis_Highlight_Studio
{
    public partial class frm_Dashboard : MaterialForm
    {
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
    }
}
