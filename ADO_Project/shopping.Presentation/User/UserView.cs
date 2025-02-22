using Shopping.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopping.Presentation.User
{
    public partial class UserView : Form
    {
        ProductsService products;
        public UserView()
        {
            InitializeComponent();
            products = new ProductsService(ConfigurationManager.ConnectionStrings["Shopping"].ConnectionString);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserView_Load(object sender, EventArgs e)
        {
            DataTable dt = products.dgv_Product();
            dgv_products.DataSource = dt;

            if (dgv_favourite.Columns.Count == 0)
            {
                dgv_favourite.Columns.Add("ID", "ID");
                dgv_favourite.Columns.Add("Name", "Name");
                dgv_favourite.Columns.Add("Price", "Price");
            }


        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (dgv_products.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_products.SelectedRows[0];

                foreach (DataGridViewRow row in dgv_favourite.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == selectedRow.Cells[0].Value.ToString())
                    {
                        MessageBox.Show("This Item Already Exist !", "Warning");
                        return;
                    }
                }

                dgv_favourite.Rows.Add(selectedRow.Cells[0].Value, selectedRow.Cells[1].Value, selectedRow.Cells[2].Value);
            }
            else
            {
                MessageBox.Show("Select A Row Please !", "Error");


            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_oldpass.UseSystemPasswordChar = !checkBox1.Checked;
            txt_newpass.UseSystemPasswordChar = !checkBox1.Checked;
            txt_confirm.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
