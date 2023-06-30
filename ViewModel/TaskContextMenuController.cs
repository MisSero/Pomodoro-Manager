using Pomodoro_Manager.Model;
namespace Pomodoro_Manager.ViewModel;

public class TaskContextMenuController
{
    TaskController _taskController;
    public TaskContextMenuController(ContextMenuStrip contextMenuStrip, TaskController taskController)
    {
        _taskController = taskController;

        contextMenuStrip.Items.Find("Delete", false)[0].Click += DeleteTask;
    }

    private void DeleteTask(object sender, EventArgs e)
    {
        ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
        ContextMenuStrip contextMenu = (ContextMenuStrip)clickedItem.GetCurrentParent();
        Control sourceControl = contextMenu.SourceControl;
        _taskController.DeleteTask((TaskFormObject)sourceControl.DataContext);
        sourceControl.Parent.Controls.Remove(sourceControl);
    }
}
