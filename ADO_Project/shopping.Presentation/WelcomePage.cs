using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopping.Presentation
{
    public partial class WelcomePage : Form
    {

        public WelcomePage()
        {
            InitializeComponent();

        }

        private void WelcomePage_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.Show();
            //this.Show();


        }

        internal static Form ActiveForm()
        {
            throw new NotImplementedException();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Registeration registeration=new Registeration();
            registeration.Show();
            this.Close();
        }
    }
}
