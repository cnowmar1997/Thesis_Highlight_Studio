using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Thesis_Highlight_Studio.UserPanel
{
    public partial class PnlNotes : UserControl
    {
        static PnlNotes notes;
        public static UserControl Stack(Panel Stackpnl,string WhatToDo ,string description, string date, string time)
        {
            notes = new PnlNotes();
            notes.lblwhat.Text = WhatToDo;
            notes.lbldescr.Text = description;
            notes.lblTime.Text = time;
            notes.lblDate.Text = date;
            Stackpnl.Controls.Add(notes);
            notes.Dock = DockStyle.Top;
            notes.SendToBack();
            return notes;
        }
        public PnlNotes()
        {
            InitializeComponent();
        }
        
        public class MyLabel : Label
        {
            protected override void WndProc(ref Message m)
            {
                const int WM_NCHITTEST = 0x0084;
                const int HTTRANSPARENT = (-1);

                if (m.Msg == WM_NCHITTEST)
                {
                    m.Result = (IntPtr)HTTRANSPARENT;
                }
                else
                {
                    base.WndProc(ref m);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
