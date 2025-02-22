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
    public partial class ManageGategory : Form
    {
        DataTable UserData;
        categorieService category;
        public ManageGategory(DataTable userData)
        {
            InitializeComponent(); ;
            category = new categorieService(ConfigurationManager.ConnectionStrings["Shopping"].ConnectionString);
            UserData = userData;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void ManageGategory_Load(object sender, EventArgs e)
        {
            DataTable categor = category.getCategories();
            dgv_Editcategory.DataSource = categor;

        }

        //double row click
        int id;
        private void dgv_Editcategory_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_Editcategory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int rowIndex = dgv_Editcategory.SelectedRows[0].Index;
            if (rowIndex >= 0)
            {
                // Get the selected row from DataTable

                DataGridViewRow selectedRow = dgv_Editcategory.Rows[e.RowIndex];
                id = Convert.ToInt32(dgv_Editcategory.SelectedRows[0].Cells["CategoryId"].Value);

                txt_name.Text = selectedRow.Cells["CategoryName"].Value.ToString();


            }
            else
            {
                MessageBox.Show("Invalid selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btn_add.Hide();
            btn_delete.Show();
            btn_update.Show();
        }


        //// update
        private void btn_update_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dgv_Editcategory.SelectedRows[0].Cells["CategoryId"].Value);
            string categoryName = txt_name.Text;
            if (string.IsNullOrWhiteSpace(txt_name.Text))
            {
                MessageBox.Show("Category Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            if (dgv_Editcategory.SelectedRows.Count > 0)
            {
                int rowAffected = category.UpdateCategory(categoryName, id);
                if (rowAffected > 0)
                {
                    MessageBox.Show("Successfully Updated ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                    clearInputs();
                    btn_add.Show();
                }
                else
                {
                    MessageBox.Show("faild to Add the product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        //show data
        public void showData()
        {
            DataTable cat = category.getCategories();
            dgv_Editcategory.DataSource = cat;
        }

        public void clearInputs()
        {
            txt_name.Text = "";

        }
        // // insert
        private void btn_add_Click(object sender, EventArgs e)
        {

            string categoryName = txt_name.Text;
            if (string.IsNullOrWhiteSpace(txt_name.Text))
            {
                MessageBox.Show("Category Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                int rowAffected = category.AddCategory(categoryName);
                if (rowAffected > 0)
                {
                    showData();
                    clearInputs();
                    btn_add.Show();

                    MessageBox.Show("Successfully Added ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("faild to Add the product");
                }
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_Editcategory.SelectedRows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    int rowAffected = category.DeleteCategory(id);
                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Successfully Deleted ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        showData();
                        clearInputs();
                        btn_add.Show();


                    }
                    else
                    {
                        MessageBox.Show("Failed to delete category. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }


            }
            else
            {
                MessageBox.Show("please select a category to delete. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminDash adminDash = new AdminDash(UserData);
            this.Hide();
            adminDash.Show();
        }
    }
}
