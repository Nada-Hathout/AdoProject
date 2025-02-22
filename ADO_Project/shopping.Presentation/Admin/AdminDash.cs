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
        public AdminDash()
        {
            InitializeComponent();
        }

        private void AdminDash_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageProduct_Admin admin = new ManageProduct_Admin();
            this.Hide();
            admin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageGategory category = new ManageGategory();
            this.Hide();
            category.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageUsers user = new ManageUsers();
            this.Hide();
            user.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
