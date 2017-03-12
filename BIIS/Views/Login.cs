using BIIS.BusinessLogics;
using System;
using System.Windows.Forms;

namespace BIIS
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        private string username;
        private string password;
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtBoxUsername.Text;
            password = txtBoxPassword.Text;

            if (username.Equals("admin") && password.Equals("nepal123"))
            {
                BaseDAL.showDashboard();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Your username or password is Invalid!", "Invalid credintials!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
