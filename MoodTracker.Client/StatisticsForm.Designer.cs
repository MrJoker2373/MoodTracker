namespace MoodTracker.Client
{
    partial class StatisticsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsForm));
            moodCalendar1 = new MoodCalendar();
            SuspendLayout();
            // 
            // moodCalendar1
            // 
            moodCalendar1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            moodCalendar1.Location = new Point(12, 9);
            moodCalendar1.Margin = new Padding(0);
            moodCalendar1.MinimumSize = new Size(300, 300);
            moodCalendar1.Moods = (List<Color>)resources.GetObject("moodCalendar1.Moods");
            moodCalendar1.Name = "moodCalendar1";
            moodCalendar1.Size = new Size(819, 382);
            moodCalendar1.TabIndex = 1;
            moodCalendar1.Text = "moodCalendar1";
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 225, 225);
            ClientSize = new Size(840, 400);
            Controls.Add(moodCalendar1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(840, 400);
            Name = "StatisticsForm";
            Text = "StatisticsForm";
            ResumeLayout(false);
        }

        #endregion
        private MoodCalendar moodCalendar1;
    }
}