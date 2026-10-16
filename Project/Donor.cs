using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project
{
    /// <summary>Dashboard for individual and organization donors. Layout: Donor.Designer.cs.</summary>
    public partial class Donor : PageForm
    {
        private DonateMoney _money;

        public Donor()
        {
            InitializeComponent();
            lblWelcome.Text = "Welcome back, " + Session.DisplayName;
            dtpBest.MinDate = DateTime.Today;
            dtpBest.Value = DateTime.Today.AddDays(7);
            RefreshData();
            this.VisibleChanged += delegate { if (this.Visible) { RefreshData(); } };
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            if (_money == null || _money.IsDisposed) { _money = new DonateMoney(this); }
            GoTo(_money);
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
                Rules.Warn("Please enter the quantity as a whole number, for example 20.", txtQty);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtItem.Text)) { Rules.Warn("Please describe the item you are donating.", txtItem); return; }
            if (cmbHandover.SelectedIndex < 0) { Rules.Warn("Please choose how the food will reach us.", cmbHandover); return; }

            bool collect = cmbHandover.SelectedIndex == 1;
            if (collect && string.IsNullOrWhiteSpace(txtAddr.Text))
            {
                Rules.Warn("Please enter the address where we should collect the food.", txtAddr);
                return;
            }

            try
            {
                // email, date, category, item, quantity, best before, handover, address, status
                DataStore.Append(DataStore.Donations, Session.Email, DateTime.Now.ToString("yyyy-MM-dd"),
                                 cmbCategory.Text, txtItem.Text, qty.ToString(), dtpBest.Value.ToString("yyyy-MM-dd"),
                                 cmbHandover.Text, collect ? txtAddr.Text : "Drop-off", "Pending");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save your donation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Thank you! Your donation has been recorded.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
            RefreshData();
        }

        private void ClearForm()
        {
            cmbCategory.SelectedIndex = -1;
            cmbHandover.SelectedIndex = -1;
            txtQty.Clear();
            txtItem.Clear();
            txtAddr.Clear();
            dtpBest.Value = DateTime.Today.AddDays(7);
            cmbCategory.Focus();
        }

        /// <summary>Reloads the stat cards and the recent list from the data files.</summary>
        private void RefreshData()
        {
            // email, date, category, item, quantity, best before, handover, address, status
            List<string[]> mine = Dash.MyRows(DataStore.Donations, 9);

            int items = 0;
            foreach (string[] r in mine)
            {
                int q;
                if (int.TryParse(r[4], out q)) { items += q; }
            }

            long pledged = 0;
            foreach (string[] m in Dash.MyRows(DataStore.Money, 7))
            {
                int a;
                if (int.TryParse(m[2], out a)) { pledged += a; }
            }

            statDonations.Value = mine.Count.ToString();
            statItems.Value = items.ToString("N0");
            statMoney.Value = Dash.Rand(pledged);
            statLast.Value = mine.Count > 0 ? Dash.ShortDate(mine[0][1]) : "None yet";

            List<string[]> shown = new List<string[]>();
            for (int i = 0; i < mine.Count && i < 8; i++)
            {
                string[] r = mine[i];
                shown.Add(new string[] { Dash.ShortDate(r[1]), r[3], r[4], r[8] });
            }
            Dash.ShowRows(lvDonations, lblEmpty, shown);
        }
    }
}
