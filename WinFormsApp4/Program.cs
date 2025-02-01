namespace WinFormsApp4
{
    using System;
    using System.Windows.Forms;
    using System.Drawing;
    class FormWithWorkingButton : Form
    {
        Button mrButton;
        // �����-����������� ������ ������ 
        public FormWithWorkingButton()
        {
            this.Text = "����� � ���������� �������!"; // ��������� ��������� ���� 
                                                       // ��������� ������ � ����������� �� � ����������� ������� 
            mrButton = new Button();
            mrButton.Text = "����� ����";
            mrButton.Top = 100;
            mrButton.Left = 100;
            mrButton.Height = 50;
            mrButton.Width = 70;
            mrButton.Click += new System.EventHandler(mrButton_Click);
            this.Controls.Add(mrButton);
        }
        static void Main()
        {
            // ������� � ��������� ����� 
            Application.Run(new FormWithWorkingButton());
        }
        // ���������� �������, ������������� ��� ������� ������ 
        void mrButton_Click(object sender, EventArgs e)
        {
            mrButton.Text = "������ ���� ������!"; // �������� ����� 
        }
    }
}