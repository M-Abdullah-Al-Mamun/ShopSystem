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
        private ForDatabaseShortcutClass FDS { get; set; }

        public AllProductsListForm()
        {
            InitializeComponent();
            this.FDS = new ForDatabaseShortcutClass();
            this.TableView();
        }

        private void TableView(string sql= "Select * from ProductInfoTable;")
        {
            DataSet ds = this.FDS.ExecuteQuery(sql);

            this.dgvProductInfo.AutoGenerateColumns = false;
            this.dgvProductInfo.DataSource=ds.Tables[0];

        }
        private void btnBackfromPE_Click(object sender, EventArgs e)
        {
            AdminForm ad=new AdminForm();
            ad.Show();
            this.Visible = false;
        }

        private void dgvProductInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void AllProductsListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            try
            {
                string code= this.txtSearch.Text;
                this.txtSearch.Clear();
                if (string.IsNullOrEmpty(code))
                {
                    MessageBox.Show("Please Enter a Product Code");
                }
                string sql = "Select * from ProductInfoTable where code= '"+code+"';";
                DataSet ds= this.FDS.ExecuteQuery(sql);
                this.dgvProductInfo.DataSource = ds.Tables[0];
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error.\n"+ex.Message);
            }
        }
    }
}
