namespace Pomodoro_Manager
{
    partial class ChangeTaskForm
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
            ChangeTextBox = new TextBox();
            ChangeNumericUpDown = new NumericUpDown();
            SaveChangeButton = new Button();
            CanсelChangeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ChangeNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // ChangeTextBox
            // 
            ChangeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ChangeTextBox.BackColor = SystemColors.ActiveBorder;
            ChangeTextBox.BorderStyle = BorderStyle.FixedSingle;
            ChangeTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeTextBox.ForeColor = Color.Black;
            ChangeTextBox.Location = new Point(12, 90);
            ChangeTextBox.MaxLength = 60;
            ChangeTextBox.Name = "ChangeTextBox";
            ChangeTextBox.Size = new Size(344, 32);
            ChangeTextBox.TabIndex = 4;
            ChangeTextBox.Text = "TaskName";
            // 
            // ChangeNumericUpDown
            // 
            ChangeNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ChangeNumericUpDown.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeNumericUpDown.Location = new Point(362, 92);
            ChangeNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            ChangeNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ChangeNumericUpDown.Name = "ChangeNumericUpDown";
            ChangeNumericUpDown.Size = new Size(86, 30);
            ChangeNumericUpDown.TabIndex = 5;
            ChangeNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // SaveChangeButton
            // 
            SaveChangeButton.Anchor = AnchorStyles.Right;
            SaveChangeButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SaveChangeButton.Location = new Point(278, 146);
            SaveChangeButton.Name = "SaveChangeButton";
            SaveChangeButton.Size = new Size(170, 34);
            SaveChangeButton.TabIndex = 6;
            SaveChangeButton.Text = "Save";
            SaveChangeButton.UseVisualStyleBackColor = true;
            SaveChangeButton.Click += SaveChangeButton_Click;
            // 
            // CanсelChangeButton
            // 
            CanсelChangeButton.Anchor = AnchorStyles.Left;
            CanсelChangeButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CanсelChangeButton.Location = new Point(12, 146);
            CanсelChangeButton.Name = "CanсelChangeButton";
            CanсelChangeButton.Size = new Size(170, 34);
            CanсelChangeButton.TabIndex = 7;
            CanсelChangeButton.Text = "Canсel";
            CanсelChangeButton.UseVisualStyleBackColor = true;
            CanсelChangeButton.Click += CanсelChangeButton_Click;
            // 
            // ChangeTaskForm
            // 
            AcceptButton = SaveChangeButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            CancelButton = CanсelChangeButton;
            ClientSize = new Size(460, 254);
            ControlBox = false;
            Controls.Add(CanсelChangeButton);
            Controls.Add(SaveChangeButton);
            Controls.Add(ChangeNumericUpDown);
            Controls.Add(ChangeTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangeTaskForm";
            StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)ChangeNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ChangeTextBox;
        private NumericUpDown ChangeNumericUpDown;
        private Button SaveChangeButton;
        private Button CanсelChangeButton;
    }
}