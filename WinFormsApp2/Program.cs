namespace WinFormsApp2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
    }
class SimpleWindowsForm : Form
    {
        public SimpleWindowsForm()
        {
            this.Text = "Это простая форма с заголовком";
        }
        static void Main()
        {
            Application.Run(new SimpleWindowsForm());
        }
    }
}