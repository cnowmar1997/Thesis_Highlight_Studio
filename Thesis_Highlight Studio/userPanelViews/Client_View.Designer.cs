namespace Thesis_Highlight_Studio.UserPanel
{
    partial class Client_View
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listViewClient = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSchoolName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCourse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMobileNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTeleNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmailAdd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateCustomerAccToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnPrintReports = new MaterialSkin.Controls.MaterialFlatButton();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewClient
            // 
            this.listViewClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnName,
            this.columnSchoolName,
            this.columnCourse,
            this.columnMobileNum,
            this.columnTeleNum,
            this.columnEmailAdd});
            this.listViewClient.FullRowSelect = true;
            this.listViewClient.GridLines = true;
            this.listViewClient.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewClient.Location = new System.Drawing.Point(10, 77);
            this.listViewClient.MultiSelect = false;
            this.listViewClient.Name = "listViewClient";
            this.listViewClient.Size = new System.Drawing.Size(1283, 579);
            this.listViewClient.TabIndex = 0;
            this.listViewClient.UseCompatibleStateImageBehavior = false;
            this.listViewClient.View = System.Windows.Forms.View.Details;
            this.listViewClient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listviewClient_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Client ID";
            this.columnHeader1.Width = 0;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 262;
            // 
            // columnSchoolName
            // 
            this.columnSchoolName.Text = "School Name";
            this.columnSchoolName.Width = 221;
            // 
            // columnCourse
            // 
            this.columnCourse.Text = "Course";
            this.columnCourse.Width = 177;
            // 
            // columnMobileNum
            // 
            this.columnMobileNum.Text = "Mobile Number";
            this.columnMobileNum.Width = 164;
            // 
            // columnTeleNum
            // 
            this.columnTeleNum.Text = "Telephone Number";
            this.columnTeleNum.Width = 164;
            // 
            // columnEmailAdd
            // 
            this.columnEmailAdd.Text = "Email Address";
            this.columnEmailAdd.Width = 178;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateCustomerAccToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.refreshToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 70);
            // 
            // updateCustomerAccToolStripMenuItem
            // 
            this.updateCustomerAccToolStripMenuItem.Name = "updateCustomerAccToolStripMenuItem";
            this.updateCustomerAccToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.updateCustomerAccToolStripMenuItem.Text = "Update customer account";
            this.updateCustomerAccToolStripMenuItem.Click += new System.EventHandler(this.updateCustomerAccToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.refreshToolStripMenuItem1.Text = "Refresh";
            // 
            // tbSearch
            // 
            this.tbSearch.Depth = 0;
            this.tbSearch.Hint = "Search here";
            this.tbSearch.Location = new System.Drawing.Point(10, 48);
            this.tbSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.SelectedText = "";
            this.tbSearch.SelectionLength = 0;
            this.tbSearch.SelectionStart = 0;
            this.tbSearch.Size = new System.Drawing.Size(279, 23);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.UseSystemPasswordChar = false;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Depth = 0;
            this.btnAdd.Location = new System.Drawing.Point(1056, 35);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = false;
            this.btnAdd.Size = new System.Drawing.Size(115, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Customer";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPrintReports
            // 
            this.btnPrintReports.AutoSize = true;
            this.btnPrintReports.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrintReports.Depth = 0;
            this.btnPrintReports.Location = new System.Drawing.Point(1179, 35);
            this.btnPrintReports.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrintReports.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrintReports.Name = "btnPrintReports";
            this.btnPrintReports.Primary = false;
            this.btnPrintReports.Size = new System.Drawing.Size(114, 36);
            this.btnPrintReports.TabIndex = 5;
            this.btnPrintReports.Text = "Print Reports";
            this.btnPrintReports.UseVisualStyleBackColor = true;
            // 
            // Client_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrintReports);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.listViewClient);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Client_View";
            this.Size = new System.Drawing.Size(1306, 679);
            this.Load += new System.EventHandler(this.Client_View_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewClient;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerAccToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnSchoolName;
        private System.Windows.Forms.ColumnHeader columnCourse;
        private System.Windows.Forms.ColumnHeader columnMobileNum;
        private System.Windows.Forms.ColumnHeader columnTeleNum;
        private System.Windows.Forms.ColumnHeader columnEmailAdd;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbSearch;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MaterialSkin.Controls.MaterialFlatButton btnAdd;
        private MaterialSkin.Controls.MaterialFlatButton btnPrintReports;
    }
}
