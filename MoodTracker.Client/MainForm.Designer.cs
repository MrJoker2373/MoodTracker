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
            controlPanel = new DraggingPanel();
            minimizeButton = new Button();
            maximizeButton = new Button();
            closeButton = new Button();
            trackerButton = new Button();
            statisticsButton = new Button();
            settingsButton = new Button();
            moodSelector = new MoodSelector();
            menuPanel = new TableLayoutPanel();
            controlPanel.SuspendLayout();
            menuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // controlPanel
            // 
            controlPanel.BackColor = Color.FromArgb(161, 11, 54);
            controlPanel.Controls.Add(minimizeButton);
            controlPanel.Controls.Add(maximizeButton);
            controlPanel.Controls.Add(closeButton);
            controlPanel.Dock = DockStyle.Top;
            controlPanel.Location = new Point(0, 0);
            controlPanel.Margin = new Padding(0);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new Size(500, 35);
            controlPanel.TabIndex = 0;
            // 
            // minimizeButton
            // 
            minimizeButton.BackgroundImage = Properties.Icons.Minimize;
            minimizeButton.BackgroundImageLayout = ImageLayout.Zoom;
            minimizeButton.Dock = DockStyle.Right;
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.Location = new Point(395, 0);
            minimizeButton.Margin = new Padding(0);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(35, 35);
            minimizeButton.TabIndex = 2;
            minimizeButton.UseVisualStyleBackColor = true;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // maximizeButton
            // 
            maximizeButton.BackgroundImage = Properties.Icons.Maximize;
            maximizeButton.BackgroundImageLayout = ImageLayout.Zoom;
            maximizeButton.Dock = DockStyle.Right;
            maximizeButton.FlatAppearance.BorderSize = 0;
            maximizeButton.FlatStyle = FlatStyle.Flat;
            maximizeButton.Location = new Point(430, 0);
            maximizeButton.Margin = new Padding(0);
            maximizeButton.Name = "maximizeButton";
            maximizeButton.Size = new Size(35, 35);
            maximizeButton.TabIndex = 1;
            maximizeButton.UseVisualStyleBackColor = true;
            maximizeButton.Click += maximizeButton_Click;
            // 
            // closeButton
            // 
            closeButton.BackgroundImage = Properties.Icons.Close;
            closeButton.BackgroundImageLayout = ImageLayout.Zoom;
            closeButton.Dock = DockStyle.Right;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Location = new Point(465, 0);
            closeButton.Margin = new Padding(0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(35, 35);
            closeButton.TabIndex = 0;
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
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
            trackerButton.Size = new Size(166, 35);
            trackerButton.TabIndex = 1;
            trackerButton.Text = "Tracker";
            trackerButton.UseVisualStyleBackColor = false;
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
            statisticsButton.Location = new Point(166, 0);
            statisticsButton.Margin = new Padding(0);
            statisticsButton.Name = "statisticsButton";
            statisticsButton.Size = new Size(166, 35);
            statisticsButton.TabIndex = 2;
            statisticsButton.Text = "Statistics";
            statisticsButton.UseVisualStyleBackColor = false;
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
            settingsButton.Location = new Point(332, 0);
            settingsButton.Margin = new Padding(0);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(168, 35);
            settingsButton.TabIndex = 3;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = false;
            // 
            // moodSelector
            // 
            moodSelector.Anchor = AnchorStyles.None;
            moodSelector.Font = new Font("Candara", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            moodSelector.ForeColor = Color.FromArgb(40, 40, 40);
            moodSelector.Location = new Point(80, 125);
            moodSelector.Margin = new Padding(0);
            moodSelector.MinimumSize = new Size(200, 200);
            moodSelector.Moods = (List<Mood>)resources.GetObject("moodSelector.Moods");
            moodSelector.Name = "moodSelector";
            moodSelector.Size = new Size(339, 339);
            moodSelector.TabIndex = 4;
            moodSelector.Text = "moodSelector1";
            // 
            // menuPanel
            // 
            menuPanel.ColumnCount = 3;
            menuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            menuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            menuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            menuPanel.Controls.Add(trackerButton, 0, 0);
            menuPanel.Controls.Add(settingsButton, 2, 0);
            menuPanel.Controls.Add(statisticsButton, 1, 0);
            menuPanel.Dock = DockStyle.Top;
            menuPanel.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            menuPanel.Location = new Point(0, 35);
            menuPanel.Margin = new Padding(0);
            menuPanel.Name = "menuPanel";
            menuPanel.RowCount = 1;
            menuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            menuPanel.Size = new Size(500, 35);
            menuPanel.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 235);
            ClientSize = new Size(500, 500);
            Controls.Add(menuPanel);
            Controls.Add(moodSelector);
            Controls.Add(controlPanel);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(500, 500);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            controlPanel.ResumeLayout(false);
            menuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DraggingPanel controlPanel;
        private Button closeButton;
        private Button minimizeButton;
        private Button maximizeButton;
        private Button trackerButton;
        private Button statisticsButton;
        private Button settingsButton;
        private MoodSelector moodSelector;
        private TableLayoutPanel menuPanel;
    }
}
