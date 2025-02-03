namespace MoodTracker.Client
{
    using System.Drawing;

    public readonly struct Mood(Image image, Color color, MoodType type)
    {
        public readonly Image Image = image;
        public readonly Color Color = color;
        public readonly MoodType Type = type;
    }
}