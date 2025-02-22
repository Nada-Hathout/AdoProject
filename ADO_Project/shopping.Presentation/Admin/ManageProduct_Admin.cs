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
        DataTable UserData;
        ProductsService Products;
        categorieService Category;
        public ManageProduct_Admin(DataTable userData)
        {
            InitializeComponent();
            Products = new ProductsService(ConfigurationManager.ConnectionStrings["Shopping"].ConnectionString);
            Category = new categorieService(ConfigurationManager.ConnectionStrings["Shopping"].ConnectionString);
            UserData = userData;
        }

        /////// insert
        private void button1_Click(object sender, EventArgs e)
        {
            int rowAffected = Products.AddProduct(txt_name.Text, Convert.ToDecimal(txt_price.Text), (int)cb_category.SelectedValue);
            if (rowAffected > 0)
            {
                showData();
                clearInputs();
                MessageBox.Show("Successfully Added ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("faild to add");
            }
        }
        //load data
        public void showData()
        {
            DataTable products = Products.dgv_Product();
            dgv_Editproducts.DataSource = products;
           

        }
        /////// page load 
        private void ManageProduct_Admin_Load(object sender, EventArgs e)
        {
            DataTable products = Products.dgv_Product();
            dgv_Editproducts.DataSource = products;

            DataTable categoryId = Category.getCategories();
            cb_category.DataSource = categoryId;
            cb_category.DisplayMember = "CategoryName";
            cb_category.ValueMember = "CategoryId";


        }
        /////// Row mouse double click
        int id;
        private void dgv_Editproducts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_Editproducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                cb_category.SelectedValue = selectedRow.Cells["CategoryId"].Value.ToString();
               
            }
            else
            {
                MessageBox.Show("Invalid selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            button1.Hide();
            button2.Show();
            button3.Show();
        }


        /////// Update
        private void button3_Click(object sender, EventArgs e)
        {
            if (Validate())

            {
                if (dgv_Editproducts.SelectedRows.Count > 0)
                {
                    string new_name = txt_name.Text;
                    var new_price = Convert.ToDecimal(txt_price.Text);
                    int new_cat = (int)cb_category.SelectedValue;
                    int id = Convert.ToInt32(dgv_Editproducts.SelectedRows[0].Cells["ProductID"].Value);
                    int rowAffected = Products.UpdateProduct(new_name, new_price, new_cat, id);
                    if (rowAffected > 0)
                    {
                        showData();
                        clearInputs();
                        button1.Show();
                        MessageBox.Show("Successfully updated ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("faild to Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void dgv_Editproducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public bool validateInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_name.Text))
            {
                MessageBox.Show("Product Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Convert.ToInt64(txt_price.Text) < 0)
            {
                MessageBox.Show("Price must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cb_category.SelectedValue == null)
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        /////// Delete
        private void button2_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                int id = Convert.ToInt32(dgv_Editproducts.SelectedRows[0].Cells["ProductID"].Value);
                int affectedRows = Products.DeleteProduct(id);
                if (affectedRows > 0)
                {
                    showData();
                    clearInputs();
                    button1.Show();
                    MessageBox.Show("Successfully Deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("faild to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Please select a product to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminDash adminDash = new AdminDash(UserData);
            this.Hide();
            adminDash.Show();
        }

        public void clearInputs()
        {
            txt_name.Text = "";
            txt_price.Text = "";
            cb_category.SelectedItem = null;
        }
    }
}
