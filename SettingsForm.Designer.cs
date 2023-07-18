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
            TaskDurationNumeric = new NumericUpDown();
            panel1 = new Panel();
            SaveSettingsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)TaskDurationNumeric).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CancelSettingsButton
            // 
            CancelSettingsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CancelSettingsButton.Location = new Point(22, 136);
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
            TaskDurationLabel.Location = new Point(3, 9);
            TaskDurationLabel.Name = "TaskDurationLabel";
            TaskDurationLabel.Size = new Size(190, 28);
            TaskDurationLabel.TabIndex = 1;
            TaskDurationLabel.Text = "Pomodoro duration:";
            // 
            // TaskDurationNumeric
            // 
            TaskDurationNumeric.Anchor = AnchorStyles.None;
            TaskDurationNumeric.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TaskDurationNumeric.Location = new Point(278, 12);
            TaskDurationNumeric.Maximum = new decimal(new int[] { 10080, 0, 0, 0 });
            TaskDurationNumeric.Name = "TaskDurationNumeric";
            TaskDurationNumeric.Size = new Size(82, 30);
            TaskDurationNumeric.TabIndex = 2;
            TaskDurationNumeric.ThousandsSeparator = true;
            TaskDurationNumeric.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // panel1
            // 
            panel1.Controls.Add(TaskDurationNumeric);
            panel1.Controls.Add(TaskDurationLabel);
            panel1.Location = new Point(22, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 48);
            panel1.TabIndex = 3;
            // 
            // SaveSettingsButton
            // 
            SaveSettingsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SaveSettingsButton.Location = new Point(311, 136);
            SaveSettingsButton.Name = "SaveSettingsButton";
            SaveSettingsButton.Size = new Size(85, 35);
            SaveSettingsButton.TabIndex = 4;
            SaveSettingsButton.Text = "Save";
            SaveSettingsButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(416, 198);
            ControlBox = false;
            Controls.Add(SaveSettingsButton);
            Controls.Add(panel1);
            Controls.Add(CancelSettingsButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)TaskDurationNumeric).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button CancelSettingsButton;
        private Label TaskDurationLabel;
        private NumericUpDown TaskDurationNumeric;
        private Panel panel1;
        private Button SaveSettingsButton;
    }
}