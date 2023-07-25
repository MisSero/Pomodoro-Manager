namespace Pomodoro_Manager.ViewModel
{
    public class InputPanelController
    {
        private string? _nameTextBoxPlaceholder;
        private TextBox? _nameTextBox;
        private NumericUpDown _taskCountNumericUpDown;
        private Button _addButton;

        public InputPanelController(string placeholder, TextBox nameTextBox, 
            NumericUpDown taskCountNumericUpDown, Button addTask) 
        {
            _nameTextBoxPlaceholder = placeholder;
            _nameTextBox = nameTextBox;
            _taskCountNumericUpDown = taskCountNumericUpDown;
            _addButton = addTask;

            _nameTextBox.Enter += TextBox_Enter;
            _nameTextBox.Leave += TextBox_Leave;
            _nameTextBox.KeyDown += PressKeyEnter;
            _taskCountNumericUpDown.MouseWheel += NumericUpDown_MouseWheel;
            _taskCountNumericUpDown.KeyDown += PressKeyEnter;
        }
        public InputPanelController(NumericUpDown taskCountNumericUpDown)
        {
            _taskCountNumericUpDown = taskCountNumericUpDown;
            _taskCountNumericUpDown.MouseWheel += NumericUpDown_MouseWheel;
        }

        private void TextBox_Enter(object? sender, EventArgs e)
        {
            if (_nameTextBox?.Text == _nameTextBoxPlaceholder)
            {
                _nameTextBox.Text = string.Empty;
                _nameTextBox.ForeColor = Color.Black;
            }
        }

        private void TextBox_Leave(object? sender, EventArgs e)
        {
            if (_nameTextBox?.Text == "")
            {
                _nameTextBox.Text = _nameTextBoxPlaceholder;
                _nameTextBox.ForeColor = Color.DimGray;
            }
        }
        private void NumericUpDown_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && _taskCountNumericUpDown.Value <= _taskCountNumericUpDown.Maximum - 5)
            {
                _taskCountNumericUpDown.Value += 2;
            }
            else if (e.Delta < 0 && _taskCountNumericUpDown.Value >= _taskCountNumericUpDown.Minimum + 5)
            {
                _taskCountNumericUpDown.Value -= 2;
            }
        }
        private void PressKeyEnter(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _addButton.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
