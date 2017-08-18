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
            this.lvCustomer = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSchoolName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCourse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnContactDetails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmailAdd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateCustomerAccToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnPrintReports = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCustTable = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnStaffTable = new MaterialSkin.Controls.MaterialFlatButton();
            this.lvStaff = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvCustomer
            // 
            this.lvCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnName,
            this.columnSchoolName,
            this.columnCourse,
            this.columnContactDetails,
            this.columnEmailAdd});
            this.lvCustomer.FullRowSelect = true;
            this.lvCustomer.GridLines = true;
            this.lvCustomer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCustomer.Location = new System.Drawing.Point(10, 92);
            this.lvCustomer.MultiSelect = false;
            this.lvCustomer.Name = "lvCustomer";
            this.lvCustomer.Size = new System.Drawing.Size(1283, 564);
            this.lvCustomer.TabIndex = 0;
            this.lvCustomer.UseCompatibleStateImageBehavior = false;
            this.lvCustomer.View = System.Windows.Forms.View.Details;
            this.lvCustomer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listviewClient_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Client ID";
            this.columnHeader1.Width = 0;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 336;
            // 
            // columnSchoolName
            // 
            this.columnSchoolName.Text = "School Name";
            this.columnSchoolName.Width = 220;
            // 
            // columnCourse
            // 
            this.columnCourse.Text = "Course";
            this.columnCourse.Width = 220;
            // 
            // columnContactDetails
            // 
            this.columnContactDetails.Text = "Contact Details";
            this.columnContactDetails.Width = 250;
            // 
            // columnEmailAdd
            // 
            this.columnEmailAdd.Text = "Email Address";
            this.columnEmailAdd.Width = 252;
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
            this.tbSearch.Location = new System.Drawing.Point(10, 63);
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
            this.btnAdd.Location = new System.Drawing.Point(1095, 47);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = false;
            this.btnAdd.Size = new System.Drawing.Size(76, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add User";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPrintReports
            // 
            this.btnPrintReports.AutoSize = true;
            this.btnPrintReports.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrintReports.Depth = 0;
            this.btnPrintReports.Location = new System.Drawing.Point(1179, 47);
            this.btnPrintReports.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrintReports.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrintReports.Name = "btnPrintReports";
            this.btnPrintReports.Primary = false;
            this.btnPrintReports.Size = new System.Drawing.Size(114, 36);
            this.btnPrintReports.TabIndex = 5;
            this.btnPrintReports.Text = "Print Reports";
            this.btnPrintReports.UseVisualStyleBackColor = true;
            // 
            // btnCustTable
            // 
            this.btnCustTable.AutoSize = true;
            this.btnCustTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCustTable.Depth = 0;
            this.btnCustTable.Location = new System.Drawing.Point(950, 47);
            this.btnCustTable.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCustTable.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCustTable.Name = "btnCustTable";
            this.btnCustTable.Primary = false;
            this.btnCustTable.Size = new System.Drawing.Size(137, 36);
            this.btnCustTable.TabIndex = 6;
            this.btnCustTable.Text = "Customers Table";
            this.btnCustTable.UseVisualStyleBackColor = true;
            this.btnCustTable.Click += new System.EventHandler(this.btnCustTable_Click);
            // 
            // btnStaffTable
            // 
            this.btnStaffTable.AutoSize = true;
            this.btnStaffTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStaffTable.Depth = 0;
            this.btnStaffTable.Location = new System.Drawing.Point(834, 47);
            this.btnStaffTable.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStaffTable.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStaffTable.Name = "btnStaffTable";
            this.btnStaffTable.Primary = false;
            this.btnStaffTable.Size = new System.Drawing.Size(108, 36);
            this.btnStaffTable.TabIndex = 7;
            this.btnStaffTable.Text = "Staff\'s Table";
            this.btnStaffTable.UseVisualStyleBackColor = true;
            this.btnStaffTable.Click += new System.EventHandler(this.btnStaffTable_Click);
            // 
            // lvStaff
            // 
            this.lvStaff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader7});
            this.lvStaff.FullRowSelect = true;
            this.lvStaff.GridLines = true;
            this.lvStaff.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvStaff.Location = new System.Drawing.Point(10, 92);
            this.lvStaff.MultiSelect = false;
            this.lvStaff.Name = "lvStaff";
            this.lvStaff.Size = new System.Drawing.Size(1283, 564);
            this.lvStaff.TabIndex = 8;
            this.lvStaff.UseCompatibleStateImageBehavior = false;
            this.lvStaff.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "userID";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 427;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Contact Details";
            this.columnHeader6.Width = 407;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Email Address";
            this.columnHeader7.Width = 440;
            // 
            // Client_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvStaff);
            this.Controls.Add(this.btnStaffTable);
            this.Controls.Add(this.btnCustTable);
            this.Controls.Add(this.btnPrintReports);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lvCustomer);
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

        private System.Windows.Forms.ListView lvCustomer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerAccToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnSchoolName;
        private System.Windows.Forms.ColumnHeader columnCourse;
        private System.Windows.Forms.ColumnHeader columnContactDetails;
        private System.Windows.Forms.ColumnHeader columnEmailAdd;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbSearch;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MaterialSkin.Controls.MaterialFlatButton btnAdd;
        private MaterialSkin.Controls.MaterialFlatButton btnPrintReports;
        private MaterialSkin.Controls.MaterialFlatButton btnCustTable;
        private MaterialSkin.Controls.MaterialFlatButton btnStaffTable;
        private System.Windows.Forms.ListView lvStaff;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}
