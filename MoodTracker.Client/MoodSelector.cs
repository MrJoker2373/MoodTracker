namespace MoodTracker.Client
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Numerics;
    using System.Windows.Forms;

    public class MoodSelector : Control
    {
        private List<Mood>? _moods;
        private Mood? _currentMood;
        private RectangleF _text;
        private RectangleF _circle;
        private RectangleF _handle;
        private RectangleF _image;
        private Vector2 _mouse;
        private Vector2 _direction;
        private bool _isDragging;

        public List<Mood>? Moods
        {
            get => _moods;
            set
            {
                _moods = value;
                Invalidate();
            }
        }

        public Mood? CurrentMood => _currentMood;

        public MoodSelector()
        {
            MinimumSize = new Size(200, 200);
            DoubleBuffered = true;
            _direction = new Vector2(1, 0);
        }

        protected override void OnResize(EventArgs e)
        {
            Width = Height;
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
                _mouse = new Vector2(e.X, e.Y);
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            CalculateRects();
            PaintRects(e.Graphics);
        }

        private void CalculateRects()
        {
            var padding = Height / 7f;

            var textSize = new SizeF(Width * 0.9f, Height * 0.1f);
            var textPoint = new PointF(Width / 2f - textSize.Width / 2f, 0);
            _text = new RectangleF(textPoint, textSize);

            var circleSize = new SizeF(Width * 0.9f - padding, Height * 0.9f - padding);
            var circlePoint = new PointF(Width / 2f - textSize.Width / 2f + padding / 2, textSize.Height + padding / 2);
            _circle = new RectangleF(circlePoint, circleSize);

            if (_isDragging == true)
                _direction = Vector2.Normalize(_mouse - (circlePoint + circleSize / 2).ToVector2());

            var point = circlePoint.ToVector2() + circleSize.ToVector2() / 2 + _direction * circleSize.Width / 2;
            var handleSize = new SizeF(circleSize.Width / 7, circleSize.Height / 7);
            var handlePoint = new PointF(point.X - handleSize.Width / 2, point.Y - handleSize.Height / 2);
            _handle = new RectangleF(handlePoint, handleSize);

            var imageSize = new SizeF(circleSize.Width / 1.5f, circleSize.Height / 1.5f);
            var imagePoint = new PointF(circlePoint.X + circleSize.Width / 2 - imageSize.Width / 2, circlePoint.Y + circleSize.Height / 2 - imageSize.Height / 2);
            _image = new RectangleF(imagePoint, imageSize);
        }

        private void PaintRects(Graphics graphics)
        {
            if (_moods == null || _moods.Count == 0)
                return;

            _currentMood = CalculateMood();

            using var backFill = new SolidBrush(Color.Black);
            graphics.FillEllipse(backFill, _circle);

            var length = 360 / _moods.Count;
            using var circleOutline = new Pen(Color.Black, Width / 14f);
            using var circleFill = new Pen(Color.Black, Width / 20f);
            graphics.DrawEllipse(circleOutline, _circle);
            for (int i = 0; i < _moods.Count; i++)
            {
                circleFill.Color = _moods[i].Color;
                graphics.DrawArc(circleFill, _circle, i * length, length);
            }

            using var handleOutline = new Pen(Color.Black, Width / 40f);
            using var handleFill = new SolidBrush(Color.White);
            graphics.DrawEllipse(handleOutline, _handle);
            graphics.FillEllipse(handleFill, _handle);

            if (_currentMood.Image != null)
                graphics.DrawImage(_currentMood.Image, _image);

            using var textFont = new Font(Font.Name, Width / 15f, FontStyle.Bold);
            using var textFill = new SolidBrush(ForeColor);
            using var textFormat = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            graphics.DrawString(_currentMood.Type.ToString(), textFont, textFill, _text, textFormat);
        }

        private Mood CalculateMood()
        {
            if (_moods == null || _moods.Count == 0)
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