
namespace FinalProject.Forms
{
    partial class UserProfile
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
            this.BtnUpdateUser = new System.Windows.Forms.Button();
            this.LblUserTitle = new System.Windows.Forms.Label();
            this.TlpUserFields = new System.Windows.Forms.TableLayoutPanel();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TbFirstName = new System.Windows.Forms.TextBox();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblContantNo = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.TbContactNo = new System.Windows.Forms.TextBox();
            this.TbLastName = new System.Windows.Forms.TextBox();
            this.TlpUserFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnUpdateUser
            // 
            this.BtnUpdateUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateUser.Location = new System.Drawing.Point(340, 370);
            this.BtnUpdateUser.Name = "BtnUpdateUser";
            this.BtnUpdateUser.Size = new System.Drawing.Size(140, 44);
            this.BtnUpdateUser.TabIndex = 17;
            this.BtnUpdateUser.Text = "Update";
            this.BtnUpdateUser.UseVisualStyleBackColor = true;
            // 
            // LblUserTitle
            // 
            this.LblUserTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUserTitle.AutoSize = true;
            this.LblUserTitle.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserTitle.Location = new System.Drawing.Point(333, 72);
            this.LblUserTitle.Name = "LblUserTitle";
            this.LblUserTitle.Size = new System.Drawing.Size(186, 42);
            this.LblUserTitle.TabIndex = 14;
            this.LblUserTitle.Text = "PROFILE";
            // 
            // TlpUserFields
            // 
            this.TlpUserFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TlpUserFields.ColumnCount = 2;
            this.TlpUserFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.37234F));
            this.TlpUserFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.62766F));
            this.TlpUserFields.Controls.Add(this.TbEmail, 1, 3);
            this.TlpUserFields.Controls.Add(this.LblEmail, 0, 3);
            this.TlpUserFields.Controls.Add(this.TbFirstName, 1, 0);
            this.TlpUserFields.Controls.Add(this.LblFirstName, 0, 0);
            this.TlpUserFields.Controls.Add(this.LblContantNo, 0, 2);
            this.TlpUserFields.Controls.Add(this.LblLastName, 0, 1);
            this.TlpUserFields.Controls.Add(this.TbContactNo, 1, 2);
            this.TlpUserFields.Controls.Add(this.TbLastName, 1, 1);
            this.TlpUserFields.Location = new System.Drawing.Point(82, 178);
            this.TlpUserFields.Name = "TlpUserFields";
            this.TlpUserFields.RowCount = 4;
            this.TlpUserFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.3299F));
            this.TlpUserFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.6701F));
            this.TlpUserFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.TlpUserFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TlpUserFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpUserFields.Size = new System.Drawing.Size(685, 164);
            this.TlpUserFields.TabIndex = 18;
            // 
            // TbEmail
            // 
            this.TbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbEmail.Location = new System.Drawing.Point(245, 126);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(437, 26);
            this.TbEmail.TabIndex = 22;
            // 
            // LblEmail
            // 
            this.LblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(3, 123);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(236, 25);
            this.LblEmail.TabIndex = 20;
            this.LblEmail.Text = "Email";
            this.LblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbFirstName
            // 
            this.TbFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbFirstName.Location = new System.Drawing.Point(245, 3);
            this.TbFirstName.Name = "TbFirstName";
            this.TbFirstName.Size = new System.Drawing.Size(437, 26);
            this.TbFirstName.TabIndex = 5;
            // 
            // LblFirstName
            // 
            this.LblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFirstName.Location = new System.Drawing.Point(3, 0);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(236, 25);
            this.LblFirstName.TabIndex = 0;
            this.LblFirstName.Text = "First Name";
            this.LblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblContantNo
            // 
            this.LblContantNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblContantNo.AutoSize = true;
            this.LblContantNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContantNo.Location = new System.Drawing.Point(3, 79);
            this.LblContantNo.Name = "LblContantNo";
            this.LblContantNo.Size = new System.Drawing.Size(236, 25);
            this.LblContantNo.TabIndex = 1;
            this.LblContantNo.Text = "Contact No.";
            this.LblContantNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblLastName
            // 
            this.LblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLastName.AutoSize = true;
            this.LblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastName.Location = new System.Drawing.Point(3, 35);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(236, 25);
            this.LblLastName.TabIndex = 19;
            this.LblLastName.Text = "Last Name";
            this.LblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbContactNo
            // 
            this.TbContactNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbContactNo.Location = new System.Drawing.Point(245, 82);
            this.TbContactNo.Name = "TbContactNo";
            this.TbContactNo.Size = new System.Drawing.Size(437, 26);
            this.TbContactNo.TabIndex = 5;
            // 
            // TbLastName
            // 
            this.TbLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbLastName.Location = new System.Drawing.Point(245, 38);
            this.TbLastName.Name = "TbLastName";
            this.TbLastName.Size = new System.Drawing.Size(437, 26);
            this.TbLastName.TabIndex = 21;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(815, 664);
            this.Controls.Add(this.TlpUserFields);
            this.Controls.Add(this.BtnUpdateUser);
            this.Controls.Add(this.LblUserTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserProfile";
            this.Text = "AdminProfile";
            this.TlpUserFields.ResumeLayout(false);
            this.TlpUserFields.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdateUser;
        private System.Windows.Forms.Label LblUserTitle;
        private System.Windows.Forms.TableLayoutPanel TlpUserFields;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.TextBox TbLastName;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblContantNo;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.TextBox TbContactNo;
        private System.Windows.Forms.TextBox TbFirstName;
        private System.Windows.Forms.Label LblFirstName;
    }
}