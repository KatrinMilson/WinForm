namespace WinFormsApp3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
       
    }
    class SimpleWindowsFormWithButton : Form
    {
        Button button1;
        public SimpleWindowsFormWithButton()
        {
            this.Text = "Форма с командной кнопкой";
            button1 = new Button();
            button1.Text = "Нажми меня!";
            button1.Top = 100;
            button1.Left = 100;
            button1.Height = 50;
            button1.Width = 70;
            this.Controls.Add(button1);
        }
        static void Main()
        {
            Application.Run(new SimpleWindowsFormWithButton());
        }
    }
}