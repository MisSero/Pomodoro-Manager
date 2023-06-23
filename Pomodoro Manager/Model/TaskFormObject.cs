namespace Pomodoro_Manager.Model
{
    public class TaskFormObject
    {
        private int _goalCounter;
        private int _currentCounter;
        private string _displayCounter;
        public string Name { get; set; }
        public int GoalCounter
        {
            get => _goalCounter;
            set
            {
                _goalCounter = value;
                DisplayCounter = "";
            }
        }
        public int CurrentCounter
        {
            get => _currentCounter;
            set
            {
                _currentCounter = value;
                DisplayCounter = "";
            }
        }
        public string DisplayCounter
        {
            get => _displayCounter;
            set => _displayCounter = $"{CurrentCounter}/{GoalCounter}";
        }

        public TaskFormObject(string name, int pomodoroCounter)
        {
            Name = name;
            GoalCounter = pomodoroCounter;
        }
    }
}
