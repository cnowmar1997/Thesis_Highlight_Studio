namespace Thesis_Highlight_Studio
{
    partial class frmAddItem
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
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tbItemPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tbItemDescription = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbItemName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSubmit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(64, 157);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(77, 19);
            this.materialLabel3.TabIndex = 15;
            this.materialLabel3.Text = "Item Price";
            // 
            // tbItemPrice
            // 
            this.tbItemPrice.Depth = 0;
            this.tbItemPrice.Hint = "";
            this.tbItemPrice.Location = new System.Drawing.Point(197, 153);
            this.tbItemPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbItemPrice.Name = "tbItemPrice";
            this.tbItemPrice.PasswordChar = '\0';
            this.tbItemPrice.SelectedText = "";
            this.tbItemPrice.SelectionLength = 0;
            this.tbItemPrice.SelectionStart = 0;
            this.tbItemPrice.Size = new System.Drawing.Size(195, 23);
            this.tbItemPrice.TabIndex = 14;
            this.tbItemPrice.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(64, 197);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(120, 19);
            this.materialLabel2.TabIndex = 13;
            this.materialLabel2.Text = "Item Description";
            // 
            // tbItemDescription
            // 
            this.tbItemDescription.Depth = 0;
            this.tbItemDescription.Hint = "";
            this.tbItemDescription.Location = new System.Drawing.Point(197, 193);
            this.tbItemDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbItemDescription.Name = "tbItemDescription";
            this.tbItemDescription.PasswordChar = '\0';
            this.tbItemDescription.SelectedText = "";
            this.tbItemDescription.SelectionLength = 0;
            this.tbItemDescription.SelectionStart = 0;
            this.tbItemDescription.Size = new System.Drawing.Size(195, 23);
            this.tbItemDescription.TabIndex = 12;
            this.tbItemDescription.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(64, 117);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(83, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Item Name";
            // 
            // tbItemName
            // 
            this.tbItemName.Depth = 0;
            this.tbItemName.Hint = "";
            this.tbItemName.Location = new System.Drawing.Point(197, 113);
            this.tbItemName.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.PasswordChar = '\0';
            this.tbItemName.SelectedText = "";
            this.tbItemName.SelectionLength = 0;
            this.tbItemName.SelectionStart = 0;
            this.tbItemName.Size = new System.Drawing.Size(195, 23);
            this.tbItemName.TabIndex = 10;
            this.tbItemName.UseSystemPasswordChar = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(276, 276);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(116, 31);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Depth = 0;
            this.btnSubmit.Location = new System.Drawing.Point(154, 276);
            this.btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Primary = true;
            this.btnSubmit.Size = new System.Drawing.Size(116, 31);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 376);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.tbItemPrice);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.tbItemDescription);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F);
            this.Name = "frmAddItem";
            this.Text = "frmAddItem";
            this.Load += new System.EventHandler(this.frmAddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbItemPrice;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbItemDescription;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbItemName;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialRaisedButton btnSubmit;

    }
}