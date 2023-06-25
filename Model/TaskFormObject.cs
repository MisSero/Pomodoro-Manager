using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Pomodoro_Manager.Model
{
    [Serializable]
    public class TaskFormObject : INotifyPropertyChanged
    {
        [field:NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        private string _name;
        private int _goalCounter;
        private int _currentCounter;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public int GoalCounter
        {
            get => _goalCounter;
            set
            {
                _goalCounter = value;
                OnPropertyChanged("DisplayCounter");
            }
        }
        public int CurrentCounter
        {
            get => _currentCounter;
            set
            {
                _currentCounter = value;
                OnPropertyChanged("DisplayCounter");
            }
        }
        public string DisplayCounter
        {
            get => $"{CurrentCounter}/{GoalCounter}";
        }
        public TaskFormObject() { }

        public TaskFormObject(string name, int pomodoroCounter)
        {
            Name = name;
            GoalCounter = pomodoroCounter;
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
