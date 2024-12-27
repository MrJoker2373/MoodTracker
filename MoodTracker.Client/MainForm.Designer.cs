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
            buttonSelector = new ButtonSelector();
            settingsButton = new Button();
            statisticsButton = new Button();
            trackerButton = new Button();
            formFitter = new FormFitter();
            buttonSelector.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSelector
            // 
            buttonSelector.ColumnCount = 3;
            buttonSelector.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            buttonSelector.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            buttonSelector.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            buttonSelector.Controls.Add(settingsButton, 2, 0);
            buttonSelector.Controls.Add(statisticsButton, 1, 0);
            buttonSelector.Controls.Add(trackerButton, 0, 0);
            buttonSelector.DefaultColor = Color.FromArgb(227, 14, 74);
            buttonSelector.Dock = DockStyle.Top;
            buttonSelector.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            buttonSelector.Location = new Point(0, 0);
            buttonSelector.Name = "buttonSelector";
            buttonSelector.RowCount = 1;
            buttonSelector.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            buttonSelector.SelectedColor = Color.FromArgb(163, 8, 52);
            buttonSelector.Size = new Size(824, 45);
            buttonSelector.TabIndex = 2;
            // 
            // settingsButton
            // 
            settingsButton.BackColor = Color.FromArgb(227, 14, 74);
            settingsButton.Dock = DockStyle.Fill;
            settingsButton.FlatAppearance.BorderSize = 0;
            settingsButton.FlatStyle = FlatStyle.Flat;
            settingsButton.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            settingsButton.Location = new Point(548, 0);
            settingsButton.Margin = new Padding(0);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(276, 45);
            settingsButton.TabIndex = 4;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = false;
            // 
            // statisticsButton
            // 
            statisticsButton.BackColor = Color.FromArgb(227, 14, 74);
            statisticsButton.Dock = DockStyle.Fill;
            statisticsButton.FlatAppearance.BorderSize = 0;
            statisticsButton.FlatStyle = FlatStyle.Flat;
            statisticsButton.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            statisticsButton.Location = new Point(274, 0);
            statisticsButton.Margin = new Padding(0);
            statisticsButton.Name = "statisticsButton";
            statisticsButton.Size = new Size(274, 45);
            statisticsButton.TabIndex = 4;
            statisticsButton.Text = "Statistics";
            statisticsButton.UseVisualStyleBackColor = false;
            // 
            // trackerButton
            // 
            trackerButton.BackColor = Color.FromArgb(163, 8, 52);
            trackerButton.Dock = DockStyle.Fill;
            trackerButton.FlatAppearance.BorderSize = 0;
            trackerButton.FlatStyle = FlatStyle.Flat;
            trackerButton.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            trackerButton.Location = new Point(0, 0);
            trackerButton.Margin = new Padding(0);
            trackerButton.Name = "trackerButton";
            trackerButton.Size = new Size(274, 45);
            trackerButton.TabIndex = 3;
            trackerButton.Text = "Tracker";
            trackerButton.UseVisualStyleBackColor = false;
            // 
            // formFitter
            // 
            formFitter.Dock = DockStyle.Fill;
            formFitter.Location = new Point(0, 45);
            formFitter.Name = "formFitter";
            formFitter.Size = new Size(824, 396);
            formFitter.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 225, 225);
            ClientSize = new Size(824, 441);
            Controls.Add(formFitter);
            Controls.Add(buttonSelector);
            DoubleBuffered = true;
            MinimumSize = new Size(840, 480);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mood Tracker";
            buttonSelector.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ButtonSelector buttonSelector;
        private Button trackerButton;
        private Button statisticsButton;
        private Button settingsButton;
        private FormFitter formFitter;
    }
}
