namespace MoodTracker.Client
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            moodSelector1 = new MoodSelector();
            SuspendLayout();
            // 
            // moodSelector1
            // 
            moodSelector1.Font = new Font("Segoe UI", 10F);
            moodSelector1.Location = new Point(140, 5);
            moodSelector1.MinimumSize = new Size(200, 200);
            moodSelector1.Moods = (List<Mood>)resources.GetObject("moodSelector1.Moods");
            moodSelector1.Name = "moodSelector1";
            moodSelector1.Size = new Size(442, 442);
            moodSelector1.TabIndex = 0;
            moodSelector1.Text = "moodSelector1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 235);
            ClientSize = new Size(723, 453);
            Controls.Add(moodSelector1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private MoodSelector moodSelector1;
    }
}
