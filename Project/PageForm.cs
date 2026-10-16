using System;
using System.Windows.Forms;

namespace Project
{
    /// <summary>
    /// Base class for every page. Pages are hidden (not closed) when you move to another page,
    /// so a real close means the user quit and the whole app should end.
    /// </summary>
    public class PageForm : Form
    {
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            System.Windows.Forms.Application.Exit();
        }

        /// <summary>Hides this page and shows another one.</summary>
        protected void GoTo(Form next)
        {
            this.Hide();
            next.Show();
        }
    }
}
