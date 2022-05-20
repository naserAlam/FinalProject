
namespace FinalProject
{
    partial class AdminControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAdminDashBoard = new System.Windows.Forms.Button();
            this.BtnUsers = new System.Windows.Forms.Button();
            this.BtnProducts = new System.Windows.Forms.Button();
            this.BtnCategories = new System.Windows.Forms.Button();
            this.PnlAdminMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 664);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BtnAdminDashBoard, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnUsers, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnProducts, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnCategories, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.18033F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.81967F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(234, 661);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BtnAdminDashBoard
            // 
            this.BtnAdminDashBoard.Location = new System.Drawing.Point(3, 292);
            this.BtnAdminDashBoard.Name = "BtnAdminDashBoard";
            this.BtnAdminDashBoard.Size = new System.Drawing.Size(228, 42);
            this.BtnAdminDashBoard.TabIndex = 1;
            this.BtnAdminDashBoard.Text = "Admin Panel";
            this.BtnAdminDashBoard.UseVisualStyleBackColor = true;
            this.BtnAdminDashBoard.Click += new System.EventHandler(this.BtnAdminDashBoard_Click);
            // 
            // BtnUsers
            // 
            this.BtnUsers.Location = new System.Drawing.Point(3, 350);
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.Size = new System.Drawing.Size(228, 42);
            this.BtnUsers.TabIndex = 2;
            this.BtnUsers.Text = "Users";
            this.BtnUsers.UseVisualStyleBackColor = true;
            this.BtnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // BtnProducts
            // 
            this.BtnProducts.Location = new System.Drawing.Point(3, 407);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.Size = new System.Drawing.Size(228, 42);
            this.BtnProducts.TabIndex = 4;
            this.BtnProducts.Text = "Products";
            this.BtnProducts.UseVisualStyleBackColor = true;
            this.BtnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // BtnCategories
            // 
            this.BtnCategories.Location = new System.Drawing.Point(3, 463);
            this.BtnCategories.Name = "BtnCategories";
            this.BtnCategories.Size = new System.Drawing.Size(228, 40);
            this.BtnCategories.TabIndex = 5;
            this.BtnCategories.Text = "Categories";
            this.BtnCategories.UseVisualStyleBackColor = true;
            // 
            // PnlAdminMain
            // 
            this.PnlAdminMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlAdminMain.Location = new System.Drawing.Point(243, 0);
            this.PnlAdminMain.Name = "PnlAdminMain";
            this.PnlAdminMain.Size = new System.Drawing.Size(815, 664);
            this.PnlAdminMain.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.PnlAdminMain);
            this.Controls.Add(this.panel1);
            this.Name = "AdminControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnAdminDashBoard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnUsers;
        private System.Windows.Forms.Button BtnProducts;
        private System.Windows.Forms.Button BtnCategories;
        private System.Windows.Forms.Panel PnlAdminMain;
    }
}

