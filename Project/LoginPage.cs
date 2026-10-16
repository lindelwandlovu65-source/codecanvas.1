using System;
using System.Windows.Forms;

namespace Project
{
    public partial class LoginPage : PageForm
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btbCancell_Click(object sender, EventArgs e)
        {
            GoTo(new frmHome());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text;

            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Please enter your username (email) and password.", "Notification");
                return;
            }

            string[] account = DataStore.FindAccount(username, password);
            if (account == null)
            {
                MessageBox.Show("Invalid Username or Password. Please try again.", "Notification");
                txtPass.Clear();
                txtPass.Focus();
                return;
            }

            Session.Start(account[0], account[1], DataStore.EmailOf(account));
            txtUser.Clear();
            txtPass.Clear();

            if (account[0] == "Admin") { GoTo(new Admin()); }
            else if (account[0] == "Apply") { GoTo(new Application()); }
            else { GoTo(new Donor()); }
        }

        // Ticked = show the password in plain text
        private void chkMask_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !chkMask.Checked;
        }
    }
}
