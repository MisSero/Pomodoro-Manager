namespace Pomodoro_Manager.ViewModel;

public class MenuPanelController
{
    Panel _archivePanel;

    public MenuPanelController(Panel archive, Button arhciveButton)
    {
        _archivePanel = archive;
        arhciveButton.Click += AchiveOpen;
    }

    public void AchiveOpen(object sender, EventArgs e)
    {
        _archivePanel.Enabled = true;
        _archivePanel.Visible = true;
    }
}
