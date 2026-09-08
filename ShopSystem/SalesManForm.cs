using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopSystem
{
    public partial class SalesManForm : Form
    {
        public SalesManForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm lg= new LoginForm();
            lg.Show();
            this.Visible = false;
        }

        private void btnSaleProduct_Click(object sender, EventArgs e)
        {
            SaleEntryForm sf= new SaleEntryForm();
            sf.Show();          
        }

        private void SalesManForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            AllProductsListForm sf= new AllProductsListForm();
            sf.Show();
        }
    }
}
