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
            button1 = new Button();
            FormTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            mainTaskPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            addTaskButton = new Button();
            taskCountNumericUpDown = new NumericUpDown();
            nameTextBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taskCountNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(59, 330);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormTimer
            // 
            FormTimer.Interval = 25;
            FormTimer.Tick += FormTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 233);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(965, 587);
            Controls.Add(panel1);
            Controls.Add(mainTaskPanel);
            Controls.Add(label1);
            Controls.Add(button1);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private System.Windows.Forms.Timer FormTimer;
        private Label label1;
        private FlowLayoutPanel mainTaskPanel;
        private Panel panel1;
        private TextBox nameTextBox;
        private Button addTaskButton;
        private NumericUpDown taskCountNumericUpDown;
    }
}