using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    /// <summary>Small white card with a big number and a caption.</summary>
    public partial class StatCard : UserControl
    {
        private Color _accent = Color.Empty;

        public StatCard()
        {
            InitializeComponent();
            DoubleBuffered = true;
            ResizeRedraw = true;
        }

        [Category("Appearance")] public string Value { get { return lblValue.Text; } set { lblValue.Text = value; } }
        [Category("Appearance")] public string Caption { get { return lblCaption.Text; } set { lblCaption.Text = value; } }

        [Category("Appearance"), Description("Colour of the 4px strip along the top edge.")]
        public Color Accent
        {
            get { return _accent; }
            set { _accent = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Pen p = new Pen(Color.FromArgb(222, 227, 232)))
            {
                e.Graphics.DrawRectangle(p, 0, 0, Width - 1, Height - 1);
            }
            if (!_accent.IsEmpty)
            {
                using (SolidBrush b = new SolidBrush(_accent))
                {
                    e.Graphics.FillRectangle(b, 0, 0, Width, 4);
                }
            }
        }
    }
}
