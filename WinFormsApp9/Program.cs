using System;
using System.Windows.Forms;
using System.Drawing;

class PictureFlipper : Form
{
    Button button1;
    Bitmap image1;
    PictureBox pictureBox1;
    // Метод-конструктор нашего класса 
    public PictureFlipper()
    {
        // Указываем размеры и заголовок окна 
        this.Text = "Поворот рисунка";
        this.Size = new Size(302, 240);
        // Добавляем на форму кнопку button1 = new Button(); 
        button1 = new Button();
        button1.Text = "Поворот рисунка";
        button1.Location = new Point(100, 150);
        button1.Size = new Size(70, 40);
        button1.Click += button1_Click;
        this.Controls.Add(button1);
        // Добавляем элемент PictureBox на форму 
        pictureBox1 = new PictureBox();
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        pictureBox1.ClientSize = new Size(300, 196);
        // Добавляем изображение в элемент PictureBox
        image1 = new Bitmap(@"C:\Users\satoa\OneDrive\Рабочий стол\\3d-logo-design-clipart-1.jpg");
        pictureBox1.Image = (Image)image1;
        // Добавляем на форму элемент 
        this.Controls.Add(pictureBox1);
    }

    static void Main()
    {
        // Создаем и запускаем форму 
        Application.Run(new PictureFlipper());
    }
    // Обработчик события, срабатывающий при нажатии кнопки 
    void button1_Click(object sender, EventArgs e)
    {
        // Отображает изоражение относительно оси X (горизонтально) 
        image1.RotateFlip(RotateFlipType.RotateNoneFlipX);
        // Повторно вставляем изображение в элемент 
        pictureBox1.Image = (Image)image1;
        // Обновляем заголовок окна 
        this.Text = "Рисунок после поворота!";
    }
}