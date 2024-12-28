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
            buttonSwitcher = new ButtonSwitcher();
            settingsButton = new Button();
            trackerButton = new Button();
            statisticsButton = new Button();
            formSwitcher = new FormSwitcher();
            buttonSwitcher.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSwitcher
            // 
            buttonSwitcher.ColumnCount = 3;
            buttonSwitcher.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            buttonSwitcher.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            buttonSwitcher.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            buttonSwitcher.Controls.Add(settingsButton, 2, 0);
            buttonSwitcher.Controls.Add(trackerButton, 0, 0);
            buttonSwitcher.Controls.Add(statisticsButton, 1, 0);
            buttonSwitcher.DefaultColor = Color.FromArgb(227, 14, 74);
            buttonSwitcher.Dock = DockStyle.Top;
            buttonSwitcher.Location = new Point(0, 0);
            buttonSwitcher.Margin = new Padding(0);
            buttonSwitcher.Name = "buttonSwitcher";
            buttonSwitcher.RowCount = 1;
            buttonSwitcher.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            buttonSwitcher.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            buttonSwitcher.SelectedColor = Color.FromArgb(163, 8, 52);
            buttonSwitcher.Size = new Size(824, 45);
            buttonSwitcher.TabIndex = 0;
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
            settingsButton.TabIndex = 3;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = false;
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
            trackerButton.TabIndex = 1;
            trackerButton.Text = "Tracker";
            trackerButton.UseVisualStyleBackColor = false;
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
            statisticsButton.TabIndex = 2;
            statisticsButton.Text = "Statistics";
            statisticsButton.UseVisualStyleBackColor = false;
            // 
            // formSwitcher
            // 
            formSwitcher.Dock = DockStyle.Fill;
            formSwitcher.Location = new Point(0, 45);
            formSwitcher.Name = "formSwitcher";
            formSwitcher.Size = new Size(824, 396);
            formSwitcher.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 225, 225);
            ClientSize = new Size(824, 441);
            Controls.Add(formSwitcher);
            Controls.Add(buttonSwitcher);
            DoubleBuffered = true;
            MinimumSize = new Size(840, 480);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mood Tracker";
            buttonSwitcher.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FormSwitcher formSwitcher;
        private ButtonSwitcher buttonSwitcher;
        private Button trackerButton;
        private Button settingsButton;
        private Button statisticsButton;
    }
}
