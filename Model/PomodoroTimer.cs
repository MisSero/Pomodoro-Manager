namespace Pomodoro_Manager.Model
{
    public class PomodoroTimer
    {
        public delegate void PomodoroTimerEventHandler();
        public event PomodoroTimerEventHandler? TimerFinished;
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }
        
        public PomodoroTimer(int minutes, PomodoroTimerEventHandler eventHandler)
        {
            Minutes = minutes;
            Seconds = 0;
            TimerFinished += eventHandler;
        }
        public void SubSecond()
        {
            if (Minutes == 0 && Seconds == 0)
            {
                TimerFinished?.Invoke();
            }
            else
            {
                if (Seconds == 0)
                {
                    Minutes -= 1;
                    Seconds = 59;
                }
                else
                    Seconds -= 1;
            }
        }
        public override string ToString()
        {
            return $"{Minutes:00}:{Seconds:00}";
        }
    }
}
