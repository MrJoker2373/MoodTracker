namespace MoodTracker.Client
{
    public class ButtonSelector : TableLayoutPanel
    {
        private Button? _currentButton;
        private Color _defaultColor;
        private Color _selectedColor;

        public Color DefaultColor
        {
            get => _defaultColor;
            set
            {
                _defaultColor = value;
                Invalidate();
            }
        }

        public Color SelectedColor
        {
            get => _selectedColor;
            set
            {
                _selectedColor = value;
                Invalidate();
            }
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            if (Controls.Count == 0)
                return;

            if (_currentButton == null)
                _currentButton = GetControlFromPosition(0, 0) as Button;

            foreach (Button button in Controls)
            {
                if (_currentButton == button)
                    button.BackColor = SelectedColor;
                else
                    button.BackColor = DefaultColor;
            }
            base.OnInvalidated(e);
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            if (e.Control is not Button button)
                Controls.Remove(e.Control);
            else
            {
                button.Margin = new Padding(0);
                button.Dock = DockStyle.Fill;
                button.Click += (sender, e) => Select(button);
            }
            base.OnControlAdded(e);
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            if (e.Control is Button button)
            {
                button.Dock = DockStyle.None;
                button.Click -= (sender, e) => Select(button);
            }
            base.OnControlRemoved(e);
        }

        private void Select(Button button)
        {
            if (_currentButton == button)
                return;

            _currentButton = button;
            Invalidate();
        }
    }
}