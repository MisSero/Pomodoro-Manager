using Pomodoro_Manager.Model;
namespace Pomodoro_Manager
{
    public static class TaskController
    {
        public static void AddToPanel(TaskFormObject task, Panel panel)
        {
            int panelTaskWidth = panel.Width - 30;
            int panelTaskHeight = 35;

            Label taskLabel = new Label();
            taskLabel.Text = task.Name;
            taskLabel.TextAlign = ContentAlignment.MiddleCenter;
            taskLabel.Dock = DockStyle.Left;

            Button button = new Button();
            button.Text = "button text";
            button.Dock = DockStyle.Right;

            Panel taskPanel = new Panel();
            taskPanel.Size = new Size(panelTaskWidth, panelTaskHeight);
            taskPanel.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            taskPanel.BorderStyle = BorderStyle.FixedSingle;
            taskPanel.Controls.Add(taskLabel);
            taskPanel.Controls.Add(button);
            
            panel.Controls.Add(taskPanel);
        }
    }
}
