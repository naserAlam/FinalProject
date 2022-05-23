using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Windows.Forms;

namespace FinalProject.Forms
{
    public partial class SupplierForm : Form
    {
        private SqlConnection connection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter dataAdapter;
        int contactId;

        public SupplierForm()
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
                string query = "SELECT * FROM FinalProjectDb.dbo.DealerCustomers";
                dataAdapter = new SqlDataAdapter(query, connection);
                DataTable contactTable = new DataTable();
                dataAdapter.Fill(contactTable);

                DGVContactList.DataSource = contactTable;

                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Dealer / Customer table could not be loaded.");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public void ClearForm()
        {
            TbContactName.Text = "";
            TbContactEmail.Text = "";
            TbContactNo.Text = "";
        }

        /* IsValid
         * The method checks if the all the data are provided in the form
         */
        private bool isValid()
        {
            string email = TbContactEmail.Text;

            try
            {
                _ = new MailAddress(email);
            }
            catch (Exception)
            {
                return false;
            }

            // validate name, contact no
            if (string.IsNullOrWhiteSpace(TbContactName.Text) || string.IsNullOrWhiteSpace(TbContactNo.Text))
                return false;

            return true;
        }

        private void DGVContactList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                contactId = Convert.ToInt32(DGVContactList.Rows[e.RowIndex].Cells[0].Value.ToString());
                TbContactName.Text = DGVContactList.Rows[e.RowIndex].Cells[1].Value.ToString();
                CbContactType.Text = DGVContactList.Rows[e.RowIndex].Cells[2].Value.ToString();
                TbContactNo.Text = DGVContactList.Rows[e.RowIndex].Cells[3].Value.ToString();
                TbContactEmail.Text = DGVContactList.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Select a valid row");
                DisplayData();
            }
        }
        #endregion

        #region Insert Supplier or Customer
        private void BtnSaveUser_Click(object sender, EventArgs e)
        {
            if(isValid())
            {
                var contactName = TbContactName.Text;
                var contactType = CbContactType.Text;
                var contactNo = TbContactNo.Text;
                var contactEmail = TbContactEmail.Text;

                try
                {
                    connection.Open();
                    string query = "INSERT INTO FinalProjectDb.dbo.DealerCustomers VALUES('" + contactName + "','" + contactType + "','" + contactNo + "','" + contactEmail + "')";
                    sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("User Created Successfuly");
                    connection.Close();

                    DisplayData();
                    ClearForm();
                }
                catch (Exception)
                {
                    MessageBox.Show("Supplier Could not be created.");
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

        #region Update Supplier & Contact Details
        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                var contactName = TbContactName.Text;
                var contactType = CbContactType.Text;
                var contactNo = TbContactNo.Text;
                var contactEmail = TbContactEmail.Text;

                try
                {
                    connection.Open();
                    string query = "UPDATE FinalProjectDb.dbo.DealerCustomers SET Name ='" + contactName + "', ContactType ='" + contactType + "', ContactNo ='" + contactNo + "', Email='" + contactEmail + "' WHERE Id='" + contactId + "'";
                    sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Supplier Updated Successfuly");
                    connection.Close();

                    DisplayData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Supplier Could not be Updated.\r\n " + ex.Message);
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

        #region Delete Supplier
        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "DELETE FinalProjectDb.dbo.DealerCustomers WHERE Id ='" + contactId + "'";
                sqlCommand = new SqlCommand(query, connection);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Supplier Deleted Successfuly");
                connection.Close();

                DisplayData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Supplier Could not be Deleted.\r\n" + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        #endregion

        #region Search Supplier
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var searchWord = TbSearchWord.Text;

            if (!string.IsNullOrWhiteSpace(searchWord))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM FinalProjectDb.dbo.DealerCustomers WHERE FinalProjectDb.dbo.DealerCustomers.Name LIKE '%" + searchWord + "%' OR FinalProjectDb.dbo.DealerCustomers.ContactNo LIKE '%" + searchWord + "%' OR FinalProjectDb.dbo.DealerCustomers.ContactType LIKE '%" + searchWord + "%' OR FinalProjectDb.dbo.DealerCustomers.Email Like '%" + searchWord + "%'";
                    dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable contactTable = new DataTable();
                    dataAdapter.Fill(contactTable);

                    DGVContactList.DataSource = contactTable;

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
