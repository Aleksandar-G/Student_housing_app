using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace TenantApp
{
    public partial class LoginForm : Form
    {
        public User currentUser = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            string email = tbLoginEmail.Text;
            string password = tbLoginPassword.Text;

            if (User.Authenticate(email, password))
            {
                MessageBox.Show("Logged in successfully!");
                currentUser = User.GetUserByEmail(email);
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong credentials!");
            }
        }
    }
}
