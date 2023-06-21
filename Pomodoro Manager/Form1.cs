using Pomodoro_Manager.Model;
using Pomodoro_Manager.ViewModel;

namespace Pomodoro_Manager
{
    public partial class Form1 : Form
    {
        TimerController _timerController;
        InputPanelController _inputPanelController;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _timerController = new TimerController(timerPanel, timerLabel, formTimer, this);
            _inputPanelController = new InputPanelController(nameTextBox.Text, 
                nameTextBox, taskCountNumericUpDown);

            mainTaskPanel.HorizontalScroll.Maximum = 0;
            mainTaskPanel.AutoScroll = true;
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void MainTaskPanel_Resize(object sender, EventArgs e)
        {
            TaskResizer.ResizeTasks(mainTaskPanel);
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            TaskFormObject task = new TaskFormObject(
                nameTextBox.Text, (int)taskCountNumericUpDown.Value);
            TaskController.AddToPanel(task, mainTaskPanel, _timerController);
        }
    }
}