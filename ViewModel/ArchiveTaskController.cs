using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pomodoro_Manager.Model;
namespace Pomodoro_Manager.ViewModel;
public class ArchiveTaskController : TaskController
{
    public ArchiveTaskController(Panel panel, TimerController timerController,
            TextBox nameTextBox, List<TaskFormObject> tasks, ContextMenuStrip contextMenuStrip) 
        : base(panel, timerController, nameTextBox, tasks, contextMenuStrip)
    {
        LoadTasks();
    }

    protected override void AddToPanel(TaskFormObject task)
    {
        Panel taskPanel = CreateTaskPanel(task);

        _tasksPanel.Controls.Add(taskPanel);
    }
}