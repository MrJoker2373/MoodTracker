namespace MoodTracker.Client
{
    using System.Drawing.Drawing2D;
    using System.Numerics;

    public class MoodSelector : Control
    {
        private List<Mood> _moods;
        private RectangleF _circle;
        private RectangleF _handle;
        private RectangleF _image;
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
            MinimumSize = new Size(200, 200);
            DoubleBuffered = true;
            _moods = new();
            _direction = new Vector2(1, 0);
        }

        protected override void OnResize(EventArgs e)
        {
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (_handle.Contains(e.X, e.Y) == true)
                _isDragging = true;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            _isDragging = false;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (_isDragging == true)
            {
                _direction = Vector2.Normalize(new Vector2(e.X, e.Y) - (_circle.Location + _circle.Size / 2f).ToVector2());
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
            var min = MathF.Min(Width, Height);
            var padding = min / 6f;

            var circleSize = new SizeF(min - padding, min - padding);
            var circlePoint = new PointF(Width / 2f - circleSize.Width / 2f, Height / 2f - circleSize.Height / 2f);
            var imageSize = new SizeF(circleSize.Width / 1.5f, circleSize.Height / 1.5f);
            var imagePoint = new PointF(circlePoint.X + circleSize.Width / 2f - imageSize.Width / 2f, circlePoint.Y + circleSize.Height / 2f - imageSize.Height / 2f);

            var handleDirection = circlePoint.ToVector2() + circleSize.ToVector2() / 2f + _direction * circleSize.Width / 2f;
            var handleSize = new SizeF(circleSize.Width / 7f, circleSize.Height / 7f);
            var handlePoint = new PointF(handleDirection.X - handleSize.Width / 2f, handleDirection.Y - handleSize.Height / 2f);

            _circle = new RectangleF(circlePoint, circleSize);
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