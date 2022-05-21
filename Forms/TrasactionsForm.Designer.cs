
namespace FinalProject.Forms
{
    partial class TrasactionsForm
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
            this.lblTransactionsTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblContactHeader = new System.Windows.Forms.Label();
            this.TlpUserFields = new System.Windows.Forms.TableLayoutPanel();
            this.LblSearch = new System.Windows.Forms.Label();
            this.LblContactName = new System.Windows.Forms.Label();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.TbContactName = new System.Windows.Forms.TextBox();
            this.LblContactNo = new System.Windows.Forms.Label();
            this.TbContactNo = new System.Windows.Forms.TextBox();
            this.LblBillDate = new System.Windows.Forms.Label();
            this.DtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.LblProductName = new System.Windows.Forms.Label();
            this.TbSearchProduct = new System.Windows.Forms.TextBox();
            this.TbProductName = new System.Windows.Forms.TextBox();
            this.LblProductInventory = new System.Windows.Forms.Label();
            this.TbProductInventory = new System.Windows.Forms.TextBox();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.TbQuantity = new System.Windows.Forms.TextBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.TbPrice = new System.Windows.Forms.TextBox();
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LblAddedProduct = new System.Windows.Forms.Label();
            this.DGVAddedProduct = new System.Windows.Forms.DataGridView();
            this.LblCalculation = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LblSubTotal = new System.Windows.Forms.Label();
            this.LblDiscount = new System.Windows.Forms.Label();
            this.LblGrandTotal = new System.Windows.Forms.Label();
            this.LblVat = new System.Windows.Forms.Label();
            this.LblPaidAmount = new System.Windows.Forms.Label();
            this.TbSubTotal = new System.Windows.Forms.TextBox();
            this.TbDiscount = new System.Windows.Forms.TextBox();
            this.TbVat = new System.Windows.Forms.TextBox();
            this.TbGrandTotal = new System.Windows.Forms.TextBox();
            this.TbPaidAmount = new System.Windows.Forms.TextBox();
            this.LblReturnAmount = new System.Windows.Forms.Label();
            this.TbReturnAmount = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.TlpUserFields.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAddedProduct)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTransactionsTitle
            // 
            this.lblTransactionsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTransactionsTitle.AutoSize = true;
            this.lblTransactionsTitle.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionsTitle.Location = new System.Drawing.Point(184, 9);
            this.lblTransactionsTitle.Name = "lblTransactionsTitle";
            this.lblTransactionsTitle.Size = new System.Drawing.Size(432, 42);
            this.lblTransactionsTitle.TabIndex = 15;
            this.lblTransactionsTitle.Text = "SALES AND SUPPLIES";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.LblContactHeader);
            this.flowLayoutPanel1.Controls.Add(this.TlpUserFields);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(791, 109);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // LblContactHeader
            // 
            this.LblContactHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblContactHeader.AutoSize = true;
            this.LblContactHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContactHeader.Location = new System.Drawing.Point(3, 0);
            this.LblContactHeader.Name = "LblContactHeader";
            this.LblContactHeader.Size = new System.Drawing.Size(322, 25);
            this.LblContactHeader.TabIndex = 5;
            this.LblContactHeader.Text = "Customer and Dealer Infomation";
            this.LblContactHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TlpUserFields
            // 
            this.TlpUserFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TlpUserFields.ColumnCount = 4;
            this.TlpUserFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.37234F));
            this.TlpUserFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.62766F));
            this.TlpUserFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.TlpUserFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 261F));
            this.TlpUserFields.Controls.Add(this.LblSearch, 0, 0);
            this.TlpUserFields.Controls.Add(this.LblContactName, 2, 0);
            this.TlpUserFields.Controls.Add(this.TbSearch, 1, 0);
            this.TlpUserFields.Controls.Add(this.TbContactName, 3, 0);
            this.TlpUserFields.Controls.Add(this.LblContactNo, 0, 1);
            this.TlpUserFields.Controls.Add(this.TbContactNo, 1, 1);
            this.TlpUserFields.Controls.Add(this.LblBillDate, 2, 1);
            this.TlpUserFields.Controls.Add(this.DtpBillDate, 3, 1);
            this.TlpUserFields.Location = new System.Drawing.Point(3, 28);
            this.TlpUserFields.Name = "TlpUserFields";
            this.TlpUserFields.RowCount = 2;
            this.TlpUserFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpUserFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpUserFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpUserFields.Size = new System.Drawing.Size(791, 80);
            this.TlpUserFields.TabIndex = 6;
            // 
            // LblSearch
            // 
            this.LblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSearch.AutoSize = true;
            this.LblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearch.Location = new System.Drawing.Point(3, 0);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(129, 25);
            this.LblSearch.TabIndex = 0;
            this.LblSearch.Text = "Search";
            this.LblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblContactName
            // 
            this.LblContactName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblContactName.AutoSize = true;
            this.LblContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContactName.Location = new System.Drawing.Point(384, 0);
            this.LblContactName.Name = "LblContactName";
            this.LblContactName.Size = new System.Drawing.Size(142, 25);
            this.LblContactName.TabIndex = 0;
            this.LblContactName.Text = "Name";
            this.LblContactName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbSearch
            // 
            this.TbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbSearch.Location = new System.Drawing.Point(138, 3);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(240, 26);
            this.TbSearch.TabIndex = 5;
            // 
            // TbContactName
            // 
            this.TbContactName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbContactName.Location = new System.Drawing.Point(532, 3);
            this.TbContactName.Name = "TbContactName";
            this.TbContactName.Size = new System.Drawing.Size(256, 26);
            this.TbContactName.TabIndex = 5;
            // 
            // LblContactNo
            // 
            this.LblContactNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblContactNo.AutoSize = true;
            this.LblContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContactNo.Location = new System.Drawing.Point(3, 40);
            this.LblContactNo.Name = "LblContactNo";
            this.LblContactNo.Size = new System.Drawing.Size(129, 25);
            this.LblContactNo.TabIndex = 4;
            this.LblContactNo.Text = "Contact No";
            this.LblContactNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbContactNo
            // 
            this.TbContactNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbContactNo.Location = new System.Drawing.Point(138, 43);
            this.TbContactNo.Name = "TbContactNo";
            this.TbContactNo.Size = new System.Drawing.Size(240, 26);
            this.TbContactNo.TabIndex = 5;
            // 
            // LblBillDate
            // 
            this.LblBillDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblBillDate.AutoSize = true;
            this.LblBillDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBillDate.Location = new System.Drawing.Point(384, 40);
            this.LblBillDate.Name = "LblBillDate";
            this.LblBillDate.Size = new System.Drawing.Size(142, 25);
            this.LblBillDate.TabIndex = 2;
            this.LblBillDate.Text = "Bill Date";
            this.LblBillDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DtpBillDate
            // 
            this.DtpBillDate.Location = new System.Drawing.Point(532, 43);
            this.DtpBillDate.Name = "DtpBillDate";
            this.DtpBillDate.Size = new System.Drawing.Size(255, 26);
            this.DtpBillDate.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 169);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(794, 147);
            this.flowLayoutPanel2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.37234F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.62766F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 261F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblProductName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TbSearchProduct, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TbProductName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblProductInventory, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TbProductInventory, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblQuantity, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TbQuantity, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblPrice, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TbPrice, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnAddProduct, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 197);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(791, 119);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblProductName
            // 
            this.LblProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblProductName.AutoSize = true;
            this.LblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductName.Location = new System.Drawing.Point(384, 0);
            this.LblProductName.Name = "LblProductName";
            this.LblProductName.Size = new System.Drawing.Size(142, 25);
            this.LblProductName.TabIndex = 0;
            this.LblProductName.Text = "Product";
            this.LblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbSearchProduct
            // 
            this.TbSearchProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbSearchProduct.Location = new System.Drawing.Point(138, 3);
            this.TbSearchProduct.Name = "TbSearchProduct";
            this.TbSearchProduct.Size = new System.Drawing.Size(240, 26);
            this.TbSearchProduct.TabIndex = 5;
            // 
            // TbProductName
            // 
            this.TbProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbProductName.Location = new System.Drawing.Point(532, 3);
            this.TbProductName.Name = "TbProductName";
            this.TbProductName.Size = new System.Drawing.Size(256, 26);
            this.TbProductName.TabIndex = 5;
            // 
            // LblProductInventory
            // 
            this.LblProductInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblProductInventory.AutoSize = true;
            this.LblProductInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductInventory.Location = new System.Drawing.Point(3, 38);
            this.LblProductInventory.Name = "LblProductInventory";
            this.LblProductInventory.Size = new System.Drawing.Size(129, 25);
            this.LblProductInventory.TabIndex = 4;
            this.LblProductInventory.Text = "Inventory";
            this.LblProductInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbProductInventory
            // 
            this.TbProductInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbProductInventory.Location = new System.Drawing.Point(138, 41);
            this.TbProductInventory.Name = "TbProductInventory";
            this.TbProductInventory.Size = new System.Drawing.Size(240, 26);
            this.TbProductInventory.TabIndex = 5;
            // 
            // LblQuantity
            // 
            this.LblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantity.Location = new System.Drawing.Point(384, 38);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(142, 25);
            this.LblQuantity.TabIndex = 2;
            this.LblQuantity.Text = "Qty.";
            this.LblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbQuantity
            // 
            this.TbQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbQuantity.Location = new System.Drawing.Point(532, 41);
            this.TbQuantity.Name = "TbQuantity";
            this.TbQuantity.Size = new System.Drawing.Size(256, 26);
            this.TbQuantity.TabIndex = 5;
            // 
            // LblPrice
            // 
            this.LblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(3, 76);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(129, 25);
            this.LblPrice.TabIndex = 4;
            this.LblPrice.Text = "Price";
            this.LblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbPrice
            // 
            this.TbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbPrice.Location = new System.Drawing.Point(138, 79);
            this.TbPrice.Name = "TbPrice";
            this.TbPrice.Size = new System.Drawing.Size(240, 26);
            this.TbPrice.TabIndex = 5;
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddProduct.Location = new System.Drawing.Point(532, 79);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(133, 37);
            this.BtnAddProduct.TabIndex = 6;
            this.BtnAddProduct.Text = "Add";
            this.BtnAddProduct.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.DGVAddedProduct, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LblAddedProduct, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LblCalculation, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 322);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 305F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 330);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // LblAddedProduct
            // 
            this.LblAddedProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAddedProduct.AutoSize = true;
            this.LblAddedProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddedProduct.Location = new System.Drawing.Point(3, 0);
            this.LblAddedProduct.Name = "LblAddedProduct";
            this.LblAddedProduct.Size = new System.Drawing.Size(391, 25);
            this.LblAddedProduct.TabIndex = 4;
            this.LblAddedProduct.Text = "Cart";
            this.LblAddedProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DGVAddedProduct
            // 
            this.DGVAddedProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVAddedProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAddedProduct.Location = new System.Drawing.Point(3, 28);
            this.DGVAddedProduct.Name = "DGVAddedProduct";
            this.DGVAddedProduct.RowHeadersWidth = 62;
            this.DGVAddedProduct.RowTemplate.Height = 28;
            this.DGVAddedProduct.Size = new System.Drawing.Size(391, 299);
            this.DGVAddedProduct.TabIndex = 0;
            // 
            // LblCalculation
            // 
            this.LblCalculation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCalculation.AutoSize = true;
            this.LblCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCalculation.Location = new System.Drawing.Point(400, 0);
            this.LblCalculation.Name = "LblCalculation";
            this.LblCalculation.Size = new System.Drawing.Size(391, 25);
            this.LblCalculation.TabIndex = 4;
            this.LblCalculation.Text = "Calculation";
            this.LblCalculation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 257F));
            this.tableLayoutPanel3.Controls.Add(this.LblSubTotal, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.LblDiscount, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.LblGrandTotal, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.LblVat, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.LblPaidAmount, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.TbSubTotal, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.TbDiscount, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.TbGrandTotal, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.TbPaidAmount, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.LblReturnAmount, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.TbReturnAmount, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.BtnSave, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.TbVat, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(400, 28);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.74627F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.25373F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(391, 299);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // LblSubTotal
            // 
            this.LblSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSubTotal.AutoSize = true;
            this.LblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTotal.Location = new System.Drawing.Point(3, 0);
            this.LblSubTotal.Name = "LblSubTotal";
            this.LblSubTotal.Size = new System.Drawing.Size(128, 25);
            this.LblSubTotal.TabIndex = 5;
            this.LblSubTotal.Text = "Sub Total";
            this.LblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblDiscount
            // 
            this.LblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDiscount.AutoSize = true;
            this.LblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiscount.Location = new System.Drawing.Point(3, 34);
            this.LblDiscount.Name = "LblDiscount";
            this.LblDiscount.Size = new System.Drawing.Size(128, 25);
            this.LblDiscount.TabIndex = 6;
            this.LblDiscount.Text = "Discount (%)";
            this.LblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblGrandTotal
            // 
            this.LblGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblGrandTotal.AutoSize = true;
            this.LblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGrandTotal.Location = new System.Drawing.Point(3, 100);
            this.LblGrandTotal.Name = "LblGrandTotal";
            this.LblGrandTotal.Size = new System.Drawing.Size(128, 25);
            this.LblGrandTotal.TabIndex = 6;
            this.LblGrandTotal.Text = "Grand Total";
            this.LblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblVat
            // 
            this.LblVat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblVat.AutoSize = true;
            this.LblVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVat.Location = new System.Drawing.Point(3, 67);
            this.LblVat.Name = "LblVat";
            this.LblVat.Size = new System.Drawing.Size(128, 25);
            this.LblVat.TabIndex = 6;
            this.LblVat.Text = "VAT (%)";
            this.LblVat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblPaidAmount
            // 
            this.LblPaidAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPaidAmount.AutoSize = true;
            this.LblPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPaidAmount.Location = new System.Drawing.Point(3, 131);
            this.LblPaidAmount.Name = "LblPaidAmount";
            this.LblPaidAmount.Size = new System.Drawing.Size(128, 25);
            this.LblPaidAmount.TabIndex = 7;
            this.LblPaidAmount.Text = "Paid Amount";
            this.LblPaidAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbSubTotal
            // 
            this.TbSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbSubTotal.Location = new System.Drawing.Point(137, 3);
            this.TbSubTotal.Name = "TbSubTotal";
            this.TbSubTotal.Size = new System.Drawing.Size(251, 26);
            this.TbSubTotal.TabIndex = 8;
            // 
            // TbDiscount
            // 
            this.TbDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbDiscount.Location = new System.Drawing.Point(137, 37);
            this.TbDiscount.Name = "TbDiscount";
            this.TbDiscount.Size = new System.Drawing.Size(251, 26);
            this.TbDiscount.TabIndex = 8;
            // 
            // TbVat
            // 
            this.TbVat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbVat.Location = new System.Drawing.Point(137, 70);
            this.TbVat.Name = "TbVat";
            this.TbVat.Size = new System.Drawing.Size(251, 26);
            this.TbVat.TabIndex = 8;
            // 
            // TbGrandTotal
            // 
            this.TbGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbGrandTotal.Location = new System.Drawing.Point(137, 103);
            this.TbGrandTotal.Name = "TbGrandTotal";
            this.TbGrandTotal.Size = new System.Drawing.Size(251, 26);
            this.TbGrandTotal.TabIndex = 8;
            // 
            // TbPaidAmount
            // 
            this.TbPaidAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbPaidAmount.Location = new System.Drawing.Point(137, 134);
            this.TbPaidAmount.Name = "TbPaidAmount";
            this.TbPaidAmount.Size = new System.Drawing.Size(251, 26);
            this.TbPaidAmount.TabIndex = 8;
            // 
            // LblReturnAmount
            // 
            this.LblReturnAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblReturnAmount.AutoSize = true;
            this.LblReturnAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReturnAmount.Location = new System.Drawing.Point(3, 167);
            this.LblReturnAmount.Name = "LblReturnAmount";
            this.LblReturnAmount.Size = new System.Drawing.Size(128, 25);
            this.LblReturnAmount.TabIndex = 9;
            this.LblReturnAmount.Text = "Return";
            this.LblReturnAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbReturnAmount
            // 
            this.TbReturnAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbReturnAmount.ForeColor = System.Drawing.Color.Maroon;
            this.TbReturnAmount.Location = new System.Drawing.Point(137, 170);
            this.TbReturnAmount.Name = "TbReturnAmount";
            this.TbReturnAmount.Size = new System.Drawing.Size(251, 26);
            this.TbReturnAmount.TabIndex = 10;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(137, 250);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(151, 46);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // TrasactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 664);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblTransactionsTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrasactionsForm";
            this.Text = "Trasactions ";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.TlpUserFields.ResumeLayout(false);
            this.TlpUserFields.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAddedProduct)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransactionsTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LblContactHeader;
        private System.Windows.Forms.TableLayoutPanel TlpUserFields;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.Label LblContactName;
        private System.Windows.Forms.TextBox TbSearch;
        private System.Windows.Forms.TextBox TbContactName;
        private System.Windows.Forms.Label LblContactNo;
        private System.Windows.Forms.TextBox TbContactNo;
        private System.Windows.Forms.Label LblBillDate;
        private System.Windows.Forms.DateTimePicker DtpBillDate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblProductName;
        private System.Windows.Forms.TextBox TbSearchProduct;
        private System.Windows.Forms.TextBox TbProductName;
        private System.Windows.Forms.Label LblProductInventory;
        private System.Windows.Forms.TextBox TbProductInventory;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.TextBox TbQuantity;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.TextBox TbPrice;
        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView DGVAddedProduct;
        private System.Windows.Forms.Label LblAddedProduct;
        private System.Windows.Forms.Label LblCalculation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label LblSubTotal;
        private System.Windows.Forms.Label LblDiscount;
        private System.Windows.Forms.Label LblGrandTotal;
        private System.Windows.Forms.Label LblVat;
        private System.Windows.Forms.Label LblPaidAmount;
        private System.Windows.Forms.TextBox TbSubTotal;
        private System.Windows.Forms.TextBox TbDiscount;
        private System.Windows.Forms.TextBox TbVat;
        private System.Windows.Forms.TextBox TbGrandTotal;
        private System.Windows.Forms.TextBox TbPaidAmount;
        private System.Windows.Forms.Label LblReturnAmount;
        private System.Windows.Forms.TextBox TbReturnAmount;
        private System.Windows.Forms.Button BtnSave;
    }
}