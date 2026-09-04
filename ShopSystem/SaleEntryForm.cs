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

        private void btnBackfromSE_Click(object sender, EventArgs e)
        {
           
            this.Visible = false;
        }

        private void SaleEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void SaleEntryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string pcodesearch = txtPcodeSaleEntrySearch.Text;
            string pcode = txtPcodeShow.Text;
            string pname = txtPnameShow.Text;
            string pprice = txtPpriceShow.Text;
            string pquantity = txtPquantityShow.Text;

            try
            {
                if (string.IsNullOrEmpty(pcodesearch))
                {
                    MessageBox.Show("Please enter a product code to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    lblDetails.Visible = true;
                    lblcode.Visible = true;
                    lblName.Visible = true;
                    lblPrice.Visible = true;
                    lblQuantitu.Visible = true;
                    txtPcodeShow.Visible = true;
                    txtPnameShow.Visible = true;
                    txtPpriceShow.Visible = true;
                    txtPquantityShow.Visible = true; 



                    SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=TestDatabase;Integrated Security=True;Encrypt=False");

                    con.Open();

                    string query = $"Select Productcode,Productname, Price, Quantity From Product Where Productcode = '{pcodesearch}'";

                    SqlCommand cmd = new SqlCommand(query, con);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        this.txtPcodeShow.Text = reader["Productcode"].ToString();
                        this.txtPnameShow.Text = reader["Productname"].ToString();
                        this.txtPpriceShow.Text = reader["Price"].ToString();
                        this.txtPquantityShow.Text = reader["Quantity"].ToString();


                    }
                    else
                    {
                        MessageBox.Show("Product code not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        this.txtPcodeShow.Clear();
                        this.txtPnameShow.Clear();
                        this.txtPpriceShow.Clear();
                        this.txtPquantityShow.Clear();


                    }

                    reader.Close();
                    con.Close();


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while searching for product: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
