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
    public partial class AllProductListForm : Form
    {
        public AllProductListForm()
        {
            InitializeComponent();
        }

        private void btnBackfromSR_Click(object sender, EventArgs e)
        {
            AdminForm ad=new AdminForm();
            ad.Show();
            this.Visible = false;
        }

        private void StockForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
