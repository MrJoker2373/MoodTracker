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
                if (value != null)
                {
                    _moods = value;
                    Invalidate();
                }
            }
        }

        public Mood? CurrentMood => _currentMood;

        public MoodSelector()
        {
            MinimumSize = new Size(200, 200);
            DoubleBuffered = true;
            _moods = new();
        }

        protected override void OnResize(EventArgs e)
        {
            Height = Width;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (_isDragging == true)
            {
                _mouse = new Vector2(e.X, e.Y);
                Invalidate();
            }
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

            _direction = new Vector2(1, 0);
            if (_mouse != Vector2.Zero)
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
            if (_moods == null)
                return;

            var circleWidth = Width / 20f;
            var circlePen = new Pen(Color.Black, circleWidth);
            if (_moods.Count == 0)
                graphics.DrawEllipse(circlePen, _circle);
            else
            {
                var length = 360 / _moods.Count;
                for (int i = 0; i < _moods.Count; i++)
                {
                    circlePen.Color = _moods[i].Color;
                    graphics.DrawArc(circlePen, _circle, i * length, length);
                }
            }

            var handleBrush = new SolidBrush(Color.White);
            graphics.FillEllipse(handleBrush, _handle);

            if (_moods.Count == 0)
                return;

            _currentMood = CalculateMood();
            if (_currentMood == null)
                return;

            if (_currentMood.Image != null)
                graphics.DrawImage(_currentMood.Image, _image);

            var textWidth = Width / 15f;
            var message = _currentMood.Type.ToString();
            var font = new Font(Font.Name, textWidth, FontStyle.Bold);
            var textBrush = new SolidBrush(Color.Black);
            var format = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
            };
            graphics.DrawString(message, font, textBrush, _text, format);
        }

        private Mood? CalculateMood()
        {
            if (_moods == null || _moods.Count == 0)
                return null;

            var degrees = MathF.Acos(_direction.X) * 180 / MathF.PI;
            if (float.IsNegative(_direction.Y))
                degrees = 360 - degrees;
            var length = 360 / _moods.Count;
            for (int i = _moods.Count - 1; i >= 0; i--)
            {
                if (degrees >= i * length)
                    return _moods[i];
            }
            return null;
        }
    }
}