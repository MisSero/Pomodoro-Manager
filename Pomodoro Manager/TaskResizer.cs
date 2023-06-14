namespace Pomodoro_Manager
{
    public static class TaskResizer
    {
        public static void ResizeTasks(Panel panel)
        {
            int panelWidth = panel.Width - 30;
            foreach(Panel taskPanel in panel.Controls)
            {
                taskPanel.Width = panelWidth;
            }
        }
    }
}
