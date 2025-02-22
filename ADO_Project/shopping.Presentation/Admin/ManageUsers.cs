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

namespace shopping.Presentation.Admin
{
    public partial class ManageUsers : Form
    {
        Users user;
        public ManageUsers()
        {
            InitializeComponent();
            user = new Users(ConfigurationManager.ConnectionStrings["Shopping"].ConnectionString);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {

            showData();

        }

        public void showData()
        {
            DataTable users = user.getAllUsers();
            dgv_users.DataSource = users;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminDash adminDash = new AdminDash();
            this.Hide();
            adminDash.Show();
        }
        public bool validateInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_name.Text))
            {
                MessageBox.Show("Product Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Convert.ToInt64(txt_email.Text) < 0)
            {
                MessageBox.Show("Price must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (Convert.ToInt64(txt_pass.Text) < 0)
            {
                MessageBox.Show("Price must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (Convert.ToInt64(txt_address.Text) < 0)
            {
                MessageBox.Show("Price must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (Convert.ToInt64(num_age.Value) < 0)
            {
                MessageBox.Show("Price must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cb_role.SelectedValue == null)
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                string username = txt_name.Text;
                string pass = txt_pass.Text;
                string address = txt_address.Text;
                string email = txt_email.Text;
                int age = (int)num_age.Value;
                string role = cb_role.SelectedItem.ToString();

                int rowsAffected = user.AddUser(username, pass, email, age, address, role);

                if (rowsAffected > 0)
                {
                    showData();
                    clearInputs();
                    MessageBox.Show("User Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("faild to Add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Please Fill inputs to Add user.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
        int id;
        private void dgv_users_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (dgv_users.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int rowIndex = dgv_users.SelectedRows[0].Index;
            if (rowIndex >= 0)
            {
                // Get the selected row from DataTable

                DataGridViewRow selectedRow = dgv_users.Rows[e.RowIndex];
                id = Convert.ToInt32(dgv_users.SelectedRows[0].Cells["UserId"].Value);

                txt_name.Text = selectedRow.Cells["Username"].Value.ToString();
                txt_pass.Text = selectedRow.Cells["Password"].Value.ToString();
                txt_email.Text = selectedRow.Cells["Email"].Value.ToString();
                txt_address.Text = selectedRow.Cells["Address"].Value.ToString();
                num_age.Value = (int)selectedRow.Cells["Age"].Value;
                //important
                cb_role.SelectedItem = selectedRow.Cells["Role"].Value;

            }
            else
            {
                MessageBox.Show("Invalid selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btn_add.Hide();
            btn_delete.Show();
            btn_update.Show();

        }

        public void clearInputs()
        {
            txt_name.Text = txt_pass.Text = txt_email.Text = txt_address.Text = "";
            num_age.Value = 0;
            cb_role.SelectedItem = null;

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (Validate())

            {
                if (dgv_users.SelectedRows.Count > 0)
                {
                    string new_name = txt_name.Text;
                    string pass = txt_pass.Text;
                    string email = txt_email.Text;
                    string address = txt_address.Text;
                    int age = (int)num_age.Value;
                    string role = Convert.ToString(cb_role.SelectedItem);


                    int rowAffected = user.UpdateUser(new_name, pass, email, age, address, role, id);
                    if (rowAffected > 0)
                    {
                        showData();
                        clearInputs();
                        btn_add.Show();
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
                MessageBox.Show("Please select a user to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_users.SelectedRows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    int rowAffected = user.DeleteUser(id);
                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Successfully Deleted ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        showData();
                        clearInputs();
                        btn_add.Show();


                    }
                    else
                    {
                        MessageBox.Show("Failed to delete user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }


            }
            else
            {
                MessageBox.Show("please select a user to delete. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
