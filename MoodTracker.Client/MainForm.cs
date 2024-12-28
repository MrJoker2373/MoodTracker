namespace MoodTracker.Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            formSwitcher.Initialize(new List<Form>()
            {
                new TrackerForm(),
                new StatisticsForm(),
                new SettingsForm()
            });
            trackerButton.Click += (sender, e) => formSwitcher.OpenForm<TrackerForm>();
            statisticsButton.Click += (sender, e) => formSwitcher.OpenForm<StatisticsForm>();
            settingsButton.Click += (sender, e) => formSwitcher.OpenForm<SettingsForm>();
        }
    }
}