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
            toggleButton.Initialize(allMoods, MoodType.Angry);
            moodSelector.Initialize(allMoods, MoodType.Angry);
            moodSelector.MoodChanged += toggleButton.SetMood;
        }
    }
}