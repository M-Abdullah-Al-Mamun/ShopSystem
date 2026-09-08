using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopSystem
{
    public partial class ManagerForm : Form
    {
        private string UserName { get; set; }
        public ManagerForm()
        {
            InitializeComponent();
        }
        public ManagerForm(string username ):this()
        {
            this.UserName = username;
            this.lblManagerUsername.Text = username;
        }
        

        private void btnShowData_Click(object sender, EventArgs e)
        {

            btnRefresh.Show();
            txtSearch.Show();
            lblSearch.Show();
            btnSearch.Show();

            try
            {
                ForDatabaseShortcutClass db = new ForDatabaseShortcutClass();
                gridShowData.DataSource = db.ExecuteQueryTable("SELECT * FROM ProductInfoTable");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            try
            {
                ForDatabaseShortcutClass db = new ForDatabaseShortcutClass();
                gridShowData.DataSource = db.ExecuteQueryTable($"SELECT * FROM ProductInfoTable WHERE Name LIKE '%{search}%'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Show();
            lblSearch.Show();
            btnSearch.Show();

            try
            {
                ForDatabaseShortcutClass db = new ForDatabaseShortcutClass();
                gridShowData.DataSource = db.ExecuteQueryTable("SELECT * FROM ProductInfoTable");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void btnout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnSaleEntry_Click(object sender, EventArgs e)
        {
            SaleEntryForm saleEntryForm = new SaleEntryForm();
            saleEntryForm.Show();
        }

        private void btnSaleSummary_Click(object sender, EventArgs e)
        {
            SaleSummaryForm saleSummaryForm = new SaleSummaryForm();
            saleSummaryForm.Show();
        }
    }
}
