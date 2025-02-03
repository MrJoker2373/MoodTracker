namespace MoodTracker.Client
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        public void Initialize(IEnumerable<Mood> allMoods)
        {
            var allTypes = Enumerable.Repeat(MoodType.Calm, 24 * 12);
            moodCalendar.Initialize(allMoods, allTypes, 24, 12);
        }
    }
}