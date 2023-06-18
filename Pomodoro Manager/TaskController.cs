using Pomodoro_Manager.Model;
namespace Pomodoro_Manager
{
    public static class TaskController
    {
        public static void AddToPanel(TaskFormObject task, Panel panel, Form1 form)
        {
            int panelTaskWidth = panel.Width - 30;
            int panelTaskHeight = 33;

            Label taskLabel = new Label();
            taskLabel.Text = task.Name;
            taskLabel.AutoSize = true;
            taskLabel.Font = new Font("Malgun Gothic", 12);
            taskLabel.TextAlign = ContentAlignment.MiddleLeft;

            Button button = new Button();
            button.Text = "Play!";
            button.Dock = DockStyle.Right;
            button.Click += form.button1_Click;


            Panel taskPanel = new Panel();
            taskPanel.Size = new Size(panelTaskWidth, panelTaskHeight);
            taskPanel.Padding = new Padding(1);
            taskPanel.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            taskPanel.BorderStyle = BorderStyle.FixedSingle;
            taskPanel.Controls.Add(button);
            taskPanel.Controls.Add(taskLabel);
            
            panel.Controls.Add(taskPanel);
        }
    }
}
