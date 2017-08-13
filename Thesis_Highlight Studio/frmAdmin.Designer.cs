namespace Thesis_Highlight_Studio
{
    partial class frmAdmin
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
            this.btnPhotos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnPurchaseOrder = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnPackages = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnClient = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Menu_label = new System.Windows.Forms.Label();
            this.timer_Open = new System.Windows.Forms.Timer(this.components);
            this.timer_Close = new System.Windows.Forms.Timer(this.components);
            this.Mainpnl = new System.Windows.Forms.Panel();
            this.btnItems = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Menu_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_panel
            // 
            this.Menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.Menu_panel.Controls.Add(this.btnItems);
            this.Menu_panel.Controls.Add(this.btnPhotos);
            this.Menu_panel.Controls.Add(this.btnPurchaseOrder);
            this.Menu_panel.Controls.Add(this.btnPackages);
            this.Menu_panel.Controls.Add(this.btnClient);
            this.Menu_panel.Controls.Add(this.Menu_label);
            this.Menu_panel.Location = new System.Drawing.Point(0, 64);
            this.Menu_panel.Name = "Menu_panel";
            this.Menu_panel.Size = new System.Drawing.Size(198, 705);
            this.Menu_panel.TabIndex = 0;
            this.Menu_panel.MouseEnter += new System.EventHandler(this.Menu_panel_MouseEnter);
            this.Menu_panel.MouseLeave += new System.EventHandler(this.Menu_panel_MouseLeave);
            // 
            // btnPhotos
            // 
            this.btnPhotos.Depth = 0;
            this.btnPhotos.Location = new System.Drawing.Point(12, 318);
            this.btnPhotos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPhotos.Name = "btnPhotos";
            this.btnPhotos.Primary = true;
            this.btnPhotos.Size = new System.Drawing.Size(175, 46);
            this.btnPhotos.TabIndex = 0;
            this.btnPhotos.Text = "Photos";
            this.btnPhotos.UseVisualStyleBackColor = false;
            this.btnPhotos.Visible = false;
            // 
            // btnPurchaseOrder
            // 
            this.btnPurchaseOrder.Depth = 0;
            this.btnPurchaseOrder.Location = new System.Drawing.Point(12, 255);
            this.btnPurchaseOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPurchaseOrder.Name = "btnPurchaseOrder";
            this.btnPurchaseOrder.Primary = true;
            this.btnPurchaseOrder.Size = new System.Drawing.Size(175, 46);
            this.btnPurchaseOrder.TabIndex = 0;
            this.btnPurchaseOrder.Text = "Purchase Order";
            this.btnPurchaseOrder.UseVisualStyleBackColor = false;
            this.btnPurchaseOrder.Visible = false;
            // 
            // btnPackages
            // 
            this.btnPackages.Depth = 0;
            this.btnPackages.Location = new System.Drawing.Point(12, 126);
            this.btnPackages.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Primary = true;
            this.btnPackages.Size = new System.Drawing.Size(175, 46);
            this.btnPackages.TabIndex = 0;
            this.btnPackages.Text = "Packages";
            this.btnPackages.UseVisualStyleBackColor = false;
            this.btnPackages.Visible = false;
            // 
            // btnClient
            // 
            this.btnClient.Depth = 0;
            this.btnClient.Location = new System.Drawing.Point(12, 380);
            this.btnClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClient.Name = "btnClient";
            this.btnClient.Primary = true;
            this.btnClient.Size = new System.Drawing.Size(175, 46);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Accounts";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Visible = false;
            this.btnClient.Click += new System.EventHandler(this.btn_ManageClient_Click);
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
            // btnItems
            // 
            this.btnItems.Depth = 0;
            this.btnItems.Location = new System.Drawing.Point(12, 192);
            this.btnItems.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnItems.Name = "btnItems";
            this.btnItems.Primary = true;
            this.btnItems.Size = new System.Drawing.Size(175, 46);
            this.btnItems.TabIndex = 2;
            this.btnItems.Text = "Items";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.Menu_panel);
            this.Controls.Add(this.Mainpnl);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdmin";
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
        private MaterialSkin.Controls.MaterialRaisedButton btnPurchaseOrder;
        private MaterialSkin.Controls.MaterialRaisedButton btnPackages;
        private MaterialSkin.Controls.MaterialRaisedButton btnClient;
        private System.Windows.Forms.Panel Mainpnl;
        private MaterialSkin.Controls.MaterialRaisedButton btnPhotos;
        private MaterialSkin.Controls.MaterialRaisedButton btnItems;

    }
}

