using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject.Forms
{
    public partial class ProductForm : Form
    {
        private SqlConnection connection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter dataAdapter;
        int productId;

        public ProductForm()
        {
            InitializeComponent();
            connection = new SqlConnection(DbConnection.ConnectionString);
            DisplayData();
        }

        #region Form Setup
        private void ProductForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "SELECT * FROM FinalProjectDb.dbo.Categories";
                sqlCommand = new SqlCommand(query, connection);
                dataAdapter = new SqlDataAdapter
                {
                    SelectCommand = sqlCommand
                };

                DataTable productCategories = new DataTable();
                dataAdapter.Fill(productCategories);

                CbProductCategory.DataSource = productCategories;
                CbProductCategory.DisplayMember = "Name";
                CbProductCategory.ValueMember = "Id";
            }
            catch (Exception)
            {
                MessageBox.Show("The form is taking longer than usual.\r\nThank You for your Patientce.");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private bool isValid()
        {
            if (string.IsNullOrWhiteSpace(TbProductName.Text) || string.IsNullOrWhiteSpace(TbPrice.Text) || string.IsNullOrWhiteSpace(TbUnit.Text) || string.IsNullOrWhiteSpace(CbProductCategory.Text))
                return false;
            return true;
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

        public void ClearForm()
        {
            TbProductName.Text = "";
            TbDescription.Text = "";
            TbPrice.Text = "";
            TbUnit.Text = "";
            CbProductCategory.Text = default;
        }
        private void DGVProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensures user selects a valid row
            try
            {
                productId = Convert.ToInt32(DGVProductList.Rows[e.RowIndex].Cells[0].Value.ToString());
                TbProductName.Text = DGVProductList.Rows[e.RowIndex].Cells[1].Value.ToString();
                TbDescription.Text = DGVProductList.Rows[e.RowIndex].Cells[2].Value.ToString();
                TbPrice.Text = DGVProductList.Rows[e.RowIndex].Cells[3].Value.ToString();
                TbUnit.Text = DGVProductList.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Select a valid row");
                DisplayData();
            }
        }
        #endregion

        #region Insert Product
        private void BtnSaveProduct_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                var productName = TbProductName.Text;
                var price = Convert.ToInt32(TbPrice.Text);
                var unit = Convert.ToInt32(TbUnit.Text);
                var category = Convert.ToInt32(CbProductCategory.SelectedValue);
                var description = TbDescription.Text;

                try
                {
                    connection.Open();
                    string query = "INSERT INTO FinalProjectDb.dbo.Products VALUES('" + productName + "','" + description + "','" + price + "','" + unit + "','" + category + "')";
                    sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Product Created Successfuly");
                    connection.Close();

                    DisplayData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Product Could not be created.\r\n" + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            else MessageBox.Show("Please Enter Correct Values");
        }
        #endregion

        #region Update Product
        private void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                var productName = TbProductName.Text;
                var price = Convert.ToDecimal(TbPrice.Text);
                var unit = Convert.ToInt32(TbUnit.Text);
                var category = Convert.ToInt32(CbProductCategory.SelectedValue);
                var description = TbDescription.Text;

                try
                {
                    connection.Open();
                    string query = "UPDATE FinalProjectDb.dbo.Products SET Name ='" + productName + "', Description ='" + description + "', Price ='" + price + "', Unit ='" + unit + "', CategoryId ='" + category + "' WHERE Id ='" + productId + "'";
                    sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Product Updated Successfuly");
                    connection.Close();

                    DisplayData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Product Could not be updated." + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            else MessageBox.Show("Please input correct values");
        }
        #endregion

        #region Delete Product
        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "DELETE FinalProjectDb.dbo.Products WHERE Id='" + productId + "'";
                sqlCommand = new SqlCommand(query, connection);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Product Deleted Successfuly");
                connection.Close();

                DisplayData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product Could not be Deleted.\r\n" + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        #endregion

        #region Search Product
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var searchWord = TbSearchWord.Text;
            if (!string.IsNullOrWhiteSpace(searchWord))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    string query = "SELECT FinalProjectDb.dbo.Products.Id, FinalProjectDb.dbo.Products.Name, Description, Price, Unit, FinalProjectDb.dbo.Categories.Name AS Category FROM FinalProjectDb.dbo.Products INNER JOIN FinalProjectDb.dbo.Categories ON FinalProjectDb.dbo.Products.CategoryId = FinalProjectDb.dbo.Categories.Id WHERE FinalProjectDb.dbo.Products.Name LIKE '%"+searchWord+ "%' OR FinalProjectDb.dbo.Categories.Name LIKE '%"+searchWord+"%'";
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

        }
        #endregion
    }
}
