using System;
using System.Collections.Generic;
using System.IO;

namespace Project
{
    /// <summary>Who is logged in right now. Set by login / registration, read by the dashboards.</summary>
    internal static class Session
    {
        public static string Type = "";   // "Individual", "Organization" or "Apply"
        public static string Name = "";   // first name for individuals, organization name otherwise
        public static string Email = "";

        public static void Start(string type, string name, string email)
        {
            Type = type;
            Name = name;
            Email = email;
        }

        public static void End()
        {
            Type = "";
            Name = "";
            Email = "";
        }

        public static string DisplayName
        {
            get { return string.IsNullOrWhiteSpace(Name) ? "friend" : Name; }
        }

        public static string RoleLabel
        {
            get
            {
                if (Type == "Organization") { return "Organization donor"; }
                if (Type == "Apply") { return "Applicant"; }
                if (Type == "Admin") { return "Administrator"; }
                return "Individual donor";
            }
        }
    }

    /// <summary>
    /// Tab-separated text files on the Desktop. One place to change if the storage moves
    /// (for example to a database later).
    ///
    /// Application.txt  (accounts)
    ///   Individual:        Individual, first, last, cell, email, gender, dob, province, address, postal, password, confirm
    ///   Organization/Apply: type, name, email, npo number, province, password, address, postal, document path
    /// Donations.txt: email, date, category, item, quantity, best before, handover, address, status
    /// Requests.txt:  email, date, category, item, quantity, people, urgency, collection, status
    /// Money.txt:     email, date, amount (whole rand), frequency, note, reference, status
    /// Admin account: Admin, name, email, (blank), (blank), password   (same password column as organizations)
    /// </summary>
    internal static class DataStore
    {
        private static string Desktop
        {
            get { return Environment.GetFolderPath(Environment.SpecialFolder.Desktop); }
        }

        public static string Accounts { get { return Path.Combine(Desktop, "Application.txt"); } }
        public static string Donations { get { return Path.Combine(Desktop, "Donations.txt"); } }
        public static string Requests { get { return Path.Combine(Desktop, "Requests.txt"); } }
        public static string Money { get { return Path.Combine(Desktop, "Money.txt"); } }
        public static string DocumentFolder { get { return Path.Combine(Desktop, "SavedDocuments"); } }

        /// <summary>Tabs and line breaks would break the file format, so flatten them.</summary>
        private static string Clean(string s)
        {
            if (s == null) { return ""; }
            return s.Replace('\t', ' ').Replace('\r', ' ').Replace('\n', ' ').Trim();
        }

        public static void Append(string file, params string[] fields)
        {
            string[] clean = new string[fields.Length];
            for (int i = 0; i < fields.Length; i++)
            {
                clean[i] = Clean(fields[i]);
            }
            File.AppendAllText(file, string.Join("\t", clean) + Environment.NewLine);
        }

        /// <summary>All rows of a file, split into columns. Returns an empty list if the file does not exist yet.</summary>
        public static List<string[]> Read(string file)
        {
            List<string[]> rows = new List<string[]>();
            if (!File.Exists(file)) { return rows; }
            foreach (string line in File.ReadAllLines(file))
            {
                if (line.Trim().Length == 0) { continue; }
                rows.Add(line.Split('\t'));
            }
            return rows;
        }

        /// <summary>Email address stored on an account row (it is also the login username).</summary>
        public static string EmailOf(string[] row)
        {
            if (row.Length > 4 && row[0] == "Individual") { return row[4]; }
            if (row.Length > 2 && (row[0] == "Organization" || row[0] == "Apply" || row[0] == "Admin")) { return row[2]; }
            return null;
        }

        public static bool EmailTaken(string email)
        {
            foreach (string[] row in Read(Accounts))
            {
                string e = EmailOf(row);
                if (e != null && string.Equals(e, email.Trim(), StringComparison.OrdinalIgnoreCase)) { return true; }
            }
            return false;
        }

        /// <summary>Returns the matching account row, or null when the username/password pair is wrong.</summary>
        public static string[] FindAccount(string username, string password)
        {
            foreach (string[] row in Read(Accounts))
            {
                string e = EmailOf(row);
                if (e == null) { continue; }

                int pwCol = (row[0] == "Individual") ? 10 : 5;
                if (row.Length <= pwCol) { continue; }

                if (string.Equals(e, username.Trim(), StringComparison.OrdinalIgnoreCase) && row[pwCol] == password)
                {
                    return row;
                }
            }
            return null;
        }

        /// <summary>Name to show for an account row (first + last for individuals).</summary>
        public static string NameOf(string[] row)
        {
            if (row[0] == "Individual" && row.Length > 2) { return (row[1] + " " + row[2]).Trim(); }
            return row.Length > 1 ? row[1] : "";
        }

        /// <summary>Lower-cased email -> display name, so the admin lists can show names instead of emails.</summary>
        public static Dictionary<string, string> NamesByEmail()
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            foreach (string[] row in Read(Accounts))
            {
                string e = EmailOf(row);
                if (e != null) { map[e.ToLowerInvariant()] = NameOf(row); }
            }
            return map;
        }

        /// <summary>
        /// Changes one column of one row (rowIndex counts the same rows Read() returns).
        /// Used by the admin to move a request or donation to a new status.
        /// </summary>
        public static void SetColumn(string file, int rowIndex, int column, string value)
        {
            List<string> lines = new List<string>();
            foreach (string line in File.ReadAllLines(file))
            {
                if (line.Trim().Length > 0) { lines.Add(line); }
            }
            if (rowIndex < 0 || rowIndex >= lines.Count) { throw new InvalidOperationException("That record no longer exists."); }

            string[] cols = lines[rowIndex].Split('\t');
            if (column >= cols.Length) { throw new InvalidOperationException("That record is in an unexpected format."); }

            cols[column] = Clean(value);
            lines[rowIndex] = string.Join("\t", cols);
            File.WriteAllLines(file, lines.ToArray());
        }

        // The first admin. Change these in Application.txt (the row that starts with "Admin") before real use.
        public const string DefaultAdminEmail = "admin@fooddonation.local";
        public const string DefaultAdminPassword = "Admin@123";

        /// <summary>Creates the admin account the first time the app runs.</summary>
        public static void EnsureAdmin()
        {
            try
            {
                foreach (string[] row in Read(Accounts))
                {
                    if (row.Length > 0 && row[0] == "Admin") { return; }
                }
                Append(Accounts, "Admin", "Admin", DefaultAdminEmail, "", "", DefaultAdminPassword);
            }
            catch
            {
                // If the Desktop is not writable there is simply no admin; everything else still works.
            }
        }

        /// <summary>Copies the proof document into SavedDocuments and returns the new path.</summary>
        public static string SaveDocument(string sourcePath, string npoNumber)
        {
            if (!Directory.Exists(DocumentFolder)) { Directory.CreateDirectory(DocumentFolder); }
            string name = "NPO_" + npoNumber.Replace("-", "") + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + Path.GetExtension(sourcePath);
            string target = Path.Combine(DocumentFolder, name);
            File.Copy(sourcePath, target, true);
            return target;
        }
    }
}
