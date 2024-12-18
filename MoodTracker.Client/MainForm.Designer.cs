﻿namespace MoodTracker.Client
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
            label1 = new Label();
            moodSelector1 = new MoodSelector();
            draggingPanel1 = new DraggingPanel();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            label1.Location = new Point(253, 59);
            label1.Name = "label1";
            label1.Size = new Size(420, 59);
            label1.TabIndex = 3;
            label1.Text = "Choose your mood!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // moodSelector1
            // 
            moodSelector1.Location = new Point(300, 130);
            moodSelector1.MinimumSize = new Size(200, 200);
            moodSelector1.Moods = (List<Mood>)resources.GetObject("moodSelector1.Moods");
            moodSelector1.Name = "moodSelector1";
            moodSelector1.Size = new Size(323, 323);
            moodSelector1.TabIndex = 4;
            moodSelector1.Text = "moodSelector1";
            // 
            // draggingPanel1
            // 
            draggingPanel1.BackColor = Color.FromArgb(28, 34, 36);
            draggingPanel1.Dock = DockStyle.Top;
            draggingPanel1.Location = new Point(0, 0);
            draggingPanel1.Name = "draggingPanel1";
            draggingPanel1.Size = new Size(743, 36);
            draggingPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 71, 74);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(181, 417);
            panel1.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(117, 151, 161);
            ClientSize = new Size(743, 453);
            Controls.Add(panel1);
            Controls.Add(draggingPanel1);
            Controls.Add(moodSelector1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private MoodSelector moodSelector1;
        private DraggingPanel draggingPanel1;
        private Panel panel1;
    }
}
