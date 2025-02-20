using shopping.Presentation.Admin;
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

namespace shopping.Presentation
{
    public partial class Login : Form
    {
        Users user;
        public Login()
        {
            InitializeComponent();
            user = new Users(ConfigurationManager.ConnectionStrings["Shopping"].ConnectionString);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();
            welcomePage.Show();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            
            if (string.IsNullOrWhiteSpace(txt_username.Text) ||
                string.IsNullOrWhiteSpace(txt_password.Text))
            {
                MessageBox.Show("Please Fill The Form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            string role = cb_role.SelectedItem?.ToString();
            string user_role = "User";
            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please select a role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
               
                int affectedRow = user.LoginAsUser(txt_username.Text, txt_password.Text);
                if (user.LoginAsUser(txt_username.Text, txt_password.Text)>0) 
                {
                    //MessageBox.Show("", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    ManageGategory manageGategory = new ManageGategory();
                    manageGategory.Show();
                    this.Close();
                    //if (role == user_role)
                    //{
                    //    MessageBox.Show("hi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //    ManageGategory category = new ManageGategory();
                    //    category.Show();
                    //}
                    //else if (role == "Admin")
                    //{
                    //    AdminDash admin = new AdminDash();
                    //    admin.Show();
                    //}

                    //this.Hide(); // Hide the login form only after successful login
                }else if (user.LoginAsAdmin(txt_username.Text, txt_password.Text) > 0)
                {
                    AdminDash adminDash = new AdminDash();
                    adminDash.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
