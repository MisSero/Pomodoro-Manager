using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Pomodoro_Manager.Model;
[Serializable]
public class DataKeeper
{
    public List<TaskFormObject> MainTasks { set; get; } = new();
    public List<TaskFormObject> ArchiveTasks { set; get; } = new();
    public Settings AppSettings { get; set; } = new();
}
