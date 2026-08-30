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
    public partial class ProductReceiveForm : Form
    {
        public ProductReceiveForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBackfromPR_Click(object sender, EventArgs e)
        {
            AdminForm ad = new AdminForm();
            ad.Show();
            this.Visible = false;
        }

        private void ProductReceiveForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
