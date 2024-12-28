namespace MoodTracker.Client
{
    public class FormSwitcher : Panel
    {
        private List<Form> _forms;
        private Form? _currentForm;

        public FormSwitcher()
        {
            _forms = new();
            Dock = DockStyle.Fill;
        }

        public void Initialize(List<Form> forms)
        {
            if (forms.Count == 0)
                return;

            foreach (var form in _forms)
                form.Dispose();
            Controls.Clear();

            _forms = forms;
            foreach (var form in _forms)
            {
                form.Dock = DockStyle.Fill;
                form.TopLevel = false;
                Controls.Add(form);
            }

            _currentForm = forms[0];
            _currentForm.Show();
        }

        public void OpenForm<T>() where T : Form
        {
            if (_currentForm is not T)
            {
                _currentForm?.Hide();
                _currentForm = _forms.OfType<T>().Single();
                _currentForm?.Show();
            }
        }
    }
}