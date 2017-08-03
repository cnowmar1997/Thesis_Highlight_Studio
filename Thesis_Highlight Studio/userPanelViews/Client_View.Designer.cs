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
            this.listviewClient = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSchoolName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCourse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMobileNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTeleNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmailAdd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateCustomerAccToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listviewClient
            // 
            this.listviewClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listviewClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnSchoolName,
            this.columnCourse,
            this.columnMobileNum,
            this.columnTeleNum,
            this.columnEmailAdd});
            this.listviewClient.FullRowSelect = true;
            this.listviewClient.GridLines = true;
            this.listviewClient.Location = new System.Drawing.Point(61, 64);
            this.listviewClient.MultiSelect = false;
            this.listviewClient.Name = "listviewClient";
            this.listviewClient.Size = new System.Drawing.Size(1193, 566);
            this.listviewClient.TabIndex = 0;
            this.listviewClient.UseCompatibleStateImageBehavior = false;
            this.listviewClient.View = System.Windows.Forms.View.Details;
            this.listviewClient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listviewClient_MouseClick);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnName.Width = 279;
            // 
            // columnSchoolName
            // 
            this.columnSchoolName.Text = "School Name";
            this.columnSchoolName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSchoolName.Width = 221;
            // 
            // columnCourse
            // 
            this.columnCourse.Text = "Course";
            this.columnCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCourse.Width = 177;
            // 
            // columnMobileNum
            // 
            this.columnMobileNum.Text = "Mobile Number";
            this.columnMobileNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnMobileNum.Width = 164;
            // 
            // columnTeleNum
            // 
            this.columnTeleNum.Text = "Telephone Number";
            this.columnTeleNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTeleNum.Width = 164;
            // 
            // columnEmailAdd
            // 
            this.columnEmailAdd.Text = "Email Address";
            this.columnEmailAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnEmailAdd.Width = 178;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateCustomerAccToolStripMenuItem,
            this.refreshToolStripMenuItem,
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
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.refreshToolStripMenuItem.Text = "Archive";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Search here";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(61, 26);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(279, 23);
            this.materialSingleLineTextField1.TabIndex = 3;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Thesis_Highlight_Studio.Properties.Resources.add;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(1135, 520);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 77);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.refreshToolStripMenuItem1.Text = "Refresh";
            // 
            // Client_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listviewClient);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Client_View";
            this.Size = new System.Drawing.Size(1306, 679);
            this.Load += new System.EventHandler(this.Client_View_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listviewClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerAccToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnSchoolName;
        private System.Windows.Forms.ColumnHeader columnCourse;
        private System.Windows.Forms.ColumnHeader columnMobileNum;
        private System.Windows.Forms.ColumnHeader columnTeleNum;
        private System.Windows.Forms.ColumnHeader columnEmailAdd;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
    }
}
