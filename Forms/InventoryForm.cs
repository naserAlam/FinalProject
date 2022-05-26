using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject.Forms
{
    public partial class InventoryForm : Form
    {
        private SqlConnection connection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter dataAdapter;
        private int productId;
        private int productInventory;
        private int productPrice;

        public InventoryForm()
        {
            InitializeComponent();
            connection = new SqlConnection(DbConnection.ConnectionString);
        }
        private void ClearForm()
        {
            TbSearchProduct.Text = "";
            TbProductInventory.Text = "";
            TbProductName.Text = "";
            TbQuantity.Text = "";
        }

        public void DisplayData()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string query = "SELECT FinalProjectDb.dbo.Products.Id, FinalProjectDb.dbo.Products.Name, Description, Price, Unit, FinalProjectDb.dbo.Categories.Name AS Category FROM FinalProjectDb.dbo.Products INNER JOIN FinalProjectDb.dbo.Categories ON FinalProjectDb.dbo.Products.CategoryId = FinalProjectDb.dbo.Categories.Id";
                dataAdapter = new SqlDataAdapter(query, connection);
                DataTable productTable = new DataTable();
                dataAdapter.Fill(productTable);

                DGVProductList.DataSource = productTable;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product table could not be loaded." + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
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
                var newStock = productInventory + quantity;

                try
                {
                    connection.Open();
                    string query = "UPDATE FinalProjectDb.dbo.Products SET Unit ='" + newStock + "' WHERE Id ='" + productId + "'";
                    sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not be updated." + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();

                    DisplayData();
                }
            }
            else MessageBox.Show("Add Quantity");

            ClearForm();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DGVProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                productId = Convert.ToInt32(DGVProductList.Rows[e.RowIndex].Cells[0].Value.ToString());
                TbProductName.Text = DGVProductList.Rows[e.RowIndex].Cells[1].Value.ToString();
                TbProductInventory.Text = DGVProductList.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Select a valid row");
                DisplayData();
            }
        }
    }
}
