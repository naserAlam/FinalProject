
namespace FinalProject.Forms
{
    partial class SupplierForm
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
            this.lblSupplierCustomerTitle = new System.Windows.Forms.Label();
            this.TlpUserFields = new System.Windows.Forms.TableLayoutPanel();
            this.CbContactType = new System.Windows.Forms.ComboBox();
            this.LblContactType = new System.Windows.Forms.Label();
            this.TbContactEmail = new System.Windows.Forms.TextBox();
            this.LblContactEmail = new System.Windows.Forms.Label();
            this.LblContactNo = new System.Windows.Forms.Label();
            this.LblContactName = new System.Windows.Forms.Label();
            this.TbContactNo = new System.Windows.Forms.TextBox();
            this.TbContactName = new System.Windows.Forms.TextBox();
            this.DGVContactList = new System.Windows.Forms.DataGridView();
            this.LblSearch = new System.Windows.Forms.Label();
            this.TbSearchWord = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnDeleteUser = new System.Windows.Forms.Button();
            this.BtnUpdateUser = new System.Windows.Forms.Button();
            this.BtnSaveUser = new System.Windows.Forms.Button();
            this.TlpUserFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVContactList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSupplierCustomerTitle
            // 
            this.lblSupplierCustomerTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupplierCustomerTitle.AutoSize = true;
            this.lblSupplierCustomerTitle.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierCustomerTitle.Location = new System.Drawing.Point(338, 9);
            this.lblSupplierCustomerTitle.Name = "lblSupplierCustomerTitle";
            this.lblSupplierCustomerTitle.Size = new System.Drawing.Size(175, 42);
            this.lblSupplierCustomerTitle.TabIndex = 14;
            this.lblSupplierCustomerTitle.Text = "DEALER";
            // 
            // TlpUserFields
            // 
            this.TlpUserFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TlpUserFields.ColumnCount = 4;
            this.TlpUserFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.37234F));
            this.TlpUserFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.62766F));
            this.TlpUserFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.TlpUserFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.TlpUserFields.Controls.Add(this.CbContactType, 3, 0);
            this.TlpUserFields.Controls.Add(this.LblContactType, 2, 0);
            this.TlpUserFields.Controls.Add(this.TbContactEmail, 3, 1);
            this.TlpUserFields.Controls.Add(this.LblContactEmail, 2, 1);
            this.TlpUserFields.Controls.Add(this.LblContactNo, 0, 1);
            this.TlpUserFields.Controls.Add(this.LblContactName, 0, 0);
            this.TlpUserFields.Controls.Add(this.TbContactNo, 1, 1);
            this.TlpUserFields.Controls.Add(this.TbContactName, 1, 0);
            this.TlpUserFields.Location = new System.Drawing.Point(12, 54);
            this.TlpUserFields.Name = "TlpUserFields";
            this.TlpUserFields.RowCount = 2;
            this.TlpUserFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpUserFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpUserFields.Size = new System.Drawing.Size(791, 81);
            this.TlpUserFields.TabIndex = 15;
            // 
            // CbContactType
            // 
            this.CbContactType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbContactType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbContactType.FormattingEnabled = true;
            this.CbContactType.Items.AddRange(new object[] {
            "Dealer",
            "Customer"});
            this.CbContactType.Location = new System.Drawing.Point(531, 3);
            this.CbContactType.Name = "CbContactType";
            this.CbContactType.Size = new System.Drawing.Size(257, 28);
            this.CbContactType.TabIndex = 6;
            // 
            // LblContactType
            // 
            this.LblContactType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblContactType.AutoSize = true;
            this.LblContactType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContactType.Location = new System.Drawing.Point(383, 0);
            this.LblContactType.Name = "LblContactType";
            this.LblContactType.Size = new System.Drawing.Size(142, 25);
            this.LblContactType.TabIndex = 3;
            this.LblContactType.Text = "Type";
            this.LblContactType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbContactEmail
            // 
            this.TbContactEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbContactEmail.Location = new System.Drawing.Point(531, 43);
            this.TbContactEmail.Name = "TbContactEmail";
            this.TbContactEmail.Size = new System.Drawing.Size(257, 26);
            this.TbContactEmail.TabIndex = 5;
            // 
            // LblContactEmail
            // 
            this.LblContactEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblContactEmail.AutoSize = true;
            this.LblContactEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContactEmail.Location = new System.Drawing.Point(383, 40);
            this.LblContactEmail.Name = "LblContactEmail";
            this.LblContactEmail.Size = new System.Drawing.Size(142, 25);
            this.LblContactEmail.TabIndex = 2;
            this.LblContactEmail.Text = "Email";
            this.LblContactEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblContactNo
            // 
            this.LblContactNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblContactNo.AutoSize = true;
            this.LblContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContactNo.Location = new System.Drawing.Point(3, 40);
            this.LblContactNo.Name = "LblContactNo";
            this.LblContactNo.Size = new System.Drawing.Size(128, 25);
            this.LblContactNo.TabIndex = 0;
            this.LblContactNo.Text = "Contact No.";
            this.LblContactNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblContactName
            // 
            this.LblContactName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblContactName.AutoSize = true;
            this.LblContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContactName.Location = new System.Drawing.Point(3, 0);
            this.LblContactName.Name = "LblContactName";
            this.LblContactName.Size = new System.Drawing.Size(128, 25);
            this.LblContactName.TabIndex = 4;
            this.LblContactName.Text = "Name";
            this.LblContactName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbContactNo
            // 
            this.TbContactNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbContactNo.Location = new System.Drawing.Point(137, 43);
            this.TbContactNo.Name = "TbContactNo";
            this.TbContactNo.Size = new System.Drawing.Size(240, 26);
            this.TbContactNo.TabIndex = 5;
            // 
            // TbContactName
            // 
            this.TbContactName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbContactName.Location = new System.Drawing.Point(137, 3);
            this.TbContactName.Name = "TbContactName";
            this.TbContactName.Size = new System.Drawing.Size(240, 26);
            this.TbContactName.TabIndex = 5;
            // 
            // DGVContactList
            // 
            this.DGVContactList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVContactList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVContactList.Location = new System.Drawing.Point(9, 195);
            this.DGVContactList.Name = "DGVContactList";
            this.DGVContactList.RowHeadersWidth = 62;
            this.DGVContactList.RowTemplate.Height = 28;
            this.DGVContactList.Size = new System.Drawing.Size(791, 457);
            this.DGVContactList.TabIndex = 16;
            this.DGVContactList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVContactList_CellDoubleClick);
            // 
            // LblSearch
            // 
            this.LblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSearch.AutoSize = true;
            this.LblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearch.Location = new System.Drawing.Point(384, 155);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(75, 25);
            this.LblSearch.TabIndex = 20;
            this.LblSearch.Text = "Search";
            this.LblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbSearchWord
            // 
            this.TbSearchWord.Location = new System.Drawing.Point(465, 156);
            this.TbSearchWord.Name = "TbSearchWord";
            this.TbSearchWord.Size = new System.Drawing.Size(214, 26);
            this.TbSearchWord.TabIndex = 21;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(685, 145);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(118, 44);
            this.BtnSearch.TabIndex = 22;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnDeleteUser
            // 
            this.BtnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteUser.Location = new System.Drawing.Point(260, 145);
            this.BtnDeleteUser.Name = "BtnDeleteUser";
            this.BtnDeleteUser.Size = new System.Drawing.Size(118, 44);
            this.BtnDeleteUser.TabIndex = 19;
            this.BtnDeleteUser.Text = "Delete";
            this.BtnDeleteUser.UseVisualStyleBackColor = true;
            this.BtnDeleteUser.Click += new System.EventHandler(this.BtnDeleteUser_Click);
            // 
            // BtnUpdateUser
            // 
            this.BtnUpdateUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateUser.Location = new System.Drawing.Point(136, 145);
            this.BtnUpdateUser.Name = "BtnUpdateUser";
            this.BtnUpdateUser.Size = new System.Drawing.Size(118, 44);
            this.BtnUpdateUser.TabIndex = 18;
            this.BtnUpdateUser.Text = "Update";
            this.BtnUpdateUser.UseVisualStyleBackColor = true;
            this.BtnUpdateUser.Click += new System.EventHandler(this.BtnUpdateUser_Click);
            // 
            // BtnSaveUser
            // 
            this.BtnSaveUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveUser.Location = new System.Drawing.Point(12, 145);
            this.BtnSaveUser.Name = "BtnSaveUser";
            this.BtnSaveUser.Size = new System.Drawing.Size(118, 44);
            this.BtnSaveUser.TabIndex = 17;
            this.BtnSaveUser.Text = "Save";
            this.BtnSaveUser.UseVisualStyleBackColor = true;
            this.BtnSaveUser.Click += new System.EventHandler(this.BtnSaveUser_Click);
            // 
            // SupplierCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 664);
            this.Controls.Add(this.LblSearch);
            this.Controls.Add(this.TbSearchWord);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnDeleteUser);
            this.Controls.Add(this.BtnUpdateUser);
            this.Controls.Add(this.BtnSaveUser);
            this.Controls.Add(this.DGVContactList);
            this.Controls.Add(this.TlpUserFields);
            this.Controls.Add(this.lblSupplierCustomerTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupplierCustomerForm";
            this.Text = "SupplierCustomerForm";
            this.TlpUserFields.ResumeLayout(false);
            this.TlpUserFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVContactList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSupplierCustomerTitle;
        private System.Windows.Forms.TableLayoutPanel TlpUserFields;
        private System.Windows.Forms.Label LblContactNo;
        private System.Windows.Forms.Label LblContactType;
        private System.Windows.Forms.TextBox TbContactNo;
        private System.Windows.Forms.ComboBox CbContactType;
        private System.Windows.Forms.Label LblContactName;
        private System.Windows.Forms.TextBox TbContactName;
        private System.Windows.Forms.Label LblContactEmail;
        private System.Windows.Forms.TextBox TbContactEmail;
        private System.Windows.Forms.DataGridView DGVContactList;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.TextBox TbSearchWord;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnDeleteUser;
        private System.Windows.Forms.Button BtnUpdateUser;
        private System.Windows.Forms.Button BtnSaveUser;
    }
}