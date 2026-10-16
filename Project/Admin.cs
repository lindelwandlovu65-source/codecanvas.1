using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    /// <summary>
    /// Admin console: review food requests, confirm food and money donations, and look at accounts.
    /// Statuses are written back to the same text files the donor and applicant pages read.
    /// Layout: Admin.Designer.cs. Only the list columns change per section, so those are set here.
    /// </summary>
    public partial class Admin : PageForm
    {
        // Per section: "button text|value". For the status sections the value is the new status; "doc" opens the proof document.
        private static readonly string[][] TabActions =
        {
            new string[] { "Approve|Approved", "Decline|Declined", "Mark fulfilled|Fulfilled" },
            new string[] { "Mark received|Received" },
            new string[] { "Mark received|Received", "Back to pledged|Pledged" },
            new string[] { "Open document|doc" }
        };

        private readonly Button[] _act;
        private int _tab;

        public Admin()
        {
            InitializeComponent();
            _act = new Button[] { btnAction1, btnAction2, btnAction3 };
            SwitchTab(0);
            RefreshStats();
            this.VisibleChanged += delegate { if (this.Visible) { RefreshAll(); } };
        }

        private void rdoTab_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            if (r.Checked) { SwitchTab(int.Parse((string)r.Tag)); }
        }

        private void lvRecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void SwitchTab(int t)
        {
            _tab = t;
            for (int j = 0; j < _act.Length; j++)
            {
                bool used = j < TabActions[t].Length;
                _act[j].Visible = used;
                if (used)
                {
                    string[] parts = TabActions[t][j].Split('|');
                    _act[j].Text = parts[0];
                    _act[j].Tag = parts[1];
                }
            }
            LoadTab();
            UpdateButtons();
        }

        private void RefreshAll()
        {
            LoadTab();
            UpdateButtons();
            RefreshStats();
        }

        // ------------------------------------------------------------ lists

        private void SetColumns(string[] names, int[] widths)
        {
            lvRecords.Columns.Clear();
            for (int i = 0; i < names.Length; i++)
            {
                lvRecords.Columns.Add(names[i], widths[i]);
            }
        }

        private void AddRow(object tag, params string[] cells)
        {
            ListViewItem item = new ListViewItem(cells[0]);
            for (int i = 1; i < cells.Length; i++)
            {
                item.SubItems.Add(cells[i]);
            }
            item.Tag = tag;
            lvRecords.Items.Add(item);
        }

        private static string Money(string text)
        {
            int a;
            return int.TryParse(text, out a) ? Dash.Rand(a) : text;
        }

        private void LoadTab()
        {
            Dictionary<string, string> names = DataStore.NamesByEmail();
            Func<string, string> who = delegate (string mail)
            {
                string n;
                return names.TryGetValue(mail.ToLowerInvariant(), out n) ? n : mail;
            };

            lvRecords.Items.Clear();

            if (_tab == 0)
            {
                // email, date, category, item, quantity, people, urgency, collection, status
                SetColumns(new string[] { "Date", "Organization", "Item", "Qty", "People", "Urgency", "Receive", "Status" },
                           new int[] { 100, 210, 210, 60, 70, 130, 140, 100 });
                List<string[]> rows = DataStore.Read(DataStore.Requests);
                for (int i = rows.Count - 1; i >= 0; i--)
                {
                    string[] r = rows[i];
                    if (r.Length < 9) { continue; }
                    AddRow(i, Dash.ShortDate(r[1]), who(r[0]), r[3], r[4], r[5], r[6], r[7], r[8]);
                }
            }
            else if (_tab == 1)
            {
                // email, date, category, item, quantity, best before, handover, address, status
                SetColumns(new string[] { "Date", "Donor", "Category", "Item", "Qty", "Handover", "Status" },
                           new int[] { 100, 220, 150, 230, 60, 170, 100 });
                List<string[]> rows = DataStore.Read(DataStore.Donations);
                for (int i = rows.Count - 1; i >= 0; i--)
                {
                    string[] r = rows[i];
                    if (r.Length < 9) { continue; }
                    AddRow(i, Dash.ShortDate(r[1]), who(r[0]), r[2], r[3], r[4], r[6], r[8]);
                }
            }
            else if (_tab == 2)
            {
                // email, date, amount, frequency, note, reference, status
                SetColumns(new string[] { "Date", "Donor", "Amount", "Frequency", "Reference", "Message", "Status" },
                           new int[] { 100, 230, 100, 100, 190, 210, 90 });
                List<string[]> rows = DataStore.Read(DataStore.Money);
                for (int i = rows.Count - 1; i >= 0; i--)
                {
                    string[] r = rows[i];
                    if (r.Length < 7) { continue; }
                    AddRow(i, Dash.ShortDate(r[1]), who(r[0]), Money(r[2]), r[3], r[5], r[4], r[6]);
                }
            }
            else
            {
                SetColumns(new string[] { "Type", "Name", "Email", "Province", "Document" },
                           new int[] { 120, 260, 280, 150, 220 });
                List<string[]> rows = DataStore.Read(DataStore.Accounts);
                for (int i = rows.Count - 1; i >= 0; i--)
                {
                    string[] r = rows[i];
                    string email = DataStore.EmailOf(r);
                    if (email == null || r[0] == "Admin") { continue; }

                    string type = r[0] == "Apply" ? "Applicant" : r[0];
                    string province = r[0] == "Individual" ? (r.Length > 7 ? r[7] : "") : (r.Length > 4 ? r[4] : "");
                    string doc = (r[0] != "Individual" && r.Length > 8) ? r[8] : "";
                    AddRow(doc, type, DataStore.NameOf(r), email, province, doc.Length > 0 ? Path.GetFileName(doc) : "-");
                }
            }

            bool any = lvRecords.Items.Count > 0;
            lvRecords.Visible = any;
            lblEmpty.Visible = !any;
        }

        private void RefreshStats()
        {
            int accounts = 0;
            foreach (string[] r in DataStore.Read(DataStore.Accounts))
            {
                if (DataStore.EmailOf(r) != null && r[0] != "Admin") { accounts++; }
            }

            int openReq = 0;
            foreach (string[] r in DataStore.Read(DataStore.Requests))
            {
                if (r.Length >= 9 && r[8] == "Pending") { openReq++; }
            }

            int pendDon = 0;
            foreach (string[] r in DataStore.Read(DataStore.Donations))
            {
                if (r.Length >= 9 && r[8] == "Pending") { pendDon++; }
            }

            long received = 0;
            foreach (string[] r in DataStore.Read(DataStore.Money))
            {
                int a;
                if (r.Length >= 7 && r[6] == "Received" && int.TryParse(r[2], out a)) { received += a; }
            }

            statAccounts.Value = accounts.ToString();
            statOpenRequests.Value = openReq.ToString();
            statPendingDonations.Value = pendDon.ToString();
            statMoney.Value = Dash.Rand(received);
        }

        // ------------------------------------------------------------ actions

        private void UpdateButtons()
        {
            bool selected = lvRecords.SelectedItems.Count > 0;
            bool can = selected;
            if (_tab == 3 && selected)
            {
                string doc = lvRecords.SelectedItems[0].Tag as string;
                can = !string.IsNullOrEmpty(doc);
            }

            foreach (Button a in _act) { a.Enabled = can; }

            if (!selected) { lblHint.Text = "Select a row to enable the actions."; }
            else if (!can) { lblHint.Text = "Individual donors have no document to open."; }
            else { lblHint.Text = ""; }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            string value = (string)((Button)sender).Tag;
            if (lvRecords.SelectedItems.Count == 0) { return; }
            ListViewItem item = lvRecords.SelectedItems[0];

            if (_tab == 3)
            {
                OpenDocument(item.Tag as string);
                return;
            }

            string file = _tab == 0 ? DataStore.Requests : (_tab == 1 ? DataStore.Donations : DataStore.Money);
            int statusColumn = _tab == 2 ? 6 : 8;

            try
            {
                DataStore.SetColumn(file, (int)item.Tag, statusColumn, value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not update the record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RefreshAll();
        }

        private void OpenDocument(string path)
        {
            if (string.IsNullOrEmpty(path) || !File.Exists(path))
            {
                MessageBox.Show("The document could not be found on this computer.", "Notification");
                return;
            }

            // Only open files the app itself saved.
            string folder = Path.GetFullPath(DataStore.DocumentFolder);
            if (!Path.GetFullPath(path).StartsWith(folder, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("That file is outside the SavedDocuments folder, so it will not be opened.", "Notification");
                return;
            }

            try
            {
                System.Diagnostics.Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open the document: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
