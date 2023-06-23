using Pomodoro_Manager.Model;

namespace Pomodoro_Manager.ViewModel
{
    public class TimerController
    {
        private PomodoroTimer? _pomodoroTimer;
        private Panel _timerPanel;
        private Label _timerLabel;
        private System.Windows.Forms.Timer _formTimer;
        private Form1 _form;
        private AudioPlayer _audioPlayer;
        private TaskFormObject _taskSender;

        public TimerController(Panel timerPanel, Label timerLabel,
            System.Windows.Forms.Timer timer, Form1 form)
        {
            _timerPanel = timerPanel;
            _timerLabel = timerLabel;
            _form = form;
            _formTimer = timer;
            _audioPlayer = new AudioPlayer();

            timer.Tick += Timer_Tick;
        }

        public void PlayButton_Click(object sender, EventArgs e)
        {
            if (!_formTimer.Enabled)
            {
                _pomodoroTimer = new PomodoroTimer(1, FinishTask);
                _formTimer.Enabled = true;
                _timerPanel.Visible = true;
            }
            if (sender is Button button)
            {
                _taskSender = (TaskFormObject)button.Parent.DataContext;
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            _timerLabel.Text = _pomodoroTimer?.ToString();
            _pomodoroTimer?.SubSecond();
        }

        private void FinishTask()
        {
            _formTimer.Enabled = false;
            _pomodoroTimer = null;
            _timerLabel.Text = "End of Timer";
            _taskSender.CurrentCounter++;
            if (_form.WindowState == FormWindowState.Minimized)
                _form.WindowState = FormWindowState.Normal;
            else
                _form.Activate();
            _audioPlayer.Play();
            _timerPanel.Visible = false;
        }
    }
}
