
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
            this.LblUserType = new System.Windows.Forms.Label();
            this.TbFirstName = new System.Windows.Forms.TextBox();
            this.TbLastName = new System.Windows.Forms.TextBox();
            this.CbUserType = new System.Windows.Forms.ComboBox();
            this.LblUsername = new System.Windows.Forms.Label();
            this.TbUsername = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.DGVUserList = new System.Windows.Forms.DataGridView();
            this.BtnSaveUser = new System.Windows.Forms.Button();
            this.BtnUpdateUser = new System.Windows.Forms.Button();
            this.BtnDeleteUser = new System.Windows.Forms.Button();
            this.LblSearch = new System.Windows.Forms.Label();
            this.TbSearchWord = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
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
            this.TlpUserFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.TlpUserFields.Controls.Add(this.LblFirstName, 0, 0);
            this.TlpUserFields.Controls.Add(this.LblLastName, 2, 0);
            this.TlpUserFields.Controls.Add(this.LblUserType, 0, 2);
            this.TlpUserFields.Controls.Add(this.TbFirstName, 1, 0);
            this.TlpUserFields.Controls.Add(this.TbLastName, 3, 0);
            this.TlpUserFields.Controls.Add(this.CbUserType, 1, 2);
            this.TlpUserFields.Controls.Add(this.LblUsername, 0, 1);
            this.TlpUserFields.Controls.Add(this.TbUsername, 1, 1);
            this.TlpUserFields.Controls.Add(this.LblPassword, 2, 1);
            this.TlpUserFields.Controls.Add(this.LblEmail, 2, 2);
            this.TlpUserFields.Controls.Add(this.TbPassword, 3, 1);
            this.TlpUserFields.Controls.Add(this.TbEmail, 3, 2);
            this.TlpUserFields.Location = new System.Drawing.Point(12, 74);
            this.TlpUserFields.Name = "TlpUserFields";
            this.TlpUserFields.RowCount = 3;
            this.TlpUserFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpUserFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpUserFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.TlpUserFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            this.LblFirstName.Size = new System.Drawing.Size(129, 25);
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
            this.LblLastName.Location = new System.Drawing.Point(385, 0);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(142, 25);
            this.LblLastName.TabIndex = 0;
            this.LblLastName.Text = "Last Name";
            this.LblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblUserType
            // 
            this.LblUserType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUserType.AutoSize = true;
            this.LblUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserType.Location = new System.Drawing.Point(3, 72);
            this.LblUserType.Name = "LblUserType";
            this.LblUserType.Size = new System.Drawing.Size(129, 25);
            this.LblUserType.TabIndex = 3;
            this.LblUserType.Text = "User Type";
            this.LblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbFirstName
            // 
            this.TbFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbFirstName.Location = new System.Drawing.Point(138, 3);
            this.TbFirstName.Name = "TbFirstName";
            this.TbFirstName.Size = new System.Drawing.Size(241, 26);
            this.TbFirstName.TabIndex = 5;
            // 
            // TbLastName
            // 
            this.TbLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbLastName.Location = new System.Drawing.Point(533, 3);
            this.TbLastName.Name = "TbLastName";
            this.TbLastName.Size = new System.Drawing.Size(255, 26);
            this.TbLastName.TabIndex = 5;
            // 
            // CbUserType
            // 
            this.CbUserType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbUserType.FormattingEnabled = true;
            this.CbUserType.Location = new System.Drawing.Point(138, 75);
            this.CbUserType.Name = "CbUserType";
            this.CbUserType.Size = new System.Drawing.Size(241, 28);
            this.CbUserType.TabIndex = 6;
            // 
            // LblUsername
            // 
            this.LblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.Location = new System.Drawing.Point(3, 36);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(129, 25);
            this.LblUsername.TabIndex = 4;
            this.LblUsername.Text = "Username";
            this.LblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbUsername
            // 
            this.TbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbUsername.Location = new System.Drawing.Point(138, 39);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(241, 26);
            this.TbUsername.TabIndex = 5;
            // 
            // LblPassword
            // 
            this.LblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(385, 36);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(142, 25);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "Password";
            this.LblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblEmail
            // 
            this.LblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(385, 72);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(142, 25);
            this.LblEmail.TabIndex = 2;
            this.LblEmail.Text = "Email";
            this.LblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbPassword
            // 
            this.TbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbPassword.Location = new System.Drawing.Point(533, 39);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(255, 26);
            this.TbPassword.TabIndex = 5;
            // 
            // TbEmail
            // 
            this.TbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbEmail.Location = new System.Drawing.Point(533, 75);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(255, 26);
            this.TbEmail.TabIndex = 5;
            // 
            // DGVUserList
            // 
            this.DGVUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUserList.Location = new System.Drawing.Point(12, 239);
            this.DGVUserList.Name = "DGVUserList";
            this.DGVUserList.RowHeadersWidth = 62;
            this.DGVUserList.RowTemplate.Height = 28;
            this.DGVUserList.Size = new System.Drawing.Size(791, 413);
            this.DGVUserList.TabIndex = 0;
            this.DGVUserList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUserList_CellDoubleClick);
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
            this.BtnSaveUser.Click += new System.EventHandler(this.BtnSaveUser_Click);
            // 
            // BtnUpdateUser
            // 
            this.BtnUpdateUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateUser.Location = new System.Drawing.Point(136, 189);
            this.BtnUpdateUser.Name = "BtnUpdateUser";
            this.BtnUpdateUser.Size = new System.Drawing.Size(118, 44);
            this.BtnUpdateUser.TabIndex = 3;
            this.BtnUpdateUser.Text = "Update";
            this.BtnUpdateUser.UseVisualStyleBackColor = true;
            this.BtnUpdateUser.Click += new System.EventHandler(this.BtnUpdateUser_Click);
            // 
            // BtnDeleteUser
            // 
            this.BtnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteUser.Location = new System.Drawing.Point(260, 189);
            this.BtnDeleteUser.Name = "BtnDeleteUser";
            this.BtnDeleteUser.Size = new System.Drawing.Size(118, 44);
            this.BtnDeleteUser.TabIndex = 4;
            this.BtnDeleteUser.Text = "Delete";
            this.BtnDeleteUser.UseVisualStyleBackColor = true;
            this.BtnDeleteUser.Click += new System.EventHandler(this.BtnDeleteUser_Click);
            // 
            // LblSearch
            // 
            this.LblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSearch.AutoSize = true;
            this.LblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearch.Location = new System.Drawing.Point(384, 199);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(75, 25);
            this.LblSearch.TabIndex = 11;
            this.LblSearch.Text = "Search";
            this.LblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbSearchWord
            // 
            this.TbSearchWord.Location = new System.Drawing.Point(465, 200);
            this.TbSearchWord.Name = "TbSearchWord";
            this.TbSearchWord.Size = new System.Drawing.Size(214, 26);
            this.TbSearchWord.TabIndex = 12;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(685, 189);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(118, 44);
            this.BtnSearch.TabIndex = 13;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(815, 664);
            this.Controls.Add(this.LblSearch);
            this.Controls.Add(this.TbSearchWord);
            this.Controls.Add(this.BtnSearch);
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
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblUserType;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.TextBox TbFirstName;
        private System.Windows.Forms.TextBox TbLastName;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Button BtnSaveUser;
        private System.Windows.Forms.Button BtnUpdateUser;
        private System.Windows.Forms.Button BtnDeleteUser;
        private System.Windows.Forms.TextBox TbUsername;
        private System.Windows.Forms.ComboBox CbUserType;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.TextBox TbSearchWord;
        private System.Windows.Forms.Button BtnSearch;
    }
}