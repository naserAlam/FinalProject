using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Security.Cryptography;

namespace FinalProject
{
    public partial class UsersForm : Form
    {
        private SqlConnection connection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter dataAdapter;
        int userId;

        public UsersForm()
        {
            InitializeComponent();
            connection = new SqlConnection(DbConnection.ConnectionString);
            DisplayData();
        }

        #region Form Setup
        /* IsValid
         * The method checks if the all the data are provided in the form
         */
        private bool IsValid()
        {
            // checking valid email using MailAddress
            string email = TbEmail.Text;

            try
            {
                _ = new MailAddress(email);
            }
            catch (Exception)
            {
                return false;
            }

            // validate username, password, usertype
            if (string.IsNullOrWhiteSpace(TbUsername.Text) || string.IsNullOrWhiteSpace(TbPassword.Text) || string.IsNullOrWhiteSpace(CbUserType.Text))
                return false;

            // password length must be greater than 5
            if (TbPassword.Text.Length <= 5)
                return false;
            
            return true;
        }

        /* Encrypt
         * The method encrypt the string using MD5 algorithm
         */
        private string Encrypt(string password)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding uTF8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(uTF8.GetBytes(password));
                return Convert.ToBase64String(data);
            }
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            try
            {
                if(connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "SELECT * FROM FinalProjectDb.dbo.UserTypes";
                sqlCommand = new SqlCommand(query, connection);
                dataAdapter = new SqlDataAdapter
                {
                    SelectCommand = sqlCommand
                };

                DataTable userTypes = new DataTable();
                dataAdapter.Fill(userTypes);

                CbUserType.DataSource = userTypes;
                CbUserType.DisplayMember = "Name";
                CbUserType.ValueMember = "Id";
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
        /*
         * Display Data Method Refreshes and loads data in the grid
         */
        public void DisplayData()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string query = "SELECT FinalProjectDb.dbo.Users.Id, Username, FirstName, LastName, Email, FinalProjectDb.dbo.UserTypes.Name AS Role FROM FinalProjectDb.dbo.Users INNER JOIN FinalProjectDb.dbo.UserTypes ON FinalProjectDb.dbo.Users.UserTypeId = FinalProjectDb.dbo.UserTypes.Id";
                dataAdapter = new SqlDataAdapter(query, connection);
                DataTable userTable = new DataTable();
                dataAdapter.Fill(userTable);

                DGVUserList.DataSource = userTable;

                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("User table could not be loaded.");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public void ClearForm()
        {
            TbUsername.Text = "";
            TbPassword.Text = "";
            TbFirstName.Text = "";
            TbLastName.Text = "";
            TbEmail.Text = "";
            CbUserType.Text = default;
        }

        /* 
         * Sends data of the row clicked twice to form
         */
        private void DGVUserList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensures user selects valid row
            try
            {
                userId = Convert.ToInt32(DGVUserList.Rows[e.RowIndex].Cells[0].Value.ToString());
                TbUsername.Text = DGVUserList.Rows[e.RowIndex].Cells[1].Value.ToString();
                TbFirstName.Text = DGVUserList.Rows[e.RowIndex].Cells[2].Value.ToString();
                TbLastName.Text = DGVUserList.Rows[e.RowIndex].Cells[3].Value.ToString();
                TbEmail.Text = DGVUserList.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Select a valid row");
                DisplayData();
            }

        }
        #endregion

        #region Insert User
        private void BtnSaveUser_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                var firstName = TbFirstName.Text;
                var lastName = TbLastName.Text;
                var password = Encrypt(TbPassword.Text);
                var username = TbUsername.Text;
                var email = TbEmail.Text;
                var usertype = Convert.ToInt32(CbUserType.SelectedValue);

                try
                {
                    connection.Open();
                    string query = "INSERT INTO FinalProjectDb.dbo.Users VALUES('" + username + "','" + password + "','" + firstName + "','" + lastName + "','" + email + "','" + usertype + "')";
                    sqlCommand = new SqlCommand(query,connection);
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("User Created Successfuly");
                    connection.Close();

                    DisplayData();
                    ClearForm();
                }
                catch (Exception)
                {
                    MessageBox.Show("User Could not be created.");
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

        #region Update User
        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                var firstName = TbFirstName.Text;
                var lastName = TbLastName.Text;
                var password = Encrypt(TbPassword.Text);
                var username = TbUsername.Text;
                var email = TbEmail.Text;
                var usertype = (int)CbUserType.SelectedValue;

                try
                {
                    connection.Open();
                    string query = "UPDATE FinalProjectDb.dbo.Users SET Username='"+username+"', Password='"+password+"', FirstName='" + firstName + "',LastName='" + lastName + "',Email='" + email + "',UserTypeId='" + usertype + "' WHERE Id='"+userId+"'";
                    sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("User Updated Successfuly");
                    connection.Close();

                    DisplayData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("User Could not be Updated.\r\n " + ex.Message);
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

        #region Delete User
        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "DELETE FinalProjectDb.dbo.Users WHERE Id='" + userId + "'";
                sqlCommand = new SqlCommand(query, connection);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("User Deleted Successfuly");
                connection.Close();

                DisplayData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("User Could not be Deleted.\r\n" + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        #endregion

        #region Search User
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var searchWord = TbSearchWord.Text;

            if(!string.IsNullOrWhiteSpace(searchWord))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT FinalProjectDb.dbo.Users.Id, FinalProjectDb.dbo.Users.Username, FinalProjectDb.dbo.Users.FirstName, FinalProjectDb.dbo.Users.LastName, FinalProjectDb.dbo.Users.Email, FinalProjectDb.dbo.UserTypes.Name AS Role FROM FinalProjectDb.dbo.Users INNER JOIN FinalProjectDb.dbo.UserTypes ON FinalProjectDb.dbo.Users.UserTypeId = FinalProjectDb.dbo.UserTypes.Id WHERE FinalProjectDb.dbo.Users.Username LIKE '%"+searchWord+ "%' OR FinalProjectDb.dbo.UserTypes.Name LIKE '%" + searchWord + "%'";
                    dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable userTable = new DataTable();
                    dataAdapter.Fill(userTable);

                    DGVUserList.DataSource = userTable;

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
