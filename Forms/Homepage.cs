using FinalProject.Forms;
using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AdminControl : Form
    {
        public AdminControl()
        {
            InitializeComponent();
        }

        public AdminControl(string userrole)
        {
            InitializeComponent();
            if (userrole == "salesoperator")
            {
                BtnCategories.Hide();
                BtnProducts.Hide();
                BtnInventory.Hide();
                BtnUsersForm.Hide();
            }
            else if (userrole == "manager")
            {
                BtnUsersForm.Hide();
            }
        }

        /** Load Form Method
         * Takes a windows form as parameter
         * Checks if any other form is open in the panel
         * Closes the active form(s)
         * Then launchs the requested form.
         */
        public void LoadForm(Form Form)
        {
            if (this.PnlAdminMain.Controls.Count >0)
            {
                this.PnlAdminMain.Controls.RemoveAt(0);
            }

            Form form = Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.PnlAdminMain.Controls.Add(form);
            this.PnlAdminMain.Tag = form;
            form.Show();
        }

        

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            LoadForm(new ProductForm());
        }

        private void BtnCategories_Click(object sender, EventArgs e)
        {
            LoadForm(new CategoriesForm());
        }
        private void BtnTransactions_Click(object sender, EventArgs e)
        {
            LoadForm(new SalesForm());
        }

        private void BtnUsersForm_Click(object sender, EventArgs e)
        {
            LoadForm(new UsersForm());
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            LoadForm(new InventoryForm());
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }
    }
}
