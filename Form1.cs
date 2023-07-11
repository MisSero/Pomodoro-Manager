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
        TaskResizer _taskResizer;
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
            _timerController = new TimerController(MainTabControl, timerLabel, formTimer, this);
            _inputPanelController = new InputPanelController(nameTextBox.Text,
                nameTextBox, taskCountNumericUpDown);
            _saveController = new SaveController();
            _taskResizer = new TaskResizer(MainTaskPanel);
            _menuPanelController = new MenuPanelController(MainTabControl, ArchiveButton);

            _mainTaskController = new MainTaskController(MainTaskPanel, _timerController,
                nameTextBox, taskCountNumericUpDown, addTaskButton, _saveController.Tasks,
                MainTaskContextMenu);
            _archiveTaskControlle = new ArchiveTaskController(ArchivePanel, _timerController,
                nameTextBox, _saveController.Tasks, ArchiveTaskContextMenu);
            _mainContextMenu = new TaskContextMenuController(MainTaskContextMenu, _mainTaskController);
            _archiveContextMenu = new TaskContextMenuController(ArchiveTaskContextMenu, _archiveTaskControlle);

            _mainTaskController.AnotherController = _archiveTaskControlle;
            _archiveTaskControlle.AnotherController = _mainTaskController;

            MainTaskPanel.HorizontalScroll.Maximum = 0;
            MainTaskPanel.AutoScroll = true;
            ArchivePanel.HorizontalScroll.Maximum = 0;
            ArchivePanel.AutoScroll = true;

        }
        private void Form1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
        private void Form1_Closing(object sender, EventArgs e)
        {
            _saveController.Save();
        }
    }
}