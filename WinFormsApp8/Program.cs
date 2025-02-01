using System;
using System.Windows.Forms;
using System.Drawing;
namespace WinFormsApp8
{
    class PictureDisplayer : Form
    {
        Bitmap image; 
        PictureBox pictureBox1;
        // �����-����������� ������ ������ 
        public PictureDisplayer()
        {
            // ��������� ������� � ��������� ���� 
            Text = "��������� ����������";
            Size = new Size(302, 240);
            // �������������� ���� ��� ���������� ����������� 
            pictureBox1 = new PictureBox();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.ClientSize = new Size(300, 196);
            // ��������� ����������� � ������� 
            Bitmap image = new Bitmap("C:\\Users\\satoa\\OneDrive\\������� ����\\3d-logo-design-clipart-1.jpg");
            pictureBox1.Image = (image as Image);
            // ��������� PictureBox (� ������������) �� ����� 
            Controls.Add(pictureBox1);
        }

        static void Main()
        {
            // ������� � ��������� ����� 
            Application.Run(new PictureDisplayer());
        }
    }
}