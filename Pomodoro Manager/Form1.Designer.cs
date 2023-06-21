namespace Pomodoro_Manager
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            formTimer = new System.Windows.Forms.Timer(components);
            mainTaskPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            addTaskButton = new Button();
            taskCountNumericUpDown = new NumericUpDown();
            nameTextBox = new TextBox();
            timerPanel = new Panel();
            timerLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taskCountNumericUpDown).BeginInit();
            timerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // formTimer
            // 
            formTimer.Interval = 25;
            formTimer.Tick += FormTimer_Tick;
            // 
            // mainTaskPanel
            // 
            mainTaskPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainTaskPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainTaskPanel.BorderStyle = BorderStyle.FixedSingle;
            mainTaskPanel.FlowDirection = FlowDirection.TopDown;
            mainTaskPanel.Location = new Point(206, 166);
            mainTaskPanel.Name = "mainTaskPanel";
            mainTaskPanel.Size = new Size(712, 384);
            mainTaskPanel.TabIndex = 0;
            mainTaskPanel.WrapContents = false;
            mainTaskPanel.Resize += MainTaskPanel_Resize;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(addTaskButton);
            panel1.Controls.Add(taskCountNumericUpDown);
            panel1.Controls.Add(nameTextBox);
            panel1.Location = new Point(206, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(712, 38);
            panel1.TabIndex = 3;
            // 
            // addTaskButton
            // 
            addTaskButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addTaskButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            addTaskButton.Location = new Point(653, 3);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(56, 30);
            addTaskButton.TabIndex = 5;
            addTaskButton.Text = "Add";
            addTaskButton.UseVisualStyleBackColor = true;
            addTaskButton.Click += AddTaskButton_Click;
            // 
            // taskCountNumericUpDown
            // 
            taskCountNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            taskCountNumericUpDown.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            taskCountNumericUpDown.Location = new Point(467, 4);
            taskCountNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            taskCountNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            taskCountNumericUpDown.Name = "taskCountNumericUpDown";
            taskCountNumericUpDown.Size = new Size(86, 30);
            taskCountNumericUpDown.TabIndex = 4;
            taskCountNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            taskCountNumericUpDown.MouseWheel += NumericUpDown_MouseWheel;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.BackColor = SystemColors.ActiveBorder;
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.Location = new Point(3, 3);
            nameTextBox.MaxLength = 60;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(458, 32);
            nameTextBox.TabIndex = 3;
            nameTextBox.Text = "Enter task name";
            nameTextBox.Enter += TextBox_Enter;
            nameTextBox.Leave += TextBox_Leave;
            // 
            // timerPanel
            // 
            timerPanel.Controls.Add(timerLabel);
            timerPanel.Dock = DockStyle.Fill;
            timerPanel.Location = new Point(0, 0);
            timerPanel.Name = "timerPanel";
            timerPanel.Size = new Size(965, 587);
            timerPanel.TabIndex = 6;
            timerPanel.Visible = false;
            // 
            // timerLabel
            // 
            timerLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            timerLabel.AutoSize = true;
            timerLabel.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            timerLabel.Location = new Point(420, 208);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(126, 57);
            timerLabel.TabIndex = 0;
            timerLabel.Text = "00:00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(965, 587);
            Controls.Add(timerPanel);
            Controls.Add(panel1);
            Controls.Add(mainTaskPanel);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pomodoro Manager";
            Load += Form1_Load;
            Click += Form1_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)taskCountNumericUpDown).EndInit();
            timerPanel.ResumeLayout(false);
            timerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer formTimer;
        private FlowLayoutPanel mainTaskPanel;
        private Panel panel1;
        private TextBox nameTextBox;
        private Button addTaskButton;
        private NumericUpDown taskCountNumericUpDown;
        private Panel timerPanel;
        private Label timerLabel;
    }
}