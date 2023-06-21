using Pomodoro_Manager.Model;
using System.Windows.Forms;

namespace Pomodoro_Manager
{
    public partial class Form1 : Form
    {
        string _nameTextBoxPlaceholder;
        PomodoroTimer? _pomodoroTimer;
        AudioPlayer _audioPlayer = new AudioPlayer();
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            mainTaskPanel.HorizontalScroll.Maximum = 0;
            mainTaskPanel.AutoScroll = true;
            _nameTextBoxPlaceholder = nameTextBox.Text;
        }

        private void FormTimer_Tick(object sender, EventArgs e)
        {
            label1.Text = _pomodoroTimer?.ToString();
            _pomodoroTimer?.SubSecond();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (!FormTimer.Enabled)
            {
                _pomodoroTimer = new PomodoroTimer(1, FinishTask);
                FormTimer.Enabled = true;
            }
            else
                FormTimer.Enabled = false;
        }

        private void FinishTask()
        {
            FormTimer.Enabled = false;
            _pomodoroTimer = null;
            label1.Text = "End of Timer";
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            else
                this.Activate();
            _audioPlayer.Play();
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
            TaskController.AddToPanel(task, mainTaskPanel, this);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}