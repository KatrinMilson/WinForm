using System;
using System.Windows.Forms;
using System.Drawing;
namespace WinFormsApp8
{
    class PictureDisplayer : Form
    {
        Bitmap image; 
        PictureBox pictureBox1;
        // Метод-конструктор нашего класса 
        public PictureDisplayer()
        {
            // Указываем размеры и заголовок окна 
            Text = "Искусство аборигенов";
            Size = new Size(302, 240);
            // Подготавливаем поле для размещения изображения 
            pictureBox1 = new PictureBox();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.ClientSize = new Size(300, 196);
            // Добавляем изображение в элемент 
            Bitmap image = new Bitmap("C:\\Users\\satoa\\OneDrive\\Рабочий стол\\3d-logo-design-clipart-1.jpg");
            pictureBox1.Image = (image as Image);
            // Добавляем PictureBox (с изображением) на форму 
            Controls.Add(pictureBox1);
        }

        static void Main()
        {
            // Создаем и запускаем форму 
            Application.Run(new PictureDisplayer());
        }
    }
}