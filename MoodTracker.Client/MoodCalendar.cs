namespace MoodTracker.Client
{
    using System.Drawing.Drawing2D;

    public class MoodCalendar : Control
    {
        private const float GROUP_COUNT = 24f;
        private const float ITEM_COUNT = 12f;
        private List<RectangleF> _squares;
        private List<Mood> _moods;

        public List<Mood> Moods
        {
            get => _moods;
            set
            {
                _moods = value;
                Invalidate();
            }
        }

        public MoodCalendar()
        {
            MinimumSize = new Size(300, 300);
            DoubleBuffered = true;
            _squares = new();
            _moods = new();
        }

        protected override void OnResize(EventArgs e)
        {
            Invalidate();
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
            _squares.Clear();

            var targetRatio = GROUP_COUNT / ITEM_COUNT;
            var rectRatio = Width / (float)Height;
            var rectSize = new SizeF(Width, Width / targetRatio);
            if (rectRatio > targetRatio)
                rectSize = new SizeF(Height * targetRatio, Height);
            var rectPoint = new PointF(Width / 2f - rectSize.Width / 2f, Height / 2f - rectSize.Height / 2f);

            var padding = rectSize.Height / ITEM_COUNT / 3f;
            var itemSize = new SizeF((rectSize.Width - padding) / GROUP_COUNT - padding, (rectSize.Height - padding) / ITEM_COUNT - padding);
            for (int i = 0; i < GROUP_COUNT; i++)
            {
                for (int j = 0; j < ITEM_COUNT; j++)
                {
                    var itemPoint = new PointF(rectPoint.X + padding + i * (itemSize.Width + padding), rectPoint.Y + padding + j * (itemSize.Height + padding));
                    var itemRect = new RectangleF(itemPoint, itemSize);
                    _squares.Add(itemRect);
                }
            }
        }

        private void PaintRects(Graphics graphics)
        {
            using var squareFill = new SolidBrush(Color.Blue);
            for (int i = 0; i < _squares.Count; i++)
            {
                if (_moods.Count <= i || _moods[i].Color == default)
                    squareFill.Color = Color.Black;
                else
                    squareFill.Color = _moods[i].Color;
                graphics.FillRectangle(squareFill, _squares[i]);
            }
        }
    }
}