using Microsoft.VisualBasic.ApplicationServices;
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
        Users user;
        Favourite favourite;
        ProductsService products;
        DataTable UserData;
        public UserView(DataTable userData)
        {
            user = new Users(ConfigurationManager.ConnectionStrings["Shopping"].ConnectionString);
            favourite = new Favourite(ConfigurationManager.ConnectionStrings["Shopping"].ConnectionString);
            InitializeComponent();
            products = new ProductsService(ConfigurationManager.ConnectionStrings["Shopping"].ConnectionString);
            UserData = userData;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int id;
        private void UserView_Load(object sender, EventArgs e)
        {
            DataRow userRow = UserData.Rows[0];
            id = Convert.ToInt32(userRow["UserId"]);
            DataTable dt = products.getAllProducts(id);
            DataTable d2 = products.ProductDataFavoriteExist(id);
            dgv_products.DataSource = dt;
            dgv_favourite.DataSource = d2;

            //if (dgv_favourite.Columns.Count == 0)
            //{
            //    dgv_favourite.Columns.Add("ID", "ID");
            //    dgv_favourite.Columns.Add("Name", "Name");
            //    dgv_favourite.Columns.Add("Price", "Price");
            //}


        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int rowsAffected = favourite.addFav(selectedProductId, id);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Product added to favorites!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserView_Load(null, null);
            }
            else
            {
                MessageBox.Show("Failed to add product to favorites.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private int selectedProductId;

        private void dgv_products_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_Add.Show();
                DataGridViewRow selectedRow = dgv_products.Rows[e.RowIndex];
                selectedProductId = Convert.ToInt32(selectedRow.Cells["ProductId"].Value);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to remove this product from favorites?",
        "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                int rowsAffected = favourite.deleteFav(selectedProductId, id);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product removed from favorites!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserView_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Failed to remove product from favorites. It may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv_favourite_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dgv_favourite.Rows[e.RowIndex];
                    selectedProductId = Convert.ToInt32(selectedRow.Cells["ProductId"].Value);

                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_oldpass.Text) ||
             string.IsNullOrWhiteSpace(txt_newpass.Text) ||
             string.IsNullOrWhiteSpace(txt_confirm.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_newpass.Text != txt_confirm.Text)
            {
                MessageBox.Show("New Password and Confirm Password do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataRow userRow = UserData.Rows[0];
            int id = Convert.ToInt32(userRow["UserId"]);

            string userName = userRow["Username"].ToString();
            string oldPassword = txt_oldpass.Text;
            string newPassword = txt_newpass.Text;
            string confirmPassword = txt_confirm.Text;

            if (!user.authenticateUser(userName, oldPassword))
            {
                MessageBox.Show("Old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int rowsAffected = user.UpdateUserPassword(id, userName, newPassword);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearInputs();
            }
            else
            {
                MessageBox.Show("Failed to update password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearInputs()
        {
            txt_oldpass.Clear();
            txt_newpass.Clear();
            txt_confirm.Clear();
        }
    }
}
