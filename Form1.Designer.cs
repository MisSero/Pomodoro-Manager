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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            formTimer = new System.Windows.Forms.Timer(components);
            mainTaskPanel = new FlowLayoutPanel();
            inputPanel = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            addTaskButton = new Button();
            taskCountNumericUpDown = new NumericUpDown();
            nameTextBox = new TextBox();
            timerPanel = new Panel();
            timerLabel = new Label();
            ArchiveButton = new Button();
            MenuPanel = new Panel();
            ArchivePanel = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            inputPanel.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taskCountNumericUpDown).BeginInit();
            timerPanel.SuspendLayout();
            MenuPanel.SuspendLayout();
            ArchivePanel.SuspendLayout();
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
            mainTaskPanel.Location = new Point(206, 166);
            mainTaskPanel.Name = "mainTaskPanel";
            mainTaskPanel.Size = new Size(712, 384);
            mainTaskPanel.TabIndex = 0;
            mainTaskPanel.WrapContents = false;
            // 
            // inputPanel
            // 
            inputPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputPanel.BorderStyle = BorderStyle.FixedSingle;
            inputPanel.ContextMenuStrip = contextMenuStrip1;
            inputPanel.Controls.Add(addTaskButton);
            inputPanel.Controls.Add(taskCountNumericUpDown);
            inputPanel.Controls.Add(nameTextBox);
            inputPanel.Location = new Point(206, 122);
            inputPanel.Name = "inputPanel";
            inputPanel.Size = new Size(712, 38);
            inputPanel.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(123, 28);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(122, 24);
            deleteToolStripMenuItem.Text = "Delete";
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
            nameTextBox.Size = new Size(458, 32);
            nameTextBox.TabIndex = 3;
            nameTextBox.Text = "Enter task name";
            // 
            // timerPanel
            // 
            timerPanel.Controls.Add(timerLabel);
            timerPanel.Location = new Point(924, 25);
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
            MenuPanel.Location = new Point(-2, -6);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(140, 600);
            MenuPanel.TabIndex = 8;
            // 
            // ArchivePanel
            // 
            ArchivePanel.Controls.Add(flowLayoutPanel1);
            ArchivePanel.Location = new Point(163, 535);
            ArchivePanel.Name = "ArchivePanel";
            ArchivePanel.Size = new Size(965, 587);
            ArchivePanel.TabIndex = 9;
            ArchivePanel.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(206, 166);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(712, 384);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(965, 587);
            Controls.Add(ArchivePanel);
            Controls.Add(MenuPanel);
            Controls.Add(timerPanel);
            Controls.Add(inputPanel);
            Controls.Add(mainTaskPanel);
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
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)taskCountNumericUpDown).EndInit();
            timerPanel.ResumeLayout(false);
            timerPanel.PerformLayout();
            MenuPanel.ResumeLayout(false);
            ArchivePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer formTimer;
        private FlowLayoutPanel mainTaskPanel;
        private Panel inputPanel;
        private TextBox nameTextBox;
        private Button addTaskButton;
        private NumericUpDown taskCountNumericUpDown;
        private Panel timerPanel;
        private Label timerLabel;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Button ArchiveButton;
        private Panel MenuPanel;
        private Panel ArchivePanel;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}