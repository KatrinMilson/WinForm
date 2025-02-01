using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateEvenSum_Click(object sender, EventArgs e)
        {
            string input = txtNumber.Text;

            // Проверяем, не слишком ли длинное число
            if (input.Length > 10) // Вы можете изменить 10 на любое другое значение
            {
                lblResult.Text = "Невозможно посчитать, так как число слишком длинное.";
                return;
            }

            int number;
            if (int.TryParse(input, out number))
            {
                int sum = 0;
                for (int i = 2; i <= number; i += 2)
                {
                    sum += i;
                }
                lblResult.Text = "Сумма четных чисел: " + sum;
            }
            else
            {
                lblResult.Text = "Введите корректное число.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
