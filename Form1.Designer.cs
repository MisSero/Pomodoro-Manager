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
            MainTaskPanel = new FlowLayoutPanel();
            inputPanel = new Panel();
            MainTaskContextMenu = new ContextMenuStrip(components);
            MainDelete = new ToolStripMenuItem();
            MainMove = new ToolStripMenuItem();
            addTaskButton = new Button();
            taskCountNumericUpDown = new NumericUpDown();
            nameTextBox = new TextBox();
            ArchiveButton = new Button();
            MenuPanel = new Panel();
            MainTabControl = new TabControl();
            MainPage = new TabPage();
            ArchivePage = new TabPage();
            ArchivePanel = new FlowLayoutPanel();
            TimerPage = new TabPage();
            timerLabel = new Label();
            ArchiveTaskContextMenu = new ContextMenuStrip(components);
            ArchiveDelete = new ToolStripMenuItem();
            ArchiveMove = new ToolStripMenuItem();
            inputPanel.SuspendLayout();
            MainTaskContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taskCountNumericUpDown).BeginInit();
            MenuPanel.SuspendLayout();
            MainTabControl.SuspendLayout();
            MainPage.SuspendLayout();
            ArchivePage.SuspendLayout();
            TimerPage.SuspendLayout();
            ArchiveTaskContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // formTimer
            // 
            formTimer.Interval = 25;
            // 
            // MainTaskPanel
            // 
            MainTaskPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainTaskPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MainTaskPanel.BorderStyle = BorderStyle.FixedSingle;
            MainTaskPanel.FlowDirection = FlowDirection.TopDown;
            MainTaskPanel.Location = new Point(207, 177);
            MainTaskPanel.Name = "MainTaskPanel";
            MainTaskPanel.Size = new Size(635, 187);
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
            inputPanel.Size = new Size(635, 38);
            inputPanel.TabIndex = 3;
            // 
            // MainTaskContextMenu
            // 
            MainTaskContextMenu.ImageScalingSize = new Size(20, 20);
            MainTaskContextMenu.Items.AddRange(new ToolStripItem[] { MainDelete, MainMove });
            MainTaskContextMenu.Name = "contextMenuStrip1";
            MainTaskContextMenu.Size = new Size(185, 52);
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
            MainPage.Controls.Add(MainTaskPanel);
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
            ArchivePage.Controls.Add(ArchivePanel);
            ArchivePage.Location = new Point(4, 29);
            ArchivePage.Name = "ArchivePage";
            ArchivePage.Padding = new Padding(3);
            ArchivePage.Size = new Size(897, 438);
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
            ArchivePanel.Size = new Size(635, 187);
            ArchivePanel.TabIndex = 2;
            ArchivePanel.WrapContents = false;
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
            // ArchiveTaskContextMenu
            // 
            ArchiveTaskContextMenu.ImageScalingSize = new Size(20, 20);
            ArchiveTaskContextMenu.Items.AddRange(new ToolStripItem[] { ArchiveDelete, ArchiveMove });
            ArchiveTaskContextMenu.Name = "contextMenuStrip1";
            ArchiveTaskContextMenu.Size = new Size(211, 80);
            // 
            // ArchiveDelete
            // 
            ArchiveDelete.Name = "ArchiveDelete";
            ArchiveDelete.Size = new Size(210, 24);
            ArchiveDelete.Text = "Delete";
            // 
            // ArchiveMove
            // 
            ArchiveMove.Name = "ArchiveMove";
            ArchiveMove.Size = new Size(210, 24);
            ArchiveMove.Text = "Move from archive";
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
            MainTaskContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)taskCountNumericUpDown).EndInit();
            MenuPanel.ResumeLayout(false);
            MainTabControl.ResumeLayout(false);
            MainPage.ResumeLayout(false);
            ArchivePage.ResumeLayout(false);
            TimerPage.ResumeLayout(false);
            TimerPage.PerformLayout();
            ArchiveTaskContextMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer formTimer;
        private FlowLayoutPanel MainTaskPanel;
        private Panel inputPanel;
        private TextBox nameTextBox;
        private Button addTaskButton;
        private NumericUpDown taskCountNumericUpDown;
        private ContextMenuStrip MainTaskContextMenu;
        private ToolStripMenuItem MainDelete;
        private Button ArchiveButton;
        private Panel MenuPanel;
        private TabControl MainTabControl;
        private TabPage MainPage;
        private TabPage ArchivePage;
        private TabPage TimerPage;
        private Label timerLabel;
        private FlowLayoutPanel ArchivePanel;
        private ToolStripMenuItem MainMove;
        private ContextMenuStrip ArchiveTaskContextMenu;
        private ToolStripMenuItem ArchiveDelete;
        private ToolStripMenuItem ArchiveMove;
    }
}