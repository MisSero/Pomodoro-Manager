namespace Pomodoro_Manager
{
    partial class SettingsForm
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
            CancelSettingsButton = new Button();
            TaskDurationLabel = new Label();
            PomodoroDurationUpDown = new NumericUpDown();
            panel1 = new Panel();
            SaveSettingsButton = new Button();
            PomodoroDutationPattern30 = new Button();
            PomodoroDutationPattern60 = new Button();
            ((System.ComponentModel.ISupportInitialize)PomodoroDurationUpDown).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CancelSettingsButton
            // 
            CancelSettingsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CancelSettingsButton.Location = new Point(12, 136);
            CancelSettingsButton.Name = "CancelSettingsButton";
            CancelSettingsButton.Size = new Size(85, 35);
            CancelSettingsButton.TabIndex = 0;
            CancelSettingsButton.Text = "Cancel";
            CancelSettingsButton.UseVisualStyleBackColor = true;
            // 
            // TaskDurationLabel
            // 
            TaskDurationLabel.Anchor = AnchorStyles.None;
            TaskDurationLabel.AutoSize = true;
            TaskDurationLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TaskDurationLabel.Location = new Point(11, 10);
            TaskDurationLabel.Name = "TaskDurationLabel";
            TaskDurationLabel.Size = new Size(190, 28);
            TaskDurationLabel.TabIndex = 1;
            TaskDurationLabel.Text = "Pomodoro duration:";
            // 
            // PomodoroDurationUpDown
            // 
            PomodoroDurationUpDown.Anchor = AnchorStyles.None;
            PomodoroDurationUpDown.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PomodoroDurationUpDown.Location = new Point(295, 13);
            PomodoroDurationUpDown.Maximum = new decimal(new int[] { 10080, 0, 0, 0 });
            PomodoroDurationUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            PomodoroDurationUpDown.Name = "PomodoroDurationUpDown";
            PomodoroDurationUpDown.Size = new Size(82, 30);
            PomodoroDurationUpDown.TabIndex = 2;
            PomodoroDurationUpDown.ThousandsSeparator = true;
            PomodoroDurationUpDown.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(PomodoroDurationUpDown);
            panel1.Controls.Add(TaskDurationLabel);
            panel1.Location = new Point(12, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 52);
            panel1.TabIndex = 3;
            // 
            // SaveSettingsButton
            // 
            SaveSettingsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SaveSettingsButton.Location = new Point(319, 136);
            SaveSettingsButton.Name = "SaveSettingsButton";
            SaveSettingsButton.Size = new Size(85, 35);
            SaveSettingsButton.TabIndex = 4;
            SaveSettingsButton.Text = "Save";
            SaveSettingsButton.UseVisualStyleBackColor = true;
            // 
            // PomodoroDutationPattern30
            // 
            PomodoroDutationPattern30.ForeColor = SystemColors.ControlDarkDark;
            PomodoroDutationPattern30.Location = new Point(298, 81);
            PomodoroDutationPattern30.Name = "PomodoroDutationPattern30";
            PomodoroDutationPattern30.Size = new Size(50, 29);
            PomodoroDutationPattern30.TabIndex = 5;
            PomodoroDutationPattern30.Text = "30";
            PomodoroDutationPattern30.UseVisualStyleBackColor = true;
            // 
            // PomodoroDutationPattern60
            // 
            PomodoroDutationPattern60.ForeColor = SystemColors.ControlDarkDark;
            PomodoroDutationPattern60.Location = new Point(354, 81);
            PomodoroDutationPattern60.Name = "PomodoroDutationPattern60";
            PomodoroDutationPattern60.Size = new Size(50, 29);
            PomodoroDutationPattern60.TabIndex = 6;
            PomodoroDutationPattern60.Text = "60";
            PomodoroDutationPattern60.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            AcceptButton = SaveSettingsButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            CancelButton = CancelSettingsButton;
            ClientSize = new Size(416, 198);
            ControlBox = false;
            Controls.Add(PomodoroDutationPattern60);
            Controls.Add(PomodoroDutationPattern30);
            Controls.Add(SaveSettingsButton);
            Controls.Add(panel1);
            Controls.Add(CancelSettingsButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)PomodoroDurationUpDown).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button CancelSettingsButton;
        private Label TaskDurationLabel;
        private NumericUpDown PomodoroDurationUpDown;
        private Panel panel1;
        private Button SaveSettingsButton;
        private Button PomodoroDutationPattern30;
        private Button PomodoroDutationPattern60;
    }
}