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
            moodCalendar = new MoodCalendar();
            SuspendLayout();
            // 
            // moodCalendar
            // 
            moodCalendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            moodCalendar.Location = new Point(12, 12);
            moodCalendar.MinimumSize = new Size(300, 300);
            moodCalendar.Name = "moodCalendar";
            moodCalendar.Size = new Size(800, 372);
            moodCalendar.TabIndex = 0;
            moodCalendar.Text = "moodCalendar1";
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 225, 225);
            ClientSize = new Size(824, 396);
            Controls.Add(moodCalendar);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(824, 396);
            Name = "StatisticsForm";
            Text = "StatisticsForm";
            ResumeLayout(false);
        }

        #endregion

        private MoodCalendar moodCalendar;
    }
}