using System.Net.NetworkInformation;

namespace WinFormsApp1
{
    internal static class Program
    {
    }

    class SimpleWindowsFormWithButton : Form
    {
        Button button1;
        public SimpleWindowsFormWithButton()
        {
            this.Text = "����� � ��������� �������";
            button1 = new Button();
            button1.Text = "����� ����!";
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