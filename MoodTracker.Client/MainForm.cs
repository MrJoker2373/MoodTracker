namespace MoodTracker.Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            trackerButton.Click += (sender, e) => formFitter.OpenForm(new TrackerForm());
            statisticsButton.Click += (sender, e) => formFitter.OpenForm(new StatisticsForm());
            settingsButton.Click += (sender, e) => formFitter.OpenForm(new SettingsForm());
            formFitter.OpenForm(new TrackerForm());
        }
    }
}