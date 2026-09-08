using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ShopSystem
{
    public partial class SaleSummaryForm : Form
    {
        public SaleSummaryForm()
        {
            InitializeComponent();
            ForDatabaseShortcutClass db = new ForDatabaseShortcutClass();
            gridSaleSummary.DataSource = db.ExecuteQueryTable("SELECT * FROM SaleSummaryTable");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBackfromSS_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }

        private void SaleSummaryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBackfromSE_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaleSummaryForm_Load(object sender, EventArgs e)
        {
            gridSaleSummary.Visible = true;

        }
    }
}
