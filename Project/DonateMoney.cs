using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project
{
    /// <summary>
    /// Money donations. No card details are collected and nothing is charged here: the donor records a
    /// pledge, receives a reference, pays by EFT, and an admin marks the pledge as received.
    /// Layout: DonateMoney.Designer.cs.
    /// </summary>
    public partial class DonateMoney : PageForm
    {
        private readonly Form _parent;
        private readonly RadioButton[] _presets;
        private bool _busy;

        public DonateMoney(Form parent)
        {
            _parent = parent;
            InitializeComponent();
            _presets = new RadioButton[] { rdoPreset50, rdoPreset100, rdoPreset250, rdoPreset500, rdoPreset1000 };
            RefreshData();
            this.VisibleChanged += delegate { if (this.Visible) { RefreshData(); } };
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GoTo(_parent);
        }

        // Clicking a quick amount types it into the amount box
        private void rdoPreset_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            if (_busy || !r.Checked) { return; }
            txtAmount.Text = (string)r.Tag;
        }

        // Typing an amount that matches a quick amount highlights that button
        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            int typed;
            bool ok = int.TryParse(txtAmount.Text.Trim(), out typed);
            _busy = true;
            foreach (RadioButton r in _presets)
            {
                r.Checked = ok && typed.ToString() == (string)r.Tag;
            }
            _busy = false;
        }

        private void btnPledge_Click(object sender, EventArgs e)
        {
            int amount;
            if (!Dash.PositiveInt(txtAmount.Text, 1000000, out amount) || amount < 10)
            {
                Rules.Warn("Please enter an amount of at least R10, in whole rand (for example 250).", txtAmount);
                return;
            }
            if (cmbFrequency.SelectedIndex < 0) { Rules.Warn("Please choose how often you would like to give.", cmbFrequency); return; }

            string reference = "FDS-" + DateTime.Now.ToString("yyyyMMdd") + "-" + new Random().Next(1000, 10000);

            try
            {
                // email, date, amount, frequency, note, reference, status
                DataStore.Append(DataStore.Money, Session.Email, DateTime.Now.ToString("yyyy-MM-dd"),
                                 amount.ToString(), cmbFrequency.Text, txtNote.Text, reference, "Pledged");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save your pledge: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Thank you! Your pledge of " + Dash.Rand(amount) + " has been recorded."
                            + Environment.NewLine + Environment.NewLine
                            + "Please pay by EFT using the reference " + reference + "."
                            + Environment.NewLine
                            + "Your pledge will show as Received once our team confirms the payment.",
                            "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtAmount.Clear();
            txtNote.Clear();
            cmbFrequency.SelectedIndex = 0;
            RefreshData();
        }

        /// <summary>Reloads the stat cards, reference and list from Money.txt.</summary>
        private void RefreshData()
        {
            // email, date, amount, frequency, note, reference, status
            List<string[]> mine = Dash.MyRows(DataStore.Money, 7);

            long pledged = 0;
            long received = 0;
            foreach (string[] r in mine)
            {
                int a;
                if (!int.TryParse(r[2], out a)) { continue; }
                pledged += a;
                if (r[6] == "Received") { received += a; }
            }

            statPledged.Value = Dash.Rand(pledged);
            statReceived.Value = Dash.Rand(received);
            statCount.Value = mine.Count.ToString();
            lblValReference.Text = mine.Count > 0 ? mine[0][5] : "Pledge first to get one";

            List<string[]> shown = new List<string[]>();
            for (int i = 0; i < mine.Count && i < 8; i++)
            {
                string[] r = mine[i];
                int a;
                string amount = int.TryParse(r[2], out a) ? Dash.Rand(a) : r[2];
                shown.Add(new string[] { Dash.ShortDate(r[1]), amount, r[5], r[6] });
            }
            Dash.ShowRows(lvContributions, lblEmpty, shown);
        }
    }
}
