namespace MoodTracker.Client
{
    using System;
    using System.Drawing.Drawing2D;

    public class MoodCalendar : Control
    {
        private const float GROUP_COUNT = 24f;
        private const float ITEM_COUNT = 12f;
        private List<List<RectangleF>> _squares;

        public MoodCalendar()
        {
            _squares = new();
            DoubleBuffered = true;
            MinimumSize = new Size(300, 300);
        }

        protected override void OnResize(EventArgs e)
        {
            Invalidate();
            base.OnResize(e);
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
            _squares.Clear();

            var defaultRatio = GROUP_COUNT / ITEM_COUNT;
            var currrentRatio = Width / (float)Height;

            var rectSize = new SizeF(Width, Width / defaultRatio);
            if (currrentRatio > defaultRatio)
                rectSize = new SizeF(Height * defaultRatio, Height);
            var rectPoint = new PointF(Width / 2f - rectSize.Width / 2f, Height / 2f - rectSize.Height / 2f);
            
            var itemPadding = rectSize.Height / (GROUP_COUNT + ITEM_COUNT);
            var itemSize = (rectSize.Height - itemPadding * (ITEM_COUNT + 1)) / ITEM_COUNT;
            for (int i = 0; i < GROUP_COUNT; i++)
            {
                var group = new List<RectangleF>();
                for (int j = 0; j < ITEM_COUNT; j++)
                {
                    var point = new PointF(rectPoint.X + itemPadding + i * (itemSize + itemPadding), rectPoint.Y + itemPadding + j * (itemSize + itemPadding));
                    var item = new RectangleF(point.X, point.Y, itemSize, itemSize);
                    group.Add(item);
                }
                _squares.Add(group);
            }
        }

        private void PaintRects(Graphics graphics)
        {
            using var squareFill = new SolidBrush(Color.Green);
            foreach (var group in _squares)
                foreach (var item in group)
                    graphics.FillRectangle(squareFill, item);
        }
    }
}