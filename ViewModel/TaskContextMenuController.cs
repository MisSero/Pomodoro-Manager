using Pomodoro_Manager.Model;
using Pomodoro_Manager.Enums;
namespace Pomodoro_Manager.ViewModel;

public class TaskContextMenuController
{
    private TaskController _taskController;
    private Form1 _form;
    public TaskContextMenuController(ContextMenuStrip contextMenuStrip, 
        TaskController taskController, Form1 form)
    {
        _taskController = taskController;
        _form = form;

        contextMenuStrip.Items[(int)ContextMenuItems.Delete]
            .Click += DeleteTask;
        contextMenuStrip.Items[(int)ContextMenuItems.Move]
            .Click += MoveTask;
        contextMenuStrip.Items[(int)ContextMenuItems.ChangeTask]
            .Click += ChangeTask;
    }

    private void DeleteTask(object? sender, EventArgs e)
    {
        ToolStripMenuItem? clickedItem = sender as ToolStripMenuItem;
        ContextMenuStrip contextMenu = (ContextMenuStrip)clickedItem!.GetCurrentParent();
        Control? sourceControl = contextMenu.SourceControl;

        if (sourceControl?.DataContext is TaskFormObject task)
        {
            DeleteTaskForm deleteForm = new DeleteTaskForm(task.Name);
            var confirmResult = deleteForm.ShowDialog();
            
            if (confirmResult == DialogResult.Yes) 
            {
                _taskController.DeleteTask(task);
                sourceControl!.Parent!.Controls.Remove(sourceControl);
            }
        }
    }
    private void MoveTask(object? sender, EventArgs e)
    {
        ToolStripMenuItem? clickedItem = sender as ToolStripMenuItem;
        ContextMenuStrip contextMenu = (ContextMenuStrip)clickedItem!.GetCurrentParent();
        Control? sourceControl = contextMenu.SourceControl;
        _taskController.ChangePanel((TaskFormObject)sourceControl!.DataContext!);
        sourceControl!.Parent!.Controls.Remove(sourceControl); // delete from panel
    }
    private void ChangeTask(object? sender, EventArgs e)
    {
        ToolStripMenuItem? clickedItem = sender as ToolStripMenuItem;
        ContextMenuStrip contextMenu = (ContextMenuStrip)clickedItem!.GetCurrentParent();
        Control? sourceControl = contextMenu.SourceControl;

        ChangeTaskForm changeForm = new ChangeTaskForm((TaskFormObject)sourceControl?.DataContext);
        changeForm.ShowDialog();
    }
}
