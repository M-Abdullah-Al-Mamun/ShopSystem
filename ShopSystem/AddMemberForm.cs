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
                    var sql = "insert into LoginTable values('" + this.txtId.Text + "', '" + this.txtName.Text + "', " + this.txtPassword.Text + ", " + this.txtRole.Text + ")";
                    int count = this.FDS.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been added properly");
                    else
                        MessageBox.Show("Data hasn't been added properly");
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

     }
}
