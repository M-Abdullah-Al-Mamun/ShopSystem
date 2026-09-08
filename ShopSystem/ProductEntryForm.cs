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
    public partial class ProductEntryForm : Form
    {
        private ForDatabaseShortcutClass FDS { get; set; }

        public ProductEntryForm()
        {
            InitializeComponent();
            this.FDS = new ForDatabaseShortcutClass();
            this.TableView();
        }
        private void TableView(string sql = "Select * from ProductInfoTable;")
        {
            DataSet ds = this.FDS.ExecuteQuery(sql);

            this.dgvProductInfAddTable.AutoGenerateColumns = false;
            this.dgvProductInfAddTable.DataSource = ds.Tables[0];
        }
        private bool IsValidToAdd()
        {
            if (string.IsNullOrEmpty(this.txtCodeAdd.Text) || string.IsNullOrEmpty(this.txtNameAdd.Text) ||
                string.IsNullOrEmpty(this.txtPriceAdd.Text) || string.IsNullOrEmpty(this.txtQuantityAdd.Text))
                return false;
            else
                return true;
        }

        private void btnBackfromPE_Click(object sender, EventArgs e)
        {
            AdminForm ad=new AdminForm();
            ad.Show();
            this.Visible = false;
          
        }

        private void ProductEntryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToAdd())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var query = "select * from ProductInfoTable where Code = '" + this.txtCodeAdd.Text + "';";
                var dt = this.FDS.ExecuteQueryTable(query);

                if (dt.Rows.Count == 0)
                {
                    var sql = "insert into ProductInfoTable values('" + this.txtCodeAdd.Text + "', '" + this.txtNameAdd.Text + "', '" + this.txtPriceAdd.Text + "', '" + this.txtQuantityAdd.Text + "')";
                    int count = this.FDS.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("New Product Added");
                    else
                        MessageBox.Show("Product hasn't been added");


                    this.TableView();
                    this.ClearAll();
                }
                else
                {
                    MessageBox.Show("There is a similar Product.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error \n" + exc.Message);
            }

        }
        private void ClearAll()
        {
            this.txtCodeAdd.Clear();
            this.txtNameAdd.Clear();
            this.txtPriceAdd.Clear();
            this.txtQuantityAdd.Clear();
        }

        private void dgvProductInfAddTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtCodeAdd.Text = this.dgvProductInfAddTable.CurrentRow.Cells[0].Value.ToString();
            this.txtNameAdd.Text = this.dgvProductInfAddTable.CurrentRow.Cells[1].Value.ToString();
            this.txtPriceAdd.Text = this.dgvProductInfAddTable.CurrentRow.Cells[2].Value.ToString();
            this.txtQuantityAdd.Text = this.dgvProductInfAddTable.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToAdd())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var query = "select * from ProductInfoTable where Code = '" + this.txtCodeAdd.Text + "';";
                var dt = this.FDS.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    var sql = @"update ProductInfoTable
                                set Name = '" + this.txtNameAdd.Text + @"',
                                Price = " + this.txtPriceAdd.Text + @",                          
                                Quantity = '" + this.txtQuantityAdd.Text + @"'
                                where Code = '" + this.txtCodeAdd.Text + "'; ";
                    int count = this.FDS.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Product has been updated properly");
                    else
                        MessageBox.Show("Product hasn't been updated properly");
                }
                else
                {
                    MessageBox.Show("Product Not Found ");
                }

                this.TableView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private void txtCodeAdd_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from ProductInfoTable where Code like '" + this.txtCodeAdd.Text + "%';";
            this.TableView(sql);
        }
    }
}
