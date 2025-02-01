using System;
using System.Windows.Forms;
using System.Drawing;

class PictureFlipper : Form
{
    Button button1;
    Bitmap image1;
    PictureBox pictureBox1;
    // �����-����������� ������ ������ 
    public PictureFlipper()
    {
        // ��������� ������� � ��������� ���� 
        this.Text = "������� �������";
        this.Size = new Size(302, 240);
        // ��������� �� ����� ������ button1 = new Button(); 
        button1 = new Button();
        button1.Text = "������� �������";
        button1.Location = new Point(100, 150);
        button1.Size = new Size(70, 40);
        button1.Click += button1_Click;
        this.Controls.Add(button1);
        // ��������� ������� PictureBox �� ����� 
        pictureBox1 = new PictureBox();
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        pictureBox1.ClientSize = new Size(300, 196);
        // ��������� ����������� � ������� PictureBox
        image1 = new Bitmap(@"C:\Users\satoa\OneDrive\������� ����\\3d-logo-design-clipart-1.jpg");
        pictureBox1.Image = (Image)image1;
        // ��������� �� ����� ������� 
        this.Controls.Add(pictureBox1);
    }

    static void Main()
    {
        // ������� � ��������� ����� 
        Application.Run(new PictureFlipper());
    }
    // ���������� �������, ������������� ��� ������� ������ 
    void button1_Click(object sender, EventArgs e)
    {
        // ���������� ���������� ������������ ��� X (�������������) 
        image1.RotateFlip(RotateFlipType.RotateNoneFlipX);
        // �������� ��������� ����������� � ������� 
        pictureBox1.Image = (Image)image1;
        // ��������� ��������� ���� 
        this.Text = "������� ����� ��������!";
    }
}