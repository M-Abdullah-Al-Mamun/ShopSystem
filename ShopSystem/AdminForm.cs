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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm lg= new LoginForm();
            MessageBox.Show("Logged out from the system");
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
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnShowMenue_Click(object sender, EventArgs e)
        {
            this.pnlMenue.Visible = true;
        }

        private void menuStrip4_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMemberForm addMember = new AddMemberForm();
            addMember.Show();
            this.Visible = false;
        }
    }
}
