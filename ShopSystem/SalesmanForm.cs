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
    public partial class SalesmanForm : Form
    {
        public SalesmanForm()
        {
            InitializeComponent();
        }

        private void button_saleentry_Click(object sender, EventArgs e)
        {
            SaleEntryForm sef = new SaleEntryForm();
            sef.Show();
        }

        private void button_salesummary_Click(object sender, EventArgs e)
        {
            SaleSummaryForm ssf = new SaleSummaryForm();
            ssf.Show();
        }
    }
}
