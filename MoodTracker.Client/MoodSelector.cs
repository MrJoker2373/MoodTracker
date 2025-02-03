namespace MoodTracker.Client
{
    using System.Drawing.Drawing2D;
    using System.Numerics;

    public class MoodSelector : Control
    {
        private List<Mood>? _allMoods;
        private Mood? _currentMood;
        private Vector2? _direction;

        private RectangleF _circle;
        private RectangleF _handle;
        private RectangleF _image;
        private bool _isDragging;

        public event Action<MoodType>? MoodChanged;

        public MoodSelector()
        {
            MinimumSize = new Size(200, 200);
            DoubleBuffered = true;
        }

        public void Initialize(IEnumerable<Mood> allMoods, MoodType defaultMood)
        {
            _allMoods = allMoods.Where(mood => mood.Type != MoodType.Null).ToList();
            if (defaultMood == MoodType.Null)
                SetDirection(new Vector2(1, 0));
            else
                SetMood(defaultMood);
        }

        public void SetMood(MoodType type)
        {
            if (_allMoods == null || type == MoodType.Null)
                return;
            _currentMood = _allMoods.Single(mood => mood.Type == type);
            MoodChanged?.Invoke(_currentMood.Value.Type);
            var length = 360f / _allMoods.Count;
            var index = _allMoods.IndexOf(_currentMood.Value);
            var degrees = index * length + length / 2f;
            var radians = degrees / 180f * MathF.PI;
            _direction = new Vector2(MathF.Cos(radians), MathF.Sin(radians));
            Invalidate();
        }

        public void SetDirection(Vector2 direction)
        {
            if (_allMoods == null)
                return;
            _direction = Vector2.Normalize(direction);
            var length = 360f / _allMoods.Count;
            var degrees = (MathF.Atan2(_direction.Value.Y, _direction.Value.X) * 180f / MathF.PI + 360f) % 360f;
            var index = (int)MathF.Max(MathF.Ceiling(_allMoods.Count * degrees / 360f) - 1, 0);
            _currentMood = _allMoods[index];
            MoodChanged?.Invoke(_currentMood.Value.Type);
            Invalidate();
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
                SetDirection(new Vector2(e.X, e.Y) - (_circle.Location + _circle.Size / 2f).ToVector2());
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_allMoods == null || _currentMood == null || _direction == null)
                return;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.Clear(BackColor);
            CalculateRects(_direction.Value);
            PaintRects(e.Graphics, _allMoods, _currentMood.Value);
        }

        private void CalculateRects(Vector2 direction)
        {
            var min = MathF.Min(Width, Height);
            var padding = min / 6f;

            var circleSize = new SizeF(min - padding, min - padding);
            var circlePoint = new PointF(Width / 2f - circleSize.Width / 2f, Height / 2f - circleSize.Height / 2f);
            var imageSize = new SizeF(circleSize.Width / 1.5f, circleSize.Height / 1.5f);
            var imagePoint = new PointF(circlePoint.X + circleSize.Width / 2f - imageSize.Width / 2f, circlePoint.Y + circleSize.Height / 2f - imageSize.Height / 2f);

            var handleDirection = circlePoint.ToVector2() + circleSize.ToVector2() / 2f + direction * circleSize.Width / 2f;
            var handleSize = new SizeF(circleSize.Width / 7f, circleSize.Height / 7f);
            var handlePoint = new PointF(handleDirection.X - handleSize.Width / 2f, handleDirection.Y - handleSize.Height / 2f);

            _circle = new RectangleF(circlePoint, circleSize);
            _handle = new RectangleF(handlePoint, handleSize);
            _image = new RectangleF(imagePoint, imageSize);
        }

        private void PaintRects(Graphics graphics, List<Mood> allMoods, Mood currentMood)
        {
            using var backFill = new SolidBrush(Color.Black);
            graphics.FillEllipse(backFill, _circle);

            var length = 360 / allMoods.Count;
            using var circleOutline = new Pen(Color.Black, _circle.Height / 10f);
            using var circleFill = new Pen(Color.Black, _circle.Height / 14f);
            graphics.DrawEllipse(circleOutline, _circle);
            for (int i = 0; i < allMoods.Count; i++)
            {
                circleFill.Color = allMoods[i].Color;
                graphics.DrawArc(circleFill, _circle, i * length, length);
            }

            using var handleOutline = new Pen(Color.Black, _handle.Height / 5f);
            using var handleFill = new SolidBrush(Color.White);
            graphics.DrawEllipse(handleOutline, _handle);
            graphics.FillEllipse(handleFill, _handle);

            graphics.DrawImage(currentMood.Image, _image);
        }
    }
}