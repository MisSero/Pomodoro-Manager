namespace Pomodoro_Manager.ViewModel;

public class MenuPanelController
{
    TabControl _tabControl;

    public MenuPanelController(TabControl tabControl, Button arhciveButton)
    {
        _tabControl = tabControl;
        arhciveButton.Click += AchiveOpen;
    }

    public void AchiveOpen(object sender, EventArgs e)
    {
        _tabControl.SelectedTab = _tabControl.TabPages[1];
    }
}
