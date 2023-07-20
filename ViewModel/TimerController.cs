using Pomodoro_Manager.Model;
using Pomodoro_Manager.Enums;

namespace Pomodoro_Manager.ViewModel
{
    public class TimerController
    {
        private PomodoroTimer? _pomodoroTimer;
        private MenuPanelController _menuController;
        private TabControl _tabControl;
        private Label _timerLabel;
        private Label _pickedTaskName;
        private System.Windows.Forms.Timer _formTimer;
        private Form1 _form;
        private AudioPlayer _audioPlayer;
        private TaskFormObject? _taskSender;
        private Button _playButton;
        private Button _stopButton;
        private Button _closeButton;
        private Settings _settings;
        private Progress _progress;
        private bool _isHidden = false;
        private string _timerPlaceholder;

        public TimerController(TabControl tabControl, Label timerLabel,
            System.Windows.Forms.Timer timer, Form1 form, Button playButton,
            Button stopButton, Button closeButton, Button hideButton, 
            Label pickedTaskName, SaveController saveController, 
            MenuPanelController menuController)
        {
            _tabControl = tabControl;
            _timerLabel = timerLabel;
            _form = form;
            _formTimer = timer;
            _audioPlayer = new AudioPlayer();
            _playButton = playButton;
            _stopButton = stopButton;
            _closeButton = closeButton;
            _pickedTaskName = pickedTaskName;
            _settings = saveController.AppSettings;
            _progress = saveController.UserProgress;
            _menuController = menuController;

            timer.Tick += Timer_Tick;
            _playButton.Click += Play;
            _stopButton.Click += Stop;
            _closeButton.Click += Close;
            hideButton.Click += HideShow;
        }

        public void PickTask(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                _timerPlaceholder = $"{_settings.TaskDuration:00}:00";

                _taskSender = (TaskFormObject)button.Parent.DataContext;

                _menuController.AllowTabSelection = true;
                _tabControl.SelectedTab = _tabControl
                    .TabPages[(int)TabPagesEnum.TimerPage];
                _menuController.AllowTabSelection = false;

                _timerLabel.Text = _timerPlaceholder;
                _pickedTaskName.Text = _taskSender?.Name;
                _playButton.Focus();
                
                _isHidden = false;
                _timerLabel.ImageIndex = -1;
            }
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            _pomodoroTimer?.SubSecond();
            if (!_isHidden && _pomodoroTimer != null)
                _timerLabel.Text = _pomodoroTimer.ToString();
    }

        private void CompleteTask()
        {
            _stopButton.PerformClick();

            _taskSender.CurrentCounter++;
            _progress.CompletedTasks++;
            _progress.MinutesAtWork += (ulong)_settings.TaskDuration;


            if (_form.WindowState == FormWindowState.Minimized)
                _form.WindowState = FormWindowState.Normal;
            else
            {
                _form.TopMost = true;
                _form.TopMost = false;
            }
            _form.Activate();
            _audioPlayer.Play();
        }
        private void Play(object? sender, EventArgs e)
        {
            if (_taskSender != null)
            {
                _pomodoroTimer = new PomodoroTimer(_settings.TaskDuration, CompleteTask);
                _formTimer.Enabled = true;

                _stopButton.Enabled = true;
                _playButton.Enabled = false;
                _closeButton.Enabled = false;

                _form.ActiveControl = null;
            }
        }
        private void Stop(object? sender, EventArgs e)
        {
            _formTimer.Enabled = false;
            _pomodoroTimer = null;
            if (!_isHidden)
                _timerLabel.Text = _timerPlaceholder;

            _stopButton.Enabled = false;
            _playButton.Enabled = true;
            _closeButton.Enabled = true;

            _playButton.Focus();
        }
        private void Close(object? sender, EventArgs e)
        {
            _taskSender = null;

            _menuController.AllowTabSelection = true;
            _tabControl.SelectedTab = _tabControl
                    .TabPages[(int)TabPagesEnum.MainPage];
            _menuController.AllowTabSelection = false;

            _pickedTaskName.Text = "";
        }
        private void HideShow(object? sender, EventArgs e)
        {
            if (_isHidden)
            {
                _isHidden = false;
                _timerLabel.ImageIndex = -1;
                if (_pomodoroTimer != null)
                    _timerLabel.Text = _pomodoroTimer.ToString();
                else
                    _timerLabel.Text = _timerPlaceholder;
            }
            else
            {
                _isHidden = true;
                _timerLabel.ImageIndex = 0;
                _timerLabel.Text = ""; 
            }
        }
    }
}
