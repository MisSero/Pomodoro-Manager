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
            mainTaskPanel = new Panel();
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
            mainTaskPanel.BorderStyle = BorderStyle.FixedSingle;
            mainTaskPanel.ForeColor = SystemColors.ControlText;
            mainTaskPanel.Location = new Point(191, 147);
            mainTaskPanel.Name = "mainTaskPanel";
            mainTaskPanel.RightToLeft = RightToLeft.No;
            mainTaskPanel.Size = new Size(630, 365);
            mainTaskPanel.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(965, 587);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private System.Windows.Forms.Timer FormTimer;
        private Label label1;
        private Panel mainTaskPanel;
    }
}