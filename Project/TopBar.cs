using System;
using System.Windows.Forms;

namespace Project
{
    /// <summary>Navy bar at the top of every logged-in page: brand, who is signed in, and Log out.</summary>
    public partial class TopBar : UserControl
    {
        public TopBar()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                lblWho.Text = Session.DisplayName + "   \u00B7   " + Session.RoleLabel;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Dash.LogOut(FindForm());
        }
    }
}
