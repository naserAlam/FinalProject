using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace FinalProject
{
    public partial class UsersForm : Form
    {
        private SqlConnection connection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter dataAdapter;
        public UsersForm()
        {
            InitializeComponent();
            connection = new SqlConnection(DbConnection.ConnectionString);
        }

        /* IsValid
         * The method checks if the all the data are provided in the form
         */
        private bool IsValid()
        {
            // checking valid email using Regular Expression
            string email = TbEmail.Text;
            //Regex regex = new Regex(@"\\*@\\*\\.\\*");
            //Match match = regex.Match(email);

            _ = new MailAddress(email);

            // validate username, password, usertype
            if (string.IsNullOrWhiteSpace(TbUsername.Text) || string.IsNullOrWhiteSpace(TbPassword.Text) || string.IsNullOrWhiteSpace(CbUserType.Text))
                return false;

            // validate email
            //if (!match.Success)
            //    return false;


            // password length must be greater than 5
            if (TbPassword.Text.Length <= 5)
                return false;
            
            return true;
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

        private void BtnSaveUser_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                var firstName = TbFirstName.Text;
                var lastName = TbLastName.Text;
                var password = TbPassword.Text;
                var username = TbUsername.Text;
                var email = TbEmail.Text;
                var usertype = (int)CbUserType.SelectedValue;

                try
                {
                    connection.Open();
                    string query = "INSERT INTO FinalProjectDb.dbo.Users VALUES('" + username + "','" + password + "','" + firstName + "','" + lastName + "','" + email + "','" + usertype + "')";
                    sqlCommand = new SqlCommand(query,connection);
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("User Created Successfuly");
                    connection.Close();
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
    }
}
