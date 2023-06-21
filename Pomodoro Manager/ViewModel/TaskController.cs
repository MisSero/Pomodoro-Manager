using Pomodoro_Manager.Model;

namespace Pomodoro_Manager.ViewModel
{
    public class TaskController
    {
        private List<TaskFormObject> _tasks;
        private Panel _mainPanel;
        private TimerController _timerController;
        private TextBox _nameTextBox;
        private NumericUpDown _taskCountNumericUpDown;
        public TaskController(Panel mainPanel, TimerController timerController,
            TextBox nameTextBox, NumericUpDown taskCountNumeric)
        {
            _mainPanel = mainPanel;
            _timerController = timerController;
            _nameTextBox = nameTextBox;
            _taskCountNumericUpDown = taskCountNumeric;

            _tasks = new List<TaskFormObject>();
        }
        public void CreateTask(object sender, EventArgs e)
        {
            TaskFormObject task = new TaskFormObject(
                _nameTextBox.Text, (int)_taskCountNumericUpDown.Value);
            _tasks.Add(task);
            AddToPanel(task);
        }
        private void AddToPanel(TaskFormObject task)
        {
            int panelTaskWidth = _mainPanel.Width - 30;
            int panelTaskHeight = 33;

            Label taskLabel = new Label();
            taskLabel.Text = task.Name;
            taskLabel.AutoSize = true;
            taskLabel.Font = new Font("Malgun Gothic", 12);
            taskLabel.TextAlign = ContentAlignment.MiddleLeft;

            Button button = new Button();
            button.Text = "Play!";
            button.Dock = DockStyle.Right;
            button.Click += _timerController.PlayButton_Click;


            Panel taskPanel = new Panel();
            taskPanel.Size = new Size(panelTaskWidth, panelTaskHeight);
            taskPanel.Padding = new Padding(1);
            taskPanel.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            taskPanel.BorderStyle = BorderStyle.FixedSingle;
            taskPanel.Controls.Add(button);
            taskPanel.Controls.Add(taskLabel);

            _mainPanel.Controls.Add(taskPanel);
        }
    }
}
