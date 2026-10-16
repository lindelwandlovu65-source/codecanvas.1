using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Project
{
    /// <summary>Navy panel on the left of the sign-in and registration cards.</summary>
    public partial class BrandPanel : UserControl
    {
        public BrandPanel()
        {
            InitializeComponent();
            lblCopyright.Text = "\u00A9 " + DateTime.Now.Year + " Food Donation System";
        }

        [Category("Brand")] public string Headline { get { return lblHeadline.Text; } set { lblHeadline.Text = value; } }
        [Category("Brand")] public string Bullet1 { get { return lblBullet1.Text; } set { lblBullet1.Text = value; } }
        [Category("Brand")] public string Bullet2 { get { return lblBullet2.Text; } set { lblBullet2.Text = value; } }
        [Category("Brand")] public string Bullet3 { get { return lblBullet3.Text; } set { lblBullet3.Text = value; } }
    }
}
