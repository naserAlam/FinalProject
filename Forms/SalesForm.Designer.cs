
namespace FinalProject.Forms
{
    partial class SalesForm
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
            this.LblDate = new System.Windows.Forms.Label();
            this.DtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.BtnSearchProduct = new System.Windows.Forms.Button();
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVCart = new System.Windows.Forms.DataGridView();
            this.LblAddedProduct = new System.Windows.Forms.Label();
            this.LblCalculation = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LblReturnAmount = new System.Windows.Forms.Label();
            this.TbReturnAmount = new System.Windows.Forms.TextBox();
            this.LblGrandTotal = new System.Windows.Forms.Label();
            this.TbGrandTotal = new System.Windows.Forms.TextBox();
            this.LblPaidAmount = new System.Windows.Forms.Label();
            this.TbPaidAmount = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCart)).BeginInit();
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
            this.lblTransactionsTitle.Location = new System.Drawing.Point(338, 9);
            this.lblTransactionsTitle.Name = "lblTransactionsTitle";
            this.lblTransactionsTitle.Size = new System.Drawing.Size(141, 42);
            this.lblTransactionsTitle.TabIndex = 15;
            this.lblTransactionsTitle.Text = "SALES";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 54);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(791, 148);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblProductName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TbSearchProduct, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TbProductName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblProductInventory, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TbProductInventory, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblQuantity, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TbQuantity, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblDate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DtpBillDate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnSearchProduct, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnAddProduct, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(791, 120);
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
            this.label2.Size = new System.Drawing.Size(127, 25);
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
            this.LblProductName.Location = new System.Drawing.Point(379, 0);
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
            this.TbSearchProduct.Location = new System.Drawing.Point(136, 3);
            this.TbSearchProduct.Name = "TbSearchProduct";
            this.TbSearchProduct.Size = new System.Drawing.Size(237, 26);
            this.TbSearchProduct.TabIndex = 5;
            // 
            // TbProductName
            // 
            this.TbProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbProductName.Location = new System.Drawing.Point(527, 3);
            this.TbProductName.Name = "TbProductName";
            this.TbProductName.Size = new System.Drawing.Size(261, 26);
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
            this.LblProductInventory.Size = new System.Drawing.Size(127, 25);
            this.LblProductInventory.TabIndex = 4;
            this.LblProductInventory.Text = "Inventory";
            this.LblProductInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbProductInventory
            // 
            this.TbProductInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbProductInventory.Location = new System.Drawing.Point(136, 41);
            this.TbProductInventory.Name = "TbProductInventory";
            this.TbProductInventory.Size = new System.Drawing.Size(237, 26);
            this.TbProductInventory.TabIndex = 5;
            // 
            // LblQuantity
            // 
            this.LblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantity.Location = new System.Drawing.Point(379, 38);
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
            this.TbQuantity.Location = new System.Drawing.Point(527, 41);
            this.TbQuantity.Name = "TbQuantity";
            this.TbQuantity.Size = new System.Drawing.Size(261, 26);
            this.TbQuantity.TabIndex = 5;
            // 
            // LblDate
            // 
            this.LblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(3, 76);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(127, 25);
            this.LblDate.TabIndex = 9;
            this.LblDate.Text = " Date";
            this.LblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DtpBillDate
            // 
            this.DtpBillDate.Location = new System.Drawing.Point(136, 79);
            this.DtpBillDate.Name = "DtpBillDate";
            this.DtpBillDate.Size = new System.Drawing.Size(237, 26);
            this.DtpBillDate.TabIndex = 10;
            // 
            // BtnSearchProduct
            // 
            this.BtnSearchProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchProduct.Location = new System.Drawing.Point(379, 79);
            this.BtnSearchProduct.Name = "BtnSearchProduct";
            this.BtnSearchProduct.Size = new System.Drawing.Size(133, 38);
            this.BtnSearchProduct.TabIndex = 8;
            this.BtnSearchProduct.Text = "Search";
            this.BtnSearchProduct.UseVisualStyleBackColor = true;
            this.BtnSearchProduct.Click += new System.EventHandler(this.BtnSearchProduct_Click);
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddProduct.Location = new System.Drawing.Point(527, 79);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(133, 38);
            this.BtnAddProduct.TabIndex = 6;
            this.BtnAddProduct.Text = "Add";
            this.BtnAddProduct.UseVisualStyleBackColor = true;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.DGVCart, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LblAddedProduct, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LblCalculation, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 220);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 432);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // DGVCart
            // 
            this.DGVCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCart.Location = new System.Drawing.Point(3, 35);
            this.DGVCart.Name = "DGVCart";
            this.DGVCart.RowHeadersWidth = 62;
            this.DGVCart.RowTemplate.Height = 28;
            this.DGVCart.Size = new System.Drawing.Size(391, 394);
            this.DGVCart.TabIndex = 0;
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
            this.tableLayoutPanel3.Controls.Add(this.LblReturnAmount, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.TbReturnAmount, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.LblGrandTotal, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.TbGrandTotal, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.LblPaidAmount, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.TbPaidAmount, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.BtnCalculate, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.BtnSave, 1, 6);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(400, 35);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.74627F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.25373F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(391, 394);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // LblReturnAmount
            // 
            this.LblReturnAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblReturnAmount.AutoSize = true;
            this.LblReturnAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReturnAmount.Location = new System.Drawing.Point(3, 236);
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
            this.TbReturnAmount.Location = new System.Drawing.Point(137, 239);
            this.TbReturnAmount.Name = "TbReturnAmount";
            this.TbReturnAmount.Size = new System.Drawing.Size(251, 26);
            this.TbReturnAmount.TabIndex = 10;
            // 
            // LblGrandTotal
            // 
            this.LblGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblGrandTotal.AutoSize = true;
            this.LblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGrandTotal.Location = new System.Drawing.Point(3, 70);
            this.LblGrandTotal.Name = "LblGrandTotal";
            this.LblGrandTotal.Size = new System.Drawing.Size(128, 25);
            this.LblGrandTotal.TabIndex = 6;
            this.LblGrandTotal.Text = "Grand Total";
            this.LblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbGrandTotal
            // 
            this.TbGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbGrandTotal.ForeColor = System.Drawing.Color.Red;
            this.TbGrandTotal.Location = new System.Drawing.Point(137, 73);
            this.TbGrandTotal.Name = "TbGrandTotal";
            this.TbGrandTotal.Size = new System.Drawing.Size(251, 26);
            this.TbGrandTotal.TabIndex = 8;
            // 
            // LblPaidAmount
            // 
            this.LblPaidAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPaidAmount.AutoSize = true;
            this.LblPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPaidAmount.Location = new System.Drawing.Point(3, 141);
            this.LblPaidAmount.Name = "LblPaidAmount";
            this.LblPaidAmount.Size = new System.Drawing.Size(128, 25);
            this.LblPaidAmount.TabIndex = 7;
            this.LblPaidAmount.Text = "Paid Amount";
            this.LblPaidAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbPaidAmount
            // 
            this.TbPaidAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbPaidAmount.Location = new System.Drawing.Point(137, 144);
            this.TbPaidAmount.Name = "TbPaidAmount";
            this.TbPaidAmount.Size = new System.Drawing.Size(251, 26);
            this.TbPaidAmount.TabIndex = 8;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculate.Location = new System.Drawing.Point(3, 303);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(128, 36);
            this.BtnCalculate.TabIndex = 12;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(137, 303);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(151, 36);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 664);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.lblTransactionsTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesForm";
            this.Text = "Trasactions ";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCart)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransactionsTitle;
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
        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView DGVCart;
        private System.Windows.Forms.Label LblAddedProduct;
        private System.Windows.Forms.Label LblCalculation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label LblGrandTotal;
        private System.Windows.Forms.Label LblPaidAmount;
        private System.Windows.Forms.TextBox TbGrandTotal;
        private System.Windows.Forms.TextBox TbPaidAmount;
        private System.Windows.Forms.Label LblReturnAmount;
        private System.Windows.Forms.TextBox TbReturnAmount;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnSearchProduct;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.DateTimePicker DtpBillDate;
        private System.Windows.Forms.Button BtnCalculate;
    }
}