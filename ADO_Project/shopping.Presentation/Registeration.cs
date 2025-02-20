using Microsoft.Data.SqlClient;
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
    public partial class Registeration : Form
    {
        Users user;
        public Registeration()
        {
            InitializeComponent();
            user = new Users(ConfigurationManager.ConnectionStrings["Shopping"].ConnectionString);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_username.Text) ||
                 string.IsNullOrWhiteSpace(txt_password.Text) ||
                 string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Please Fill The Form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                try
                {
                    int rowAffected = user.AddUser(txt_username.Text.Trim(), txt_password.Text.Trim(), txt_email.Text.Trim(), Convert.ToInt16(txt_agee.Value), txt_address.Text, Convert.ToString(cb_role.SelectedItem));
                    if (rowAffected > 0)
                    {

                        MessageBox.Show("Successfully Registered ");
                    }
                    else
                    {
                        MessageBox.Show("faild to Register");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void Registeration_Load(object sender, EventArgs e)
        {
            

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();
            this.Hide();
            welcomePage.Show();
        }
    }
}
