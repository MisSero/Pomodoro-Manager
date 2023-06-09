using System.Text;
using Pomodoro_Manager.Model;

namespace Pomodoro_Manager
{
    public partial class Form1 : Form
    {
        PomodoroTimer? pomodoroTimer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pomodoroTimer = new PomodoroTimer(1, FinishTask);
        }

        private void FormTimer_Tick(object sender, EventArgs e)
        {
            label1.Text = pomodoroTimer?.ToString();
            pomodoroTimer?.SubSecond();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!FormTimer.Enabled)
                FormTimer.Enabled = true;
            else
                FormTimer.Enabled = false;
        }

        private void FinishTask()
        {
            FormTimer.Enabled = false;
            pomodoroTimer = null;
            label1.Text = "End of Timer";
        }
    }
}