namespace MoodTracker.Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var allMoods = new List<Mood>()
            {
                new (Properties.Icons.Close, Color.Black, MoodType.Null),
                new (Properties.Moods.Calm, Color.FromArgb(255, 243, 51), MoodType.Calm),
                new (Properties.Moods.Happy, Color.FromArgb(47, 224, 75), MoodType.Happy),
                new (Properties.Moods.Sad, Color.FromArgb(51, 75, 255), MoodType.Sad),
                new (Properties.Moods.Angry, Color.FromArgb(252, 32, 32), MoodType.Angry),
                new (Properties.Moods.Excited, Color.FromArgb(252, 32, 213), MoodType.Excited),
                new (Properties.Moods.Scared, Color.FromArgb(120, 159, 188), MoodType.Scared),
                new (Properties.Moods.Shamed, Color.FromArgb(223, 95, 128), MoodType.Shamed),
                new (Properties.Moods.Sick, Color.FromArgb(197, 255, 91), MoodType.Sick),
            };

            var trackerForm = new TrackerForm();
            trackerForm.Initialize(allMoods);
            var statisticsForm = new StatisticsForm();
            statisticsForm.Initialize(allMoods);

            var allMenus = new List<Menu>()
            {
                new (trackerForm, trackerButton, fillPanel),
                new (statisticsForm, statisticsButton, fillPanel),
            };

            var menuSwitcher = new MenuSwitcher(allMenus, Color.FromArgb(227, 14, 74), Color.FromArgb(163, 8, 52));
        }
    }
}