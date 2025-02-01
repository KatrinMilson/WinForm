using System;
using System.Windows.Forms;
using System.Drawing;
class SimpleShapeMaker : Form
{
    // �����-����������� ������ ������ 
    public SimpleShapeMaker()
    {
        // ������ ���� ���� ����� �� ����� 
        this.BackColor = Color.White;
        // ��������� �� ����� ������ � ����������� �� � ����������� ������� 
        Button button1 = new Button();
        button1.Text = "����� ��������!";
        button1.Location = new Point(110, 10);
        button1.Size = new Size(70, 40);
        button1.BackColor = Color.LightGray;
        button1.Click += new System.EventHandler(button1_Click);
        this.Controls.Add(button1);
    }
    // ���������� �������, ������������� ��� ������� ������ 
    void button1_Click(object o, System.EventArgs e)
    {
        // ����� ������ 
        DrawSomeShapes();
    }
    // ����� ��� ��������� �� ����������� ����� ���������� ����� 
    void DrawSomeShapes()
    {
        // ���������� ������� ��������� �� ����� 
        Graphics g = this.CreateGraphics();
        // �������������� ����, �������� ������� ����� �������� 3 ������� 
        Pen redPen = new Pen(Color.Red, 3);
        // � ������� ���� ������ ������ �����, ������������� � ������ 
        g.DrawLine(redPen, 140, 170, 140, 230);
        g.DrawRectangle(redPen, 50, 60, 50, 60);
        g.DrawEllipse(redPen, 150, 100, 100, 60);
        // ������� 
        g.Dispose();
    }
    static void Main()
    {
        // ������� � ��������� ����� 
        Application.Run(new SimpleShapeMaker());
    }
}

