namespace Thesis_Highlight_Studio
{
    partial class frmEditItem
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSubmit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbDescription = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 37);
            this.panel2.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Edit Item";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(64, 231);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(43, 19);
            this.materialLabel3.TabIndex = 53;
            this.materialLabel3.Text = "Price";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(64, 193);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(86, 19);
            this.materialLabel2.TabIndex = 51;
            this.materialLabel2.Text = "Description";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(64, 152);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(49, 19);
            this.materialLabel1.TabIndex = 49;
            this.materialLabel1.Text = "Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(353, 333);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(116, 31);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Depth = 0;
            this.btnSubmit.Location = new System.Drawing.Point(231, 333);
            this.btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Primary = true;
            this.btnSubmit.Size = new System.Drawing.Size(116, 31);
            this.btnSubmit.TabIndex = 46;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(481, 27);
            this.panel3.TabIndex = 54;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(448, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 27);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "✖";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // tbPrice
            // 
            this.tbPrice.Depth = 0;
            this.tbPrice.Hint = "";
            this.tbPrice.Location = new System.Drawing.Point(197, 227);
            this.tbPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.SelectedText = "";
            this.tbPrice.SelectionLength = 0;
            this.tbPrice.SelectionStart = 0;
            this.tbPrice.Size = new System.Drawing.Size(195, 23);
            this.tbPrice.TabIndex = 58;
            this.tbPrice.UseSystemPasswordChar = false;
            // 
            // tbDescription
            // 
            this.tbDescription.Depth = 0;
            this.tbDescription.Hint = "";
            this.tbDescription.Location = new System.Drawing.Point(197, 189);
            this.tbDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.PasswordChar = '\0';
            this.tbDescription.SelectedText = "";
            this.tbDescription.SelectionLength = 0;
            this.tbDescription.SelectionStart = 0;
            this.tbDescription.Size = new System.Drawing.Size(195, 23);
            this.tbDescription.TabIndex = 57;
            this.tbDescription.UseSystemPasswordChar = false;
            // 
            // tbName
            // 
            this.tbName.Depth = 0;
            this.tbName.Hint = "e.g 1 by 1 ID Picture";
            this.tbName.Location = new System.Drawing.Point(197, 148);
            this.tbName.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.SelectedText = "";
            this.tbName.SelectionLength = 0;
            this.tbName.SelectionStart = 0;
            this.tbName.Size = new System.Drawing.Size(195, 23);
            this.tbName.TabIndex = 59;
            this.tbName.UseSystemPasswordChar = false;
            // 
            // frmEditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 376);
            this.ControlBox = false;
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditItem";
            this.Load += new System.EventHandler(this.frmEditItem_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialRaisedButton btnSubmit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbPrice;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbDescription;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbName;
    }
}