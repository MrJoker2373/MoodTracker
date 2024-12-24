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
            headPanel = new TableLayoutPanel();
            trackerButton = new Button();
            settingsButton = new Button();
            statisticsButton = new Button();
            bodyPanel = new Panel();
            moodSelector = new MoodSelector();
            headPanel.SuspendLayout();
            bodyPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headPanel
            // 
            headPanel.ColumnCount = 3;
            headPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            headPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            headPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            headPanel.Controls.Add(trackerButton, 0, 0);
            headPanel.Controls.Add(settingsButton, 2, 0);
            headPanel.Controls.Add(statisticsButton, 1, 0);
            headPanel.Dock = DockStyle.Top;
            headPanel.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            headPanel.Location = new Point(0, 0);
            headPanel.Margin = new Padding(0);
            headPanel.Name = "headPanel";
            headPanel.RowCount = 1;
            headPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            headPanel.Size = new Size(824, 45);
            headPanel.TabIndex = 9;
            // 
            // trackerButton
            // 
            trackerButton.BackColor = Color.FromArgb(227, 14, 74);
            trackerButton.BackgroundImageLayout = ImageLayout.Zoom;
            trackerButton.Dock = DockStyle.Fill;
            trackerButton.FlatAppearance.BorderSize = 0;
            trackerButton.FlatStyle = FlatStyle.Flat;
            trackerButton.Font = new Font("Candara", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            trackerButton.ForeColor = Color.FromArgb(40, 40, 40);
            trackerButton.ImageAlign = ContentAlignment.MiddleRight;
            trackerButton.Location = new Point(0, 0);
            trackerButton.Margin = new Padding(0);
            trackerButton.Name = "trackerButton";
            trackerButton.Size = new Size(274, 45);
            trackerButton.TabIndex = 1;
            trackerButton.Text = "Tracker";
            trackerButton.UseVisualStyleBackColor = false;
            // 
            // settingsButton
            // 
            settingsButton.BackColor = Color.FromArgb(227, 14, 74);
            settingsButton.BackgroundImageLayout = ImageLayout.Zoom;
            settingsButton.Dock = DockStyle.Fill;
            settingsButton.FlatAppearance.BorderSize = 0;
            settingsButton.FlatStyle = FlatStyle.Flat;
            settingsButton.Font = new Font("Candara", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            settingsButton.ForeColor = Color.FromArgb(40, 40, 40);
            settingsButton.ImageAlign = ContentAlignment.MiddleRight;
            settingsButton.Location = new Point(548, 0);
            settingsButton.Margin = new Padding(0);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(276, 45);
            settingsButton.TabIndex = 3;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = false;
            // 
            // statisticsButton
            // 
            statisticsButton.BackColor = Color.FromArgb(227, 14, 74);
            statisticsButton.BackgroundImageLayout = ImageLayout.Zoom;
            statisticsButton.Dock = DockStyle.Fill;
            statisticsButton.FlatAppearance.BorderSize = 0;
            statisticsButton.FlatStyle = FlatStyle.Flat;
            statisticsButton.Font = new Font("Candara", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            statisticsButton.ForeColor = Color.FromArgb(40, 40, 40);
            statisticsButton.ImageAlign = ContentAlignment.MiddleRight;
            statisticsButton.Location = new Point(274, 0);
            statisticsButton.Margin = new Padding(0);
            statisticsButton.Name = "statisticsButton";
            statisticsButton.Size = new Size(274, 45);
            statisticsButton.TabIndex = 2;
            statisticsButton.Text = "Statistics";
            statisticsButton.UseVisualStyleBackColor = false;
            // 
            // bodyPanel
            // 
            bodyPanel.BackColor = Color.FromArgb(225, 225, 225);
            bodyPanel.Controls.Add(moodSelector);
            bodyPanel.Dock = DockStyle.Fill;
            bodyPanel.Location = new Point(0, 45);
            bodyPanel.Margin = new Padding(0);
            bodyPanel.Name = "bodyPanel";
            bodyPanel.Size = new Size(824, 396);
            bodyPanel.TabIndex = 10;
            // 
            // moodSelector
            // 
            moodSelector.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            moodSelector.Font = new Font("Candara", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            moodSelector.ForeColor = Color.FromArgb(40, 40, 40);
            moodSelector.Location = new Point(260, 28);
            moodSelector.Margin = new Padding(0);
            moodSelector.MinimumSize = new Size(200, 200);
            moodSelector.Moods = (List<Mood>)resources.GetObject("moodSelector.Moods");
            moodSelector.Name = "moodSelector";
            moodSelector.Size = new Size(304, 339);
            moodSelector.TabIndex = 4;
            moodSelector.Text = "moodSelector1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(161, 11, 54);
            ClientSize = new Size(824, 441);
            Controls.Add(bodyPanel);
            Controls.Add(headPanel);
            DoubleBuffered = true;
            MinimumSize = new Size(840, 480);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mood Tracker";
            headPanel.ResumeLayout(false);
            bodyPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button trackerButton;
        private Button statisticsButton;
        private Button settingsButton;
        private TableLayoutPanel headPanel;
        private Panel bodyPanel;
        private MoodSelector moodSelector;
    }
}
