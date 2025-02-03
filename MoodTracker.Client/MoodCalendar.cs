namespace MoodTracker.Client
{
    using System.Drawing;
    using System.Drawing.Drawing2D;

    public class MoodCalendar : Control
    {
        private Dictionary<RectangleF, Mood>? _currentMoods;
        private List<MoodType>? _currentTypes;
        private List<Mood>? _allMoods;

        private int _columns;
        private int _rows;

        public MoodCalendar()
        {
            MinimumSize = new Size(300, 300);
            DoubleBuffered = true;
        }

        public void Initialize(IEnumerable<Mood> allMoods, IEnumerable<MoodType> defaultTypes, int columns, int rows)
        {
            _currentMoods = new();
            _currentTypes = defaultTypes.ToList();
            _allMoods = allMoods.ToList();
            _columns = columns;
            _rows = rows;
        }

        public void SetMoods(IEnumerable<MoodType> types)
        {
            if (_currentMoods == null)
                return;
            _currentTypes = types.ToList();
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_currentMoods == null || _currentTypes == null || _allMoods == null)
                return;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.Clear(BackColor);
            CalculateRects(_currentMoods, _allMoods, _currentTypes);
            PaintRects(e.Graphics, _currentMoods);
        }

        private void CalculateRects(Dictionary<RectangleF, Mood> currentMoods, List<Mood> allMoods, List<MoodType> currentTypes)
        {
            var targetRatio = _columns / _rows;
            var rectRatio = Width / (float)Height;
            var rectSize = new SizeF(Width, Width / targetRatio);
            if (rectRatio > targetRatio)
                rectSize = new SizeF(Height * targetRatio, Height);
            var rectPoint = new PointF(Width / 2f - rectSize.Width / 2f, Height / 2f - rectSize.Height / 2f);

            var paddingX = rectSize.Height / _rows / 3f;
            var paddingY = rectSize.Width / _columns / 3f;
            var itemSize = new SizeF((rectSize.Width - paddingX) / _columns - paddingX, (rectSize.Height - paddingY) / _rows - paddingY);

            currentMoods.Clear();
            for (int x = 0; x < _columns; x++)
            {
                for (int y = 0; y < _rows; y++)
                {
                    var itemPoint = new PointF(rectPoint.X + paddingX + x * (itemSize.Width + paddingX), rectPoint.Y + paddingY + y * (itemSize.Height + paddingY));
                    var itemRect = new RectangleF(itemPoint, itemSize);
                    var index = y * _columns + x;
                    var mood = allMoods.Single(mood => mood.Type == MoodType.Null);
                    if (currentTypes.Count > index)
                        mood = allMoods.Single(mood => mood.Type == currentTypes[index]);
                    currentMoods.Add(itemRect, mood);
                }
            }
        }

        private void PaintRects(Graphics graphics, Dictionary<RectangleF, Mood> currentMoods)
        {
            using var squareFill = new SolidBrush(Color.Black);
            foreach (var mood in currentMoods)
            {
                squareFill.Color = mood.Value.Color;
                graphics.FillRectangle(squareFill, mood.Key);
            }
        }
    }
}