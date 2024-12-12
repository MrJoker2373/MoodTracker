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
        private Vector2 _mouse;
        private Vector2 _direction;
        private Vector2 _center;
        private float _padding;
        private RectangleF _handle;
        private float _radius;
        private bool _isDragging;

        public Mood? CurrentMood => _currentMood;

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

        public MoodSelector()
        {
            MinimumSize = new Size(200, 200);
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            _padding = Width / 4f;
            _radius = (Width - _padding) / 2;
            _center = new Vector2(Width, Width + _padding / 2) / 2f;
            if (_mouse == Vector2.Zero)
                _direction = new Vector2(1, 0);
            else
                _direction = Vector2.Normalize(_mouse - _center);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            PaintCircle(e.Graphics);
            PaintHandle(e.Graphics);
            PaintImage(e.Graphics);
            PaintText(e.Graphics);
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

        private void PaintCircle(Graphics graphics)
        {
            if (_moods == null)
                return;

            var size = new SizeF(_radius * 2, _radius * 2);
            var position = new PointF(_center.X - size.Width / 2, _center.Y - size.Width / 2);
            var pen = new Pen(Color.Black, Width / 16f);
            var rect = new RectangleF(position, size);

            if (_moods.Count == 0)
                graphics.DrawEllipse(pen, rect);
            else
            {
                var length = 360 / _moods.Count;
                for (int i = 0; i < _moods.Count; i++)
                {
                    pen.Color = _moods[i].Color;
                    graphics.DrawArc(pen, rect, i * length, length);
                }
            }
        }

        private void PaintHandle(Graphics graphics)
        {
            if (_isDragging == true || _mouse == Vector2.Zero)
            {
                var point = _center + _direction * _radius;
                var size = new SizeF(Size.Width / 8f, Size.Width / 8f);
                var position = new PointF(point.X - size.Width / 2, point.Y - size.Width / 2);
                _handle = new RectangleF(position, size);
            }

            var brush = new SolidBrush(Color.White);
            graphics.FillEllipse(brush, _handle);
        }

        private void PaintImage(Graphics graphics)
        {
            if (_moods == null || _moods.Count == 0)
                return;

            var degrees = MathF.Acos(_direction.X) * 180 / MathF.PI;
            if (float.IsNegative(_direction.Y))
                degrees = 360 - degrees;

            var length = 360 / _moods.Count;
            for (int i = _moods.Count - 1; i >= 0; i--)
            {
                if (degrees >= i * length)
                {
                    _currentMood = _moods[i];
                    break;
                }
            }

            if (_currentMood != null && _currentMood.Image != null)
            {
                var size = new SizeF(Width / 2f, Width / 2f);
                var position = new PointF(_center.X - size.Width / 2, _center.Y - size.Height / 2);
                var rect = new RectangleF(position, size);
                graphics.DrawImage(_currentMood.Image, rect);
            }
        }

        private void PaintText(Graphics graphics)
        {
            if (_currentMood == null)
                return;

            var message = _currentMood.Type.ToString();
            var brush = new SolidBrush(Color.Black);
            var format = new StringFormat()
            {
                Alignment = StringAlignment.Center
            };
            var font = new Font(Font.Name, Width / 20, FontStyle.Bold);
            var size = new SizeF(Width / 3, Width / 9);
            var position = new PointF(_center.X - size.Width / 2, _padding / 3f - size.Height / 2);
            var rect = new RectangleF(position, size);
            graphics.DrawString(message, font, brush, rect, format);
        }
    }
}