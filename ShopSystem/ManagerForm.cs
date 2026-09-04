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
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {

            btnRefresh.Show();
            txtSearch.Show();
            lblSearch.Show();
            btnSearch.Show();

            try
            {
                SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=TestDatabase;Integrated Security=True;Encrypt=False");
                con.Open();
                var query = "Select * from Product";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];

                gridShowData.DataSource = dt;
                gridShowData.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while fetching data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=TestDatabase;Integrated Security=True;Encrypt=False");
                con.Open();
                var query = $"Select * from Product where Productname like '%{search}%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];

                gridShowData.DataSource = dt;
                gridShowData.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while fetching data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Show();
            lblSearch.Show();
            btnSearch.Show();

            try
            {
                SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=TestDatabase;Integrated Security=True;Encrypt=False");
                con.Open();
                var query = "Select * from Product";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];

                gridShowData.DataSource = dt;
                gridShowData.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while fetching data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
