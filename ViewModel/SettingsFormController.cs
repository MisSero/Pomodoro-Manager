using Pomodoro_Manager.Model;

namespace Pomodoro_Manager.ViewModel;

public class SettingsFormController
{
    private SettingsForm _form;
    private Settings _settings;
    private NumericUpDown _pomodoroDurationUpDown;

    public SettingsFormController(SettingsForm settingsForm, 
        NumericUpDown pomodoroDurationUpDown, Button pomodoroPattern30, 
        Button pomodoroPattern60, Button cancel, Button save, Settings settings)
    {
        _form = settingsForm;
        _settings = settings;
        _pomodoroDurationUpDown = pomodoroDurationUpDown;

        _pomodoroDurationUpDown.MouseWheel += NumericUpDown_MouseWheel;
        cancel.Click += Cancel;
        save.Click += Save;
        pomodoroPattern30.Click += SetPattern;
        pomodoroPattern60.Click += SetPattern;

        _pomodoroDurationUpDown.Value = (int)_settings.TaskDuration;
    }

    private void Cancel(object? sender, EventArgs e)
    {
        _form.Close();
    }
    private void Save(object? sender, EventArgs e)
    {
        _settings.TaskDuration = (int)_pomodoroDurationUpDown.Value;
        _form.Close();
    }
    private void SetPattern(object? sender, EventArgs e)
    {
        if (sender is Button patternButton)
        {
            if (int.TryParse(patternButton.Text, out var duration))
            {
                _pomodoroDurationUpDown.Value = duration;
            }
        }
    }
    private void NumericUpDown_MouseWheel(object? sender, MouseEventArgs e)
    {
        if (e.Delta > 0 && _pomodoroDurationUpDown.Value <= _pomodoroDurationUpDown.Maximum - 5)
        {
            _pomodoroDurationUpDown.Value += 2;
        }
        else if (e.Delta < 0 && _pomodoroDurationUpDown.Value >= _pomodoroDurationUpDown.Minimum + 5)
        {
            _pomodoroDurationUpDown.Value -= 2;
        }
    }
}
