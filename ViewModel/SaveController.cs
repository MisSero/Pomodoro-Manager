using Pomodoro_Manager.Model;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace Pomodoro_Manager.ViewModel
{
    public class SaveController
    {
        private string _path;
        private DataKeeper _dataKeeper;
        public List<TaskFormObject> MainTasks { private set; get; }
        public List<TaskFormObject> ArchiveTasks { private set; get; }

        public SaveController()
        {
            _path = Application.StartupPath + @"save.xml";

            Load();
        }
        
        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataKeeper));
            using (StreamWriter streamWriter = new StreamWriter(_path))
            {
                xmlSerializer.Serialize(streamWriter, _dataKeeper);
            }
        }
        private void Load()
        {
            if (File.Exists(_path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataKeeper));
                using (StreamReader streamReader = new StreamReader(_path))
                {
                    _dataKeeper = (DataKeeper)xmlSerializer.Deserialize(streamReader);
                }
            }
            else
            {
                _dataKeeper = new DataKeeper();
            }
            MainTasks = _dataKeeper!.MainTasks;
            ArchiveTasks = _dataKeeper!.ArchiveTasks;
        }
    }
}
