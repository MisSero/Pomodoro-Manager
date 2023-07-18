using Pomodoro_Manager.Model;
using Pomodoro_Manager.ViewModel;

namespace Pomodoro_Manager
{
    public partial class Form1 : Form
    {
        TimerController _timerController;
        InputPanelController _inputPanelController;
        MainTaskController _mainTaskController;
        ArchiveTaskController _archiveTaskControlle;
        TaskResizer _mainTaskResizer;
        TaskResizer _archiveTaskResizer;
        SaveController _saveController;
        MenuPanelController _menuPanelController;
        TaskContextMenuController _mainContextMenu;
        TaskContextMenuController _archiveContextMenu;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _saveController = new SaveController();
            _timerController = new TimerController(MainTabControl, TimerLabel, formTimer, this, TimerPlay,
                TimerStop, TimerClose, TimerHide, PickedTaskName, _saveController.AppSettings);
            _inputPanelController = new InputPanelController(nameTextBox.Text,
                nameTextBox, taskCountNumericUpDown);
            _mainTaskResizer = new TaskResizer(MainTaskPanel);
            _archiveTaskResizer = new TaskResizer(ArchivePanel);
            _menuPanelController = new MenuPanelController(MainTabControl, ArchiveButton, SettingsButton,
                _saveController.AppSettings, ProgressButton, BackFromArchive, BackFromProgress);

            _mainTaskController = new MainTaskController(MainTaskPanel, _timerController,
                nameTextBox, taskCountNumericUpDown, addTaskButton, _saveController.MainTasks,
                MainTaskContextMenu);
            _archiveTaskControlle = new ArchiveTaskController(ArchivePanel, _timerController,
                nameTextBox, _saveController.ArchiveTasks, ArchiveTaskContextMenu);
            _mainContextMenu = new TaskContextMenuController(MainTaskContextMenu, _mainTaskController, this);
            _archiveContextMenu = new TaskContextMenuController(ArchiveTaskContextMenu,
                _archiveTaskControlle, this);

            _mainTaskController.AnotherController = _archiveTaskControlle;
            _archiveTaskControlle.AnotherController = _mainTaskController;

            MainTaskPanel.HorizontalScroll.Maximum = 0;
            MainTaskPanel.AutoScroll = true;
            ArchivePanel.HorizontalScroll.Maximum = 0;
            ArchivePanel.AutoScroll = true;
        }
        private void MainPage_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
        private void Form1_Closing(object sender, EventArgs e)
        {
            _saveController.Save();
        }
    }
}