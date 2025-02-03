namespace MoodTracker.Client
{
    using System.Text.Json;

    public static class TrackerSaver
    {
        public struct TrackerData
        {
            public bool IsTrack { get; set; }
            public MoodType CurrentMood { get; set; }
        }

        private static TrackerData _currentData;

        public static bool IsTrack
        {
            get => _currentData.IsTrack;
            set
            {
                _currentData.IsTrack = value;
                SaveData(_currentData);
            }
        }

        public static MoodType CurrentMood
        {
            get => _currentData.CurrentMood;
            set
            {
                _currentData.CurrentMood = value;
                SaveData(_currentData);
            }
        }

        public static void Initialize()
        {
            _currentData = GetData();
        }

        private static TrackerData GetData()
        {
            var data = new TrackerData();
            if (File.Exists(GetPath()) == true)
            {
                using var reader = new StreamReader(GetPath());
                data = JsonSerializer.Deserialize<TrackerData>(reader.ReadToEnd());
            }
            return data;
        }

        private static void SaveData(TrackerData data)
        {
            var json = JsonSerializer.Serialize(data);
            using var writer = new StreamWriter(GetPath());
            writer.WriteLine(json);
        }

        private static string GetPath()
        {
            return Path.Combine(Environment.CurrentDirectory, nameof(TrackerData));
        }
    }
}