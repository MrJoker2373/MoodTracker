namespace MoodTracker.Client
{
    using System;
    using System.Drawing;

    [Serializable]
    public class Mood
    {
        public Image? Image { get; set; }
        public Color Color { get; set; }
        public MoodType Type { get; set; }

        public enum MoodType
        {
            Calm,
            Happy,
            Sad,
            Angry,
            Excited,
            Scared,
            Shamed,
            Sick
        }
    }
}