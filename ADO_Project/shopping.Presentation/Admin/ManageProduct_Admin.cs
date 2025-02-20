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

namespace shopping.Presentation.Admin
{
    public partial class ManageProduct_Admin : Form
    {
        ProductsService Products;
        categorieService Category;
        public ManageProduct_Admin()
        {
            InitializeComponent();
            Products = new ProductsService(ConfigurationManager.ConnectionStrings["Shopping"].ConnectionString);
            Category = new categorieService(ConfigurationManager.ConnectionStrings["Shopping"].ConnectionString);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowAffected = Products.AddProduct(txt_name.Text, Convert.ToDecimal(txt_price.Text), (int)cb_category.SelectedValue);
            if (rowAffected > 0)
            {
                DataTable products = Products.getProduct();
                dgv_Editproducts.DataSource = products;
                MessageBox.Show("Successfully Added ");
            }
            else
            {
                MessageBox.Show("faild to add");
            }
        }

        private void ManageProduct_Admin_Load(object sender, EventArgs e)
        {
            DataTable products = Products.getProduct();
            dgv_Editproducts.DataSource = products;

            DataTable categoryId = Category.getCategories();
            cb_category.DataSource = categoryId;
            cb_category.DisplayMember = "CategoryName";
            cb_category.ValueMember = "CategoryId";


        }
        int id;
        private void dgv_Editproducts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_Editproducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.");
                return;
            }

            int rowIndex = dgv_Editproducts.SelectedRows[0].Index;
            if (rowIndex >= 0)
            {
                // Get the selected row from DataTable

                DataGridViewRow selectedRow = dgv_Editproducts.Rows[e.RowIndex];
                id = Convert.ToInt32(dgv_Editproducts.SelectedRows[0].Cells["ProductID"].Value);

                txt_name.Text = selectedRow.Cells["ProductName"].Value.ToString();
                txt_price.Text = selectedRow.Cells["Price"].Value.ToString();
                //cb_cate
            }
            else
            {
                MessageBox.Show("Invalid selection.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (dgv_)
            //{

            //}
        }
    }
}
