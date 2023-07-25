namespace Pomodoro_Manager.ViewModel
{
    public class TaskResizer
    {
        Panel _panel;

        public TaskResizer(Panel panel)
        {
            _panel = panel;
            panel.SizeChanged += ResizeTasks;
        }

        public void ResizeTasks(object sender, EventArgs e)
        {
            int panelWidth = _panel.Width - 30;
            foreach (Panel taskPanel in _panel.Controls)
            {
                taskPanel.Width = panelWidth;
            }
            _panel.PerformLayout();
        }
    }
}
