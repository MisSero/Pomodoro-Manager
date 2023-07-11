using Pomodoro_Manager.Model;
namespace Pomodoro_Manager.ViewModel;

public class TaskContextMenuController
{
    private TaskController _taskController;
    public TaskContextMenuController(ContextMenuStrip contextMenuStrip, TaskController taskController)
    {
        _taskController = taskController;

        contextMenuStrip.Items[0].Click += DeleteTask;
        contextMenuStrip.Items[1].Click += MoveTask;
    }

    private void DeleteTask(object? sender, EventArgs e)
    {
        ToolStripMenuItem? clickedItem = sender as ToolStripMenuItem;
        ContextMenuStrip contextMenu = (ContextMenuStrip)clickedItem!.GetCurrentParent();
        Control? sourceControl = contextMenu.SourceControl;
        _taskController.DeleteTask((TaskFormObject)sourceControl!.DataContext!);
        sourceControl!.Parent!.Controls.Remove(sourceControl);
    }
    private void MoveTask(object? sender, EventArgs e)
    {
        ToolStripMenuItem? clickedItem = sender as ToolStripMenuItem;
        ContextMenuStrip contextMenu = (ContextMenuStrip)clickedItem!.GetCurrentParent();
        Control? sourceControl = contextMenu.SourceControl;
        _taskController.ChangePanel((TaskFormObject)sourceControl!.DataContext!);
        sourceControl!.Parent!.Controls.Remove(sourceControl); // delete from panel
    }
}
