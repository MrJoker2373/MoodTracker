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
            layoutPanel = new TableLayoutPanel();
            trackerButton = new Button();
            statisticsButton = new Button();
            fillPanel = new Panel();
            layoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // layoutPanel
            // 
            layoutPanel.ColumnCount = 2;
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            layoutPanel.Controls.Add(trackerButton, 0, 0);
            layoutPanel.Controls.Add(statisticsButton, 1, 0);
            layoutPanel.Dock = DockStyle.Top;
            layoutPanel.Location = new Point(0, 0);
            layoutPanel.Margin = new Padding(0);
            layoutPanel.Name = "layoutPanel";
            layoutPanel.RowCount = 1;
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layoutPanel.Size = new Size(824, 45);
            layoutPanel.TabIndex = 0;
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
            trackerButton.Size = new Size(412, 45);
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
            statisticsButton.Location = new Point(412, 0);
            statisticsButton.Margin = new Padding(0);
            statisticsButton.Name = "statisticsButton";
            statisticsButton.Size = new Size(412, 45);
            statisticsButton.TabIndex = 2;
            statisticsButton.Text = "Statistics";
            statisticsButton.UseVisualStyleBackColor = false;
            // 
            // fillPanel
            // 
            fillPanel.Dock = DockStyle.Fill;
            fillPanel.Location = new Point(0, 45);
            fillPanel.Name = "fillPanel";
            fillPanel.Size = new Size(824, 396);
            fillPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 225, 225);
            ClientSize = new Size(824, 441);
            Controls.Add(fillPanel);
            Controls.Add(layoutPanel);
            DoubleBuffered = true;
            MinimumSize = new Size(840, 480);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mood Tracker";
            layoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel fillPanel;
        private TableLayoutPanel layoutPanel;
        private Button trackerButton;
        private Button statisticsButton;
    }
}
