using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var sql = "select * from LoginTable where Name='"+this.txtUsername.Text+"'and Password='"+this.txtPassword.Text+"';";
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-9IP21J0\SQLEXPRESS;Initial Catalog=c#ProjectDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sql,sqlcon);
            SqlDataAdapter sda=new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1) 
            {
                this.Visible = false;
                MessageBox.Show("Login Successful");
                var name = ds.Tables[0].Rows[0][1].ToString();
                if (ds.Tables[0].Rows[0][3].ToString() == "Admin")
                {
                    new AdminForm(name, this).Show();
                }
                else if (ds.Tables[0].Rows[0][3].ToString() == "Manager")
                {
                    //.................................
                }
                else if (ds.Tables[0].Rows[0][3].ToString() == "Sales Man")
                {
                    //.................................
                }
                           
            }
            else
            {
                MessageBox.Show("Invalid user");
                this.txtUsername.Clear();
                this.txtPassword.Clear();
            }
            sqlcon.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
