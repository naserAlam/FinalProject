using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject.Forms
{
    public partial class CategoriesForm : Form
    {
        private SqlConnection connection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter dataAdapter;
        int categoryId;

        public CategoriesForm()
        {
            InitializeComponent();
            connection = new SqlConnection(DbConnection.ConnectionString);
            DisplayData();
        }

        #region Form Setup
        public void DisplayData()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string query = "SELECT * FROM FinalProjectDb.dbo.Categories";
                dataAdapter = new SqlDataAdapter(query, connection);
                DataTable categoryTable = new DataTable();
                dataAdapter.Fill(categoryTable);

                DGVCategoryList.DataSource = categoryTable;

                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Category table could not be loaded.");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public void ClearForm()
        {
            TbCategoryName.Text = ""; 
        }

        private void DGVCategoryList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                categoryId = Convert.ToInt32(DGVCategoryList.Rows[e.RowIndex].Cells[0].Value.ToString());
                TbCategoryName.Text = DGVCategoryList.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Select a valid row");
                DisplayData();
            }
        }
        #endregion

        #region Insert Category
        private void BtnSaveCategory_Click(object sender, EventArgs e)
        {
            var categoryName = TbCategoryName.Text;
            if(!string.IsNullOrWhiteSpace(categoryName))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO FinalProjectDb.dbo.Categories VALUES('" + categoryName + "')";
                    sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Category Created Successfuly");
                    connection.Close();

                    DisplayData();
                    ClearForm();
                }
                catch (Exception)
                {
                    MessageBox.Show("Category Could not be created.");
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

        #region Update Category
        private void BtnUpdateCategory_Click(object sender, EventArgs e)
        {
            var categoryName = TbCategoryName.Text;
            if (!string.IsNullOrWhiteSpace(categoryName)) 
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE FinalProjectDb.dbo.Categories SET Name='" + categoryName + "' WHERE Id='" + categoryId + "'";
                    sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Category Updated Successfuly");
                    connection.Close();

                    DisplayData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Category Could not be Updated.\r\n " + ex.Message);
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

        #region Delete Category
        private void BtnDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "DELETE FinalProjectDb.dbo.Categories WHERE Id='" + categoryId + "'";
                sqlCommand = new SqlCommand(query, connection);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Category Deleted Successfuly");
                connection.Close();

                DisplayData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Category Could not be Deleted.\r\n" + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        #endregion

        #region Search Category
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var searchWord = TbSearchWord.Text;

            if (!string.IsNullOrWhiteSpace(searchWord))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM FinalProjectDb.dbo.Categories WHERE FinalProjectDb.dbo.Categories.Name LIKE '%"+searchWord+"%'";
                    dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable categoryTable = new DataTable();
                    dataAdapter.Fill(categoryTable);

                    DGVCategoryList.DataSource = categoryTable;

                    connection.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
