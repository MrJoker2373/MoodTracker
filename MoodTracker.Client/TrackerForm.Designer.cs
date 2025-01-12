namespace MoodTracker.Client
{
    partial class TrackerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackerForm));
            moodSelector = new MoodSelector();
            trackToggle = new ToggleButton();
            layoutPanel = new TableLayoutPanel();
            layoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // moodSelector
            // 
            moodSelector.Dock = DockStyle.Fill;
            moodSelector.Font = new Font("Candara", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            moodSelector.ForeColor = Color.FromArgb(40, 40, 40);
            moodSelector.Location = new Point(82, 0);
            moodSelector.Margin = new Padding(0);
            moodSelector.MinimumSize = new Size(200, 200);
            moodSelector.Moods = (List<Mood>)resources.GetObject("moodSelector.Moods");
            moodSelector.Name = "moodSelector";
            moodSelector.Size = new Size(288, 396);
            moodSelector.TabIndex = 5;
            moodSelector.Text = "moodSelector1";
            // 
            // trackToggle
            // 
            trackToggle.CheckedColor = Color.Lime;
            trackToggle.DefaultColor = Color.Gray;
            trackToggle.Dock = DockStyle.Fill;
            trackToggle.Font = new Font("Candara", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            trackToggle.Location = new Point(455, 3);
            trackToggle.MinimumSize = new Size(100, 100);
            trackToggle.Name = "trackToggle";
            trackToggle.Size = new Size(282, 390);
            trackToggle.TabIndex = 6;
            trackToggle.Text = "Track";
            trackToggle.UseVisualStyleBackColor = false;
            // 
            // layoutPanel
            // 
            layoutPanel.ColumnCount = 5;
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            layoutPanel.Controls.Add(trackToggle, 3, 0);
            layoutPanel.Controls.Add(moodSelector, 1, 0);
            layoutPanel.Dock = DockStyle.Fill;
            layoutPanel.Location = new Point(0, 0);
            layoutPanel.Name = "layoutPanel";
            layoutPanel.RowCount = 1;
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutPanel.Size = new Size(824, 396);
            layoutPanel.TabIndex = 7;
            // 
            // TrackerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 225, 225);
            ClientSize = new Size(824, 396);
            Controls.Add(layoutPanel);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(824, 396);
            Name = "TrackerForm";
            Text = "TrackerForm";
            layoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MoodSelector moodSelector;
        private ToggleButton trackToggle;
        private TableLayoutPanel layoutPanel;
    }
}