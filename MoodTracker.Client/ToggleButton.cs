namespace MoodTracker.Client
{
    using System.Drawing.Drawing2D;

    public class ToggleButton : Control
    {
        private List<Mood>? _allMoods;
        private Mood? _currentMood;

        private RectangleF _text;
        private RectangleF _toggle;
        private RectangleF _handle;
        private bool _isChecked;

        public event Action<bool>? Checked;

        public ToggleButton()
        {
            MinimumSize = new Size(100, 100);
            DoubleBuffered = true;
        }

        public void Initialize(IEnumerable<Mood> allMoods, MoodType defaultMood)
        {
            _allMoods = allMoods.ToList();
            SetMood(defaultMood);
        }

        public void SetMood(MoodType type)
        {
            if (_allMoods == null)
                return;
            _currentMood = _allMoods.Single(mood => mood.Type == type);
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (_handle.Contains(e.Location) == false)
                return;
            _isChecked = !_isChecked;
            Checked?.Invoke(_isChecked);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_allMoods == null || _currentMood == null)
                return;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.Clear(BackColor);
            CalculateRects();
            PaintRects(e.Graphics, _currentMood.Value);
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
            var textSize = new SizeF(rectSize.Width - padding, rectSize.Height * 0.4f - padding);
            var textPoint = new PointF(rectPoint.X + padding / 2f, rectPoint.Y + padding / 2f);
            var toggleSize = new SizeF(rectSize.Width - padding, rectSize.Height * 0.6f - padding);
            var togglePoint = new PointF(rectPoint.X + padding / 2f, rectPoint.Y + textSize.Height + padding * 1.5f);
            var handleSize = new SizeF(toggleSize.Height, toggleSize.Height);
            var handlePoint = new PointF(togglePoint.X, togglePoint.Y);
            if (_isChecked == true)
                handlePoint.X = togglePoint.X + toggleSize.Width - toggleSize.Height;

            _text = new RectangleF(textPoint, textSize);
            _toggle = new RectangleF(togglePoint, toggleSize);
            _handle = new RectangleF(handlePoint, handleSize);
        }

        private void PaintRects(Graphics graphics, Mood currentMood)
        {
            using var textFill = new SolidBrush(ForeColor);
            var font = new Font(Font.FontFamily, _text.Width / 18f, FontStyle.Bold);
            var format = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            graphics.DrawString(currentMood.Type.ToString(), font, textFill, _text, format);

            var path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(_toggle.Left, _toggle.Top, _toggle.Height, _toggle.Height, 90f, 180f);
            path.AddArc(_toggle.Left + _toggle.Width - _toggle.Height, _toggle.Top, _toggle.Height, _toggle.Height, 270f, 180f);
            path.CloseFigure();

            using var toggleOutline = new Pen(Color.Black, _toggle.Width / 40f);
            using var toggleFill = new SolidBrush(Color.Black);
            if (_isChecked == true)
                toggleFill.Color = currentMood.Color;
            graphics.DrawPath(toggleOutline, path);
            graphics.FillPath(toggleFill, path);

            using var handleFill = new SolidBrush(Color.White);
            graphics.DrawEllipse(toggleOutline, _handle);
            graphics.FillEllipse(handleFill, _handle);
        }
    }
}