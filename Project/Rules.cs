using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Project
{
    /// <summary>Checks shared by the registration forms.</summary>
    internal static class Rules
    {
        /// <summary>Shows a warning, puts the cursor in the offending field and returns false.</summary>
        public static bool Warn(string message, Control focus)
        {
            MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (focus != null)
            {
                focus.Focus();
                TextBoxBase box = focus as TextBoxBase;
                if (box != null) { box.SelectAll(); }
            }
            return false;
        }

        public static bool EmailFormat(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public static bool PersonalEmail(string email)
        {
            string[] domains = { "@gmail.com", "@yahoo.com", "@outlook.com", "@hotmail.com" };
            foreach (string d in domains)
            {
                if (email.EndsWith(d, StringComparison.OrdinalIgnoreCase)) { return true; }
            }
            return false;
        }

        /// <summary>Returns an error message, or null when the address is fine.</summary>
        public static string Address(string address)
        {
            if (string.IsNullOrWhiteSpace(address)) { return "Please enter the physical address."; }
            if (Regex.IsMatch(address, @"\b\d{4}\b")) { return "Please enter the physical address ONLY. Do not include a 4-digit postal code in this field."; }
            return null;
        }

        public static bool PostalCode(string code)
        {
            return Regex.IsMatch(code.Trim(), @"^\d{4}$");
        }

        /// <summary>Returns an error message, or null when the password is acceptable and matches.</summary>
        public static string Password(string create, string confirm)
        {
            if (string.IsNullOrWhiteSpace(create)) { return "Password cannot be empty."; }
            if (create.Length < 8) { return "Password must be at least 8 characters long."; }
            if (!create.Any(char.IsUpper)) { return "Password must contain at least one uppercase letter."; }
            if (!create.Any(char.IsLower)) { return "Password must contain at least one lowercase letter."; }
            if (!create.Any(char.IsDigit)) { return "Password must contain at least one number."; }
            if (!create.Any(ch => !char.IsLetterOrDigit(ch))) { return "Password must contain at least one special character."; }
            if (create != confirm) { return "Passwords do not match."; }
            return null;
        }

        /// <summary>
        /// Everything the Organization and Apply forms have in common. Returns true when all
        /// fields are valid; otherwise a message has been shown and the right field focused.
        /// </summary>
        public static bool OrganizationFields(TextBox name, TextBox npo, TextBox email, string documentPath,
                                              ComboBox province, TextBox code, TextBox address,
                                              TextBox create, TextBox confirm)
        {
            if (string.IsNullOrWhiteSpace(name.Text)) { return Warn("Please enter the organization name.", name); }

            if (!Regex.IsMatch(npo.Text, @"^\d{3}-\d{3}$"))
            {
                return Warn("Invalid NPO Registration Number.\nPlease use the format: 000-000 (e.g., 123-456).", npo);
            }

            if (!EmailFormat(email.Text))
            {
                return Warn("Invalid email format.\nPlease enter a valid organisation email (e.g., info@organisation.org).", email);
            }
            if (PersonalEmail(email.Text))
            {
                return Warn("Please provide an official organisation email address rather than a personal account.", email);
            }
            if (DataStore.EmailTaken(email.Text))
            {
                return Warn("An account with this email address already exists. Please log in instead.", email);
            }

            if (string.IsNullOrEmpty(documentPath) || !System.IO.File.Exists(documentPath))
            {
                return Warn("Please attach your proof of legal entity (PDF, DOCX, JPG or PNG).", null);
            }

            if (province.SelectedIndex < 0) { return Warn("Please select a province.", province); }
            if (!PostalCode(code.Text)) { return Warn("Please enter a valid 4-digit postal code.", code); }

            string addr = Address(address.Text);
            if (addr != null) { return Warn(addr, address); }

            string pw = Password(create.Text, confirm.Text);
            if (pw != null) { return Warn(pw, create); }

            return true;
        }
    }
}
