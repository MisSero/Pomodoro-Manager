using Pomodoro_Manager.Model;
using Pomodoro_Manager.ViewModel;

namespace Pomodoro_Manager
{
    public partial class Form1 : Form
    {
        TimerController _timerController;
        InputPanelController _inputPanelController;
        TaskController _taskController;
        TaskResizer _taskResizer;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _timerController = new TimerController(timerPanel, timerLabel, formTimer, this);
            _inputPanelController = new InputPanelController(nameTextBox.Text,
                nameTextBox, taskCountNumericUpDown);
            _taskController = new TaskController(mainTaskPanel, _timerController,
                nameTextBox, taskCountNumericUpDown, addTaskButton);
            _taskResizer = new TaskResizer(mainTaskPanel);

            mainTaskPanel.HorizontalScroll.Maximum = 0;
            mainTaskPanel.AutoScroll = true;
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}