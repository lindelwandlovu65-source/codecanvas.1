using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Project
{
    public partial class Apply : PageForm
    {
        private string selectedFilePath = "";

        public Apply()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e) { GoTo(new frmHome()); }
        private void btnLogin_Click(object sender, EventArgs e) { GoTo(new LoginPage()); }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Select Legal Proof Document";
                dialog.Filter = "Supported Documents (*.pdf;*.docx;*.jpg;*.png)|*.pdf;*.docx;*.jpg;*.png|All Files (*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = dialog.FileName;
                    txtBrowse.Text = Path.GetFileName(dialog.FileName);
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!Rules.OrganizationFields(txtName, txtRegNum, txtEmail, selectedFilePath,
                                          cmbProvince, txtCode, txtAdress, txtCreate, txtConfirm))
            {
                return;
            }

            try
            {
                string savedDoc = DataStore.SaveDocument(selectedFilePath, txtRegNum.Text);

                // type, name, email, npo number, province, password, address, postal code, document
                DataStore.Append(DataStore.Accounts, "Apply", txtName.Text, txtEmail.Text, txtRegNum.Text,
                                 cmbProvince.Text, txtCreate.Text, txtAdress.Text, txtCode.Text.Trim(), savedDoc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save your application: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Session.Start("Apply", txtName.Text.Trim(), txtEmail.Text.Trim());
            MessageBox.Show("Application submitted and account registered successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GoTo(new Application());
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
