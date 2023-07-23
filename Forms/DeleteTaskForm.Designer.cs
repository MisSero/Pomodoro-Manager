namespace Pomodoro_Manager
{
    partial class DeleteTaskForm
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
            components = new System.ComponentModel.Container();
            DeleteTaskLabel = new Label();
            DeleteTaskYes = new Button();
            DeleteTaskNo = new Button();
            DeleteToolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // DeleteTaskLabel
            // 
            DeleteTaskLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteTaskLabel.Location = new Point(12, 9);
            DeleteTaskLabel.Name = "DeleteTaskLabel";
            DeleteTaskLabel.Size = new Size(475, 92);
            DeleteTaskLabel.TabIndex = 0;
            DeleteTaskLabel.Text = "???";
            DeleteTaskLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DeleteTaskYes
            // 
            DeleteTaskYes.AccessibleDescription = "";
            DeleteTaskYes.AccessibleName = "";
            DeleteTaskYes.Anchor = AnchorStyles.None;
            DeleteTaskYes.BackgroundImage = Properties.Resources.save_icon;
            DeleteTaskYes.BackgroundImageLayout = ImageLayout.Zoom;
            DeleteTaskYes.FlatAppearance.BorderSize = 0;
            DeleteTaskYes.FlatStyle = FlatStyle.Flat;
            DeleteTaskYes.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteTaskYes.Location = new Point(444, 104);
            DeleteTaskYes.Name = "DeleteTaskYes";
            DeleteTaskYes.Size = new Size(43, 34);
            DeleteTaskYes.TabIndex = 8;
            DeleteToolTip.SetToolTip(DeleteTaskYes, "Yes");
            DeleteTaskYes.UseVisualStyleBackColor = true;
            // 
            // DeleteTaskNo
            // 
            DeleteTaskNo.Anchor = AnchorStyles.None;
            DeleteTaskNo.BackgroundImage = Properties.Resources.cancel_icon;
            DeleteTaskNo.BackgroundImageLayout = ImageLayout.Zoom;
            DeleteTaskNo.FlatAppearance.BorderSize = 0;
            DeleteTaskNo.FlatStyle = FlatStyle.Flat;
            DeleteTaskNo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteTaskNo.Location = new Point(12, 104);
            DeleteTaskNo.Name = "DeleteTaskNo";
            DeleteTaskNo.Size = new Size(43, 34);
            DeleteTaskNo.TabIndex = 9;
            DeleteTaskNo.TextImageRelation = TextImageRelation.ImageBeforeText;
            DeleteToolTip.SetToolTip(DeleteTaskNo, "No");
            DeleteTaskNo.UseVisualStyleBackColor = false;
            // 
            // DeleteTaskForm
            // 
            AcceptButton = DeleteTaskYes;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 175, 185);
            CancelButton = DeleteTaskNo;
            ClientSize = new Size(499, 150);
            ControlBox = false;
            Controls.Add(DeleteTaskYes);
            Controls.Add(DeleteTaskNo);
            Controls.Add(DeleteTaskLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeleteTaskForm";
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
        }

        #endregion

        private Label DeleteTaskLabel;
        private Button DeleteTaskYes;
        private Button DeleteTaskNo;
        private ToolTip DeleteToolTip;
    }
}