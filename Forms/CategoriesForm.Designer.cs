
namespace FinalProject.Forms
{
    partial class CategoriesForm
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
            this.LblCategoryTitle = new System.Windows.Forms.Label();
            this.TlpUserFields = new System.Windows.Forms.TableLayoutPanel();
            this.LblCategoryName = new System.Windows.Forms.Label();
            this.TbCategoryName = new System.Windows.Forms.TextBox();
            this.TbSearchWord = new System.Windows.Forms.TextBox();
            this.BtnDeleteCategory = new System.Windows.Forms.Button();
            this.BtnUpdateCategory = new System.Windows.Forms.Button();
            this.BtnSaveCategory = new System.Windows.Forms.Button();
            this.DGVCategoryList = new System.Windows.Forms.DataGridView();
            this.LblSearch = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TlpUserFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCategoryTitle
            // 
            this.LblCategoryTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCategoryTitle.AutoSize = true;
            this.LblCategoryTitle.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoryTitle.Location = new System.Drawing.Point(271, 9);
            this.LblCategoryTitle.Name = "LblCategoryTitle";
            this.LblCategoryTitle.Size = new System.Drawing.Size(271, 42);
            this.LblCategoryTitle.TabIndex = 2;
            this.LblCategoryTitle.Text = "CATEGORIES";
            this.LblCategoryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TlpUserFields
            // 
            this.TlpUserFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TlpUserFields.ColumnCount = 4;
            this.TlpUserFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.37234F));
            this.TlpUserFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.62766F));
            this.TlpUserFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.TlpUserFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.TlpUserFields.Controls.Add(this.LblCategoryName, 0, 0);
            this.TlpUserFields.Controls.Add(this.TbCategoryName, 1, 0);
            this.TlpUserFields.Location = new System.Drawing.Point(12, 54);
            this.TlpUserFields.Name = "TlpUserFields";
            this.TlpUserFields.RowCount = 1;
            this.TlpUserFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpUserFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.TlpUserFields.Size = new System.Drawing.Size(791, 38);
            this.TlpUserFields.TabIndex = 3;
            // 
            // LblCategoryName
            // 
            this.LblCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCategoryName.AutoSize = true;
            this.LblCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoryName.Location = new System.Drawing.Point(3, 0);
            this.LblCategoryName.Name = "LblCategoryName";
            this.LblCategoryName.Size = new System.Drawing.Size(131, 25);
            this.LblCategoryName.TabIndex = 0;
            this.LblCategoryName.Text = "Category";
            this.LblCategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbCategoryName
            // 
            this.TbCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbCategoryName.Location = new System.Drawing.Point(140, 3);
            this.TbCategoryName.Name = "TbCategoryName";
            this.TbCategoryName.Size = new System.Drawing.Size(245, 26);
            this.TbCategoryName.TabIndex = 5;
            // 
            // TbSearchWord
            // 
            this.TbSearchWord.Location = new System.Drawing.Point(465, 108);
            this.TbSearchWord.Name = "TbSearchWord";
            this.TbSearchWord.Size = new System.Drawing.Size(214, 26);
            this.TbSearchWord.TabIndex = 5;
            // 
            // BtnDeleteCategory
            // 
            this.BtnDeleteCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteCategory.Location = new System.Drawing.Point(260, 98);
            this.BtnDeleteCategory.Name = "BtnDeleteCategory";
            this.BtnDeleteCategory.Size = new System.Drawing.Size(118, 44);
            this.BtnDeleteCategory.TabIndex = 10;
            this.BtnDeleteCategory.Text = "Delete";
            this.BtnDeleteCategory.UseVisualStyleBackColor = true;
            this.BtnDeleteCategory.Click += new System.EventHandler(this.BtnDeleteCategory_Click);
            // 
            // BtnUpdateCategory
            // 
            this.BtnUpdateCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateCategory.Location = new System.Drawing.Point(136, 98);
            this.BtnUpdateCategory.Name = "BtnUpdateCategory";
            this.BtnUpdateCategory.Size = new System.Drawing.Size(118, 44);
            this.BtnUpdateCategory.TabIndex = 9;
            this.BtnUpdateCategory.Text = "Update";
            this.BtnUpdateCategory.UseVisualStyleBackColor = true;
            this.BtnUpdateCategory.Click += new System.EventHandler(this.BtnUpdateCategory_Click);
            // 
            // BtnSaveCategory
            // 
            this.BtnSaveCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveCategory.Location = new System.Drawing.Point(12, 98);
            this.BtnSaveCategory.Name = "BtnSaveCategory";
            this.BtnSaveCategory.Size = new System.Drawing.Size(118, 44);
            this.BtnSaveCategory.TabIndex = 8;
            this.BtnSaveCategory.Text = "Save";
            this.BtnSaveCategory.UseVisualStyleBackColor = true;
            this.BtnSaveCategory.Click += new System.EventHandler(this.BtnSaveCategory_Click);
            // 
            // DGVCategoryList
            // 
            this.DGVCategoryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVCategoryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCategoryList.Location = new System.Drawing.Point(12, 161);
            this.DGVCategoryList.Name = "DGVCategoryList";
            this.DGVCategoryList.RowHeadersWidth = 62;
            this.DGVCategoryList.RowTemplate.Height = 28;
            this.DGVCategoryList.Size = new System.Drawing.Size(791, 491);
            this.DGVCategoryList.TabIndex = 11;
            this.DGVCategoryList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVCategoryList_CellMouseDoubleClick);
            // 
            // LblSearch
            // 
            this.LblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSearch.AutoSize = true;
            this.LblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearch.Location = new System.Drawing.Point(384, 108);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(75, 25);
            this.LblSearch.TabIndex = 0;
            this.LblSearch.Text = "Search";
            this.LblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(685, 97);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(118, 44);
            this.BtnSearch.TabIndex = 10;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 664);
            this.Controls.Add(this.LblSearch);
            this.Controls.Add(this.TbSearchWord);
            this.Controls.Add(this.DGVCategoryList);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnDeleteCategory);
            this.Controls.Add(this.BtnUpdateCategory);
            this.Controls.Add(this.BtnSaveCategory);
            this.Controls.Add(this.TlpUserFields);
            this.Controls.Add(this.LblCategoryTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoriesForm";
            this.Text = "CategoriesForm";
            this.TlpUserFields.ResumeLayout(false);
            this.TlpUserFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategoryList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCategoryTitle;
        private System.Windows.Forms.TableLayoutPanel TlpUserFields;
        private System.Windows.Forms.Label LblCategoryName;
        private System.Windows.Forms.TextBox TbSearchWord;
        private System.Windows.Forms.Button BtnDeleteCategory;
        private System.Windows.Forms.Button BtnUpdateCategory;
        private System.Windows.Forms.Button BtnSaveCategory;
        private System.Windows.Forms.DataGridView DGVCategoryList;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.TextBox TbCategoryName;
        private System.Windows.Forms.Button BtnSearch;
    }
}