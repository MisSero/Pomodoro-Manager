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
        private ContextMenuStrip _contextMenuStrip;
      
        public TaskController(Panel mainPanel, TimerController timerController, TextBox nameTextBox,
            NumericUpDown taskCountNumeric, Button addButton, List<TaskFormObject> tasks,
            ContextMenuStrip contextMenuStrip)
        {
            _tasks = tasks;
            _mainPanel = mainPanel;
            _timerController = timerController;
            _nameTextBox = nameTextBox;
            _taskCountNumericUpDown = taskCountNumeric;
            _addButton = addButton;
            _contextMenuStrip = contextMenuStrip;

            _addButton.Click += CreateTask;

            LoadTasks();
        }
        public void DeleteTask(TaskFormObject task) => _tasks.Remove(task);
        private void CreateTask(object sender, EventArgs e)
        {
            TaskFormObject task = new TaskFormObject(
                _nameTextBox.Text, (int)_taskCountNumericUpDown.Value);
            _tasks.Add(task);
            AddToPanel(task);

            // update TextBox and NumericUpDown
            _nameTextBox.Focus();
            _nameTextBox.Text = "";
            _taskCountNumericUpDown.Value = _taskCountNumericUpDown.Minimum;
            ((Button)sender).Focus();
        }
        private void LoadTasks()
        {
            foreach (TaskFormObject task in _tasks)
                AddToPanel(task);
        }
        private void AddToPanel(TaskFormObject task)
        {
            int panelTaskWidth = _mainPanel.Width - 30;
            int panelTaskHeight = 33;

            Label taskLabel = new Label();
            taskLabel.DataBindings.Add(new Binding("Text", task, "Name", 
                false, DataSourceUpdateMode.OnPropertyChanged));
            taskLabel.AutoSize = true;
            taskLabel.Font = new Font("Malgun Gothic", 12);
            taskLabel.TextAlign = ContentAlignment.MiddleLeft;

            Button button = new Button();
            button.Text = "Play!";
            button.Dock = DockStyle.Right;
            button.Click += _timerController.PlayButton_Click;

            Label labelCounter = new Label();
            labelCounter.DataBindings.Add(new Binding("Text", task, "DisplayCounter", 
                false, DataSourceUpdateMode.OnPropertyChanged));
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
            taskPanel.DataContext = task;
            taskPanel.ContextMenuStrip = _contextMenuStrip;

            _mainPanel.Controls.Add(taskPanel);
        }
    }
}
