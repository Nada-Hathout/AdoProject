using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopping.Presentation.Admin
{
    public partial class AdminDash : Form
    {
        DataTable UserData;
        public AdminDash(DataTable userData)
        {
            InitializeComponent();
            UserData = userData;
        }

        private void AdminDash_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageProduct_Admin admin = new ManageProduct_Admin(UserData);
            this.Hide();
            admin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageGategory category = new ManageGategory(UserData);
            this.Hide();
            category.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageUsers user = new ManageUsers(UserData);
            this.Hide();
            user.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminEditProfile adminEditProfile = new AdminEditProfile(UserData); 
            adminEditProfile.Show();
            this.Hide();
        }
    }
}
