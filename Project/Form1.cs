using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    /// <summary>Home page. The layout is in Form1.Designer.cs; open Form1.cs in the designer to edit it.</summary>
    public partial class frmHome : PageForm
    {
        public frmHome()
        {
            InitializeComponent();
            lblCopyright.Text = "\u00A9 " + DateTime.Now.Year + " Food Donation System. All rights reserved.";
            pnlPage.EnableWheel();
            this.Shown += delegate { pnlPage.Focus(); };
        }

        private void btnLogin_Click(object sender, EventArgs e) { GoTo(new LoginPage()); }
        private void btnApply_Click(object sender, EventArgs e) { GoTo(new Apply()); }
        private void btnIndividual_Click(object sender, EventArgs e) { GoTo(new Individual()); }
        private void btnOrganization_Click(object sender, EventArgs e) { GoTo(new Organization()); }

        // "Donate now" reveals the "I'm donating as" choice
        private void btnNow_Click(object sender, EventArgs e)
        {
            pnlType.Visible = true;
            pnlPage.AutoScrollPosition = new Point(0, 0);
        }

        // Every nav / footer link carries its target in its Tag
        private void lnkNav_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switch ((string)((Control)sender).Tag)
            {
                case "top": ScrollTo(null); break;
                case "how": ScrollTo(pnlHow); break;
                case "needed": ScrollTo(pnlNeeded); break;
                case "involved": ScrollTo(pnlInvolved); break;
                case "contact": ScrollTo(pnlFooter); break;
            }
        }

        private void ScrollTo(Control section)
        {
            int y = 0;
            if (section != null)
            {
                // Top is relative to what is on screen now, so add the scroll offset back.
                y = section.Top - pnlPage.AutoScrollPosition.Y;
            }
            pnlPage.AutoScrollPosition = new Point(0, y);
        }
    }
}
