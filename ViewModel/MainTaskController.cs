using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pomodoro_Manager.Model;
using Pomodoro_Manager.ViewModel;
public class MainTaskController : TaskController
{
    private NumericUpDown _taskCountNumericUpDown;
    private Button _addButton;
    public MainTaskController(Panel panel, TimerController timerController,
            TextBox nameTextBox, NumericUpDown taskCountNumeric, Button addButton,
            List<TaskFormObject> tasks, ContextMenuStrip contextMenuStrip) : base(panel, timerController,
            nameTextBox, tasks, contextMenuStrip)
    {
        _taskCountNumericUpDown = taskCountNumeric;
        _addButton = addButton;
        _addButton.Click += CreateTask;
        LoadTasks();
    }
    private void CreateTask(object? sender, EventArgs e)
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

    protected override void AddToPanel(TaskFormObject task)
    {
        Button button = new Button();
        button.Text = "Play!";
        button.Dock = DockStyle.Right;
        button.Click += _timerController.PlayButton_Click;

        Panel taskPanel = CreateTaskPanel(task);

        taskPanel.Controls.Add(button);

        _tasksPanel.Controls.Add(taskPanel);
    }
}