using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject.Forms
{
    public partial class SalesForm : Form
    {
        private SqlConnection connection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter dataAdapter;
        private DataTable cart;
        private int productId;
        private int productInventory;
        private List<int> costList;
        private int productPrice;
        private int newStock;

        public SalesForm()
        {
            InitializeComponent();
            connection = new SqlConnection(DbConnection.ConnectionString);
            cart = new DataTable();
            costList = new List<int>();

            cart.Columns.Add("Product Id", typeof(int));
            cart.Columns.Add("Date", typeof(DateTime));
            cart.Columns.Add("Quantity", typeof(int));
        }

        private void ClearForm()
        {
            TbSearchProduct.Text = "";
            TbProductInventory.Text = "";
            TbProductName.Text = "";
            TbQuantity.Text = "";
        }

        private void BtnSearchProduct_Click(object sender, EventArgs e)
        {
            var searchWord = TbSearchProduct.Text;

            if (!string.IsNullOrWhiteSpace(searchWord))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    //string query = "SELECT * FROM FinalProjectDb.dbo.Products WHERE FinalProjectDb.dbo.Products.Name = '%"+searchWord+ "%'";
                    string query = $"SELECT * FROM FinalProjectDb.dbo.Products WHERE FinalProjectDb.dbo.Products.Name = '{searchWord}'";
                    dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable productTable = new DataTable();
                    dataAdapter.Fill(productTable);

                    if (productTable.Rows.Count > 0)
                    {
                        productId = productTable.Rows[0].Field<int>(0);
                        var productName = productTable.Rows[0].Field<string>(1);
                        productPrice = productTable.Rows[0].Field<int>(3);
                        productInventory = productTable.Rows[0].Field<int>(4);


                        TbProductName.Text = productName;
                        TbProductInventory.Text = productInventory.ToString();
                    }
                    else MessageBox.Show("Please add correct product name");

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Product table could not be loaded.\r\n" + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TbQuantity.Text))
            {

                var quantity = Convert.ToInt32(TbQuantity.Text);
                var billDate = DtpBillDate.Value;

                if (productInventory >= quantity)
                {
                    cart.Rows.Add(productId, billDate, quantity);
                    costList.Add(productPrice*quantity);

                    var grandCost = 0;

                    foreach (int cost in costList)
                        grandCost += cost;

                    TbGrandTotal.Text = grandCost.ToString();

                    newStock = productInventory - quantity;

                }
                else MessageBox.Show("Not in stock");

                DGVCart.DataSource = cart;
            }
            else MessageBox.Show("Add Quantity");

            ClearForm();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var grandTotal = Convert.ToInt32(TbGrandTotal.Text);
            var paidAmount = Convert.ToInt32(TbPaidAmount.Text);
            var returnAmount = paidAmount - grandTotal;

            TbReturnAmount.Text = returnAmount.ToString();

            try
            {
                connection.Open();
                string query_oo = "UPDATE FinalProjectDb.dbo.Products SET Unit ='" + newStock + "' WHERE Id ='" + productId + "'";
                sqlCommand = new SqlCommand(query_oo, connection);
                sqlCommand.ExecuteNonQuery();

                foreach (DataRow row in cart.Rows)
                {
                    var proId = row.Field<int>(0);
                    var bildat = row.Field<DateTime>(1);
                    var qnty = row.Field<int>(2);

                    string query_o = "INSERT INTO FinalProjectDb.dbo.BillDetails VALUES('" + proId + "','" + bildat + "','" + qnty + "')";
                    dataAdapter = new SqlDataAdapter(query_o, connection);
                    sqlCommand.ExecuteNonQuery();
                }

                string query = "SELECT Id FROM FinalProjectDb.dbo.BillDetails";
                dataAdapter = new SqlDataAdapter(query, connection);
                sqlCommand.ExecuteNonQuery();

                DataTable billdetailsTable = new DataTable();
                dataAdapter.Fill(billdetailsTable);

                foreach(DataRow row in billdetailsTable.Rows)
                {
                    var bilid = row.Field<int>(0);

                    string query_o = "INSERT INTO FinalProjectDb.dbo.Bills VALUES('" + grandTotal + "','" + paidAmount + "','" + returnAmount + "','" + bilid + "')";
                    dataAdapter = new SqlDataAdapter(query_o, connection);
                    sqlCommand.ExecuteNonQuery();
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not be updated." + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

                TbReturnAmount.Text = "";
                TbGrandTotal.Text = "";
                TbPaidAmount.Text = "";
                cart.Clear();
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TbPaidAmount.Text))
            {
                var grandTotal = Convert.ToInt32(TbGrandTotal.Text);
                var paidAmount = Convert.ToInt32(TbPaidAmount.Text);
                var returnAmount = paidAmount - grandTotal;

                TbReturnAmount.Text = returnAmount.ToString();
            }
            else MessageBox.Show("Input Paid Amount");
        }
    }
}
