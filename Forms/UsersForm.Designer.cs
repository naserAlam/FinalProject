
namespace FinalProject
{
    partial class UsersForm
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
            this.LblUserTitle = new System.Windows.Forms.Label();
            this.TlpUserFields = new System.Windows.Forms.TableLayoutPanel();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblContantNo = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblUserType = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.TbFirstName = new System.Windows.Forms.TextBox();
            this.TbLastName = new System.Windows.Forms.TextBox();
            this.TbContactNo = new System.Windows.Forms.TextBox();
            this.TbUsername = new System.Windows.Forms.TextBox();
            this.CbUserType = new System.Windows.Forms.ComboBox();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.DGVUserList = new System.Windows.Forms.DataGridView();
            this.BtnSaveUser = new System.Windows.Forms.Button();
            this.BtnUpdateUser = new System.Windows.Forms.Button();
            this.BtnDeleteUser = new System.Windows.Forms.Button();
            this.TlpUserFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUserTitle
            // 
            this.LblUserTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUserTitle.AutoSize = true;
            this.LblUserTitle.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserTitle.Location = new System.Drawing.Point(324, 19);
            this.LblUserTitle.Name = "LblUserTitle";
            this.LblUserTitle.Size = new System.Drawing.Size(147, 42);
            this.LblUserTitle.TabIndex = 0;
            this.LblUserTitle.Text = "USERS";
            // 
            // TlpUserFields
            // 
            this.TlpUserFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TlpUserFields.ColumnCount = 4;
            this.TlpUserFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.37234F));
            this.TlpUserFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.62766F));
            this.TlpUserFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.TlpUserFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.TlpUserFields.Controls.Add(this.LblFirstName, 0, 0);
            this.TlpUserFields.Controls.Add(this.LblLastName, 2, 0);
            this.TlpUserFields.Controls.Add(this.LblContantNo, 0, 1);
            this.TlpUserFields.Controls.Add(this.LblEmail, 2, 1);
            this.TlpUserFields.Controls.Add(this.LblUserType, 0, 2);
            this.TlpUserFields.Controls.Add(this.LblUsername, 2, 2);
            this.TlpUserFields.Controls.Add(this.TbFirstName, 1, 0);
            this.TlpUserFields.Controls.Add(this.TbLastName, 3, 0);
            this.TlpUserFields.Controls.Add(this.TbContactNo, 1, 1);
            this.TlpUserFields.Controls.Add(this.TbUsername, 3, 2);
            this.TlpUserFields.Controls.Add(this.CbUserType, 1, 2);
            this.TlpUserFields.Controls.Add(this.TbEmail, 3, 1);
            this.TlpUserFields.Location = new System.Drawing.Point(12, 74);
            this.TlpUserFields.Name = "TlpUserFields";
            this.TlpUserFields.RowCount = 3;
            this.TlpUserFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpUserFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpUserFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.TlpUserFields.Size = new System.Drawing.Size(791, 109);
            this.TlpUserFields.TabIndex = 1;
            // 
            // LblFirstName
            // 
            this.LblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFirstName.Location = new System.Drawing.Point(3, 0);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(132, 25);
            this.LblFirstName.TabIndex = 0;
            this.LblFirstName.Text = "First Name";
            this.LblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblLastName
            // 
            this.LblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLastName.AutoSize = true;
            this.LblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastName.Location = new System.Drawing.Point(393, 0);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(142, 25);
            this.LblLastName.TabIndex = 0;
            this.LblLastName.Text = "Last Name";
            this.LblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblContantNo
            // 
            this.LblContantNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblContantNo.AutoSize = true;
            this.LblContantNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContantNo.Location = new System.Drawing.Point(3, 36);
            this.LblContantNo.Name = "LblContantNo";
            this.LblContantNo.Size = new System.Drawing.Size(132, 25);
            this.LblContantNo.TabIndex = 1;
            this.LblContantNo.Text = "Contact No.";
            this.LblContantNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblEmail
            // 
            this.LblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(393, 36);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(142, 25);
            this.LblEmail.TabIndex = 2;
            this.LblEmail.Text = "Email";
            this.LblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblUserType
            // 
            this.LblUserType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUserType.AutoSize = true;
            this.LblUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserType.Location = new System.Drawing.Point(3, 72);
            this.LblUserType.Name = "LblUserType";
            this.LblUserType.Size = new System.Drawing.Size(132, 25);
            this.LblUserType.TabIndex = 3;
            this.LblUserType.Text = "User Type";
            this.LblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblUsername
            // 
            this.LblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.Location = new System.Drawing.Point(393, 72);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(142, 25);
            this.LblUsername.TabIndex = 4;
            this.LblUsername.Text = "Username";
            this.LblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbFirstName
            // 
            this.TbFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbFirstName.Location = new System.Drawing.Point(141, 3);
            this.TbFirstName.Name = "TbFirstName";
            this.TbFirstName.Size = new System.Drawing.Size(246, 26);
            this.TbFirstName.TabIndex = 5;
            // 
            // TbLastName
            // 
            this.TbLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbLastName.Location = new System.Drawing.Point(541, 3);
            this.TbLastName.Name = "TbLastName";
            this.TbLastName.Size = new System.Drawing.Size(247, 26);
            this.TbLastName.TabIndex = 5;
            // 
            // TbContactNo
            // 
            this.TbContactNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbContactNo.Location = new System.Drawing.Point(141, 39);
            this.TbContactNo.Name = "TbContactNo";
            this.TbContactNo.Size = new System.Drawing.Size(246, 26);
            this.TbContactNo.TabIndex = 5;
            // 
            // TbUsername
            // 
            this.TbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbUsername.Location = new System.Drawing.Point(541, 75);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(247, 26);
            this.TbUsername.TabIndex = 5;
            // 
            // CbUserType
            // 
            this.CbUserType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbUserType.FormattingEnabled = true;
            this.CbUserType.Location = new System.Drawing.Point(141, 75);
            this.CbUserType.Name = "CbUserType";
            this.CbUserType.Size = new System.Drawing.Size(246, 28);
            this.CbUserType.TabIndex = 6;
            // 
            // TbEmail
            // 
            this.TbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbEmail.Location = new System.Drawing.Point(541, 39);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(247, 26);
            this.TbEmail.TabIndex = 5;
            // 
            // DGVUserList
            // 
            this.DGVUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUserList.Location = new System.Drawing.Point(12, 239);
            this.DGVUserList.Name = "DGVUserList";
            this.DGVUserList.RowHeadersWidth = 62;
            this.DGVUserList.RowTemplate.Height = 28;
            this.DGVUserList.Size = new System.Drawing.Size(791, 413);
            this.DGVUserList.TabIndex = 0;
            // 
            // BtnSaveUser
            // 
            this.BtnSaveUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveUser.Location = new System.Drawing.Point(12, 189);
            this.BtnSaveUser.Name = "BtnSaveUser";
            this.BtnSaveUser.Size = new System.Drawing.Size(118, 44);
            this.BtnSaveUser.TabIndex = 2;
            this.BtnSaveUser.Text = "Save";
            this.BtnSaveUser.UseVisualStyleBackColor = true;
            // 
            // BtnUpdateUser
            // 
            this.BtnUpdateUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateUser.Location = new System.Drawing.Point(155, 189);
            this.BtnUpdateUser.Name = "BtnUpdateUser";
            this.BtnUpdateUser.Size = new System.Drawing.Size(118, 44);
            this.BtnUpdateUser.TabIndex = 3;
            this.BtnUpdateUser.Text = "Update";
            this.BtnUpdateUser.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteUser
            // 
            this.BtnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteUser.Location = new System.Drawing.Point(296, 189);
            this.BtnDeleteUser.Name = "BtnDeleteUser";
            this.BtnDeleteUser.Size = new System.Drawing.Size(118, 44);
            this.BtnDeleteUser.TabIndex = 4;
            this.BtnDeleteUser.Text = "Delete";
            this.BtnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(815, 664);
            this.Controls.Add(this.BtnDeleteUser);
            this.Controls.Add(this.BtnUpdateUser);
            this.Controls.Add(this.BtnSaveUser);
            this.Controls.Add(this.DGVUserList);
            this.Controls.Add(this.TlpUserFields);
            this.Controls.Add(this.LblUserTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersForm";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.TlpUserFields.ResumeLayout(false);
            this.TlpUserFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUserTitle;
        private System.Windows.Forms.TableLayoutPanel TlpUserFields;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.DataGridView DGVUserList;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblContantNo;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblUserType;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.TextBox TbFirstName;
        private System.Windows.Forms.TextBox TbLastName;
        private System.Windows.Forms.TextBox TbContactNo;
        private System.Windows.Forms.Button BtnSaveUser;
        private System.Windows.Forms.Button BtnUpdateUser;
        private System.Windows.Forms.Button BtnDeleteUser;
        private System.Windows.Forms.TextBox TbUsername;
        private System.Windows.Forms.ComboBox CbUserType;
        private System.Windows.Forms.TextBox TbEmail;
    }
}