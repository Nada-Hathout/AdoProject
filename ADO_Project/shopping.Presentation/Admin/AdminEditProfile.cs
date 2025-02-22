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
    public partial class AdminEditProfile : Form
    {
        Users userService;
        DataTable theUser;
        public AdminEditProfile(DataTable user)
        {
            InitializeComponent();
            userService=new Users(ConfigurationManager.ConnectionStrings["Shopping"].ConnectionString);
            theUser = user;
        }

        private void show_pass1_CheckedChanged(object sender, EventArgs e)
        {
            if (show_pass1.Checked)
            {
                txt_oldpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txt_oldpassword.UseSystemPasswordChar = true;
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txt_newPass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_newPass.UseSystemPasswordChar = true;
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_confirmpass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_confirmpass.UseSystemPasswordChar = true;
            }

            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_oldpassword.Text)|| string.IsNullOrWhiteSpace(txt_newPass.Text)|| string.IsNullOrWhiteSpace(txt_confirmpass.Text))
            {
                MessageBox.Show("Please Fill The inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txt_newPass.Text != txt_confirmpass.Text )
            {
                MessageBox.Show("Confirm password Don't match New Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow userRow = theUser.Rows[0];
            int id=Convert.ToInt32(userRow["UserId"]);

            string userName = userRow["Username"].ToString();
            string oldPassword = txt_oldpassword.Text;
            string newPassword = txt_newPass.Text;
            string confirmPassword = txt_confirmpass.Text;

            if (!userService.authenticateAdmin(userName, oldPassword))
            {
                MessageBox.Show("Old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int rowsAffected = userService.UpdatePassword(id, userName, newPassword);

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
        public void clearInputs()
        {
            txt_oldpassword.Text = txt_newPass.Text = txt_confirmpass.Text = "";
        }
    }
}
