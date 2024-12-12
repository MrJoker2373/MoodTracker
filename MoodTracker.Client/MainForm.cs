namespace MoodTracker.Client
{
    using System.Drawing;

    public partial class MainForm : Form
    {
        private Point _startPosition;
        private bool _isDragging;

        public MainForm()
        {
            InitializeComponent();
        }

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
                var point = PointToScreen(e.Location);
                Location = new Point(point.X - _startPosition.X, point.Y - _startPosition.Y);
            }
        }
    }
}