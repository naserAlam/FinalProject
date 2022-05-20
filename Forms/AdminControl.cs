using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AdminControl : Form
    {
        public AdminControl()
        {
            InitializeComponent();
        }

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

        private void BtnAdminDashBoard_Click(object sender, EventArgs e)
        {
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            LoadForm(new UsersForm());
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
        }
    }
}
