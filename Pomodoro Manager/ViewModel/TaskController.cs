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
        private Button _addButton;
        public TaskController(Panel mainPanel, TimerController timerController,
            TextBox nameTextBox, NumericUpDown taskCountNumeric, Button addButton)
        {
            _tasks = new List<TaskFormObject>();
            _mainPanel = mainPanel;
            _timerController = timerController;
            _nameTextBox = nameTextBox;
            _taskCountNumericUpDown = taskCountNumeric;
            _addButton = addButton;

            _addButton.Click += CreateTask;
        }
        private void CreateTask(object sender, EventArgs e)
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
            taskLabel.DataBindings.Add(new Binding("Text", task, "Name"));
            taskLabel.AutoSize = true;
            taskLabel.Font = new Font("Malgun Gothic", 12);
            taskLabel.TextAlign = ContentAlignment.MiddleLeft;

            Button button = new Button();
            button.Text = "Play!";
            button.Dock = DockStyle.Right;
            button.Click += _timerController.PlayButton_Click;

            Label labelCounter = new Label();
            labelCounter.DataBindings.Add(new Binding("Text", task, "DisplayCounter"));
            labelCounter.Dock = DockStyle.Right;
            labelCounter.AutoSize = true;
            labelCounter.Font = new Font("Malgun Gothic", 12);
            labelCounter.TextAlign = ContentAlignment.MiddleLeft;


            Panel taskPanel = new Panel();
            taskPanel.Size = new Size(panelTaskWidth, panelTaskHeight);
            taskPanel.Padding = new Padding(1);
            taskPanel.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            taskPanel.BorderStyle = BorderStyle.FixedSingle;
            taskPanel.Controls.Add(labelCounter);
            taskPanel.Controls.Add(button);
            taskPanel.Controls.Add(taskLabel);

            _mainPanel.Controls.Add(taskPanel);
        }
    }
}
