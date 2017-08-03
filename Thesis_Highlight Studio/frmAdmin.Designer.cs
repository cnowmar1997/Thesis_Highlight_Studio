namespace Thesis_Highlight_Studio
{
    partial class frm_Main
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
            this.btn_GenerateReport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_SalesAndPurchases = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_ManagePhotos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_ManageClientSched = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_ManagePackage = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_ManageClient = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_ManageStaff = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.Menu_panel.Controls.Add(this.btn_GenerateReport);
            this.Menu_panel.Controls.Add(this.btn_SalesAndPurchases);
            this.Menu_panel.Controls.Add(this.btn_ManagePhotos);
            this.Menu_panel.Controls.Add(this.btn_ManageClientSched);
            this.Menu_panel.Controls.Add(this.btn_ManagePackage);
            this.Menu_panel.Controls.Add(this.btn_ManageClient);
            this.Menu_panel.Controls.Add(this.btn_ManageStaff);
            this.Menu_panel.Controls.Add(this.Menu_label);
            this.Menu_panel.Location = new System.Drawing.Point(0, 64);
            this.Menu_panel.Name = "Menu_panel";
            this.Menu_panel.Size = new System.Drawing.Size(220, 705);
            this.Menu_panel.TabIndex = 0;
            this.Menu_panel.MouseEnter += new System.EventHandler(this.Menu_panel_MouseEnter);
            this.Menu_panel.MouseLeave += new System.EventHandler(this.Menu_panel_MouseLeave);
            // 
            // btn_GenerateReport
            // 
            this.btn_GenerateReport.Depth = 0;
            this.btn_GenerateReport.Location = new System.Drawing.Point(14, 426);
            this.btn_GenerateReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_GenerateReport.Name = "btn_GenerateReport";
            this.btn_GenerateReport.Primary = true;
            this.btn_GenerateReport.Size = new System.Drawing.Size(175, 46);
            this.btn_GenerateReport.TabIndex = 0;
            this.btn_GenerateReport.Text = "Generate Report";
            this.btn_GenerateReport.UseVisualStyleBackColor = false;
            this.btn_GenerateReport.Visible = false;
            // 
            // btn_SalesAndPurchases
            // 
            this.btn_SalesAndPurchases.Depth = 0;
            this.btn_SalesAndPurchases.Location = new System.Drawing.Point(14, 360);
            this.btn_SalesAndPurchases.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_SalesAndPurchases.Name = "btn_SalesAndPurchases";
            this.btn_SalesAndPurchases.Primary = true;
            this.btn_SalesAndPurchases.Size = new System.Drawing.Size(175, 46);
            this.btn_SalesAndPurchases.TabIndex = 0;
            this.btn_SalesAndPurchases.Text = "Generate Reports";
            this.btn_SalesAndPurchases.UseVisualStyleBackColor = false;
            this.btn_SalesAndPurchases.Visible = false;
            this.btn_SalesAndPurchases.Click += new System.EventHandler(this.btn_SalesAndPurchases_Click);
            // 
            // btn_ManagePhotos
            // 
            this.btn_ManagePhotos.Depth = 0;
            this.btn_ManagePhotos.Location = new System.Drawing.Point(14, 303);
            this.btn_ManagePhotos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ManagePhotos.Name = "btn_ManagePhotos";
            this.btn_ManagePhotos.Primary = true;
            this.btn_ManagePhotos.Size = new System.Drawing.Size(175, 46);
            this.btn_ManagePhotos.TabIndex = 0;
            this.btn_ManagePhotos.Text = "Manage Photos";
            this.btn_ManagePhotos.UseVisualStyleBackColor = false;
            this.btn_ManagePhotos.Visible = false;
            // 
            // btn_ManageClientSched
            // 
            this.btn_ManageClientSched.Depth = 0;
            this.btn_ManageClientSched.Location = new System.Drawing.Point(14, 246);
            this.btn_ManageClientSched.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ManageClientSched.Name = "btn_ManageClientSched";
            this.btn_ManageClientSched.Primary = true;
            this.btn_ManageClientSched.Size = new System.Drawing.Size(175, 46);
            this.btn_ManageClientSched.TabIndex = 0;
            this.btn_ManageClientSched.Text = "Manage Customer\'s Order";
            this.btn_ManageClientSched.UseVisualStyleBackColor = false;
            this.btn_ManageClientSched.Visible = false;
            // 
            // btn_ManagePackage
            // 
            this.btn_ManagePackage.Depth = 0;
            this.btn_ManagePackage.Location = new System.Drawing.Point(14, 189);
            this.btn_ManagePackage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ManagePackage.Name = "btn_ManagePackage";
            this.btn_ManagePackage.Primary = true;
            this.btn_ManagePackage.Size = new System.Drawing.Size(175, 46);
            this.btn_ManagePackage.TabIndex = 0;
            this.btn_ManagePackage.Text = "Manage Packages";
            this.btn_ManagePackage.UseVisualStyleBackColor = false;
            this.btn_ManagePackage.Visible = false;
            // 
            // btn_ManageClient
            // 
            this.btn_ManageClient.Depth = 0;
            this.btn_ManageClient.Location = new System.Drawing.Point(14, 132);
            this.btn_ManageClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ManageClient.Name = "btn_ManageClient";
            this.btn_ManageClient.Primary = true;
            this.btn_ManageClient.Size = new System.Drawing.Size(175, 46);
            this.btn_ManageClient.TabIndex = 0;
            this.btn_ManageClient.Text = "Manage Accounts";
            this.btn_ManageClient.UseVisualStyleBackColor = false;
            this.btn_ManageClient.Visible = false;
            this.btn_ManageClient.Click += new System.EventHandler(this.btn_ManageClient_Click);
            // 
            // btn_ManageStaff
            // 
            this.btn_ManageStaff.Depth = 0;
            this.btn_ManageStaff.Location = new System.Drawing.Point(14, 75);
            this.btn_ManageStaff.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ManageStaff.Name = "btn_ManageStaff";
            this.btn_ManageStaff.Primary = true;
            this.btn_ManageStaff.Size = new System.Drawing.Size(175, 46);
            this.btn_ManageStaff.TabIndex = 0;
            this.btn_ManageStaff.Text = "Manage Own Account";
            this.btn_ManageStaff.UseVisualStyleBackColor = false;
            this.btn_ManageStaff.Visible = false;
            this.btn_ManageStaff.Click += new System.EventHandler(this.btn_ManageStaff_Click);
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
            this.Mainpnl.Location = new System.Drawing.Point(45, 78);
            this.Mainpnl.Name = "Mainpnl";
            this.Mainpnl.Size = new System.Drawing.Size(1306, 679);
            this.Mainpnl.TabIndex = 1;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.Menu_panel);
            this.Controls.Add(this.Mainpnl);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Main";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hi-Light Studio Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.frm_Dashboard_Load);
            this.Menu_panel.ResumeLayout(false);
            this.Menu_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu_panel;
        private System.Windows.Forms.Label Menu_label;
        private System.Windows.Forms.Timer timer_Open;
        private System.Windows.Forms.Timer timer_Close;
        private MaterialSkin.Controls.MaterialRaisedButton btn_ManageClientSched;
        private MaterialSkin.Controls.MaterialRaisedButton btn_ManagePackage;
        private MaterialSkin.Controls.MaterialRaisedButton btn_ManageClient;
        private MaterialSkin.Controls.MaterialRaisedButton btn_ManageStaff;
        private System.Windows.Forms.Panel Mainpnl;
        private MaterialSkin.Controls.MaterialRaisedButton btn_SalesAndPurchases;
        private MaterialSkin.Controls.MaterialRaisedButton btn_ManagePhotos;
        private MaterialSkin.Controls.MaterialRaisedButton btn_GenerateReport;

    }
}

