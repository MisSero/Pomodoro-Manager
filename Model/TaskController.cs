using Pomodoro_Manager.ViewModel;

namespace Pomodoro_Manager.Model
{
    public abstract class TaskController
    {
        protected List<TaskFormObject> _tasks;
        protected TextBox _nameTextBox;
        protected Panel _tasksPanel;
        protected TimerController _timerController;
        protected ContextMenuStrip _contextMenuStrip;
        public TaskController AnotherController { get; set; }

        public TaskController(Panel panel, TimerController timerController,
            TextBox nameTextBox, List<TaskFormObject> tasks, ContextMenuStrip contextMenuStrip)
        {
            _tasks = tasks;
            _tasksPanel = panel;
            _timerController = timerController;
            _nameTextBox = nameTextBox;
            _contextMenuStrip = contextMenuStrip;
        }
        public void DeleteTask(TaskFormObject task) => _tasks.Remove(task);
        public void ChangePanel(TaskFormObject task)
        {
            AnotherController._tasks.Add(task);
            DeleteTask(task);
            AnotherController.AddToPanel(task);
        }
        protected abstract void AddToPanel(TaskFormObject task);
        protected void LoadTasks()
        {
            foreach (TaskFormObject task in _tasks)
                AddToPanel(task);
        }
        protected Panel CreateTaskPanel(TaskFormObject task)
        {
            int panelTaskWidth = _tasksPanel.Width - 30;
            int panelTaskHeight = 33;

            Label taskLabel = new Label();
            taskLabel.DataBindings.Add(new Binding("Text", task, "Name",
                false, DataSourceUpdateMode.OnPropertyChanged));
            taskLabel.AutoSize = true;
            taskLabel.Font = new Font("Malgun Gothic", 12);
            taskLabel.TextAlign = ContentAlignment.MiddleLeft;

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
            taskPanel.Controls.Add(taskLabel);
            taskPanel.DataContext = task;
            taskPanel.ContextMenuStrip = _contextMenuStrip;

            taskPanel.Controls.SetChildIndex(taskLabel, 2);
            return taskPanel;
        }
    }
}
