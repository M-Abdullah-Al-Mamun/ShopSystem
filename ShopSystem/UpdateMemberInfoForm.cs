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
    public partial class UpdateMemberInfoForm : Form
    {
        private ForDatabaseShortcutClass FDS { get; set; }

        public UpdateMemberInfoForm()
        {
            InitializeComponent();
            this.FDS = new ForDatabaseShortcutClass();
            this.TableView();
        }
        private void TableView(string sql = "Select * from LoginTable;")
        {
            DataSet ds = this.FDS.ExecuteQuery(sql);

            this.dgvMemberInfo.AutoGenerateColumns = false;
            this.dgvMemberInfo.DataSource = ds.Tables[0];
        }
        private bool IsValidToUpdate()
        {
            if (string.IsNullOrEmpty(this.txtId.Text) || string.IsNullOrEmpty(this.txtName.Text) ||
                string.IsNullOrEmpty(this.txtPassword.Text) || string.IsNullOrEmpty(this.txtRole.Text))
                return false;
            else
                return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToUpdate())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var query = "select * from LoginTable where Id = '" + this.txtId.Text + "';";
                var dt = this.FDS.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    var sql = @"update LoginTable
                                set Name = '" + this.txtName.Text + @"',
                                Password = " + this.txtPassword.Text + @",                          
                                Role = '" + this.txtRole.Text + @"'
                                where Id = '" + this.txtId.Text + "'; ";
                    int count = this.FDS.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated properly");
                    else
                        MessageBox.Show("Data hasn't been updated properly");
                }
                else
                {
                    MessageBox.Show("Member Not Found ");
                }

                this.TableView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }


        }

        private void ClearAll()
        {
            this.txtName.Clear();
            this.txtPassword.Clear();
            this.txtRole.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm ad = new AdminForm();
            ad.Show();
            this.Visible = false;
        }

        private void UpdateMemberInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvMemberInfo.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to remove Member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult res = MessageBox.Show("Are you sure to remove the Member?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    return;

                var id = this.dgvMemberInfo.CurrentRow.Cells[0].Value.ToString();
                var title = this.dgvMemberInfo.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from LoginTable where Id = '" + id + "';";
                var count = this.FDS.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(title.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("Data hasn't been removed properly");

                this.TableView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from LoginTable where Id like '" + this.txtId.Text + "%';";
            this.TableView(sql);
        }

        private void dgvMemberInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            this.txtId.Text = this.dgvMemberInfo.CurrentRow.Cells[0].Value.ToString();
            this.txtName.Text = this.dgvMemberInfo.CurrentRow.Cells[1].Value.ToString();
            this.txtPassword.Text = this.dgvMemberInfo.CurrentRow.Cells[2].Value.ToString();
            this.txtRole.Text = this.dgvMemberInfo.CurrentRow.Cells[3].Value.ToString();
        }
    }

}
