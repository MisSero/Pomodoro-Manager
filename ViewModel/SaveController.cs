using Pomodoro_Manager.Model;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace Pomodoro_Manager.ViewModel
{
    public class SaveController
    {
        private string _pathDirectory;
        private string _fileName = "save.xml";
        private DataKeeper _dataKeeper;
        public List<TaskFormObject> MainTasks { private set; get; }
        public List<TaskFormObject> ArchiveTasks { private set; get; }
        public Settings AppSettings { private set; get; }
        public Progress UserProgress { private set; get; }


        public SaveController()
        {
            _pathDirectory = Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments) + @"\Pomodoro Manager\";
            Load();
        }
        
        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataKeeper));
            using (StreamWriter streamWriter = new StreamWriter(_pathDirectory + _fileName))
            {
                xmlSerializer.Serialize(streamWriter, _dataKeeper);
            }
        }
        private void Load()
        {
            if (!Directory.Exists(_pathDirectory))
            {
                Directory.CreateDirectory(_pathDirectory);
            }

            if (File.Exists(_pathDirectory + _fileName))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataKeeper));
                using (StreamReader streamReader = new StreamReader(_pathDirectory + _fileName))
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
            AppSettings = _dataKeeper!.AppSettings;
            UserProgress = _dataKeeper!.UserProgress;
        }
    }
}
