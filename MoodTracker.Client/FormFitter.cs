namespace MoodTracker.Client
{
    public class FormFitter : Panel
    {
        private Form? _currentForm;

        public FormFitter()
        {
            Dock = DockStyle.Fill;
        }

        public void OpenForm(Form form)
        {
            if (_currentForm?.GetType() == form.GetType())
                form.Dispose();
            else
            {
                CloseForm();
                _currentForm = form;
                _currentForm.Dock = DockStyle.Fill;
                _currentForm.TopLevel = false;
                Controls.Add(form);
                _currentForm.Show();
            }
        }

        public void CloseForm()
        {
            if (_currentForm != null)
            {
                Controls.Remove(_currentForm);
                _currentForm.Dispose();
            }
        }
    }
}