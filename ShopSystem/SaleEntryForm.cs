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

            string search = this.txtPcodeSaleEntrySearch.Text;

            try
            {
               if (!string.IsNullOrEmpty(search))
                {

                    ForDatabaseShortcutClass db = new ForDatabaseShortcutClass();

                    DataTable dt = db.ExecuteQueryTable($"SELECT * FROM ProductInfoTable WHERE Code = '{search}'");

                    if (dt.Rows.Count > 0)
                    {
                        //lblDetails.Show();
                        lblcode.Show();
                        lblName.Show();
                        lblPrice.Show();
                        lblQuantity.Show();
                        txtPcodeShow.Show();
                        txtPnameShow.Show();
                        txtPpriceShow.Show();
                        txtPquantityShow.Show();

                        txtPcodeShow.Text = dt.Rows[0]["Code"].ToString();
                        txtPnameShow.Text = dt.Rows[0]["Name"].ToString();
                        txtPpriceShow.Text = dt.Rows[0]["Price"].ToString();
                        txtPquantityShow.Text = dt.Rows[0]["Quantity"].ToString();

                        btnAdd.Enabled = true;
                        txtAddedQuantity.Enabled = true;
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
                MessageBox.Show("Error :\n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string inputQuantity = this.txtAddedQuantity.Text;
            string availableQuantity = this.txtPquantityShow.Text;

            try
            {
                if (!string.IsNullOrEmpty(inputQuantity))
                {
                    if (Convert.ToDecimal(inputQuantity) > Convert.ToDecimal(availableQuantity))
                    {
                        MessageBox.Show("Not enough quantity available in stock.", "Invalid ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        //Creating a new row and adding it to the DataGridView

                        string productCode = this.txtPcodeShow.Text;
                        string productName = this.txtPnameShow.Text;
                        decimal price = Convert.ToDecimal(txtPpriceShow.Text);
                        decimal quantity = Convert.ToDecimal(txtAddedQuantity.Text);
                        string totalPrice = (price * quantity).ToString();

                        gridSaleEntry.Rows.Add(productCode, productName, price,quantity,totalPrice);


                        //Adding the Grand total from all the rows-


                        decimal grandTotal = 0;

                        foreach (DataGridViewRow row in gridSaleEntry.Rows)
                        {
                            if (row.Cells[4].Value != null)
                            {
                                grandTotal += Convert.ToDecimal(row.Cells[4].Value);
                            }
                        }

                        this.txtGrandTotal.Text = grandTotal.ToString();


                        //Adding the total Quantity sold for the SaleSummaryForm from all the rows-


                        decimal totalQuantitySold = 0;

                        foreach (DataGridViewRow row in gridSaleEntry.Rows)
                        {
                            if (row.Cells[3].Value != null)
                            {
                                totalQuantitySold += Convert.ToDecimal(row.Cells[3].Value);
                            }
                        }

                        txtTotalQuantitySold.Text = totalQuantitySold.ToString();



                        this.lblGrandTotal.Show();
                        this.txtGrandTotal.Show();

                        this.txtAddedQuantity.Text = "";
                        this.txtPcodeSaleEntrySearch.Clear();

                        this.btnAdd.Enabled = false;
                        this.txtAddedQuantity.Enabled = false;
                    }

                }
                else
                {
                    MessageBox.Show("Please enter a quantity to add to the list.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            

            catch (Exception ex)
            {
                MessageBox.Show("Error :\n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAddedQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
         
            try
            {
                ForDatabaseShortcutClass db = new ForDatabaseShortcutClass();

                foreach (DataGridViewRow row in gridSaleEntry.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        string productCode = row.Cells[0].Value.ToString();
                        decimal quantitySold = Convert.ToDecimal(row.Cells[3].Value);

                        db.ExecuteDMLQuery($"Update ProductInfoTable Set Quantity = Quantity - {quantitySold} Where Code = '{productCode}'");
                    }
                }


                try
                {
                    Random random = new Random();

                    int id = random.Next(1000, 9999);



                    string TotalQuantitysAddtoDb = txtTotalQuantitySold.Text;

                    string Query = $"Insert into SaleSummaryTable (SalesId, SalesDateandTime, SalesQuantity, TotalSalesAmount) VALUES ({id}, GETDATE(),'{TotalQuantitysAddtoDb}','{txtGrandTotal.Text}')";

                    ForDatabaseShortcutClass dbinsert = new ForDatabaseShortcutClass();

                    dbinsert.ExecuteDMLQuery(Query);

                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while inserting into SaleSummaryTable:\n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                this.gridSaleEntry.Rows.Clear();
                this.txtPcodeSaleEntrySearch.Clear();
                this.txtAddedQuantity.Text = "";

                this.lblGrandTotal.Hide();
                this.lblcode.Hide();
                this.lblQuantity.Hide();
                this.lblPrice.Hide();
                this.lblName.Hide();
                //this.lblDetails.Hide();

                this.txtGrandTotal.Hide();
                this.txtPcodeShow.Hide();
                this.txtPnameShow.Hide();
                this.txtPquantityShow.Hide();
                this.txtPpriceShow.Hide();
                this.txtDiscount.Hide();
                this.txtTotalAfterDiscount.Hide();

               
                double payment = Convert.ToDouble(txtPayment.Text);
                double bill = Convert.ToDouble(txtTotalAfterDiscount.Text);          
                if (payment < bill)
                {
                    MessageBox.Show("Payment is not enough!");
                }
                else
                {
                    MessageBox.Show("Produt Salled Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtGrandTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(txtGrandTotal.Text);
            double dicount=Convert.ToDouble(txtDiscount.Text);

            double billTotal = total - dicount;

            txtTotalAfterDiscount.Text= billTotal.ToString();
        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            double payment = Convert.ToDouble(txtPayment.Text);
            double bill = Convert.ToDouble(txtTotalAfterDiscount.Text);

            double exchange = payment - bill;

            txtExchange.Text = exchange.ToString();
        }
    }
}