using Pomodoro_Manager.Model;
using System.Windows.Forms;

namespace Pomodoro_Manager
{
    public partial class Form1 : Form
    {
        string _nameTextBoxPlaceholder;
        TimerController _timerController;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _timerController = new TimerController(timerPanel, timerLabel, formTimer, this);

            mainTaskPanel.HorizontalScroll.Maximum = 0;
            mainTaskPanel.AutoScroll = true;
            _nameTextBoxPlaceholder = nameTextBox.Text;
        }

        private void MainTaskPanel_Resize(object sender, EventArgs e)
        {
            TaskResizer.ResizeTasks(mainTaskPanel);
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (nameTextBox.Text == _nameTextBoxPlaceholder)
                nameTextBox.Text = string.Empty;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
                nameTextBox.Text = _nameTextBoxPlaceholder;
        }
        void NumericUpDown_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && taskCountNumericUpDown.Value <= taskCountNumericUpDown.Maximum - 5)
            {
                taskCountNumericUpDown.Value += 2;
            }
            else if (e.Delta < 0 && taskCountNumericUpDown.Value >= taskCountNumericUpDown.Minimum + 5)
            {
                taskCountNumericUpDown.Value -= 2;
            }
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            TaskFormObject task = new TaskFormObject(
                nameTextBox.Text, (int)taskCountNumericUpDown.Value);
            TaskController.AddToPanel(task, mainTaskPanel, _timerController);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}