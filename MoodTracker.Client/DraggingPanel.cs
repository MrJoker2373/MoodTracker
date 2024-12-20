namespace MoodTracker.Client
{
    using System.Drawing;

    public class DraggingPanel : Panel
    {
        private Point _startPosition;
        private bool _isDragging;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            _isDragging = true;
            _startPosition = e.Location;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            _isDragging = false;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (_isDragging == true)
            {
                var root = FindForm();
                if (root != null && root.WindowState == FormWindowState.Normal)
                {
                    var point = PointToScreen(e.Location);
                    root.Location = new Point(point.X - _startPosition.X, point.Y - _startPosition.Y);
                }
            }
        }
    }
}