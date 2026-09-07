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

namespace ShopSystem
{
    public partial class SaleEntryForm : Form
    {
        public SaleEntryForm()
        {
            InitializeComponent();
        }

        private void SaleEntryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBackfromSE_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string search = txtPcodeSaleEntrySearch.Text;

            try
            {
               if (!string.IsNullOrEmpty(search))
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9IP21J0\SQLEXPRESS;Initial Catalog=c#ProjectDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                    con.Open();
                    var query = $"Select * from ProductInfoTable where Productcode = '{search}'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblDetails.Show();

                        lblcode.Show();
                        lblName.Show();
                        lblPrice.Show();
                        lblQuantity.Show();

                        txtPcodeShow.Show();
                        txtPnameShow.Show();
                        txtPpriceShow.Show();
                        txtPquantityShow.Show();

                        txtPcodeShow.Text = reader["Code"].ToString();
                        txtPnameShow.Text = reader["Name"].ToString();
                        txtPpriceShow.Text = reader["Price"].ToString();
                        txtPquantityShow.Text = reader["Quantity"].ToString();

                       this.btnAdd.Enabled = true;
                       this.txtAddedQuantity.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Product not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }



                }
                else
                {
                    MessageBox.Show("Please enter a product code.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while fetching data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (!string.IsNullOrEmpty(this.txtAddedQuantity.Text))
                {
                    if (Convert.ToDecimal(this.txtAddedQuantity.Text) > Convert.ToDecimal(this.txtPquantityShow.Text))
                    {
                        MessageBox.Show("Not enough quantity available in stock.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    { string quantity = this.txtAddedQuantity.Text;


                        DataGridViewRow newrow = new DataGridViewRow();

                        DataGridViewCell cell1 = new DataGridViewTextBoxCell();
                        cell1.Value = this.txtPcodeShow.Text;
                        newrow.Cells.Add(cell1);
                        DataGridViewCell cell2 = new DataGridViewTextBoxCell();
                        cell2.Value = this.txtPnameShow.Text;
                        newrow.Cells.Add(cell2);
                        DataGridViewCell cell3 = new DataGridViewTextBoxCell();
                        cell3.Value = this.txtPpriceShow.Text;
                        newrow.Cells.Add(cell3);
                        DataGridViewCell cell4 = new DataGridViewTextBoxCell();
                        cell4.Value = this.txtAddedQuantity.Text;
                        newrow.Cells.Add(cell4);
                        DataGridViewCell cell5 = new DataGridViewTextBoxCell();
                        cell5.Value = Convert.ToDecimal(quantity) * Convert.ToDecimal(this.txtPpriceShow.Text);
                        newrow.Cells.Add(cell5);

                        gridSaleEntry.Rows.Add(newrow);


                        this.txtGrandTotal.Text = (from DataGridViewRow row in gridSaleEntry.Rows
                                                   where row.Cells[4].FormattedValue.ToString() != string.Empty
                                                   select Convert.ToDecimal(row.Cells[4].FormattedValue)).Sum().ToString();
                        this.lblGrandTotal.Show();
                        this.txtGrandTotal.Show();

                        this.txtAddedQuantity.Text = "";
                        this.txtPcodeSaleEntrySearch.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("Please enter a quantity to add to the list.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            

            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while adding product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAddedQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPcodeSaleEntrySearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}