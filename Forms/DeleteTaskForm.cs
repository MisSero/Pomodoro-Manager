using System.Threading.Tasks;

namespace Pomodoro_Manager;

public partial class DeleteTaskForm : Form
{
    public DeleteTaskForm(string taskName)
    {
        InitializeComponent();

        DeleteTaskYes.DialogResult = DialogResult.Yes;
        DeleteTaskNo.DialogResult = DialogResult.No;

        DeleteTaskLabel.Text = $"Are you sure you want to " +
            $"delete the \"{taskName}\" task?";
    }
}
