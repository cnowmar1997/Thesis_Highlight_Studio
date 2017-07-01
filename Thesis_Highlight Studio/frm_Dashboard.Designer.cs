namespace Thesis_Highlight_Studio
{
    partial class frm_Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.Menu_panel = new System.Windows.Forms.Panel();
            this.Menu_label = new System.Windows.Forms.Label();
            this.timer_Open = new System.Windows.Forms.Timer(this.components);
            this.timer_Close = new System.Windows.Forms.Timer(this.components);
            this.Mainpnl = new System.Windows.Forms.Panel();
            this.Menu_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_panel
            // 
            this.Menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.Menu_panel.Controls.Add(this.Menu_label);
            this.Menu_panel.Location = new System.Drawing.Point(0, 64);
            this.Menu_panel.Name = "Menu_panel";
            this.Menu_panel.Size = new System.Drawing.Size(42, 705);
            this.Menu_panel.TabIndex = 0;
            // 
            // Menu_label
            // 
            this.Menu_label.AutoSize = true;
            this.Menu_label.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_label.Location = new System.Drawing.Point(2, 2);
            this.Menu_label.Name = "Menu_label";
            this.Menu_label.Size = new System.Drawing.Size(37, 40);
            this.Menu_label.TabIndex = 0;
            this.Menu_label.Text = "≡";
            this.Menu_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer_Open
            // 
            this.timer_Open.Interval = 1;
            this.timer_Open.Tick += new System.EventHandler(this.timer_Open_Tick);
            // 
            // timer_Close
            // 
            this.timer_Close.Interval = 1;
            this.timer_Close.Tick += new System.EventHandler(this.timer_Close_Tick);
            // 
            // Mainpnl
            // 
            this.Mainpnl.Location = new System.Drawing.Point(48, 77);
            this.Mainpnl.Name = "Mainpnl";
            this.Mainpnl.Size = new System.Drawing.Size(1306, 679);
            this.Mainpnl.TabIndex = 1;
            // 
            // frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.Mainpnl);
            this.Controls.Add(this.Menu_panel);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hi-Light Studio Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Menu_panel.ResumeLayout(false);
            this.Menu_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu_panel;
        private System.Windows.Forms.Label Menu_label;
        private System.Windows.Forms.Timer timer_Open;
        private System.Windows.Forms.Timer timer_Close;
        private System.Windows.Forms.Panel Mainpnl;

    }
}

