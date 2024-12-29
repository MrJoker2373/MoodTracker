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
            SuspendLayout();
            // 
            // moodSelector
            // 
            moodSelector.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            moodSelector.Font = new Font("Candara", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            moodSelector.ForeColor = Color.FromArgb(40, 40, 40);
            moodSelector.Location = new Point(233, 13);
            moodSelector.Margin = new Padding(0);
            moodSelector.MinimumSize = new Size(300, 300);
            moodSelector.Moods = (List<Mood>)resources.GetObject("moodSelector.Moods");
            moodSelector.Name = "moodSelector";
            moodSelector.Size = new Size(375, 375);
            moodSelector.TabIndex = 5;
            moodSelector.Text = "moodSelector1";
            // 
            // TrackerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 225, 225);
            ClientSize = new Size(840, 400);
            Controls.Add(moodSelector);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(840, 400);
            Name = "TrackerForm";
            Text = "TrackerForm";
            ResumeLayout(false);
        }

        #endregion

        private MoodSelector moodSelector;
    }
}