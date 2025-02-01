using System;

class ValueInput
{
    public static T ReadValue<T>(string prompt)
    {
        Console.Write(prompt);
        string input = Console.ReadLine();

        try
        {
            return (T)Convert.ChangeType(input, typeof(T));
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное значение.");
            return ReadValue<T>(prompt);
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Программа для ввода значений:");

        string word = ValueInput.ReadValue<string>("Введите слово: ");
        int number = ValueInput.ReadValue<int>("Введите целое число: ");
        double decimalNumber = ValueInput.ReadValue<double>("Введите дробное число: ");

        Console.WriteLine($"Вы ввели: {word}, {number}, {decimalNumber}");
    }
}
