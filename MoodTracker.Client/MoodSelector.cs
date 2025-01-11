namespace MoodTracker.Client
{
    using System.Drawing.Drawing2D;
    using System.Numerics;

    public class MoodSelector : Control
    {
        private List<Mood> _moods;
        private RectangleF _text;
        private RectangleF _circle;
        private RectangleF _handle;
        private RectangleF _image;
        private Vector2 _mouse;
        private Vector2 _direction;
        private bool _isDragging;

        public List<Mood> Moods
        {
            get => _moods;
            set
            {
                _moods = value;
                Invalidate();
            }
        }

        public Mood? CurrentMood { get; private set; }

        public MoodSelector()
        {
            MinimumSize = new Size(300, 300);
            DoubleBuffered = true;
            _moods = new();
            _direction = new Vector2(1, 0);
        }

        protected override void OnResize(EventArgs e)
        {
            Invalidate();
            base.OnResize(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (_handle.Contains(e.X, e.Y) == true)
                _isDragging = true;
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            _isDragging = false;
            base.OnMouseUp(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (_isDragging == true)
            {
                _mouse = new Vector2(e.X, e.Y);
                Invalidate();
            }
            base.OnMouseMove(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            CalculateRects();
            PaintRects(e.Graphics);
            base.OnPaint(e);
        }

        private void CalculateRects()
        {
            var rectMin = MathF.Min(Width, Height);
            var rectPadding = rectMin / 7f;
            var rectSize = new SizeF(rectMin, rectMin);
            var rectPoint = new PointF(Width / 2f - rectMin / 2f, Height / 2f - rectMin / 2f);

            var textSize = new SizeF(rectSize.Width * 0.9f - rectPadding, rectSize.Height * 0.1f);
            var textPoint = new PointF(rectPoint.X + rectSize.Width / 2f - textSize.Width / 2f, rectPoint.Y);
            var circleSize = new SizeF(rectSize.Width * 0.9f - rectPadding, rectSize.Height * 0.9f - rectPadding);
            var circlePoint = new PointF(rectPoint.X + rectSize.Width / 2f - circleSize.Width / 2f, textPoint.Y + textSize.Height + rectPadding / 2f);

            var imageSize = new SizeF(circleSize.Width / 1.5f, circleSize.Height / 1.5f);
            var imagePoint = new PointF(circlePoint.X + circleSize.Width / 2f - imageSize.Width / 2f, circlePoint.Y + circleSize.Height / 2f - imageSize.Height / 2f);

            if (_isDragging == true)
                _direction = Vector2.Normalize(_mouse - (circlePoint + circleSize / 2f).ToVector2());
            var handleDirection = circlePoint.ToVector2() + circleSize.ToVector2() / 2f + _direction * circleSize.Width / 2f;
            var handleSize = new SizeF(circleSize.Width / 7f, circleSize.Height / 7f);
            var handlePoint = new PointF(handleDirection.X - handleSize.Width / 2f, handleDirection.Y - handleSize.Height / 2f);

            _circle = new RectangleF(circlePoint, circleSize);
            _text = new RectangleF(textPoint, textSize);
            _handle = new RectangleF(handlePoint, handleSize);
            _image = new RectangleF(imagePoint, imageSize);
        }

        private void PaintRects(Graphics graphics)
        {
            if (_moods.Count == 0)
                return;

            CurrentMood = CalculateMood();

            using var backFill = new SolidBrush(Color.Black);
            graphics.FillEllipse(backFill, _circle);

            var length = 360 / _moods.Count;
            using var circleOutline = new Pen(Color.Black, _circle.Height / 10f);
            using var circleFill = new Pen(Color.Black, _circle.Height / 14f);
            graphics.DrawEllipse(circleOutline, _circle);
            for (int i = 0; i < _moods.Count; i++)
            {
                circleFill.Color = _moods[i].Color;
                graphics.DrawArc(circleFill, _circle, i * length, length);
            }

            using var handleOutline = new Pen(Color.Black, _handle.Height / 5f);
            using var handleFill = new SolidBrush(Color.White);
            graphics.DrawEllipse(handleOutline, _handle);
            graphics.FillEllipse(handleFill, _handle);

            if (CurrentMood.Image != null)
                graphics.DrawImage(CurrentMood.Image, _image);

            using var textFont = new Font(Font.Name, _text.Height / 1.5f, FontStyle.Bold);
            using var textFill = new SolidBrush(ForeColor);
            using var textFormat = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            graphics.DrawString(CurrentMood.Type.ToString(), textFont, textFill, _text, textFormat);
        }

        private Mood CalculateMood()
        {
            if (_moods.Count == 0)
                throw new InvalidOperationException();

            var degrees = MathF.Acos(_direction.X) * 180 / MathF.PI;
            if (float.IsNegative(_direction.Y))
                degrees = 360 - degrees;

            var length = 360 / _moods.Count;
            for (int i = _moods.Count - 1; i >= 0; i--)
            {
                if (degrees >= i * length)
                    return _moods[i];
            }

            throw new InvalidOperationException();
        }
    }
}