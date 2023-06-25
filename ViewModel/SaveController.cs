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
        public List<TaskFormObject> Tasks { private set; get; }

        public SaveController()
        {
            _path = Application.StartupPath + @"save.xml";

            Load();
        }
        
        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<TaskFormObject>));
            using (StreamWriter streamWriter = new StreamWriter(_path))
            {
                xmlSerializer.Serialize(streamWriter, Tasks);
            }
        }
        private void Load()
        {
            if (File.Exists(_path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<TaskFormObject>));
                using (StreamReader streamReader = new StreamReader(_path))
                {
                    Tasks = (List<TaskFormObject>)xmlSerializer.Deserialize(streamReader);
                }
            }
            else
            {
                Tasks = new List<TaskFormObject>();
            }
        }
    }
}
