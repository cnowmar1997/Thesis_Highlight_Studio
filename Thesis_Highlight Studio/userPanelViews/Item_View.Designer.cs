namespace Thesis_Highlight_Studio.userPanelViews
{
    partial class Item_View
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.tbSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnPrintReports = new MaterialSkin.Controls.MaterialFlatButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateItemInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(26, 97);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1259, 516);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Id";
            this.columnHeader1.Width = 5;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 394;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 587;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.Width = 264;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Depth = 0;
            this.btnAdd.Location = new System.Drawing.Point(1089, 52);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = false;
            this.btnAdd.Size = new System.Drawing.Size(74, 36);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Depth = 0;
            this.tbSearch.Hint = "Search here";
            this.tbSearch.Location = new System.Drawing.Point(26, 68);
            this.tbSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.SelectedText = "";
            this.tbSearch.SelectionLength = 0;
            this.tbSearch.SelectionStart = 0;
            this.tbSearch.Size = new System.Drawing.Size(279, 23);
            this.tbSearch.TabIndex = 5;
            this.tbSearch.UseSystemPasswordChar = false;
            // 
            // btnPrintReports
            // 
            this.btnPrintReports.AutoSize = true;
            this.btnPrintReports.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrintReports.Depth = 0;
            this.btnPrintReports.Location = new System.Drawing.Point(1171, 52);
            this.btnPrintReports.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrintReports.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrintReports.Name = "btnPrintReports";
            this.btnPrintReports.Primary = false;
            this.btnPrintReports.Size = new System.Drawing.Size(114, 36);
            this.btnPrintReports.TabIndex = 7;
            this.btnPrintReports.Text = "Print Reports";
            this.btnPrintReports.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateItemInfoToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.refreshToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(206, 92);
            // 
            // updateItemInfoToolStripMenuItem
            // 
            this.updateItemInfoToolStripMenuItem.Name = "updateItemInfoToolStripMenuItem";
            this.updateItemInfoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.updateItemInfoToolStripMenuItem.Text = "Update item information";
            this.updateItemInfoToolStripMenuItem.Click += new System.EventHandler(this.updateItemInfoToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.refreshToolStripMenuItem1.Text = "Refresh";
            // 
            // Item_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrintReports);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Item_View";
            this.Size = new System.Drawing.Size(1306, 679);
            this.Load += new System.EventHandler(this.Item_View_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private MaterialSkin.Controls.MaterialFlatButton btnAdd;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbSearch;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MaterialSkin.Controls.MaterialFlatButton btnPrintReports;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateItemInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
    }
}
