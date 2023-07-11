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
            inputPanel = new Panel();
            TaskContextMenu = new ContextMenuStrip(components);
            Delete = new ToolStripMenuItem();
            addTaskButton = new Button();
            taskCountNumericUpDown = new NumericUpDown();
            nameTextBox = new TextBox();
            ArchiveButton = new Button();
            MenuPanel = new Panel();
            MainTabControl = new TabControl();
            MainPage = new TabPage();
            ArchivePage = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            TimerPage = new TabPage();
            timerLabel = new Label();
            moveFromtoArchiveToolStripMenuItem = new ToolStripMenuItem();
            inputPanel.SuspendLayout();
            TaskContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taskCountNumericUpDown).BeginInit();
            MenuPanel.SuspendLayout();
            MainTabControl.SuspendLayout();
            MainPage.SuspendLayout();
            ArchivePage.SuspendLayout();
            TimerPage.SuspendLayout();
            SuspendLayout();
            // 
            // formTimer
            // 
            formTimer.Interval = 25;
            // 
            // mainTaskPanel
            // 
            mainTaskPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainTaskPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainTaskPanel.BorderStyle = BorderStyle.FixedSingle;
            mainTaskPanel.FlowDirection = FlowDirection.TopDown;
            mainTaskPanel.Location = new Point(207, 177);
            mainTaskPanel.Name = "mainTaskPanel";
            mainTaskPanel.Size = new Size(635, 187);
            mainTaskPanel.TabIndex = 0;
            mainTaskPanel.WrapContents = false;
            // 
            // inputPanel
            // 
            inputPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputPanel.BorderStyle = BorderStyle.FixedSingle;
            inputPanel.ContextMenuStrip = TaskContextMenu;
            inputPanel.Controls.Add(addTaskButton);
            inputPanel.Controls.Add(taskCountNumericUpDown);
            inputPanel.Controls.Add(nameTextBox);
            inputPanel.Location = new Point(207, 103);
            inputPanel.Name = "inputPanel";
            inputPanel.Size = new Size(635, 38);
            inputPanel.TabIndex = 3;
            // 
            // TaskContextMenu
            // 
            TaskContextMenu.ImageScalingSize = new Size(20, 20);
            TaskContextMenu.Items.AddRange(new ToolStripItem[] { Delete, moveFromtoArchiveToolStripMenuItem });
            TaskContextMenu.Name = "contextMenuStrip1";
            TaskContextMenu.Size = new Size(223, 80);
            // 
            // Delete
            // 
            Delete.Name = "Delete";
            Delete.Size = new Size(222, 24);
            Delete.Text = "Delete";
            // 
            // addTaskButton
            // 
            addTaskButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addTaskButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            addTaskButton.Location = new Point(574, 1);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(56, 34);
            addTaskButton.TabIndex = 5;
            addTaskButton.Text = "Add";
            addTaskButton.UseVisualStyleBackColor = true;
            // 
            // taskCountNumericUpDown
            // 
            taskCountNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            taskCountNumericUpDown.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            taskCountNumericUpDown.Location = new Point(349, 4);
            taskCountNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            taskCountNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            taskCountNumericUpDown.Name = "taskCountNumericUpDown";
            taskCountNumericUpDown.Size = new Size(86, 30);
            taskCountNumericUpDown.TabIndex = 4;
            taskCountNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.BackColor = SystemColors.ActiveBorder;
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.ForeColor = Color.DimGray;
            nameTextBox.Location = new Point(3, 3);
            nameTextBox.MaxLength = 60;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(340, 32);
            nameTextBox.TabIndex = 3;
            nameTextBox.Text = "Enter task name";
            // 
            // ArchiveButton
            // 
            ArchiveButton.Location = new Point(25, 93);
            ArchiveButton.Name = "ArchiveButton";
            ArchiveButton.Size = new Size(90, 88);
            ArchiveButton.TabIndex = 7;
            ArchiveButton.Text = "Archive";
            ArchiveButton.UseVisualStyleBackColor = true;
            // 
            // MenuPanel
            // 
            MenuPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            MenuPanel.BackColor = Color.Silver;
            MenuPanel.Controls.Add(ArchiveButton);
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(140, 505);
            MenuPanel.TabIndex = 8;
            // 
            // MainTabControl
            // 
            MainTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainTabControl.Controls.Add(MainPage);
            MainTabControl.Controls.Add(ArchivePage);
            MainTabControl.Controls.Add(TimerPage);
            MainTabControl.Location = new Point(-2, 2);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(905, 471);
            MainTabControl.TabIndex = 1;
            // 
            // MainPage
            // 
            MainPage.BackColor = Color.DarkGray;
            MainPage.Controls.Add(mainTaskPanel);
            MainPage.Controls.Add(inputPanel);
            MainPage.Controls.Add(MenuPanel);
            MainPage.Location = new Point(4, 29);
            MainPage.Name = "MainPage";
            MainPage.Padding = new Padding(3);
            MainPage.Size = new Size(897, 438);
            MainPage.TabIndex = 0;
            MainPage.Text = "MainPage";
            // 
            // ArchivePage
            // 
            ArchivePage.BackColor = Color.DarkGray;
            ArchivePage.Controls.Add(flowLayoutPanel1);
            ArchivePage.Location = new Point(4, 29);
            ArchivePage.Name = "ArchivePage";
            ArchivePage.Padding = new Padding(3);
            ArchivePage.Size = new Size(897, 438);
            ArchivePage.TabIndex = 1;
            ArchivePage.Text = "ArchivePage";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(207, 177);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(635, 187);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // TimerPage
            // 
            TimerPage.BackColor = Color.DarkGray;
            TimerPage.Controls.Add(timerLabel);
            TimerPage.Location = new Point(4, 29);
            TimerPage.Name = "TimerPage";
            TimerPage.Padding = new Padding(3);
            TimerPage.Size = new Size(897, 438);
            TimerPage.TabIndex = 2;
            TimerPage.Text = "TimerPage";
            // 
            // timerLabel
            // 
            timerLabel.Anchor = AnchorStyles.None;
            timerLabel.AutoSize = true;
            timerLabel.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            timerLabel.Location = new Point(364, 170);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(126, 57);
            timerLabel.TabIndex = 1;
            timerLabel.Text = "00:00";
            // 
            // moveFromtoArchiveToolStripMenuItem
            // 
            moveFromtoArchiveToolStripMenuItem.Name = "moveFromtoArchiveToolStripMenuItem";
            moveFromtoArchiveToolStripMenuItem.Size = new Size(222, 24);
            moveFromtoArchiveToolStripMenuItem.Text = "Move from/to archive";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(907, 475);
            Controls.Add(MainTabControl);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pomodoro Manager";
            FormClosing += Form1_Closing;
            Load += Form1_Load;
            Click += Form1_Click;
            inputPanel.ResumeLayout(false);
            inputPanel.PerformLayout();
            TaskContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)taskCountNumericUpDown).EndInit();
            MenuPanel.ResumeLayout(false);
            MainTabControl.ResumeLayout(false);
            MainPage.ResumeLayout(false);
            ArchivePage.ResumeLayout(false);
            TimerPage.ResumeLayout(false);
            TimerPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer formTimer;
        private FlowLayoutPanel mainTaskPanel;
        private Panel inputPanel;
        private TextBox nameTextBox;
        private Button addTaskButton;
        private NumericUpDown taskCountNumericUpDown;
        private ContextMenuStrip TaskContextMenu;
        private ToolStripMenuItem Delete;
        private Button ArchiveButton;
        private Panel MenuPanel;
        private TabControl MainTabControl;
        private TabPage MainPage;
        private TabPage ArchivePage;
        private TabPage TimerPage;
        private Label timerLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private ToolStripMenuItem moveFromtoArchiveToolStripMenuItem;
    }
}