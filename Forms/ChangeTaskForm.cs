using Pomodoro_Manager.Model;
using Pomodoro_Manager.ViewModel;
namespace Pomodoro_Manager
{
    public partial class ChangeTaskForm : Form
    {
        private TaskFormObject _task;
        private InputPanelController _inputPanelController;
        public ChangeTaskForm(TaskFormObject task)
        {
            InitializeComponent();

            _inputPanelController = new InputPanelController(ChangeNumericUpDown);
            _task = task;

            ChangeTextBox.Text = _task.Name;
            ChangeNumericUpDown.Value = _task.GoalCounter;
        }

        private void CanсelChangeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveChangeButton_Click(object sender, EventArgs e)
        {
            _task.Name = ChangeTextBox.Text;
            _task.GoalCounter = (int)ChangeNumericUpDown.Value;
            this.Close();
        }
    }
}
