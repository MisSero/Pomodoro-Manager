using Pomodoro_Manager.Enums;
using Pomodoro_Manager.Model;

namespace Pomodoro_Manager.ViewModel;

public class MenuPanelController
{
    private TabControl _tabControl;
    private Settings _settings;

    public MenuPanelController(TabControl tabControl, Button arhciveButton,
        Button settingsButton, Settings settings)
    {
        _tabControl = tabControl;
        _settings = settings;

        arhciveButton.Click += AchiveOpen;
        settingsButton.Click += SettingsOpen;
    }

    private void AchiveOpen(object? sender, EventArgs e)
    {
        _tabControl.SelectedTab = _tabControl
            .TabPages[(int)TabPagesEnum.ArchivePage];
    }
    private void ProgressOpen(object? sender, EventArgs e)
    {
        _tabControl.SelectedTab = _tabControl
            .TabPages[(int)TabPagesEnum.ProgressPage];
    }
    private void SettingsOpen(object? sender, EventArgs e)
    {
        SettingsForm settingsForm = new SettingsForm(_settings);
        settingsForm.ShowDialog();
    }
}
