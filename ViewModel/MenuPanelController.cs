using Pomodoro_Manager.Enums;
using Pomodoro_Manager.Model;

namespace Pomodoro_Manager.ViewModel;

public class MenuPanelController
{
    private TabControl _tabControl;
    private Settings _settings;
    private Progress _progress;
    private Label _progressTimeLabel;
    private Label _taskCompletedLabel;
    public bool AllowTabSelection { get; set; } = false;

    public MenuPanelController(TabControl tabControl, Button arhciveButton,
        Button settingsButton, SaveController saveController, Button progressButton,
        Button backFromArchive, Button backFromProgress, Label progressTimeLabel,
        Label taskCompletedLabel)
    {
        _tabControl = tabControl;
        _settings = saveController.AppSettings;
        _progress = saveController.UserProgress;
        _progressTimeLabel = progressTimeLabel;
        _taskCompletedLabel = taskCompletedLabel;

        _tabControl.Selecting += PageSelecting;
        arhciveButton.Click += AchiveOpen;
        progressButton.Click += ProgressOpen;
        settingsButton.Click += SettingsOpen;
        backFromArchive.Click += MainOpen;
        backFromProgress.Click += MainOpen;
    }
    private void MainOpen(object? sender, EventArgs e)
    {
        AllowTabSelection = true;
        _tabControl.SelectedTab = _tabControl
            .TabPages[(int)TabPagesEnum.MainPage];
        AllowTabSelection = false;
    }
    private void AchiveOpen(object? sender, EventArgs e)
    {
        AllowTabSelection = true;
        _tabControl.SelectedTab = _tabControl
            .TabPages[(int)TabPagesEnum.ArchivePage];
        AllowTabSelection = false;
    }
    private void ProgressOpen(object? sender, EventArgs e)
    {
        int minutes = (int)(_progress.MinutesAtWork % 60);
        ulong hours = _progress.MinutesAtWork / 60;
        _progressTimeLabel.Text = $"{hours:00}:{minutes:00}";
        _taskCompletedLabel.Text = _progress.CompletedTasks.ToString();

        AllowTabSelection = true;
        _tabControl.SelectedTab = _tabControl
            .TabPages[(int)TabPagesEnum.ProgressPage];
        AllowTabSelection = false;
    }
    private void SettingsOpen(object? sender, EventArgs e)
    {
        SettingsForm settingsForm = new SettingsForm(_settings);
        settingsForm.ShowDialog();
    }
    private void PageSelecting(object? sender, TabControlCancelEventArgs e)
    {
        if (!AllowTabSelection)
        {
            e.Cancel = true;
        }
    }
}
