using System.Text;
using System.Media;
using Pomodoro_Manager.Model;
using System.Windows.Forms;

namespace Pomodoro_Manager
{
    public partial class Form1 : Form
    {
        PomodoroTimer? _pomodoroTimer;
        AudioPlayer _audioPlayer = new AudioPlayer();
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainTaskPanel.VerticalScroll.Maximum = 0;
            mainTaskPanel.AutoScroll = true;
        }

        private void FormTimer_Tick(object sender, EventArgs e)
        {
            label1.Text = _pomodoroTimer?.ToString();
            _pomodoroTimer?.SubSecond();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!FormTimer.Enabled)
            {
                _pomodoroTimer = new PomodoroTimer(1, FinishTask);
                FormTimer.Enabled = true;
            }
            else
                FormTimer.Enabled = false;


            //Test block
            TaskFormObject task = new TaskFormObject($"My task {++counter}", 15);
            TaskController.AddToPanel(task, mainTaskPanel);

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
    }
}