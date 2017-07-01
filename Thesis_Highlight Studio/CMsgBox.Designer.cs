namespace Thesis_Highlight_Studio
{
    partial class CMsgBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MessageLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonYes = new System.Windows.Forms.Button();
            this.ButtonNo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CaptionLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageLbl
            // 
            this.MessageLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLbl.ForeColor = System.Drawing.Color.Black;
            this.MessageLbl.Location = new System.Drawing.Point(25, 41);
            this.MessageLbl.Name = "MessageLbl";
            this.MessageLbl.Size = new System.Drawing.Size(346, 118);
            this.MessageLbl.TabIndex = 6;
            this.MessageLbl.Text = "Message";
            this.MessageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.ButtonOK);
            this.panel1.Controls.Add(this.ButtonYes);
            this.panel1.Controls.Add(this.ButtonNo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 28);
            this.panel1.TabIndex = 4;
            // 
            // ButtonOK
            // 
            this.ButtonOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.ButtonOK.FlatAppearance.BorderSize = 0;
            this.ButtonOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOK.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOK.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonOK.Location = new System.Drawing.Point(181, 0);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(72, 28);
            this.ButtonOK.TabIndex = 2;
            this.ButtonOK.TabStop = false;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonYes
            // 
            this.ButtonYes.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonYes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.ButtonYes.FlatAppearance.BorderSize = 0;
            this.ButtonYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonYes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonYes.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonYes.Location = new System.Drawing.Point(253, 0);
            this.ButtonYes.Name = "ButtonYes";
            this.ButtonYes.Size = new System.Drawing.Size(72, 28);
            this.ButtonYes.TabIndex = 1;
            this.ButtonYes.TabStop = false;
            this.ButtonYes.Text = "Yes";
            this.ButtonYes.UseVisualStyleBackColor = true;
            this.ButtonYes.Click += new System.EventHandler(this.ButtonYes_Click);
            // 
            // ButtonNo
            // 
            this.ButtonNo.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonNo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.ButtonNo.FlatAppearance.BorderSize = 0;
            this.ButtonNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNo.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonNo.Location = new System.Drawing.Point(325, 0);
            this.ButtonNo.Name = "ButtonNo";
            this.ButtonNo.Size = new System.Drawing.Size(72, 28);
            this.ButtonNo.TabIndex = 0;
            this.ButtonNo.TabStop = false;
            this.ButtonNo.Text = "No";
            this.ButtonNo.UseVisualStyleBackColor = true;
            this.ButtonNo.Click += new System.EventHandler(this.ButtonNo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel2.Controls.Add(this.CaptionLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 30);
            this.panel2.TabIndex = 5;
            // 
            // CaptionLbl
            // 
            this.CaptionLbl.AutoSize = true;
            this.CaptionLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.CaptionLbl.Location = new System.Drawing.Point(6, 7);
            this.CaptionLbl.Name = "CaptionLbl";
            this.CaptionLbl.Size = new System.Drawing.Size(62, 17);
            this.CaptionLbl.TabIndex = 2;
            this.CaptionLbl.Text = "Caption";
            // 
            // CMsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(397, 199);
            this.Controls.Add(this.MessageLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CMsgBox";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CMsgBox";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MessageLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonYes;
        private System.Windows.Forms.Button ButtonNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CaptionLbl;
    }
}