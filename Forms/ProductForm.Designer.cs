
namespace FinalProject.Forms
{
    partial class ProductForm
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
            this.LblProductTitle = new System.Windows.Forms.Label();
            this.TlpUserFields = new System.Windows.Forms.TableLayoutPanel();
            this.LblProductName = new System.Windows.Forms.Label();
            this.LblCategory = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.LblUnit = new System.Windows.Forms.Label();
            this.TbProductName = new System.Windows.Forms.TextBox();
            this.TbPrice = new System.Windows.Forms.TextBox();
            this.CbProductCategory = new System.Windows.Forms.ComboBox();
            this.TbUnit = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblDescription = new System.Windows.Forms.Label();
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.BtnDeleteProduct = new System.Windows.Forms.Button();
            this.BtnUpdateProduct = new System.Windows.Forms.Button();
            this.BtnSaveProduct = new System.Windows.Forms.Button();
            this.DGVProductList = new System.Windows.Forms.DataGridView();
            this.TlpUserFields.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // LblProductTitle
            // 
            this.LblProductTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblProductTitle.AutoSize = true;
            this.LblProductTitle.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductTitle.Location = new System.Drawing.Point(286, 19);
            this.LblProductTitle.Name = "LblProductTitle";
            this.LblProductTitle.Size = new System.Drawing.Size(230, 42);
            this.LblProductTitle.TabIndex = 1;
            this.LblProductTitle.Text = "PRODUCTS";
            this.LblProductTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.TlpUserFields.Controls.Add(this.LblProductName, 0, 0);
            this.TlpUserFields.Controls.Add(this.LblCategory, 2, 0);
            this.TlpUserFields.Controls.Add(this.LblPrice, 0, 1);
            this.TlpUserFields.Controls.Add(this.LblUnit, 2, 1);
            this.TlpUserFields.Controls.Add(this.TbProductName, 1, 0);
            this.TlpUserFields.Controls.Add(this.TbPrice, 1, 1);
            this.TlpUserFields.Controls.Add(this.TbUnit, 3, 1);
            this.TlpUserFields.Controls.Add(this.CbProductCategory, 3, 0);
            this.TlpUserFields.Location = new System.Drawing.Point(12, 64);
            this.TlpUserFields.Name = "TlpUserFields";
            this.TlpUserFields.RowCount = 2;
            this.TlpUserFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpUserFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpUserFields.Size = new System.Drawing.Size(791, 76);
            this.TlpUserFields.TabIndex = 2;
            // 
            // LblProductName
            // 
            this.LblProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblProductName.AutoSize = true;
            this.LblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductName.Location = new System.Drawing.Point(3, 0);
            this.LblProductName.Name = "LblProductName";
            this.LblProductName.Size = new System.Drawing.Size(132, 25);
            this.LblProductName.TabIndex = 0;
            this.LblProductName.Text = "Product";
            this.LblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblCategory
            // 
            this.LblCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCategory.AutoSize = true;
            this.LblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategory.Location = new System.Drawing.Point(393, 0);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(142, 25);
            this.LblCategory.TabIndex = 0;
            this.LblCategory.Text = "Category";
            this.LblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblPrice
            // 
            this.LblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(3, 38);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(132, 25);
            this.LblPrice.TabIndex = 1;
            this.LblPrice.Text = "Price";
            this.LblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblUnit
            // 
            this.LblUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUnit.AutoSize = true;
            this.LblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUnit.Location = new System.Drawing.Point(393, 38);
            this.LblUnit.Name = "LblUnit";
            this.LblUnit.Size = new System.Drawing.Size(142, 25);
            this.LblUnit.TabIndex = 2;
            this.LblUnit.Text = "Unit";
            this.LblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbProductName
            // 
            this.TbProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbProductName.Location = new System.Drawing.Point(141, 3);
            this.TbProductName.Name = "TbProductName";
            this.TbProductName.Size = new System.Drawing.Size(246, 26);
            this.TbProductName.TabIndex = 5;
            // 
            // TbPrice
            // 
            this.TbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbPrice.Location = new System.Drawing.Point(141, 41);
            this.TbPrice.Name = "TbPrice";
            this.TbPrice.Size = new System.Drawing.Size(246, 26);
            this.TbPrice.TabIndex = 5;
            // 
            // CbProductCategory
            // 
            this.CbProductCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbProductCategory.FormattingEnabled = true;
            this.CbProductCategory.Location = new System.Drawing.Point(541, 3);
            this.CbProductCategory.Name = "CbProductCategory";
            this.CbProductCategory.Size = new System.Drawing.Size(247, 28);
            this.CbProductCategory.TabIndex = 6;
            // 
            // TbUnit
            // 
            this.TbUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbUnit.Location = new System.Drawing.Point(541, 41);
            this.TbUnit.Name = "TbUnit";
            this.TbUnit.Size = new System.Drawing.Size(247, 26);
            this.TbUnit.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.38579F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.61421F));
            this.tableLayoutPanel1.Controls.Add(this.LblDescription, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TbDescription, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 146);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(791, 35);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // LblDescription
            // 
            this.LblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.Location = new System.Drawing.Point(3, 0);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(131, 25);
            this.LblDescription.TabIndex = 0;
            this.LblDescription.Text = "Description";
            this.LblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbDescription
            // 
            this.TbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbDescription.Location = new System.Drawing.Point(140, 3);
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(648, 26);
            this.TbDescription.TabIndex = 5;
            // 
            // BtnDeleteProduct
            // 
            this.BtnDeleteProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteProduct.Location = new System.Drawing.Point(296, 187);
            this.BtnDeleteProduct.Name = "BtnDeleteProduct";
            this.BtnDeleteProduct.Size = new System.Drawing.Size(118, 44);
            this.BtnDeleteProduct.TabIndex = 7;
            this.BtnDeleteProduct.Text = "Delete";
            this.BtnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // BtnUpdateProduct
            // 
            this.BtnUpdateProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateProduct.Location = new System.Drawing.Point(155, 187);
            this.BtnUpdateProduct.Name = "BtnUpdateProduct";
            this.BtnUpdateProduct.Size = new System.Drawing.Size(118, 44);
            this.BtnUpdateProduct.TabIndex = 6;
            this.BtnUpdateProduct.Text = "Update";
            this.BtnUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // BtnSaveProduct
            // 
            this.BtnSaveProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveProduct.Location = new System.Drawing.Point(12, 187);
            this.BtnSaveProduct.Name = "BtnSaveProduct";
            this.BtnSaveProduct.Size = new System.Drawing.Size(118, 44);
            this.BtnSaveProduct.TabIndex = 5;
            this.BtnSaveProduct.Text = "Save";
            this.BtnSaveProduct.UseVisualStyleBackColor = true;
            // 
            // DGVProductList
            // 
            this.DGVProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductList.Location = new System.Drawing.Point(9, 239);
            this.DGVProductList.Name = "DGVProductList";
            this.DGVProductList.RowHeadersWidth = 62;
            this.DGVProductList.RowTemplate.Height = 28;
            this.DGVProductList.Size = new System.Drawing.Size(791, 413);
            this.DGVProductList.TabIndex = 8;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 664);
            this.Controls.Add(this.DGVProductList);
            this.Controls.Add(this.BtnDeleteProduct);
            this.Controls.Add(this.BtnUpdateProduct);
            this.Controls.Add(this.BtnSaveProduct);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TlpUserFields);
            this.Controls.Add(this.LblProductTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.TlpUserFields.ResumeLayout(false);
            this.TlpUserFields.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProductTitle;
        private System.Windows.Forms.TableLayoutPanel TlpUserFields;
        private System.Windows.Forms.Label LblProductName;
        private System.Windows.Forms.Label LblCategory;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblUnit;
        private System.Windows.Forms.TextBox TbProductName;
        private System.Windows.Forms.TextBox TbPrice;
        private System.Windows.Forms.TextBox TbUnit;
        private System.Windows.Forms.ComboBox CbProductCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.TextBox TbDescription;
        private System.Windows.Forms.Button BtnDeleteProduct;
        private System.Windows.Forms.Button BtnUpdateProduct;
        private System.Windows.Forms.Button BtnSaveProduct;
        private System.Windows.Forms.DataGridView DGVProductList;
    }
}