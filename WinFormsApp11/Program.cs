using System;
using System.Windows.Forms;
using System.Drawing;
class FunWithTheMouse : Form
{
    // ��������� �������, ��������� ��� ������ ������� 
    PictureBox pictureBox1;
    Label label1;
    Point spotClicked;
    // �����-����������� ������ ������ 
    public FunWithTheMouse()
    {
        // ������ ������� ���� 
        this.Size = new Size(640, 480);
        // ��������� ������� � ������� PictureBox � ��������� � ����� 
        pictureBox1 = new PictureBox();
        pictureBox1.Image = (Image)new Bitmap(@"C:\Users\satoa\OneDrive\������� ����\\1047933-mops-klipart-21.bmp");
        pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        pictureBox1.Dock = DockStyle.Fill; this.Controls.Add(pictureBox1);

        // ��������� ����� � ������������ � ������ ����� ������ 
        label1 = new Label();
        label1.BackColor = Color.Wheat;
        label1.Dock = DockStyle.Bottom;
        label1.Text = "��� ������� ����� ������ ���� ����� �������� ��������������. " + "������� ������ ������ �������� ������� �������������� " + "����� SHIFT � ��������� ����, ������ ������ ������.";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        this.Controls.Add(label1);
        // ����������� PictureBox � ������������ ������� ���� 
        this.pictureBox1.MouseDown +=
        new MouseEventHandler(MouseButtonIsDown);
        this.pictureBox1.MouseUp += new MouseEventHandler(MouseButtonIsUp);
        this.pictureBox1.MouseMove += new MouseEventHandler(TheMouseMoved);
    }
    // ���������� �������, ������������� ��� ����������� ���� 
    public void TheMouseMoved(object sender, MouseEventArgs e)
    {
        // ���� �� ���������� ������ ������� SHIFT 
        if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
        {
            // ���������� ������� ��������� �� ����������� 
            Graphics g = this.pictureBox1.CreateGraphics();
            this.pictureBox1.CreateGraphics();
            // ���������� ������ ���� 
            System.Drawing.Pen yellowPen = new System.Drawing.Pen(Color.Yellow, 3);
            // ������ ���������� (������, ��������� � �������) 
            // ������� ����� ���� �������� ����� ���������� X � Y 
            // �������� ��������� ����. 
            g.DrawEllipse(yellowPen, e.X, e.Y, 40, 40);
            // ������� 
            g.Dispose();
        }
    }
    // ���������� �������, ������������� ��� ������� ������ ���� 
    public void MouseButtonIsDown(object sender, MouseEventArgs e)
    {
        // ���������� �����, � ������� ��������� ������� ������ ����. 
        // ����� ������ ����� ��������, ��� ����������� �� ���������� 
        spotClicked.X = e.X;// �������������� ���������� 
        spotClicked.Y = e.Y;// ������������ ���������� 
    }
    // ���������� �������, ������������� ��� ������� ������ ���� 
    public void MouseButtonIsUp(object sender, MouseEventArgs e)
    {
        /* ������������ �������� ������ ����! */
        // ������� ������������� (���� �� ��� �� �����), �������������� 
        // ������� �����������, � ������� ������������ ����� �������� 
        Rectangle r = new Rectangle();
        // ����� ������� ���� �������������� ������������� �����, 
        // � ������� ���� ������ ������ ����. 
        // �� ��������� �� ����������. 
        r.X = spotClicked.X;
        r.Y = spotClicked.Y;

        // ������ � ������ �������������� ����������� 
        // ����� ��������� ��������� ���� � ����� ������� 
        // �� ������� ��������� (� ����� ������� ������). 
        r.Width = e.X - spotClicked.X;
        r.Height = e.Y - spotClicked.Y;
        if (e.Button == MouseButtons.Left)
        {
            /* ���� ���� ������ � �������� ����� ������ ����, ������ ������� ������ �������������� */
            // ���������� ������� ��������� �� ����������� 
            Graphics g = this.pictureBox1.CreateGraphics();
            // ������ ������� ������ �������������� 
            Pen redPen = new Pen(Color.Red, 2);
            g.DrawRectangle(redPen, r);
        }
        else
        {
            // ���� ���� ������ ������ ������, �������� 
            // �����, �������������� ������� ����������� 
            ChangeLightness(r);
        }
    }

    // �����, ������������� ������� ���������� ������� ����������� 
    // ����� ���������� ������� ������� ������� ����� ������� 
    public void ChangeLightness(Rectangle rect)
    {
        int newRed, newGreen, newBlue;
        Color pixel = new Color();
        // �������� �����������, ����������� � PictureBox 
        System.Drawing.Bitmap picture = new Bitmap(this.pictureBox1.Image);
        // �������� ���������� ������� ����� ������ ����� �������, 
        // ������������ �������������, ���� ������ ������� �������. 
        if ((rect.Width > 150) || (rect.Height > 150))
        {
            DialogResult result = MessageBox.Show("���������� ������� ������! " + "��������� ������� ����� ��������� ������������� �������!", "Warning", MessageBoxButtons.OKCancel);
            // ��� ������� ������ Cancel (������) ������� �� ������ 
            // � ������������ � ����� ��� ������ 
            if (result == DialogResult.Cancel) return;
        }
        /* ���������� ��������������� ��� ������� ������� ������� � ��������� �������� ������� ��������� RGB �������� */
        // ������� �� ����������� ����� �������...
        for (int x = rect.X; x < rect.X + rect.Width; x++)
        {
            // � �� ��������� ������ ����... 
            for (int y = rect.Y; y < (rect.Y + rect.Height); y++)
            {
                // ��������� ������� ������� pixel = picture.GetPixel(x, y); 
                // ����������� ������� �������� ��������� ������� 
                newRed = (int)Math.Round(pixel.R * 2.0, 0);
                if (newRed > 255) newRed = 255; newGreen = (int)Math.Round(pixel.G * 2.0, 0);
                if (newGreen > 255) newGreen = 255; newBlue = (int)Math.Round(pixel.B * 2.0, 0);
                if (newBlue > 255) newBlue = 255;
                // ����������� ������� ����� �������� �������� 
                picture.SetPixel(x, y, Color.FromArgb((byte)newRed, (byte)newGreen, (byte)newBlue));
            }
        }
        // �������� ���������� ����� ����������� � PictureBox, 
        // ����� ��������� ������������ �� ������ 
        this.pictureBox1.Image = picture;
    }
    static void Main()
    {
        // ������� ��������� ������ ����� 
        Application.Run(new FunWithTheMouse());
    }
}


