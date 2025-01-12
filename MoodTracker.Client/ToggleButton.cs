namespace MoodTracker.Client
{
    using System.Drawing.Drawing2D;

    public class ToggleButton : CheckBox
    {
        private RectangleF _text;
        private RectangleF _toggle;
        private RectangleF _handle;
        private Color _defaultColor;
        private Color _checkedColor;

        public Color DefaultColor
        {
            get => _defaultColor;
            set
            {
                _defaultColor = value;
                Invalidate();
            }
        }

        public Color CheckedColor
        {
            get => _checkedColor;
            set
            {
                _checkedColor = value;
                Invalidate();
            }
        }

        public override bool AutoSize { get => base.AutoSize; set => base.AutoSize = false; }

        public ToggleButton()
        {
            MinimumSize = new Size(100, 100);
            DoubleBuffered = true;
        }

        protected override void OnResize(EventArgs e)
        {
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if(_handle.Contains(e.Location))
            {
                Checked = !Checked;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.Clear(BackColor);
            CalculateRects();
            PaintRects(e.Graphics);
        }

        private void CalculateRects()
        {
            var targetRatio = 3f;
            var rectRatio = Width / (float)Height;
            var rectSize = new SizeF(Width, Width / targetRatio);
            if (rectRatio > targetRatio)
                rectSize = new SizeF(Height * targetRatio, Height);
            var rectPoint = new PointF(Width / 2f - rectSize.Width / 2f, Height / 2f - rectSize.Height / 2f);

            var padding = rectSize.Width / 30f;
            var textSize = new SizeF(rectSize.Width - padding, rectSize.Height * 0.35f - padding);
            var textPoint = new PointF(rectPoint.X + padding / 2f, rectPoint.Y + padding / 2f);
            var toggleSize = new SizeF(rectSize.Width - padding, rectSize.Height * 0.65f - padding);
            var togglePoint = new PointF(rectPoint.X + padding / 2f, rectPoint.Y + textSize.Height + padding * 1.5f);
            var handleSize = new SizeF(toggleSize.Height, toggleSize.Height);
            var handlePoint = new PointF(togglePoint.X, togglePoint.Y);
            if (Checked == true)
                handlePoint.X = togglePoint.X + toggleSize.Width - toggleSize.Height;

            _text = new RectangleF(textPoint, textSize);
            _toggle = new RectangleF(togglePoint, toggleSize);
            _handle = new RectangleF(handlePoint, handleSize);
        }

        private void PaintRects(Graphics graphics)
        {
            using var textFill = new SolidBrush(ForeColor);
            var font = new Font(Font.FontFamily, _text.Width / 15f, Font.Style);
            var format = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            graphics.DrawString(Text, font, textFill, _text, format);

            var path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(_toggle.Left, _toggle.Top, _toggle.Height, _toggle.Height, 90f, 180f);
            path.AddArc(_toggle.Left + _toggle.Width - _toggle.Height, _toggle.Top, _toggle.Height, _toggle.Height, 270f, 180f);
            path.CloseFigure();

            using var toggleOutline = new Pen(Color.Black, _toggle.Width / 40f);
            using var toggleFill = new SolidBrush(DefaultColor);
            if (Checked == true)
                toggleFill.Color = CheckedColor;
            graphics.DrawPath(toggleOutline, path);
            graphics.FillPath(toggleFill, path);

            using var handleFill = new SolidBrush(Color.White);
            graphics.DrawEllipse(toggleOutline, _handle);
            graphics.FillEllipse(handleFill, _handle);
        }
    }
}