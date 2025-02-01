using System;

namespace LineIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = GetCoefficient("Введите A: ");
            double B = GetCoefficient("Введите B: ");
            double C = GetCoefficient("Введите C: ");
            double D = GetCoefficient("Введите D: ");
            double E = GetCoefficient("Введите E: ");
            double F = GetCoefficient("Введите F: ");

            string line1Description = DescribeLine(A, B, C);
            string line2Description = DescribeLine(D, E, F);

            Console.WriteLine($"Первая прямая: {line1Description}");
            Console.WriteLine($"Вторая прямая: {line2Description}");

            IdentifyIntersection(A, B, C, D, E, F);
        }

        static double GetCoefficient(string message)
        {
            Console.Write(message);
            return double.Parse(Console.ReadLine());
        }

        static string DescribeLine(double A, double B, double C)
        {
            if (A == 0 && B == 0)
            {
                return "недействительна (не существует)";
            }
            if (B == 0)
            {
                return (A > 0) ? "параллельна оси X" : "параллельна оси X и проходит через 0";
            }
            if (A == 0)
            {
                return "параллельна оси Y";
            }

            return "общего положения";
        }

        static void IdentifyIntersection(double A, double B, double C, double D, double E, double F)
        {
            double determinant = A * E - B * D;

            if (determinant == 0)
            {
                // Проверка на совпадение
                if (A * F == C * D && B * F == C * E)
                {
                    Console.WriteLine("Точек пересечения бесконечно много, т. к. прямые совпадают.");
                }
                else
                {
                    Console.WriteLine("Точек пересечения нет, т. к. прямые параллельны.");
                }
            }
            else
            {
                double x = (C * E - B * F) / determinant;
                double y = (A * F - C * D) / determinant;
                Console.WriteLine($"Одна точка пересечения, её координаты: ({x}, {y}).");
            }
        }
    }
}
