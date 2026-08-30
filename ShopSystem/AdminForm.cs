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
    public partial class AdminForm : Form
    {
        private LoginForm LF { get; set; }

        public AdminForm()
        {
            InitializeComponent();
        }
        public AdminForm(string name, LoginForm LF) : this()
        {
           // this.lbl.Text += name;
           
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm lg= new LoginForm();
            lg.Show();
            this.Visible = false;


        }

        private void masterSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productReceiveStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductReceiveForm pr= new ProductReceiveForm();
            pr.Show();
            this.Visible=false;
        }

        private void StackStripMenuItem_Click(object sender, EventArgs e)
        {
            StockForm stc= new StockForm();
            stc.Show();
            this.Visible = false;

        }

        private void salePunchStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleEntryForm se= new SaleEntryForm();
            se.Show();
            this.Visible = false;

        }

        private void saleSummaryStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleSummaryForm ss= new SaleSummaryForm();
            ss.Show();
            this.Visible = false;

        }

        private void productEntryStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductEntryForm pe= new ProductEntryForm();
            pe.Show();
            this.Visible = false;

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            pnlAddMember.Visible = true;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtId.Clear();
            this.txtName.Clear();
            this.txtPassword.Clear();
            this.txtRole.Clear();
        }

        private void btnBackfromAddMember_Click(object sender, EventArgs e)
        {
            pnlAddMember.Visible= false;
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
