using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Project
{
    public partial class Individual : PageForm
    {
        public Individual()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e) { GoTo(new frmHome()); }
        private void btnLogin_Click(object sender, EventArgs e) { GoTo(new LoginPage()); }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            string firstName = txtName.Text.Trim();
            string lastName = txtSurname.Text.Trim();
            string number = txtNum.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (firstName.Length == 0) { Rules.Warn("Please enter your first name.", txtName); return; }
            if (lastName.Length == 0) { Rules.Warn("Please enter your last name.", txtSurname); return; }

            // South African mobile number: 0 + 6/7/8 + 8 more digits = 10 digits
            if (number == "") { Rules.Warn("Please enter your cellphone number.", txtNum); return; }
            if (!Regex.IsMatch(number, @"^0[678]\d{8}$"))
            {
                Rules.Warn("Please enter a valid 10-digit South African mobile number.\n\nExample: 0821234567", txtNum);
                return;
            }

            if (!Rules.EmailFormat(email)) { Rules.Warn("Please enter a valid email address (e.g., name@email.com).", txtEmail); return; }
            if (DataStore.EmailTaken(email)) { Rules.Warn("An account with this email address already exists. Please log in instead.", txtEmail); return; }

            string gender = rdnMale.Checked ? "Male" : (rdnFemale.Checked ? "Female" : "");
            if (gender == "") { Rules.Warn("Please select your gender.", null); return; }

            if (cmbProvince.SelectedIndex < 0) { Rules.Warn("Please select a province.", cmbProvince); return; }
            if (!Rules.PostalCode(txtCode.Text)) { Rules.Warn("Please enter a valid 4-digit postal code.", txtCode); return; }

            string addressError = Rules.Address(txtAdress.Text);
            if (addressError != null) { Rules.Warn(addressError, txtAdress); return; }

            string passwordError = Rules.Password(txtCreate.Text, txtConfirm.Text);
            if (passwordError != null) { Rules.Warn(passwordError, txtCreate); return; }

            try
            {
                // Individual, first, last, cell, email, gender, dob, province, address, postal, password, confirm
                DataStore.Append(DataStore.Accounts, "Individual", firstName, lastName, number, email, gender,
                                 dtpDOB.Value.ToString("dd/MM/yyyy"), cmbProvince.Text, txtAdress.Text,
                                 txtCode.Text.Trim(), txtCreate.Text, txtConfirm.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save your account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Session.Start("Individual", firstName, email);
            MessageBox.Show("Account registered successfully.", "Notification");
            GoTo(new Donor());
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            bool ok = txtNum.Text.Length == 0 || Regex.IsMatch(txtNum.Text, @"^\d+$");
            errorProvider1.SetError(txtNum, ok ? "" : "Numbers only are allowed.");
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            bool ok = txtCode.Text.Length == 0 || Regex.IsMatch(txtCode.Text, @"^\d+$");
            errorProvider1.SetError(txtCode, ok ? "" : "Numbers only are allowed.");
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            bool same = txtCreate.Text != "" && txtConfirm.Text == txtCreate.Text;
            errorProvider1.SetError(txtConfirm, same ? "" : "Password does not match!!");
        }
    }
}
