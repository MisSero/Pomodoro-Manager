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
            MainTaskContextMenu = new ContextMenuStrip(components);
            MainDelete = new ToolStripMenuItem();
            MainMove = new ToolStripMenuItem();
            MainChange = new ToolStripMenuItem();
            ArchiveTaskContextMenu = new ContextMenuStrip(components);
            ArchiveDelete = new ToolStripMenuItem();
            ArchiveMove = new ToolStripMenuItem();
            ArchiveChange = new ToolStripMenuItem();
            TimerPage = new TabPage();
            TimerLabel = new Label();
            BaseImageList = new ImageList(components);
            TimerClose = new Button();
            TimerStop = new Button();
            TimerPlay = new Button();
            TimerHide = new Button();
            PickedTaskName = new Label();
            ArchivePage = new TabPage();
            ArchivePanel = new FlowLayoutPanel();
            MainPage = new TabPage();
            MainTaskPanel = new FlowLayoutPanel();
            inputPanel = new Panel();
            addTaskButton = new Button();
            taskCountNumericUpDown = new NumericUpDown();
            nameTextBox = new TextBox();
            MenuPanel = new Panel();
            ProgressButton = new Button();
            SettingsButton = new Button();
            ArchiveButton = new Button();
            MainTabControl = new TabControl();
            ProgressPage = new TabPage();
            BackFromArchive = new Button();
            BackFromProgress = new Button();
            MainTaskContextMenu.SuspendLayout();
            ArchiveTaskContextMenu.SuspendLayout();
            TimerPage.SuspendLayout();
            ArchivePage.SuspendLayout();
            MainPage.SuspendLayout();
            inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taskCountNumericUpDown).BeginInit();
            MenuPanel.SuspendLayout();
            MainTabControl.SuspendLayout();
            ProgressPage.SuspendLayout();
            SuspendLayout();
            // 
            // formTimer
            // 
            formTimer.Interval = 10;
            // 
            // MainTaskContextMenu
            // 
            MainTaskContextMenu.ImageScalingSize = new Size(20, 20);
            MainTaskContextMenu.Items.AddRange(new ToolStripItem[] { MainDelete, MainMove, MainChange });
            MainTaskContextMenu.Name = "contextMenuStrip1";
            MainTaskContextMenu.Size = new Size(185, 76);
            // 
            // MainDelete
            // 
            MainDelete.Name = "MainDelete";
            MainDelete.Size = new Size(184, 24);
            MainDelete.Text = "Delete";
            // 
            // MainMove
            // 
            MainMove.Name = "MainMove";
            MainMove.Size = new Size(184, 24);
            MainMove.Text = "Move to archive";
            // 
            // MainChange
            // 
            MainChange.Name = "MainChange";
            MainChange.Size = new Size(184, 24);
            MainChange.Text = "Change Task";
            // 
            // ArchiveTaskContextMenu
            // 
            ArchiveTaskContextMenu.ImageScalingSize = new Size(20, 20);
            ArchiveTaskContextMenu.Items.AddRange(new ToolStripItem[] { ArchiveDelete, ArchiveMove, ArchiveChange });
            ArchiveTaskContextMenu.Name = "contextMenuStrip1";
            ArchiveTaskContextMenu.Size = new Size(203, 76);
            // 
            // ArchiveDelete
            // 
            ArchiveDelete.Name = "ArchiveDelete";
            ArchiveDelete.Size = new Size(202, 24);
            ArchiveDelete.Text = "Delete";
            // 
            // ArchiveMove
            // 
            ArchiveMove.Name = "ArchiveMove";
            ArchiveMove.Size = new Size(202, 24);
            ArchiveMove.Text = "Move from archive";
            // 
            // ArchiveChange
            // 
            ArchiveChange.Name = "ArchiveChange";
            ArchiveChange.Size = new Size(202, 24);
            ArchiveChange.Text = "Change Task";
            // 
            // TimerPage
            // 
            TimerPage.BackColor = Color.DarkGray;
            TimerPage.Controls.Add(TimerLabel);
            TimerPage.Controls.Add(TimerClose);
            TimerPage.Controls.Add(TimerStop);
            TimerPage.Controls.Add(TimerPlay);
            TimerPage.Controls.Add(TimerHide);
            TimerPage.Controls.Add(PickedTaskName);
            TimerPage.Location = new Point(4, 29);
            TimerPage.Name = "TimerPage";
            TimerPage.Padding = new Padding(3);
            TimerPage.Size = new Size(928, 465);
            TimerPage.TabIndex = 2;
            TimerPage.Text = "TimerPage";
            // 
            // TimerLabel
            // 
            TimerLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TimerLabel.Font = new Font("Segoe UI", 58.2F, FontStyle.Regular, GraphicsUnit.Point);
            TimerLabel.ImageKey = "(нет)";
            TimerLabel.ImageList = BaseImageList;
            TimerLabel.Location = new Point(11, 93);
            TimerLabel.Name = "TimerLabel";
            TimerLabel.Size = new Size(910, 192);
            TimerLabel.TabIndex = 1;
            TimerLabel.Text = "00:00";
            TimerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BaseImageList
            // 
            BaseImageList.ColorDepth = ColorDepth.Depth8Bit;
            BaseImageList.ImageStream = (ImageListStreamer)resources.GetObject("BaseImageList.ImageStream");
            BaseImageList.TransparentColor = Color.Transparent;
            BaseImageList.Images.SetKeyName(0, "hide_icon.png");
            // 
            // TimerClose
            // 
            TimerClose.Anchor = AnchorStyles.Bottom;
            TimerClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TimerClose.Location = new Point(150, 300);
            TimerClose.Name = "TimerClose";
            TimerClose.Size = new Size(102, 40);
            TimerClose.TabIndex = 2;
            TimerClose.Text = "Close";
            TimerClose.UseVisualStyleBackColor = true;
            // 
            // TimerStop
            // 
            TimerStop.Anchor = AnchorStyles.Bottom;
            TimerStop.Enabled = false;
            TimerStop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TimerStop.Location = new Point(476, 300);
            TimerStop.Name = "TimerStop";
            TimerStop.Size = new Size(102, 40);
            TimerStop.TabIndex = 4;
            TimerStop.Text = "Stop";
            TimerStop.UseVisualStyleBackColor = true;
            // 
            // TimerPlay
            // 
            TimerPlay.Anchor = AnchorStyles.Bottom;
            TimerPlay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TimerPlay.Location = new Point(353, 300);
            TimerPlay.Name = "TimerPlay";
            TimerPlay.Size = new Size(102, 40);
            TimerPlay.TabIndex = 3;
            TimerPlay.Text = "Play";
            TimerPlay.UseVisualStyleBackColor = true;
            // 
            // TimerHide
            // 
            TimerHide.Anchor = AnchorStyles.Bottom;
            TimerHide.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TimerHide.Location = new Point(678, 300);
            TimerHide.Name = "TimerHide";
            TimerHide.Size = new Size(102, 40);
            TimerHide.TabIndex = 5;
            TimerHide.Text = "Hide";
            TimerHide.UseVisualStyleBackColor = true;
            // 
            // PickedTaskName
            // 
            PickedTaskName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PickedTaskName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            PickedTaskName.Location = new Point(11, 33);
            PickedTaskName.Name = "PickedTaskName";
            PickedTaskName.Size = new Size(910, 38);
            PickedTaskName.TabIndex = 6;
            PickedTaskName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ArchivePage
            // 
            ArchivePage.BackColor = Color.DarkGray;
            ArchivePage.Controls.Add(BackFromArchive);
            ArchivePage.Controls.Add(ArchivePanel);
            ArchivePage.Location = new Point(4, 29);
            ArchivePage.Name = "ArchivePage";
            ArchivePage.Padding = new Padding(3);
            ArchivePage.Size = new Size(928, 465);
            ArchivePage.TabIndex = 1;
            ArchivePage.Text = "ArchivePage";
            // 
            // ArchivePanel
            // 
            ArchivePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ArchivePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ArchivePanel.BorderStyle = BorderStyle.FixedSingle;
            ArchivePanel.FlowDirection = FlowDirection.TopDown;
            ArchivePanel.Location = new Point(207, 177);
            ArchivePanel.Name = "ArchivePanel";
            ArchivePanel.Size = new Size(650, 223);
            ArchivePanel.TabIndex = 2;
            ArchivePanel.WrapContents = false;
            // 
            // MainPage
            // 
            MainPage.BackColor = Color.DarkGray;
            MainPage.Controls.Add(MainTaskPanel);
            MainPage.Controls.Add(inputPanel);
            MainPage.Controls.Add(MenuPanel);
            MainPage.Location = new Point(4, 29);
            MainPage.Name = "MainPage";
            MainPage.Padding = new Padding(3);
            MainPage.Size = new Size(928, 465);
            MainPage.TabIndex = 0;
            MainPage.Text = "MainPage";
            MainPage.Click += MainPage_Click;
            // 
            // MainTaskPanel
            // 
            MainTaskPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainTaskPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MainTaskPanel.BorderStyle = BorderStyle.FixedSingle;
            MainTaskPanel.FlowDirection = FlowDirection.TopDown;
            MainTaskPanel.Location = new Point(207, 177);
            MainTaskPanel.Name = "MainTaskPanel";
            MainTaskPanel.Size = new Size(663, 214);
            MainTaskPanel.TabIndex = 0;
            MainTaskPanel.WrapContents = false;
            // 
            // inputPanel
            // 
            inputPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputPanel.BorderStyle = BorderStyle.FixedSingle;
            inputPanel.ContextMenuStrip = MainTaskContextMenu;
            inputPanel.Controls.Add(addTaskButton);
            inputPanel.Controls.Add(taskCountNumericUpDown);
            inputPanel.Controls.Add(nameTextBox);
            inputPanel.Location = new Point(207, 103);
            inputPanel.Name = "inputPanel";
            inputPanel.Size = new Size(663, 38);
            inputPanel.TabIndex = 3;
            // 
            // addTaskButton
            // 
            addTaskButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addTaskButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            addTaskButton.Location = new Point(599, 1);
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
            taskCountNumericUpDown.Location = new Point(374, 4);
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
            nameTextBox.Size = new Size(365, 32);
            nameTextBox.TabIndex = 3;
            nameTextBox.Text = "Enter task name";
            // 
            // MenuPanel
            // 
            MenuPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            MenuPanel.BackColor = Color.Silver;
            MenuPanel.Controls.Add(ProgressButton);
            MenuPanel.Controls.Add(SettingsButton);
            MenuPanel.Controls.Add(ArchiveButton);
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(144, 462);
            MenuPanel.TabIndex = 8;
            // 
            // ProgressButton
            // 
            ProgressButton.Location = new Point(27, 177);
            ProgressButton.Name = "ProgressButton";
            ProgressButton.Size = new Size(90, 88);
            ProgressButton.TabIndex = 9;
            ProgressButton.Text = "Progress";
            ProgressButton.UseVisualStyleBackColor = true;
            // 
            // SettingsButton
            // 
            SettingsButton.Location = new Point(27, 291);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(90, 88);
            SettingsButton.TabIndex = 8;
            SettingsButton.Text = "Settings";
            SettingsButton.UseVisualStyleBackColor = true;
            // 
            // ArchiveButton
            // 
            ArchiveButton.Location = new Point(27, 68);
            ArchiveButton.Name = "ArchiveButton";
            ArchiveButton.Size = new Size(90, 88);
            ArchiveButton.TabIndex = 7;
            ArchiveButton.Text = "Archive";
            ArchiveButton.UseVisualStyleBackColor = true;
            // 
            // MainTabControl
            // 
            MainTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainTabControl.Controls.Add(MainPage);
            MainTabControl.Controls.Add(ArchivePage);
            MainTabControl.Controls.Add(TimerPage);
            MainTabControl.Controls.Add(ProgressPage);
            MainTabControl.Location = new Point(-3, 0);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(936, 498);
            MainTabControl.TabIndex = 1;
            // 
            // ProgressPage
            // 
            ProgressPage.BackColor = Color.DarkGray;
            ProgressPage.Controls.Add(BackFromProgress);
            ProgressPage.Location = new Point(4, 29);
            ProgressPage.Name = "ProgressPage";
            ProgressPage.Padding = new Padding(3);
            ProgressPage.Size = new Size(928, 465);
            ProgressPage.TabIndex = 3;
            ProgressPage.Text = "ProgressPage";
            // 
            // BackFromArchive
            // 
            BackFromArchive.Location = new Point(11, 369);
            BackFromArchive.Name = "BackFromArchive";
            BackFromArchive.Size = new Size(90, 88);
            BackFromArchive.TabIndex = 8;
            BackFromArchive.Text = "Back";
            BackFromArchive.UseVisualStyleBackColor = true;
            // 
            // BackFromProgress
            // 
            BackFromProgress.Location = new Point(11, 369);
            BackFromProgress.Name = "BackFromProgress";
            BackFromProgress.Size = new Size(90, 88);
            BackFromProgress.TabIndex = 9;
            BackFromProgress.Text = "Back";
            BackFromProgress.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(934, 498);
            Controls.Add(MainTabControl);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pomodoro Manager";
            FormClosing += Form1_Closing;
            Load += Form1_Load;
            MainTaskContextMenu.ResumeLayout(false);
            ArchiveTaskContextMenu.ResumeLayout(false);
            TimerPage.ResumeLayout(false);
            ArchivePage.ResumeLayout(false);
            MainPage.ResumeLayout(false);
            inputPanel.ResumeLayout(false);
            inputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)taskCountNumericUpDown).EndInit();
            MenuPanel.ResumeLayout(false);
            MainTabControl.ResumeLayout(false);
            ProgressPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer formTimer;
        private ContextMenuStrip MainTaskContextMenu;
        private ToolStripMenuItem MainDelete;
        private ToolStripMenuItem MainMove;
        private ContextMenuStrip ArchiveTaskContextMenu;
        private ToolStripMenuItem ArchiveDelete;
        private ToolStripMenuItem ArchiveMove;
        private ToolStripMenuItem MainChange;
        private ToolStripMenuItem ArchiveChange;
        private TabPage TimerPage;
        private Label TimerLabel;
        private TabPage ArchivePage;
        private FlowLayoutPanel ArchivePanel;
        private TabPage MainPage;
        private FlowLayoutPanel MainTaskPanel;
        private Panel inputPanel;
        private Button addTaskButton;
        private NumericUpDown taskCountNumericUpDown;
        private TextBox nameTextBox;
        private Panel MenuPanel;
        private Button ArchiveButton;
        private TabControl MainTabControl;
        private Button TimerClose;
        private Button TimerHide;
        private Button TimerStop;
        private Button TimerPlay;
        private ImageList BaseImageList;
        private Label PickedTaskName;
        private Button SettingsButton;
        private Button ProgressButton;
        private TabPage ProgressPage;
        private Button BackFromArchive;
        private Button BackFromProgress;
    }
}