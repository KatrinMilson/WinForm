using System;
using System.Windows.Forms;

namespace ЛР1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateFactorial_Click(object sender, EventArgs e)
        {
            string input = txtNumber.Text;

            // Проверяем, если длина введенного числа больше 10 (можно изменить это значение)
            if (input.Length > 10)
            {
                lblFactorialResult.Text = "Невозможно посчитать, так как число слишком длинное.";
                return;
            }

            int number;
            if (int.TryParse(input, out number) && number >= 0)
            {
                long factorial = 1;
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }
                lblFactorialResult.Text = "Факториал числа: " + factorial;
            }
            else
            {
                lblFactorialResult.Text = "Введите корректное число.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
