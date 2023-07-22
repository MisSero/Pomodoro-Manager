using Pomodoro_Manager.Model;
using Pomodoro_Manager.ViewModel;
namespace Pomodoro_Manager;

public partial class SettingsForm : Form
{
    public SettingsForm(Settings settings)
    {
        InitializeComponent();
        SettingsFormController settingsController = new(this, PomodoroDurationUpDown,
            PomodoroDutationPattern30, PomodoroDutationPattern60, CancelSettingsButton,
            SaveSettingsButton, settings, GithubLinkLabel);
    }
}
