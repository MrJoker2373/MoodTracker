namespace MoodTracker.Client
{
    public partial class TrackerForm : Form
    {
        public TrackerForm()
        {
            InitializeComponent();
        }

        public void Initialize(IEnumerable<Mood> allMoods)
        {
            toggleButton.Checked += (isChecked) => TrackerSaver.IsTrack = isChecked;
            moodSelector.MoodChanged += (mood) => TrackerSaver.CurrentMood = mood;
            moodSelector.MoodChanged += toggleButton.SetMood;
            toggleButton.Initialize(allMoods, TrackerSaver.CurrentMood, TrackerSaver.IsTrack);
            moodSelector.Initialize(allMoods, TrackerSaver.CurrentMood);
        }
    }
}