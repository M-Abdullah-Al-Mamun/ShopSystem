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
    public partial class AllProductsListForm : Form
    {
        public AllProductsListForm()
        {
            InitializeComponent();
        }

        private void btnBackfromPE_Click(object sender, EventArgs e)
        {
            AdminForm ad=new AdminForm();
            ad.Show();
            this.Visible = false;
        }
    }
}
