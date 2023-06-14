namespace Pomodoro_Manager.Model
{
    public class TaskFormObject
    {
        public string Name { get; set; }
        public int PomodoroCounter { get; set; }

        public TaskFormObject(string name, int pomodoroCounter)
        {
            Name = name;
            PomodoroCounter = pomodoroCounter;
        }
    }
}
