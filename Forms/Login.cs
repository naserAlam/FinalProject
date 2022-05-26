using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Forms
{
    public partial class Login : Form
    {
        private SqlConnection connection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter dataAdapter;

        public Login()
        {
            InitializeComponent();
            connection = new SqlConnection(DbConnection.ConnectionString);
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

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            var username = TbUsername.Text;
            var rawpassword = TbPassword.Text;

            if(string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(rawpassword))
            {
                MessageBox.Show("Input valid credentials");
            }
            else
            {
                var encryptedPassowrd = Encrypt(rawpassword);

                string query = $"SELECT FinalProjectDb.dbo.Users.Id, FinalProjectDb.dbo.Users.Username, FinalProjectDb.dbo.Users.Password, FinalProjectDb.dbo.Users.FirstName, FinalProjectDb.dbo.Users.LastName, FinalProjectDb.dbo.Users.Email, FinalProjectDb.dbo.UserTypes.Name FROM FinalProjectDb.dbo.Users INNER JOIN FinalProjectDb.dbo.UserTypes ON FinalProjectDb.dbo.Users.UserTypeId = FinalProjectDb.dbo.UserTypes.Id WHERE FinalProjectDb.dbo.Users.Username = '{username}' AND FinalProjectDb.dbo.Users.Password = '{encryptedPassowrd}'";
                dataAdapter = new SqlDataAdapter(query, connection);
                DataTable userCred = new DataTable();
                dataAdapter.Fill(userCred);


                if (userCred.Rows.Count > 0)
                {
                    var userrole = userCred.Rows[0].Field<string>(6);
                    AdminControl homepage = new AdminControl(userrole);
                    homepage.Show();
                    Hide();
                }
                else
                {
                    TbUsername.Text = "";
                    TbPassword.Text = "";
                    MessageBox.Show("Input valid credentials.");
                }
                
            }


        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
