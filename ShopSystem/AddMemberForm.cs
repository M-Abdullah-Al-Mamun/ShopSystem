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
    public partial class AddMemberForm : Form
    {
        private ForDatabaseShortcutClass FDS { get; set; }
        public AddMemberForm()
        {
            InitializeComponent();
            this.FDS=new ForDatabaseShortcutClass();
            this.TableView();
        }

        private void TableView(string sql="Select * from LoginTable;")
        {
            DataSet ds = this.FDS.ExecuteQuery(sql);

            this.dgvMemberInfo.AutoGenerateColumns = false;
            this.dgvMemberInfo.DataSource = ds.Tables[0];
        }

        private bool IsValidToAdd()
        {
            if (string.IsNullOrEmpty(this.txtId.Text) || string.IsNullOrEmpty(this.txtName.Text) ||
                string.IsNullOrEmpty(this.txtPassword.Text) || string.IsNullOrEmpty(this.txtRole.Text))
                return false;
            else
                return true;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToAdd())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var query = "select * from LoginTable where Id = '" + this.txtId.Text + "';";
                var dt = this.FDS.ExecuteQueryTable(query);
                
                if (dt.Rows.Count == 0)
                {
                    var sql = "insert into LoginTable values('" + this.txtId.Text + "', '" +this.txtName.Text + "', '" + this.txtPassword.Text + "', '" + this.txtRole.Text + "')";
                    int count = this.FDS.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("New data Added");
                    else
                        MessageBox.Show("Data hasn't been added");
                    
                    
                   this.TableView();
                   this.ClearAll();
                }
                else 
                {
                    MessageBox.Show("There is a similar value.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error \n"+exc.Message);
            }
        }

        private void dgvMemberInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            this.txtId.Text = this.dgvMemberInfo.CurrentRow.Cells[0].Value.ToString();
            this.txtName.Text = this.dgvMemberInfo.CurrentRow.Cells[1].Value.ToString();
            this.txtPassword.Text = this.dgvMemberInfo.CurrentRow.Cells[2].Value.ToString();
            this.txtRole.Text = this.dgvMemberInfo.CurrentRow.Cells[3].Value.ToString();
        }

        private void ClearAll()
        {
            this.txtId.Clear();
            this.txtName.Clear();
            this.txtPassword.Clear();
            this.txtRole.Clear();
        }

        private void AddMemberForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm ad = new AdminForm();
            ad.Show();
            this.Visible = false;
        }
    }
}
