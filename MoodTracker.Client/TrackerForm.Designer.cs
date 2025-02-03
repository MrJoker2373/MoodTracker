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
            layoutPanel = new TableLayoutPanel();
            toggleButton = new ToggleButton();
            moodSelector = new MoodSelector();
            layoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // layoutPanel
            // 
            layoutPanel.ColumnCount = 5;
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            layoutPanel.Controls.Add(toggleButton, 3, 0);
            layoutPanel.Controls.Add(moodSelector, 1, 0);
            layoutPanel.Dock = DockStyle.Fill;
            layoutPanel.Location = new Point(0, 0);
            layoutPanel.Name = "layoutPanel";
            layoutPanel.RowCount = 1;
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutPanel.Size = new Size(824, 396);
            layoutPanel.TabIndex = 0;
            // 
            // toggleButton
            // 
            toggleButton.Dock = DockStyle.Fill;
            toggleButton.Location = new Point(452, 0);
            toggleButton.Margin = new Padding(0);
            toggleButton.MinimumSize = new Size(100, 100);
            toggleButton.Name = "toggleButton";
            toggleButton.Size = new Size(288, 396);
            toggleButton.TabIndex = 0;
            toggleButton.Text = "toggleButton1";
            // 
            // moodSelector
            // 
            moodSelector.Dock = DockStyle.Fill;
            moodSelector.Location = new Point(85, 3);
            moodSelector.MinimumSize = new Size(200, 200);
            moodSelector.Name = "moodSelector";
            moodSelector.Size = new Size(282, 390);
            moodSelector.TabIndex = 1;
            moodSelector.Text = "moodSelector1";
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

        private TableLayoutPanel layoutPanel;
        private ToggleButton toggleButton;
        private MoodSelector moodSelector;
    }
}