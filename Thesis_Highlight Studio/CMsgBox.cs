using System;
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
    public partial class CMsgBox : Form
    {
        public CMsgBox()
        {
            InitializeComponent();
        }
        static CMsgBox MsgBox;
        static DialogResult result { get; set; }
        public static DialogResult Show(Form owner, string message, string caption, CMsgBtns buttons)
        {
            MsgBox = new CMsgBox();
            MsgBox.Owner = owner;
            MsgBox.CaptionLbl.Text = caption;
            MsgBox.MessageLbl.Text = message;
            MsgBox.MessageLbl.Left = ((MsgBox.ClientSize.Width - MsgBox.MessageLbl.Size.Width) / 2);
            switch (buttons)
            {
                case CMsgBtns.YesNo:
                    MsgBox.ButtonNo.Visible = true;
                    MsgBox.ButtonYes.Visible = true;
                    MsgBox.ButtonOK.Visible = false;
                    MsgBox.AcceptButton = MsgBox.ButtonYes;
                    MsgBox.CancelButton = MsgBox.ButtonNo;
                    break;
                case CMsgBtns.OK:
                    MsgBox.ButtonYes.Visible = false;
                    MsgBox.ButtonNo.Visible = false;
                    MsgBox.ButtonOK.Visible = true;
                    MsgBox.AcceptButton = MsgBox.ButtonOK;
                    MsgBox.CancelButton = MsgBox.ButtonOK;
                    break;
            }
            MsgBox.ShowDialog();
            return result;
        }

        public static DialogResult Show(string message, string caption, CMsgBtns buttons)
        {
            MsgBox = new CMsgBox();
            MsgBox.CaptionLbl.Text = caption;
            MsgBox.MessageLbl.Text = message;
            MsgBox.MessageLbl.Left = ((MsgBox.ClientSize.Width - MsgBox.MessageLbl.Size.Width) / 2);
            switch (buttons)
            {
                case CMsgBtns.YesNo:
                    MsgBox.ButtonNo.Visible = true;
                    MsgBox.ButtonYes.Visible = true;
                    MsgBox.ButtonOK.Visible = false;
                    MsgBox.AcceptButton = MsgBox.ButtonYes;
                    MsgBox.CancelButton = MsgBox.ButtonNo;
                    break;
                case CMsgBtns.OK:
                    MsgBox.ButtonYes.Visible = false;
                    MsgBox.ButtonNo.Visible = false;
                    MsgBox.ButtonOK.Visible = true;
                    MsgBox.AcceptButton = MsgBox.ButtonOK;
                    MsgBox.CancelButton = MsgBox.ButtonOK;
                    break;
            }
            MsgBox.ShowDialog();
            return result;
        }

        public static DialogResult Show(string message, string caption)
        {
            MsgBox = new CMsgBox();
            MsgBox.CaptionLbl.Text = caption;
            MsgBox.MessageLbl.Text = message;
            MsgBox.MessageLbl.Left = ((MsgBox.ClientSize.Width - MsgBox.MessageLbl.Size.Width) / 2);
            MsgBox.ButtonYes.Visible = false;
            MsgBox.ButtonNo.Visible = false;
            MsgBox.ButtonOK.Visible = true;
            MsgBox.AcceptButton = MsgBox.ButtonOK;
            MsgBox.CancelButton = MsgBox.ButtonOK;
            MsgBox.ShowDialog();
            return result;
        }

        public static DialogResult Show(string message)
        {
            MsgBox = new CMsgBox();
            MsgBox.CaptionLbl.Text = "";
            MsgBox.MessageLbl.Text = message;
            MsgBox.MessageLbl.Left = ((MsgBox.ClientSize.Width - MsgBox.MessageLbl.Size.Width) / 2);
            MsgBox.ButtonYes.Visible = false;
            MsgBox.ButtonNo.Visible = false;
            MsgBox.ButtonOK.Visible = true;
            MsgBox.AcceptButton = MsgBox.ButtonOK;
            MsgBox.CancelButton = MsgBox.ButtonOK;
            MsgBox.ShowDialog();
            return result;
        }

        public enum CMsgBtns
        {
            YesNo,
            OK
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            MsgBox.Close();
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            MsgBox.Close();
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            result = DialogResult.No;
            MsgBox.Close();
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.IndianRed;
        }

        private void Mouse_Leave(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.Gainsboro;
        }

        #region WindowDragEvent
        public Point mouseLocation;
        private void frmInstallDevice_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void frmInstallDevice_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }
        #endregion

        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                // add the drop shadow flag for automatically drawing
                // a drop shadow around the form
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
    }
}

