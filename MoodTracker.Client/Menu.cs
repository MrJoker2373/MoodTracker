namespace MoodTracker.Client
{
    public class Menu
    {
        private readonly Form _form;
        private readonly Button _button;

        public event Action? Triggered;

        public Menu(Form form, Button button, Panel fillPanel)
        {
            _form = form;
            _button = button;

            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            fillPanel.Controls.Add(_form);
            _button.Click += (sender, args) => Triggered?.Invoke();
        }

        public void Show(Color color)
        {
            _form.Show();
            _button.BackColor = color;
        }

        public void Hide(Color color)
        {
            _form.Hide();
            _button.BackColor = color;
        }
    }
}