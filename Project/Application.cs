using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project
{
    /// <summary>Dashboard for organizations that applied to receive food. Layout: Application.Designer.cs.</summary>
    public partial class Application : PageForm
    {
        public Application()
        {
            InitializeComponent();
            lblWelcome.Text = "Welcome, " + Session.DisplayName;
            lblBeforeText.Text = "Keep your proof of registration up to date. We will contact you at " + Session.Email + " once a request is reviewed.";
            RefreshData();
            this.VisibleChanged += delegate { if (this.Visible) { RefreshData(); } };
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex < 0) { Rules.Warn("Please choose a food category.", cmbCategory); return; }

            int qty;
            if (!Dash.PositiveInt(txtQty.Text, 100000, out qty))
            {
                Rules.Warn("Please enter the quantity as a whole number, for example 50.", txtQty);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtItem.Text)) { Rules.Warn("Please describe the items you need.", txtItem); return; }

            int people;
            if (!Dash.PositiveInt(txtPeople.Text, 1000000, out people))
            {
                Rules.Warn("Please enter how many people will be fed, as a whole number.", txtPeople);
                return;
            }

            if (cmbUrgency.SelectedIndex < 0) { Rules.Warn("Please choose how soon you need the food.", cmbUrgency); return; }
            if (cmbReceive.SelectedIndex < 0) { Rules.Warn("Please choose how you would like to receive the food.", cmbReceive); return; }

            try
            {
                // email, date, category, item, quantity, people, urgency, collection, status
                DataStore.Append(DataStore.Requests, Session.Email, DateTime.Now.ToString("yyyy-MM-dd"),
                                 cmbCategory.Text, txtItem.Text, qty.ToString(), people.ToString(),
                                 cmbUrgency.Text, cmbReceive.Text, "Pending");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save your request: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Your request has been submitted for review.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
            RefreshData();
        }

        private void ClearForm()
        {
            cmbCategory.SelectedIndex = -1;
            cmbUrgency.SelectedIndex = -1;
            cmbReceive.SelectedIndex = -1;
            txtQty.Clear();
            txtItem.Clear();
            txtPeople.Clear();
            cmbCategory.Focus();
        }

        /// <summary>Reloads the stat cards and the recent list from Requests.txt.</summary>
        private void RefreshData()
        {
            // email, date, category, item, quantity, people, urgency, collection, status
            List<string[]> mine = Dash.MyRows(DataStore.Requests, 9);

            int pending = 0;
            int people = 0;
            foreach (string[] r in mine)
            {
                if (r[8] == "Pending") { pending++; }
                int p;
                if (int.TryParse(r[5], out p)) { people += p; }
            }

            statRequests.Value = mine.Count.ToString();
            statPending.Value = pending.ToString();
            statPeople.Value = people.ToString("N0");

            List<string[]> shown = new List<string[]>();
            for (int i = 0; i < mine.Count && i < 8; i++)
            {
                string[] r = mine[i];
                shown.Add(new string[] { Dash.ShortDate(r[1]), r[3], r[5], r[8] });
            }
            Dash.ShowRows(lvRequests, lblEmpty, shown);
        }
    }
}
