﻿namespace Pomodoro_Manager
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
            TimerClose = new Button();
            TimerStop = new Button();
            TimerPlay = new Button();
            TimerHide = new Button();
            PickedTaskName = new Label();
            ArchivePage = new TabPage();
            ArchiveMenuPanel = new Panel();
            ArchiveTasksLabel = new Label();
            BackFromArchive = new Button();
            ActiveTasksLabel = new Label();
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
            ProgressTimeBox = new GroupBox();
            ProgressMinutesPictureBox = new PictureBox();
            ProgressTimeLabel = new Label();
            ProgressTaskBox = new GroupBox();
            TaskCompletedPictureBox = new PictureBox();
            TaskCompletedLabel = new Label();
            BackFromProgress = new Button();
            MainTaskContextMenu.SuspendLayout();
            ArchiveTaskContextMenu.SuspendLayout();
            TimerPage.SuspendLayout();
            ArchivePage.SuspendLayout();
            ArchiveMenuPanel.SuspendLayout();
            MainPage.SuspendLayout();
            inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taskCountNumericUpDown).BeginInit();
            MenuPanel.SuspendLayout();
            MainTabControl.SuspendLayout();
            ProgressPage.SuspendLayout();
            ProgressTimeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProgressMinutesPictureBox).BeginInit();
            ProgressTaskBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TaskCompletedPictureBox).BeginInit();
            SuspendLayout();
            // 
            // formTimer
            // 
            formTimer.Interval = 1000;
            // 
            // MainTaskContextMenu
            // 
            MainTaskContextMenu.ImageScalingSize = new Size(20, 20);
            MainTaskContextMenu.Items.AddRange(new ToolStripItem[] { MainDelete, MainMove, MainChange });
            MainTaskContextMenu.Name = "contextMenuStrip1";
            MainTaskContextMenu.Size = new Size(189, 82);
            // 
            // MainDelete
            // 
            MainDelete.Image = Properties.Resources.cancel_icon;
            MainDelete.Name = "MainDelete";
            MainDelete.Size = new Size(188, 26);
            MainDelete.Text = "Delete";
            // 
            // MainMove
            // 
            MainMove.Image = Properties.Resources.toArchive_icon;
            MainMove.Name = "MainMove";
            MainMove.Size = new Size(188, 26);
            MainMove.Text = "Move to archive";
            // 
            // MainChange
            // 
            MainChange.Image = Properties.Resources.changeTask_icon;
            MainChange.Name = "MainChange";
            MainChange.Size = new Size(188, 26);
            MainChange.Text = "Change task";
            // 
            // ArchiveTaskContextMenu
            // 
            ArchiveTaskContextMenu.ImageScalingSize = new Size(20, 20);
            ArchiveTaskContextMenu.Items.AddRange(new ToolStripItem[] { ArchiveDelete, ArchiveMove, ArchiveChange });
            ArchiveTaskContextMenu.Name = "contextMenuStrip1";
            ArchiveTaskContextMenu.Size = new Size(187, 82);
            // 
            // ArchiveDelete
            // 
            ArchiveDelete.Image = Properties.Resources.cancel_icon;
            ArchiveDelete.Name = "ArchiveDelete";
            ArchiveDelete.Size = new Size(186, 26);
            ArchiveDelete.Text = "Delete";
            // 
            // ArchiveMove
            // 
            ArchiveMove.Image = Properties.Resources.fromArchive_icon;
            ArchiveMove.Name = "ArchiveMove";
            ArchiveMove.Size = new Size(186, 26);
            ArchiveMove.Text = "Return to active";
            // 
            // ArchiveChange
            // 
            ArchiveChange.Image = Properties.Resources.changeTask_icon;
            ArchiveChange.Name = "ArchiveChange";
            ArchiveChange.Size = new Size(186, 26);
            ArchiveChange.Text = "Change task";
            // 
            // TimerPage
            // 
            TimerPage.BackColor = Color.FromArgb(236, 248, 248);
            TimerPage.Controls.Add(TimerLabel);
            TimerPage.Controls.Add(TimerClose);
            TimerPage.Controls.Add(TimerStop);
            TimerPage.Controls.Add(TimerPlay);
            TimerPage.Controls.Add(TimerHide);
            TimerPage.Controls.Add(PickedTaskName);
            TimerPage.Location = new Point(4, 29);
            TimerPage.Name = "TimerPage";
            TimerPage.Padding = new Padding(3);
            TimerPage.Size = new Size(843, 543);
            TimerPage.TabIndex = 2;
            TimerPage.Text = "TimerPage";
            // 
            // TimerLabel
            // 
            TimerLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TimerLabel.Font = new Font("Comic Sans MS", 58.2F, FontStyle.Regular, GraphicsUnit.Point);
            TimerLabel.ImageKey = "(нет)";
            TimerLabel.Location = new Point(14, 104);
            TimerLabel.Name = "TimerLabel";
            TimerLabel.Size = new Size(780, 293);
            TimerLabel.TabIndex = 1;
            TimerLabel.Text = "00:00";
            TimerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TimerClose
            // 
            TimerClose.Anchor = AnchorStyles.Bottom;
            TimerClose.BackgroundImage = Properties.Resources.cancel_icon;
            TimerClose.BackgroundImageLayout = ImageLayout.Zoom;
            TimerClose.FlatStyle = FlatStyle.Flat;
            TimerClose.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TimerClose.Location = new Point(74, 400);
            TimerClose.Name = "TimerClose";
            TimerClose.Size = new Size(102, 40);
            TimerClose.TabIndex = 2;
            TimerClose.UseVisualStyleBackColor = false;
            // 
            // TimerStop
            // 
            TimerStop.Anchor = AnchorStyles.Bottom;
            TimerStop.BackColor = Color.FromArgb(220, 232, 232);
            TimerStop.BackgroundImage = Properties.Resources.stop_icon;
            TimerStop.BackgroundImageLayout = ImageLayout.Zoom;
            TimerStop.Enabled = false;
            TimerStop.FlatStyle = FlatStyle.Flat;
            TimerStop.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TimerStop.Location = new Point(432, 400);
            TimerStop.Name = "TimerStop";
            TimerStop.Size = new Size(102, 40);
            TimerStop.TabIndex = 4;
            TimerStop.UseVisualStyleBackColor = false;
            // 
            // TimerPlay
            // 
            TimerPlay.Anchor = AnchorStyles.Bottom;
            TimerPlay.BackgroundImage = Properties.Resources.play_icon;
            TimerPlay.BackgroundImageLayout = ImageLayout.Zoom;
            TimerPlay.FlatStyle = FlatStyle.Flat;
            TimerPlay.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TimerPlay.Location = new Point(295, 400);
            TimerPlay.Name = "TimerPlay";
            TimerPlay.Size = new Size(102, 40);
            TimerPlay.TabIndex = 3;
            TimerPlay.UseVisualStyleBackColor = false;
            // 
            // TimerHide
            // 
            TimerHide.Anchor = AnchorStyles.Bottom;
            TimerHide.BackgroundImage = Properties.Resources.hide_icon;
            TimerHide.BackgroundImageLayout = ImageLayout.Zoom;
            TimerHide.FlatStyle = FlatStyle.Flat;
            TimerHide.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TimerHide.Location = new Point(663, 400);
            TimerHide.Name = "TimerHide";
            TimerHide.Size = new Size(102, 40);
            TimerHide.TabIndex = 5;
            TimerHide.UseVisualStyleBackColor = false;
            // 
            // PickedTaskName
            // 
            PickedTaskName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PickedTaskName.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            PickedTaskName.Location = new Point(14, 44);
            PickedTaskName.Name = "PickedTaskName";
            PickedTaskName.Size = new Size(811, 60);
            PickedTaskName.TabIndex = 6;
            PickedTaskName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ArchivePage
            // 
            ArchivePage.BackColor = Color.FromArgb(236, 248, 248);
            ArchivePage.Controls.Add(ArchiveMenuPanel);
            ArchivePage.Controls.Add(ArchivePanel);
            ArchivePage.Location = new Point(4, 29);
            ArchivePage.Name = "ArchivePage";
            ArchivePage.Padding = new Padding(3);
            ArchivePage.Size = new Size(843, 543);
            ArchivePage.TabIndex = 1;
            ArchivePage.Text = "ArchivePage";
            // 
            // ArchiveMenuPanel
            // 
            ArchiveMenuPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ArchiveMenuPanel.BackColor = Color.FromArgb(231, 216, 201);
            ArchiveMenuPanel.Controls.Add(ArchiveTasksLabel);
            ArchiveMenuPanel.Controls.Add(BackFromArchive);
            ArchiveMenuPanel.Controls.Add(ActiveTasksLabel);
            ArchiveMenuPanel.Location = new Point(0, 0);
            ArchiveMenuPanel.Name = "ArchiveMenuPanel";
            ArchiveMenuPanel.Size = new Size(143, 524);
            ArchiveMenuPanel.TabIndex = 9;
            // 
            // ArchiveTasksLabel
            // 
            ArchiveTasksLabel.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ArchiveTasksLabel.Location = new Point(7, 237);
            ArchiveTasksLabel.Name = "ArchiveTasksLabel";
            ArchiveTasksLabel.Size = new Size(133, 101);
            ArchiveTasksLabel.TabIndex = 11;
            ArchiveTasksLabel.Text = "Archive taks: ??";
            // 
            // BackFromArchive
            // 
            BackFromArchive.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BackFromArchive.BackgroundImage = Properties.Resources.back_icon;
            BackFromArchive.BackgroundImageLayout = ImageLayout.Zoom;
            BackFromArchive.FlatAppearance.BorderSize = 0;
            BackFromArchive.FlatStyle = FlatStyle.Flat;
            BackFromArchive.Location = new Point(14, 436);
            BackFromArchive.Name = "BackFromArchive";
            BackFromArchive.Size = new Size(70, 65);
            BackFromArchive.TabIndex = 8;
            BackFromArchive.UseVisualStyleBackColor = true;
            // 
            // ActiveTasksLabel
            // 
            ActiveTasksLabel.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ActiveTasksLabel.Location = new Point(7, 61);
            ActiveTasksLabel.Name = "ActiveTasksLabel";
            ActiveTasksLabel.Size = new Size(133, 101);
            ActiveTasksLabel.TabIndex = 10;
            ActiveTasksLabel.Text = "Active taks: ??";
            // 
            // ArchivePanel
            // 
            ArchivePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ArchivePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ArchivePanel.BorderStyle = BorderStyle.FixedSingle;
            ArchivePanel.FlowDirection = FlowDirection.TopDown;
            ArchivePanel.Location = new Point(171, 29);
            ArchivePanel.Name = "ArchivePanel";
            ArchivePanel.Size = new Size(641, 469);
            ArchivePanel.TabIndex = 2;
            ArchivePanel.WrapContents = false;
            // 
            // MainPage
            // 
            MainPage.BackColor = Color.FromArgb(236, 248, 248);
            MainPage.Controls.Add(MainTaskPanel);
            MainPage.Controls.Add(inputPanel);
            MainPage.Controls.Add(MenuPanel);
            MainPage.Location = new Point(4, 29);
            MainPage.Name = "MainPage";
            MainPage.Padding = new Padding(3);
            MainPage.Size = new Size(843, 543);
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
            MainTaskPanel.Location = new Point(176, 177);
            MainTaskPanel.Name = "MainTaskPanel";
            MainTaskPanel.Size = new Size(635, 331);
            MainTaskPanel.TabIndex = 3;
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
            inputPanel.Location = new Point(176, 103);
            inputPanel.Name = "inputPanel";
            inputPanel.Size = new Size(635, 38);
            inputPanel.TabIndex = 0;
            // 
            // addTaskButton
            // 
            addTaskButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addTaskButton.BackgroundImage = Properties.Resources.add_icon;
            addTaskButton.BackgroundImageLayout = ImageLayout.Zoom;
            addTaskButton.FlatAppearance.BorderSize = 0;
            addTaskButton.FlatStyle = FlatStyle.Flat;
            addTaskButton.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            addTaskButton.Location = new Point(595, 1);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(34, 35);
            addTaskButton.TabIndex = 2;
            addTaskButton.UseVisualStyleBackColor = true;
            // 
            // taskCountNumericUpDown
            // 
            taskCountNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            taskCountNumericUpDown.BackColor = Color.White;
            taskCountNumericUpDown.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            taskCountNumericUpDown.Location = new Point(348, 4);
            taskCountNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            taskCountNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            taskCountNumericUpDown.Name = "taskCountNumericUpDown";
            taskCountNumericUpDown.Size = new Size(86, 31);
            taskCountNumericUpDown.TabIndex = 1;
            taskCountNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.BackColor = Color.White;
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.ForeColor = Color.DimGray;
            nameTextBox.Location = new Point(3, 3);
            nameTextBox.MaxLength = 60;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(338, 31);
            nameTextBox.TabIndex = 0;
            nameTextBox.Text = "Enter task name";
            // 
            // MenuPanel
            // 
            MenuPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            MenuPanel.BackColor = Color.FromArgb(231, 216, 201);
            MenuPanel.Controls.Add(ProgressButton);
            MenuPanel.Controls.Add(SettingsButton);
            MenuPanel.Controls.Add(ArchiveButton);
            MenuPanel.Location = new Point(0, -1);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(144, 541);
            MenuPanel.TabIndex = 4;
            // 
            // ProgressButton
            // 
            ProgressButton.Anchor = AnchorStyles.None;
            ProgressButton.BackgroundImage = Properties.Resources.progress_icon;
            ProgressButton.BackgroundImageLayout = ImageLayout.Zoom;
            ProgressButton.FlatAppearance.BorderSize = 0;
            ProgressButton.FlatStyle = FlatStyle.Flat;
            ProgressButton.Location = new Point(27, 223);
            ProgressButton.Name = "ProgressButton";
            ProgressButton.Size = new Size(90, 88);
            ProgressButton.TabIndex = 5;
            ProgressButton.UseVisualStyleBackColor = true;
            // 
            // SettingsButton
            // 
            SettingsButton.Anchor = AnchorStyles.None;
            SettingsButton.BackgroundImage = Properties.Resources.settings_icon;
            SettingsButton.BackgroundImageLayout = ImageLayout.Zoom;
            SettingsButton.FlatAppearance.BorderSize = 0;
            SettingsButton.FlatStyle = FlatStyle.Flat;
            SettingsButton.Location = new Point(27, 338);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(90, 88);
            SettingsButton.TabIndex = 6;
            SettingsButton.UseVisualStyleBackColor = true;
            // 
            // ArchiveButton
            // 
            ArchiveButton.Anchor = AnchorStyles.None;
            ArchiveButton.BackgroundImage = Properties.Resources.archive_icon;
            ArchiveButton.BackgroundImageLayout = ImageLayout.Zoom;
            ArchiveButton.FlatAppearance.BorderSize = 0;
            ArchiveButton.FlatStyle = FlatStyle.Flat;
            ArchiveButton.Location = new Point(27, 115);
            ArchiveButton.Name = "ArchiveButton";
            ArchiveButton.Size = new Size(90, 88);
            ArchiveButton.TabIndex = 4;
            ArchiveButton.UseVisualStyleBackColor = false;
            // 
            // MainTabControl
            // 
            MainTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainTabControl.Controls.Add(MainPage);
            MainTabControl.Controls.Add(ArchivePage);
            MainTabControl.Controls.Add(TimerPage);
            MainTabControl.Controls.Add(ProgressPage);
            MainTabControl.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MainTabControl.Location = new Point(-6, -32);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(851, 576);
            MainTabControl.TabIndex = 100;
            // 
            // ProgressPage
            // 
            ProgressPage.BackColor = Color.FromArgb(236, 248, 248);
            ProgressPage.Controls.Add(ProgressTimeBox);
            ProgressPage.Controls.Add(ProgressTaskBox);
            ProgressPage.Controls.Add(BackFromProgress);
            ProgressPage.Location = new Point(4, 29);
            ProgressPage.Name = "ProgressPage";
            ProgressPage.Padding = new Padding(3);
            ProgressPage.Size = new Size(843, 543);
            ProgressPage.TabIndex = 3;
            ProgressPage.Text = "ProgressPage";
            // 
            // ProgressTimeBox
            // 
            ProgressTimeBox.Anchor = AnchorStyles.None;
            ProgressTimeBox.Controls.Add(ProgressMinutesPictureBox);
            ProgressTimeBox.Controls.Add(ProgressTimeLabel);
            ProgressTimeBox.Font = new Font("Comic Sans MS", 18F, FontStyle.Italic, GraphicsUnit.Point);
            ProgressTimeBox.Location = new Point(448, 250);
            ProgressTimeBox.Name = "ProgressTimeBox";
            ProgressTimeBox.Size = new Size(341, 187);
            ProgressTimeBox.TabIndex = 11;
            ProgressTimeBox.TabStop = false;
            ProgressTimeBox.Text = "Time at work";
            // 
            // ProgressMinutesPictureBox
            // 
            ProgressMinutesPictureBox.Image = Properties.Resources.Clock_icon;
            ProgressMinutesPictureBox.Location = new Point(17, 72);
            ProgressMinutesPictureBox.Name = "ProgressMinutesPictureBox";
            ProgressMinutesPictureBox.Size = new Size(83, 80);
            ProgressMinutesPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ProgressMinutesPictureBox.TabIndex = 1;
            ProgressMinutesPictureBox.TabStop = false;
            // 
            // ProgressTimeLabel
            // 
            ProgressTimeLabel.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            ProgressTimeLabel.Location = new Point(95, 53);
            ProgressTimeLabel.Name = "ProgressTimeLabel";
            ProgressTimeLabel.Size = new Size(239, 115);
            ProgressTimeLabel.TabIndex = 0;
            ProgressTimeLabel.Text = "?";
            ProgressTimeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProgressTaskBox
            // 
            ProgressTaskBox.Anchor = AnchorStyles.None;
            ProgressTaskBox.Controls.Add(TaskCompletedPictureBox);
            ProgressTaskBox.Controls.Add(TaskCompletedLabel);
            ProgressTaskBox.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ProgressTaskBox.Location = new Point(59, 59);
            ProgressTaskBox.Name = "ProgressTaskBox";
            ProgressTaskBox.Size = new Size(341, 187);
            ProgressTaskBox.TabIndex = 10;
            ProgressTaskBox.TabStop = false;
            ProgressTaskBox.Text = "Completed tasks";
            // 
            // TaskCompletedPictureBox
            // 
            TaskCompletedPictureBox.Image = Properties.Resources.done_icon;
            TaskCompletedPictureBox.Location = new Point(17, 72);
            TaskCompletedPictureBox.Name = "TaskCompletedPictureBox";
            TaskCompletedPictureBox.Size = new Size(83, 80);
            TaskCompletedPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            TaskCompletedPictureBox.TabIndex = 1;
            TaskCompletedPictureBox.TabStop = false;
            // 
            // TaskCompletedLabel
            // 
            TaskCompletedLabel.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            TaskCompletedLabel.Location = new Point(95, 53);
            TaskCompletedLabel.Name = "TaskCompletedLabel";
            TaskCompletedLabel.Size = new Size(239, 115);
            TaskCompletedLabel.TabIndex = 0;
            TaskCompletedLabel.Text = "?";
            TaskCompletedLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BackFromProgress
            // 
            BackFromProgress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BackFromProgress.BackgroundImage = Properties.Resources.back_icon;
            BackFromProgress.BackgroundImageLayout = ImageLayout.Zoom;
            BackFromProgress.FlatAppearance.BorderSize = 0;
            BackFromProgress.FlatStyle = FlatStyle.Flat;
            BackFromProgress.Location = new Point(14, 433);
            BackFromProgress.Name = "BackFromProgress";
            BackFromProgress.Size = new Size(70, 65);
            BackFromProgress.TabIndex = 9;
            BackFromProgress.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(835, 516);
            Controls.Add(MainTabControl);
            ForeColor = SystemColors.ControlText;
            Icon = Properties.Resources.pomodoro_form;
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
            ArchiveMenuPanel.ResumeLayout(false);
            MainPage.ResumeLayout(false);
            inputPanel.ResumeLayout(false);
            inputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)taskCountNumericUpDown).EndInit();
            MenuPanel.ResumeLayout(false);
            MainTabControl.ResumeLayout(false);
            ProgressPage.ResumeLayout(false);
            ProgressTimeBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProgressMinutesPictureBox).EndInit();
            ProgressTaskBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TaskCompletedPictureBox).EndInit();
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
        private Label PickedTaskName;
        private Button SettingsButton;
        private Button ProgressButton;
        private TabPage ProgressPage;
        private Button BackFromArchive;
        private Button BackFromProgress;
        private GroupBox ProgressTaskBox;
        private PictureBox TaskCompletedPictureBox;
        private Label TaskCompletedLabel;
        private GroupBox ProgressTimeBox;
        private PictureBox ProgressMinutesPictureBox;
        private Label ProgressTimeLabel;
        private Panel ArchiveMenuPanel;
        private Label ArchiveTasksLabel;
        private Label ActiveTasksLabel;
    }
}