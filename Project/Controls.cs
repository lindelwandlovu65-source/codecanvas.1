using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Project
{
    /// <summary>
    /// Custom controls used by the designer-built pages. After a build they appear in the
    /// Visual Studio toolbox under "Project Components" and can be dragged onto any form.
    /// </summary>

    /// <summary>Text box with grey placeholder text. Set the Hint property in the Properties window.</summary>
    public class HintBox : TextBox
    {
        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);

        private string _hint = "";

        [Category("Appearance"), Description("Grey placeholder text shown while the box is empty.")]
        public string Hint
        {
            get { return _hint; }
            set { _hint = value ?? ""; ApplyHint(); }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            ApplyHint();
        }

        private void ApplyHint()
        {
            if (IsHandleCreated)
            {
                SendMessage(Handle, EM_SETCUEBANNER, (IntPtr)1, _hint);
            }
        }
    }

    /// <summary>White card with a hairline border and an optional coloured strip along the top.</summary>
    public class CardPanel : Panel
    {
        private Color _accent = Color.Empty;

        public CardPanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = Color.White;
        }

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

    /// <summary>
    /// Panel that paints an image so it fills the area without stretching (cropped from the centre),
    /// with a tint so white cards and text stand out.
    /// </summary>
    public class CoverPanel : Panel
    {
        private Image _image;
        private Bitmap _cache;
        private Color _tint = Color.FromArgb(70, 15, 35, 55);

        public CoverPanel()
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }

        [Category("Appearance"), Description("Background photo.")]
        public Image Cover
        {
            get { return _image; }
            set { _image = value; DropCache(); Invalidate(); }
        }

        [Category("Appearance"), Description("Colour (with transparency) laid over the photo.")]
        public Color Tint
        {
            get { return _tint; }
            set { _tint = value; DropCache(); Invalidate(); }
        }

        private void DropCache()
        {
            if (_cache != null)
            {
                _cache.Dispose();
                _cache = null;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_image == null || Width <= 0 || Height <= 0)
            {
                base.OnPaint(e);
                return;
            }
            if (_cache == null || _cache.Width != Width || _cache.Height != Height)
            {
                DropCache();
                _cache = new Bitmap(Width, Height);
                using (Graphics g = Graphics.FromImage(_cache))
                {
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    float scale = Math.Max((float)Width / _image.Width, (float)Height / _image.Height);
                    float w = _image.Width * scale;
                    float h = _image.Height * scale;
                    g.DrawImage(_image, (Width - w) / 2f, (Height - h) / 2f, w, h);
                    using (SolidBrush b = new SolidBrush(_tint))
                    {
                        g.FillRectangle(b, 0, 0, Width, Height);
                    }
                }
            }
            e.Graphics.DrawImageUnscaled(_cache, 0, 0);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) { DropCache(); }
            base.Dispose(disposing);
        }
    }

    /// <summary>Filled orange circle with a number in it.</summary>
    public class NumberBadge : Control
    {
        private string _number = "1";

        public NumberBadge()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            Size = new Size(42, 42);
            BackColor = Color.White;
            Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
        }

        [Category("Appearance"), DefaultValue("1")]
        public string Number
        {
            get { return _number; }
            set { _number = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush b = new SolidBrush(Color.FromArgb(230, 126, 34)))
            {
                e.Graphics.FillEllipse(b, 0, 0, Width - 1, Height - 1);
            }
            TextRenderer.DrawText(e.Graphics, _number, Font, ClientRectangle, Color.White,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine);
        }
    }

    /// <summary>Scrolling page. Call EnableWheel() so the mouse wheel scrolls it wherever the pointer is.</summary>
    public class ScrollPage : Panel
    {
        public ScrollPage()
        {
            SetStyle(ControlStyles.Selectable, true);
            DoubleBuffered = true;
        }

        public void EnableWheel()
        {
            Hook(this);
        }

        private void Hook(Control c)
        {
            c.MouseEnter += delegate { Focus(); };
            foreach (Control child in c.Controls)
            {
                Hook(child);
            }
        }
    }
}
